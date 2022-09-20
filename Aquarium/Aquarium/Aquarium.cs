using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class Aquarium
    {

        public static void AquariumLeer(int x, int y)
        {
           // x = 100;
           // y = 20;

            string[,] aquarium = new string[x, y];

           

            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    if (i == 0 || i == x - 1)
                    {
                        aquarium[i, j] = "|";
                    }
                    else
                    {
                        aquarium[i, j] = " ";
                    }
                    if (j == y - 1)
                    {
                        aquarium[i, j] = "-";
                    }
                }
            }



            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(aquarium[i, j]);
                }
                Console.Write("\n");
            }

        }
    }
}
