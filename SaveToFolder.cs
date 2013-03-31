using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace Notes
{
    class SaveToFolder
    {
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
        public void SaveSettings()
        {
            
        }
    }
}
