using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Notes
{
    class LoadData
    {
        private string 
            AppNotes = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "poznamky.txt"),
            AppImages = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "obrazky.txt");
        private string[]
            Notes3FromAppNotes = new string[3],
            Images3FromAppImages = new string[3];
        private int[]
            NotesCoordinates = new int[6],
            ImagesCoordinates = new int[6];

        public string getAppNotes()
        {
            return AppNotes;
        }

        public string getAppImages()
        {
            return AppImages;
        }

        public string[] get3Notes()
        {
            using (StreamReader sr = new StreamReader(getAppNotes()))
            {
                string s = "";
                int j = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    Notes3FromAppNotes[j] = s;
                    j++;
                }
            }
            return Notes3FromAppNotes;
        }

        public string[] get3Images()
        {
            using (StreamReader sr = new StreamReader(getAppImages()))
            {
                string s = "";
                int j = 0;
                while ((s = sr.ReadLine()) != null)
                {
                    Images3FromAppImages[j] = s;
                    j++;
                }
            }
            return Images3FromAppImages;
        }

        public int[] getCoordinate(bool coor)
        {
            string[] DataFromFile;
            if(coor == true)
                DataFromFile = get3Notes();
            else
                DataFromFile = get3Images();
            string[, ] Data = new string[3, 6];
            string[] Calculation;
            for (int i = 0; i < 3; i++)
            {
                Calculation = DataFromFile[i].Split(';');
                for (int j = 0; j < 6; j++)
                    Data[i, j] = Calculation[j];
            }
            int Index = 0;
            for (int i = 0; i < 3; i++)
            {
                for (int j = 1; j < 3; j++)
                {
                    if(coor == true)
                        NotesCoordinates[Index] = int.Parse(Data[i, j]);
                    else
                        ImagesCoordinates[Index] = int.Parse(Data[i, j]);
                    Index++;
                }
            }
            if (coor == true)
                return NotesCoordinates;
            else
                return ImagesCoordinates;
        }
    }
}
