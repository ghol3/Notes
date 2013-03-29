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
        private bool poznamkahide0 = false;
        private bool poznamkahide1 = false;
        private bool poznamkahide2 = false;
        private string[] poznamkyhodnoty = new string[3];

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
                    for (int i = 0; i < 3; i++)
                    {
                        MessageBox.Show(poznamkyhodnoty[i]);
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
            EditForm edit = new EditForm();
            edit.ShowDialog();
        }

        //POHYB S POZNAMKOU 0 ---------------------------------------------
        private void poznamka0_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void poznamka0_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void poznamka0_MouseUp(object sender, MouseEventArgs e)
        {

        }
        //------------------------------------------------------------------

        /*METODA NA ZMENU VLASTNOSTI OBJEKTU -------------------------------
         * True;    30;          30;      45;   45;  45,  45, 54
         * bool;souradniceX;souradniceY;sirka;vyska;red,green,blue
         * 
         */
        private void zmena()
        {
            string[] prvnipoznamka = poznamkyhodnoty[0].Split(';');
            poznamka0.Visible = bool.Parse(prvnipoznamka[0]);

        }
        //------------------------------------------------------------------
        
    }
}
