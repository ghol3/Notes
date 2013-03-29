using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

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
    }
}
