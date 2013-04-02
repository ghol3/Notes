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
        LoadData load = new LoadData();
        SaveToFolder savetofolder = new SaveToFolder();
        private string[,]
            NotesData,
            ImagesData;
        int[] 
            coordsNotes = new int[6],
            coordsImages = new int[6];


        public EditForm(int[] coordNotes, int[] coordImages)
        {
            InitializeComponent();
            for(int i = 0; i < 6;i++)
            {
                coordsNotes[i] = coordNotes[i];
                coordsImages[i] = coordImages[i];
            }
            completion();
        }

        private void completion()
        {
            NotesData = load.getAllDatas(true);
            ImagesData = load.getAllDatas(false);
            TextBox[,] textboxs = TextBoxs();
            CheckBox[] checkboxs = CheckBoxs();
            for (int i = 0; i < 3; i++)
            {
                textboxs[i, 0].Text = NotesData[i, 3];
                textboxs[i, 1].Text = NotesData[i, 4];
                textboxs[i, 2].Text = NotesData[i, 5];
                if (bool.Parse(NotesData[i, 0]))
                    checkboxs[i].Checked = true;
                else
                    checkboxs[i].Checked = false;
                //obrazky
                textboxs[i + 3, 0].Text = ImagesData[i, 3];
                textboxs[i + 3, 1].Text = ImagesData[i, 4];
                textboxs[i + 3, 2].Text = ImagesData[i, 5];
                if (bool.Parse(ImagesData[i, 0]))
                    checkboxs[i + 3].Checked = true;
                else
                    checkboxs[i + 3].Checked = false;
            }
        }

        public CheckBox[] CheckBoxs()
        {
            CheckBox[] CheckBoxs = new CheckBox[6];
            CheckBoxs[0] = checkBox1;
            CheckBoxs[1] = checkBox2;
            CheckBoxs[2] = checkBox3;
            CheckBoxs[3] = checkBox1ob;
            CheckBoxs[4] = checkBox2ob;
            CheckBoxs[5] = checkBox3ob;
            return CheckBoxs;
        }

        public TextBox[,] TextBoxs()
        {
            TextBox[,] TextBoxs = new TextBox[6, 3];
            //notes
            TextBoxs[0, 0] = sirka1;
            TextBoxs[0, 1] = vyska1;
            TextBoxs[0, 2] = barva1;
            TextBoxs[1, 0] = sirka2;
            TextBoxs[1, 1] = vyska2;
            TextBoxs[1, 2] = barva2;
            TextBoxs[2, 0] = sirka3;
            TextBoxs[2, 1] = vyska3;
            TextBoxs[2, 2] = barva3;
            //images
            TextBoxs[3, 0] = obrazeksirka1;
            TextBoxs[3, 1] = obrazekvyska1;
            TextBoxs[3, 2] = obrazekbarva1;
            TextBoxs[4, 0] = obrazeksirka2;
            TextBoxs[4, 1] = obrazekvyska2;
            TextBoxs[4, 2] = obrazekbarva2;
            TextBoxs[5, 0] = obrazeksirka3;
            TextBoxs[5, 1] = obrazekvyska3;
            TextBoxs[5, 2] = obrazekbarva3;
            return TextBoxs;
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
            bool Save = testingMinMax();
            bool SaveImages = testingMinMaxImages();
            if (Save && SaveImages)
            {
                savetofolder.SaveSettings(this, coordsNotes, coordsImages);
                this.Close();
            }
        }

        private void SaveOb_Click(object sender, EventArgs e)
        {
            bool Save = testingMinMax();
            bool SaveImages = testingMinMaxImages();
            if (Save && SaveImages)
            {
                savetofolder.SaveSettings(this, coordsNotes, coordsImages);
                this.Close();
            }
        }

        private bool testingMinMax()
        {
            bool testing = true;
            TextBox[] textboxy = new TextBox[6];
            textboxy[0] = sirka1;
            textboxy[1] = sirka2;
            textboxy[2] = sirka3;
            textboxy[3] = vyska1;
            textboxy[4] = vyska2;
            textboxy[5] = vyska3;
            for (int i = 0; i < 3; i++)
            {
                if (int.Parse(textboxy[i].Text) > 400)
                {
                    MessageBox.Show("Invalid " + (i + 1) + ". widht in Notes settings!");
                    testing = false;
                }
                if (int.Parse(textboxy[i + 3].Text) > 200)
                {
                    MessageBox.Show("Invalid " + (i + 1) + ". height in Notes settings!");
                    testing = false;
                }
            }
            return testing;
        }

        private void sirka1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 0 && c != 13 && c != 8)
                e.Handled = true;
        }

        private void obrazeksirka1_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;
            if (!Char.IsDigit(c) && c != 0 && c != 13 && c != 8)
                e.Handled = true;
        }

        private bool testingMinMaxImages()
        {
            bool testing = true;
            TextBox[] Images = new TextBox[6];
            Images[0] = obrazeksirka1;
            Images[1] = obrazeksirka2;
            Images[2] = obrazeksirka3;
            Images[3] = obrazekvyska1;
            Images[4] = obrazekvyska2;
            Images[5] = obrazekvyska3;
            for (int i = 0; i < 3; i++)
            {
                if (int.Parse(Images[i].Text) > 400)
                {
                    MessageBox.Show("Invalid " + (i + 1) + ". widht in Images settings!");
                    testing = false;
                }
                if (int.Parse(Images[i + 3].Text) > 200)
                {
                    MessageBox.Show("Invalid " + (i + 1) + ". height in Images settings!");
                    testing = false;
                }
            }
            return testing;
        }
    }
}
