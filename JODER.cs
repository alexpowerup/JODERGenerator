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
            if (min < 5 || max < 5 || min>max)
                return "";

            string[] letters = new string[5]; //This array will store all the letters generated.
            Random RNG = new Random();
            int length;
            //If the minimum and the maximum length are the same, just set it to that value.
            //If they aren't the same, generate randomly a fixed length to work with that limitation.
            if(min == max)
            {
                length = min;
            }
            else
            {
                length = RNG.Next(min, max+1);
            }

            int generate = length - 5;
            int genletter;

            //STRING GENERATION
            /*All it has to do:
            -Each letter can occupy all the spaces it physically can. For example, for a generation limited to 7 words these can be generated:
              -JJJODER
              -JOOODER
              -JODDDER
              -JODEEER
              -JODERRR
              -JJOODER
              -JJODDER
              -JJODEER
              -JJODERR
              -JOODDER
              -JOODEER
              -JOODERR
              -JODDEER
              -JODDERR
              -JODEERR
            In order to achieve that, we can just substract the length of the word (which is 5 in every cases) and that is the letters that are going to
          be generated. With that in mind, we will store the letter that can additionally be created and choose a random number for each one. The last word
          will take all the remaining letters.
            
            -For hillarious results, additional text mechanics might be implemented such as using camelcase, make a letter sequence lowercased and more stupid stuff
            */
            //Generate J
            genletter = RNG.Next(generate+1);
            generate -= genletter;
            for(int i=0; i<=genletter; i++)
            {
                letters[0] += "J";
            }

            //Generate O
            genletter = RNG.Next(generate+1);
            generate -= genletter;
            for (int i = 0; i <= genletter; i++)
            {
                letters[1] += "O";
            }

            //Generate D
            genletter = RNG.Next(generate+1);
            generate -= genletter;
            for (int i = 0; i <= genletter; i++)
            {
                letters[2] += "D";
            }

            //Generate E
            genletter = RNG.Next(generate+1);
            generate -= genletter;
            for (int i = 0; i <= genletter; i++)
            {
                letters[3] += "E";
            }

            //Generate R
            genletter = generate;
            generate -= genletter;
            for (int i = 0; i <= genletter; i++)
            {
                letters[4] += "R";
            }

            return letters[0] + letters[1] + letters[2] + letters[3] + letters[4];
        }
    }
}
