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
        SaveToFolder savetofolder = new SaveToFolder();
        SaveData save = new SaveData();
        LoadData load = new LoadData();
        private int
            a = 50,
            b = 50;


        public Form1()
        {
            InitializeComponent();
            try { string[] Notes3 = load.get3Notes(); }
            catch { savetofolder.DefaulthSave(load.getAppNotes()); }
            try { string[] Images3 = load.get3Images(); }
            catch { savetofolder.DefaulthSave(load.getAppImages()); }
            ChangeNotes();
            ChangeImages();
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
            ChangeNotes();
            ChangeImages();
        }

        //POHYB S POZNAMKOU 0 ---------------------------------------------
        bool Nmove = false;
        private void poznamka0_MouseDown(object sender, MouseEventArgs e)
        {
            Nmove = true;
        }

        private void poznamka0_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (Nmove)
                poznamka0.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }
        
        private void poznamka0_MouseUp(object sender, MouseEventArgs e)
        {
            Nmove = false;
            int type = 0;
            save.NCoordinates(type, poznamka0.Location.X, poznamka0.Location.Y);
        }
        //------------------------------------------------------------------

        //DRUHA POZNAMKA --------------------------------------------------
        bool Nmove1 = false;
        private void poznamka1_MouseDown(object sender, MouseEventArgs e)
        {
            Nmove1 = true;
        }

        private void poznamka1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (Nmove)
                poznamka1.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }

        private void poznamka1_MouseUp(object sender, MouseEventArgs e)
        {
            Nmove1 = false;
            int type = 2;
            save.NCoordinates(type, poznamka1.Location.X, poznamka1.Location.Y);
        }
        //-------------------------------------------------------------------

        //TRETI POZNAMKA
        bool Nmove2 = false;
        private void poznamka2_MouseDown(object sender, MouseEventArgs e)
        {
            Nmove2 = true;
        }

        private void poznamka2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (Nmove2)
                poznamka2.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }

        private void poznamka2_MouseUp(object sender, MouseEventArgs e)
        {
            Nmove2 = false;
            int type = 4;
            save.NCoordinates(type, poznamka2.Location.X, poznamka2.Location.Y);
        }
        //------------------------------------------------------------------

        //OBRAZEK1-OBRAZEK3 POHYBOVANI-----------------------------------
        bool Imove = false;
        private void obrazek0_MouseDown(object sender, MouseEventArgs e)
        {
            Imove = true;
        }

        private void obrazek0_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (Imove)
                obrazek0.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }

        private void obrazek0_MouseUp(object sender, MouseEventArgs e)
        {
            Imove = false;
            int type = 0;
            save.ICoordinates(type, obrazek0.Location.X, obrazek0.Location.Y);
        }

        bool Imove1 = false;
        private void obrazek1_MouseDown(object sender, MouseEventArgs e)
        {
            Imove1 = true;
        }

        private void obrazek1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (Imove1)
                obrazek1.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }

        private void obrazek1_MouseUp(object sender, MouseEventArgs e)
        {
            Imove1 = false;
            int type = 2;
            save.ICoordinates(type, obrazek1.Location.X, obrazek1.Location.Y);
        }

        bool Imove2 = false;
        private void obrazek2_MouseDown(object sender, MouseEventArgs e)
        {
            Imove2 = true;
        }

        private void obrazek2_MouseMove(object sender, MouseEventArgs e)
        {
            this.Location = new Point(a, b);
            if (Imove2)
                obrazek2.Location = new Point(MousePosition.X - a, MousePosition.Y - b);
        }

        private void obrazek2_MouseUp(object sender, MouseEventArgs e)
        {
            Imove2 = false;
            int type = 4;
            save.ICoordinates(type, obrazek2.Location.X, obrazek2.Location.Y);
        }
        //------------------------------------------------------------------

        /*METODA NA ZMENU VLASTNOSTI OBJEKTU -------------------------------
         * True;    30;          30;      45;   45;  45,  45, 54
         * bool;souradniceX;souradniceY;sirka;vyska;red,green,blue
         * 
         */
        private void ChangeNotes()
        {
            string[, ] Data = load.getAllDatas(true);
            TextBox[] textboxy = new TextBox[3];
            textboxy[0] = poznamka0;
            textboxy[1] = poznamka1;
            textboxy[2] = poznamka2;
            for (int i = 0; i < 3; i++)
            {
                textboxy[i].Visible = bool.Parse(Data[i, 0]);
                textboxy[i].Location = new Point(int.Parse(Data[i, 1]), int.Parse(Data[i, 2]));
                textboxy[i].Width = int.Parse(Data[i, 3]);
                textboxy[i].Height = int.Parse(Data[i, 4]);
                string[] color = Data[i, 5].Split(',');
                textboxy[i].BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
            }
        }

        public void ChangeImages()
        {
            string[,] Data = load.getAllDatas(false);
            PictureBox[] pictureboxy = new PictureBox[3];
            pictureboxy[0] = obrazek0;
            pictureboxy[1] = obrazek1;
            pictureboxy[2] = obrazek2;
            for (int i = 0; i < 3; i++)
            {
                pictureboxy[i].Visible = bool.Parse(Data[i, 0]);
                pictureboxy[i].Location = new Point(int.Parse(Data[i, 1]), int.Parse(Data[i, 2]));
                pictureboxy[i].Width = int.Parse(Data[i, 3]);
                pictureboxy[i].Height = int.Parse(Data[i, 4]);
                string[] color = Data[i, 5].Split(',');
                pictureboxy[i].BackColor = Color.FromArgb(int.Parse(color[0]), int.Parse(color[1]), int.Parse(color[2]));
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
