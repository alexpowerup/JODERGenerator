using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JODERGenerator
{
    class JODER
    {
        static public string Generate(int min, int max)
        {
            //Security check: If the given arguments aren't valid, return an empty string.
            if (min < 5 || max < 5)
                return "";

            string[] letters = new string[5];

            //Generate J


            //Generate O


            //Generate D


            //Generate E


            //Generate R



            return letters[0] + letters[1] + letters[2] + letters[3] + letters[4];
        }
    }
}
