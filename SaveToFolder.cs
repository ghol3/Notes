using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Notes
{
    class SaveToFolder
    {
        LoadData load = new LoadData();

        public void DefaulthSave(string FileName)
        {
            using (StreamWriter sw = new StreamWriter(FileName))
            {
                for (int i = 0; i < 3; i++)
                {
                    sw.WriteLine("False;0;0;0;0;0,0,0");
                }
                sw.Flush();
            }
        }
        /*METODA NA ULOZENI VLASTNOSTI OBJEKTU -------------------
         * True;    30;          30;      45;   45;  45,  45, 54
         * bool;souradniceX;souradniceY;sirka;vyska;red,green,blue
         * 
         */
        public void SaveSettings(EditForm edit, int[] Ncoords, int[] Icoords)
        {
            TextBox[,] Data = edit.TextBoxs();
            CheckBox[] Display = edit.CheckBoxs();
            using (StreamWriter sw = new StreamWriter(load.getAppNotes()))
            {
                for (int i = 0; i < 3; i++)
                {
                    sw.Write(Display[i].Checked.ToString() + ";" + Ncoords[2 * i].ToString() + ";" + Ncoords[(2 * i) + 1].ToString() + ";");
                    sw.Write(Data[i, 0].Text + ";" + Data[i, 1].Text + ";" + Data[i, 2].Text);
                    sw.WriteLine();
                }
                sw.Flush();
            }
            int k = 0;
            using (StreamWriter sw = new StreamWriter(load.getAppImages()))
            {
                for (int i = 3; i < 6; i++)
                {
                    sw.Write(Display[i].Checked.ToString() + ";" + Icoords[2 * k].ToString() + ";" + Icoords[(2 * k) + 1].ToString() + ";");
                    sw.Write(Data[i, 0].Text + ";" + Data[i, 1].Text + ";" + Data[i, 2].Text);
                    sw.WriteLine();
                    k++;
                }
                sw.Flush();
            }
        }

        public void savingForm(string colors, string firstNote, string secondNote, string thirdNote)
        {
            string[] Data = new string[4];
            Data[0] = colors;
            Data[1] = firstNote;
            Data[2] = secondNote;
            Data[3] = thirdNote;
            using (StreamWriter sw = new StreamWriter(load.getAppForm()))
            {
                for (int i = 0; i < 4; i++)
                    sw.WriteLine(Data[i]);
                sw.Flush();
            }  
        }

        public void DefaulthSaveForm()
        {
            using (StreamWriter sw = new StreamWriter(load.getAppForm()))
            {
                sw.WriteLine("240,240,240");
                for (int i = 0; i < 3; i++)
                {
                    sw.WriteLine("");
                }
                sw.Flush();
            }
        }
    }
}
