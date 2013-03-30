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
        private int[] pole = new int[6];

        public EditForm(int[] souradnice)
        {
            InitializeComponent();
            for (int i = 0; i < 6; i++)
            {
                pole[i] = souradnice[i];
            }
            string[] udaje = new string[3];
            int o = 0;
            string s = "";
            using (StreamReader sr = new StreamReader(APPpoznamky))
            {
                while ((s = sr.ReadLine()) != null)
                {
                    udaje[o] = s;
                    o++;
                }
            }
            //prvni poznamka
            string[] data = udaje[0].Split(';');
            sirka1.Text = data[3];
            vyska1.Text = data[4];
            barva1.Text = data[5];
            if (bool.Parse(data[0]) == true)
                checkBox1.Checked = true;
            else
                checkBox1.Checked = false;
            //druha ponamka
            string[] data1 = udaje[1].Split(';');
            sirka2.Text = data1[3];
            vyska2.Text = data1[4];
            barva2.Text = data1[5];
            if (bool.Parse(data1[0]) == true)
                checkBox2.Checked = true;
            else
                checkBox2.Checked = false;
            //treti poznamka
            string[] data2 = udaje[2].Split(';');
            sirka3.Text = data2[3];
            vyska3.Text = data2[4];
            barva3.Text = data2[5];
            if (bool.Parse(data2[0]) == true)
                checkBox3.Checked = true;
            else
                checkBox3.Checked = false;
            //sirka1.Text = souradnice[0].ToString();
            //vyska1.Text = souradnice[1].ToString();
            
        }
        //PRVNI STRANKA ---------------------------------------------
        private void colorButton1_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm(barva1.Text);
            colorform.ShowDialog();
            barva1.Text = colorform.colorfromform;
        }

        private void colorButton2_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm(barva2.Text);
            colorform.ShowDialog();
            barva2.Text = colorform.colorfromform;
        }

        private void colorButton3_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm(barva3.Text);
            colorform.ShowDialog();
            barva3.Text = colorform.colorfromform;
        }
        //---------------------------------------------------------------
        //DRUHA STRANKA--------------------------------------------------
        private void colorbutton1obrazek_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm(obrazekbarva1.Text);
            colorform.ShowDialog();
            obrazekbarva1.Text = colorform.colorfromform;
        }

        private void colorbutton2obrazek_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm(obrazekbarva2.Text);
            colorform.ShowDialog();
            obrazekbarva2.Text = colorform.colorfromform;
        }

        private void colorbutton3obrazek_Click(object sender, EventArgs e)
        {
            ColorForm colorform = new ColorForm(obrazekbarva3.Text);
            colorform.ShowDialog();
            obrazekbarva3.Text = colorform.colorfromform;
        }
        //--------------------------------------------------------------

        //SAVE----------------------------------------------------------
        private void Save_Click(object sender, EventArgs e)
        {
            save();
        }

        private void SaveOb_Click(object sender, EventArgs e)
        {
            save();
        }

        /*METODA NA ULOZENI VLASTNOSTI OBJEKTU -------------------------------
         * True;    30;          30;      45;   45;  45,  45, 54
         * bool;souradniceX;souradniceY;sirka;vyska;red,green,blue
         * 
         */
        public void save()
        {
            Form1 f = new Form1();
            using (StreamWriter sw = new StreamWriter(APPpoznamky))
            {
                sw.WriteLine(checkBox1.Checked.ToString() + ";" + pole[0].ToString() + ";" + pole[1].ToString() + ";" + sirka1.Text + ";" + vyska1.Text + ";" + barva1.Text);
                sw.WriteLine(checkBox2.Checked.ToString() + ";" + pole[2].ToString() + ";" + pole[3].ToString() + ";" + sirka2.Text + ";" + vyska2.Text + ";" + barva2.Text);
                sw.WriteLine(checkBox3.Checked.ToString() + ";" + pole[4].ToString() + ";" + pole[5].ToString() + ";" + sirka3.Text + ";" + vyska3.Text + ";" + barva3.Text);
                sw.Flush();
            }
            
        }
        //---------------------------------------------------------------
    }
}
