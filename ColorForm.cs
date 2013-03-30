using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Notes
{
    public partial class ColorForm : Form
    {
        public string colorfromform;

        public ColorForm()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            colorfromform = red.Value.ToString() + "," + green.Value.ToString() + "," + blue.Value.ToString();
            this.Close();
        }

        private void red_Scroll(object sender, EventArgs e)
        {
            Barva.BackColor = Color.FromArgb(red.Value, green.Value, blue.Value);
        }
    }
}
