using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notes
{
    public partial class Form1 : Form
    {
        private string APPpoznamky = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "poznamky.txt");
        private string APPobrazky = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "obrazky.txt");
        private string[] poznamkyhodnoty = new string[3];
        private int[] souradnicePoznamek = new int[6];
        private int[] souradniceObrazku = new int[6];
        private int a = 50;
        private int b = 50;

        public Form1()
        {
            InitializeComponent();
            poznamka0.Visible = false;
            poznamka1.Visible = false;
            poznamka2.Visible = false;

            try
            {
                using (StreamReader sr = new StreamReader(APPpoznamky))
                {
                    string s = "";
                    int j = 0;
                    while ((s = sr.ReadLine()) != null)
                    {
                        poznamkyhodnoty[j] = s;
                        j++;
                    }
                }
            }
            catch
            {
                using (StreamWriter sw = new StreamWriter(APPpoznamky))
                {
                    sw.Write("");
                    sw.Flush();
                }
            }
            zmena();
        }

        //HRANY VYKRESLENI ---------------------------------------------
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Brush brush = new SolidBrush(Color.FromArgb(49, 48, 48));
            Rectangle horni = new Rectangle(0, 25, 441, 2);
            Rectangle leva = new Rectangle(0, 25, 2, 279);
            Rectangle spodni = new Rectangle(0, 277, 441, 2);
            Rectangle prava = new Rectangle(439, 25, 2, 279);
            e.Graphics.FillRectangle(brush, horni);
            e.Graphics.FillRectangle(brush, leva);
            e.Graphics.FillRectangle(brush, spodni);
            e.Graphics.FillRectangle(brush, prava);
        }
        //--------------------------------------------------------------

        // POHYBOVANI OKNEM --------------------------------------------
        int WindowMoveX, WindowMoveY;
        bool WindowMove;
        private void Lista_MouseDown(object sender, MouseEventArgs e)
        {
            WindowMove = true;
            WindowMoveX = e.X;
            WindowMoveY = e.Y;
        }

        private void Lista_MouseMove(object sender, MouseEventArgs e)
        {
            if (WindowMove)
                this.SetDesktopLocation(MousePosition.X - WindowMoveX - 230, MousePosition.Y - WindowMoveY);
        }

        private void Lista_MouseUp(object sender, MouseEventArgs e)
        {
            WindowMove = false;
        }
        //---------------------------------------------------------------

        //EDIT kliknuti -------------------------------------------------
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            EditForm edit = new EditForm(souradnicePoznamek);
            edit.ShowDialog();
        }

        //POHYB S POZNAMKOU 0 ---------------------------------------------
        bool pohyb = false;
        private void poznamka0_MouseDown(object sender, MouseEventArgs e)
        {
            pohyb = true;
        }

        private void poznamka0_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (pohyb)
                poznamka0.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }
        
        private void poznamka0_MouseUp(object sender, MouseEventArgs e)
        {
            pohyb = false;
            souradnicePoznamek[0] = poznamka0.Location.X;
            souradnicePoznamek[1] = poznamka0.Location.Y;
            MessageBox.Show(souradnicePoznamek[0].ToString());
            MessageBox.Show(souradnicePoznamek[1].ToString());
            
        }
        //------------------------------------------------------------------

        /*METODA NA ZMENU VLASTNOSTI OBJEKTU -------------------------------
         * True;    30;          30;      45;   45;  45,  45, 54
         * bool;souradniceX;souradniceY;sirka;vyska;red,green,blue
         * 
         */
        private void zmena()
        {
            string[, ] poznamky = new string[3, 6];
            string[] rozdelene;
            for (int i = 0; i < 3; i++)
            {
                try { rozdelene = poznamkyhodnoty[i].Split(';'); }
                catch { rozdelene = poznamkyhodnoty[i].Split(' '); }
                for (int j = 0; j < 6; j++)
                    poznamky[i, j] = rozdelene[j];
            }
            TextBox[] textboxy = new TextBox[3];
            textboxy[0] = poznamka0;
            textboxy[1] = poznamka1;
            textboxy[2] = poznamka2;
            for (int i = 0; i < 3; i++)
            {
                textboxy[i].Visible = bool.Parse(poznamky[i, 0]);
                textboxy[i].Location = new Point(int.Parse(poznamky[i, 1]), int.Parse(poznamky[i, 2]));
                textboxy[i].Width = int.Parse(poznamky[i, 3]);
                textboxy[i].Height = int.Parse(poznamky[i, 4]);
                string[] color = poznamky[i, 5].Split(',');
                textboxy[i].BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
            }
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            a = this.Location.X;
            b = this.Location.Y;
        }
        //------------------------------------------------------------------
        
    }
}
