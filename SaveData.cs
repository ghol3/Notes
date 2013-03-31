using System;
using System.Collections.Generic;
using System.Text;

namespace Notes
{
    class SaveData
    {
        private int[]
            NotesCoordinates = new int[6],
            ImagesCoordinates = new int[6];

        public void NCoordinates(int type, int x, int y)
        {
            NotesCoordinates[type] = x;
            NotesCoordinates[type + 1] = y;
        }

        public void ICoordinates(int type, int x, int y)
        {
            ImagesCoordinates[type] = x;
            ImagesCoordinates[type + 1] = y;
        }
    }
}
