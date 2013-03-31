using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

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
    }
}
