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

        public ColorForm(string barva)
        {
            InitializeComponent();
            string[] color = barva.Split(',');
            red.Value = int.Parse(color[0]);
            green.Value = int.Parse(color[1]);
            blue.Value = int.Parse(color[2]);
            Barva.BackColor = Color.FromArgb(red.Value, green.Value, blue.Value);
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
