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

        public Aquarium()
        {
            FishList = new List<Fish>();
        }

        public void AquariumLeer(int x, int y)
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

            foreach (Fish selection in FishList)
            {
                for (int i = 0; i < selection.Look.Length; i++)
                {
                    aquarium[selection.XPosition + i, selection.YPosition] = selection.Look[i].ToString();
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

        public void AddCarp(int x, int y)
        {

            FCarp myCarp = new FCarp(x, y);
            FishList.Add(myCarp);

        }

        public void AddShark(int x, int y)
        {

            FShark myShark = new FShark(x, y);
            FishList.Add(myShark);

        }

        public void AddBlowfish(int x, int y)
        {

            FBlowfish myBlowfish = new FBlowfish(x, y);
            FishList.Add(myBlowfish);

        }

        public void AddSwordfish(int x, int y)
        {

            FSwordfish mySwordfish = new FSwordfish(x, y);
            FishList.Add(mySwordfish);

        }






    }
}
