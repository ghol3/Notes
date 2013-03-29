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
    public partial class EditForm : Form
    {
        private string APPpoznamky = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "poznamky.txt");
        private string APPobrazky = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "obrazky.txt");
        private int pocetPripominek = 0;
        private int pocetObrazku = 0;
        private int poziceX = 30, poziceY = 30;

        public EditForm()
        {
            InitializeComponent();
            try
            {
                using (StreamReader sr = new StreamReader(APPpoznamky))
                {
                    string s = "";
                    while ((s = sr.ReadLine()) != null)
                    {
                        pocetPripominek++;
                    }
                }
            }
            catch
            {
                using (StreamWriter sw = new StreamWriter(APPpoznamky))
                {
                    sw.Write("");
                    sw.Flush();
                    pocetPripominek++;
                }
            }
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                int width = int.Parse(sirka.Text);
                int height = int.Parse(vyska.Text);
                bool hide = true;
                string[] barvy = barva.Text.Split(';');
                Color color = Color.FromArgb(int.Parse(barvy[0]), int.Parse(barvy[1]), int.Parse(barvy[2]));
                if (pocetPripominek > 2)
                    MessageBox.Show("mate maximum poznamek");
                else if (pocetObrazku > 3)
                    MessageBox.Show("mate maximum obrazku");
                else if (druh.Text == "Poznamka")
                    using(StreamWriter sw = new StreamWriter(APPpoznamky, true))
                    {
                        sw.WriteLine(hide.ToString() + ";" + poziceX.ToString() + ";" + poziceY.ToString() + ";" + width.ToString() + ";" + height.ToString() + ";" + barvy[0] + "," + barvy[1] + "," + barvy[2]);
                        sw.Flush();
                        pocetPripominek++;
                    }
                this.Close();
            }
            catch
            {
                MessageBox.Show("chlebaci");
            }
        }

        private void ColorButton_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm();
            colorform.ShowDialog();
            barva.Text = colorform.colorfromform;
        }
    }
}
