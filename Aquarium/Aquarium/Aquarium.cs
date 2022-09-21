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
        public List<Fish> FishList { get; set; }

        public static void AquariumLeer(int x, int y)
        {

            string[,] aquarium = new string[x, y];

            Random positionY = new Random();
            int posY = positionY.Next(1, y - 1);
            Random positionX = new Random();
            int posX = positionX.Next(1, x - 1);

            AddFish(posX, posY);


            for (int j = 0; j < y; j++)
            {

                for (int i = 0; i < x; i++)
                {
                    if (aquarium[i, j] != " ")
                    {
                    }

                    else
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

        public static void AddFish(int x, int y)
        {
            //Console.Write(Look);
            FCarp myCarp = new FCarp();
           // myCarp.ShowAppearence();

        }






    }
}
