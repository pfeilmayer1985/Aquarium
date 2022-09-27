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
        public string[,] AquariumBehaelter { get; set; }
        Random random = new Random();

        public Aquarium()
        {
            FishList = new List<Fish>();
        }

        public void AquariumLeer(int x, int y)
        {


            AquariumBehaelter = new string[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    if (i == 0 || i == x - 1)
                    {
                        AquariumBehaelter[i, j] = "|";
                    }
                    else
                    {
                        AquariumBehaelter[i, j] = " ";
                    }
                    if (j == y - 1)
                    {

                        AquariumBehaelter[i, j] = "-";
                    }

                }

            }


            foreach (Fish selection in FishList)
            {
                for (int i = 0; i < selection.Look.Length; i++)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    AquariumBehaelter[(selection.XPosition) + i, selection.YPosition] = selection.Look[i].ToString();
                }
            }
            Console.Clear();

            for (int j = 0; j < y; j++)
            {
                for (int i = 0; i < x; i++)
                {
                    Console.Write(AquariumBehaelter[i, j]);
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



        public void AddFood(int x, int y)
        {
            FFood myFood = new FFood(x, y);
            FishList.Add(myFood);
        }



        public void RemoveAFish(Fish fishToBeRemoved)
        {
            FishList.Remove(fishToBeRemoved);
        }



        public void MoveXAxis()
        {


            foreach (Fish myFish in FishList)
            {

                if (random.Next(0, 25) == 10)
                {

                    myFish.SwimDirection = !myFish.SwimDirection;
                    if (myFish.SwimDirection)
                    {
                        myFish.Look = myFish.BasicLook;
                    }
                    else
                    {
                        myFish.Look = myFish.InvertedLook;
                    }

                }



                if (myFish.XPosition >= 2 && myFish.SwimDirection == false)
                {
                    myFish.Look = myFish.BasicLook;
                    myFish.XPosition -= myFish.Speed;
                }
                else if (myFish.XPosition + myFish.Look.Length >= AquariumBehaelter.GetLength(0) - 2)
                {
                    myFish.Look = myFish.BasicLook;
                    myFish.XPosition -= myFish.Speed;
                    myFish.SwimDirection = false;
                }
                else
                {
                    myFish.XPosition += myFish.Speed;
                    myFish.Look = myFish.InvertedLook;
                    myFish.SwimDirection = true;

                }
            }


        }

        public void MoveYAxis()
        {



            foreach (Fish myFish in FishList)
            {



                if (random.Next(0, 1000) <= myFish.MoveSpeedUpAndDown)
                {

                    //random up or down swimming for each fish
                    if (random.Next(0, 2) == 0)
                    {
                        myFish.SwimDepth = true;
                        // myFish.YPosition += 1;

                    }
                    else
                    {
                        myFish.SwimDepth = false;
                        // myFish.YPosition -= 1;

                    }

                    //checking the aquarium boundaries up and down and changing direction if close to top or bottom
                    if (myFish.YPosition >= 2 && myFish.SwimDepth == false)
                    {

                        myFish.YPosition -= 1;

                    }
                    else if (myFish.YPosition >= AquariumBehaelter.GetLength(1) - 2)
                    {
                        myFish.SwimDepth = false;
                        myFish.YPosition -= 1;
                    }

                    else
                    {
                        myFish.SwimDepth = true;
                        myFish.YPosition += 1;

                    }


                }
            }
        }
    }
}


