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

        public static void AddCarp(int x, int y)
        {
            
            FCarp myCarp = new FCarp();
            Console.Write(myCarp.Look);

        }

        public static void AddShark(int x, int y)
        {

            FShark myShark = new FShark();
            Console.Write(myShark.Look);

        }






    }
}
