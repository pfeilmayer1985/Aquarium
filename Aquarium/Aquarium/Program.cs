﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //for (int i = 0; i < 10; i++)
            //{
            //    for (int j = i; j < 10; j++)
            //    {
            //        Console.WriteLine($"I:{i}  \t j: {j}");
            //    }
            //}
            bool continueGame = true;


            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Your Aquarium Length (x) (min 40, max 120): ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Your Aquarium Height (y) (min 15, max 30): ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Aquarium aq = new Aquarium();


            Random randomGenerator = new Random();
            int posYC = randomGenerator.Next(1, y - 1);
            int posXC = randomGenerator.Next(3, x - 5);

            int posYS = randomGenerator.Next(1, y - 1);
            int posXS = randomGenerator.Next(3, x - 12);

            int posYB = randomGenerator.Next(1, y - 1);
            int posXB = randomGenerator.Next(3, x - 7);

            int posYSw = randomGenerator.Next(1, y - 1);
            int posXSw = randomGenerator.Next(3, x - 6);

            aq.AddCarp(posXC, posYC);
            aq.AddShark(posXS, posYS);
            aq.AddBlowfish(posXB, posYB);
            aq.AddSwordfish(posXSw, posYSw);

            bool doAsLong = true;
            // bool doAsShort = true;

            //aici se verifica pestele actual in comparatie cu pozitia pestelui anterior si urmator.

            for (int i = 0; i < aq.FishList.Count; i++)
            {

                for (int j = i; j < aq.FishList.Count; j++)
                {

                    //if the fish i is the same as fish j, continue
                    if (aq.FishList[i] == aq.FishList[j])
                    {
                        continue;
                    }

                    if (aq.FishList[i].YPosition - 2 <= aq.FishList[j].YPosition && aq.FishList[j].YPosition <= aq.FishList[i].YPosition + 2)
                    {
                        aq.FishList[j].YPosition = randomGenerator.Next(1, y - 1);
                    }
                    else if (aq.FishList[i].XPosition - aq.FishList[j].Look.Length <= aq.FishList[j].XPosition && aq.FishList[j].XPosition <= aq.FishList[i].XPosition + aq.FishList[j].Look.Length)
                    {
                        aq.FishList[j].XPosition = randomGenerator.Next(1, x - (aq.FishList[j].Look.Length + 1));
                    }
                    else
                    {
                        continue;
                    }

                }
            }


            int numberOfRefreshes = 0;
            while (doAsLong)
            {
                aq.AquariumLeer(x, y);
                aq.MoveXAxis();
                aq.MoveYAxis();



                for (int i = 0; i < aq.FishList.Count; i++)
                {
                    for (int j = i; j < aq.FishList.Count; j++)
                    {

                        //if the fish i is the same as fish j, continue
                        if (aq.FishList[i] == aq.FishList[j])
                        {
                            continue;
                        }

                        //if fish i and fist j have the exact same depth (Y - position) then check the X proximity/overlapping
                        if (aq.FishList[i].YPosition == aq.FishList[j].YPosition)
                        {

                            //Make a new integer based list and add the first fish's look length(range - from starting x point to look lenght as endpoint) to the fish/list
                            List<int> firstFishRange = Enumerable.Range(aq.FishList[i].XPosition, aq.FishList[i].Look.Length).ToList();

                            //Make a new integer based list and add the second fish's look length(range - from starting x point to look lenght as endpoint) to the fish/list
                            List<int> secondFishRange = Enumerable.Range(aq.FishList[j].XPosition, aq.FishList[j].Look.Length).ToList();

                            //Check if the range of the first list has any overlapping with the second list and save the value to a boolean - either false or true
                            bool intersection = firstFishRange.Any(a => secondFishRange.Any(b => a == b));

                            //if the boolean previously saved is true and any element from the first list/fish overlapps with any elements from the second list/fish
                            if (intersection)
                            {
                                //if the size (length of the fish's look) of the first fish is bigger than the second one
                                if (aq.FishList[i].Look.Length > aq.FishList[j].Look.Length)
                                {
                                    //the first fish, being bigger, eats the second, smaller fish
                                    aq.RemoveAFish(aq.FishList[j]);

                                    //resetting the list, starting both list checking from 0 instead of continuing from the last point
                                    i = 0;
                                    j = 0;
                                }
                                else
                                {
                                    //the second fish, being bigger, eats the first, smaller fish
                                    aq.RemoveAFish(aq.FishList[i]);

                                    //resetting the list, starting both list checking from 0 instead of continuing from the last point
                                    i = 0;
                                    j = 0;
                                }
                            }
                        }
                    }
                }
                /*
                //Checking if Y(A) is the same with Y(B) - both fishes are on the same line/heighth
                if ((aq.FishList[i - 1].YPosition == aq.FishList[i].YPosition) &&
                    //Checking if X(A) is in the same pos with X(B)+FishLength
                    (aq.FishList[i - 1].XPosition == aq.FishList[i].XPosition + aq.FishList[i].Size ||
                    //Checking if X(A)+FishLength is in the same pos with X(B)
                    aq.FishList[i - 1].XPosition + aq.FishList[i - 1].Size == aq.FishList[i].XPosition ||
                    //Checking if X(A) is in the same pos with X(B)
                    aq.FishList[i - 1].XPosition == aq.FishList[i].XPosition ||
                    //Checking if X(A)+FishLength is in the same pos with X(B)+FishLength
                    aq.FishList[i - 1].XPosition + aq.FishList[i - 1].Size == aq.FishList[i].XPosition + aq.FishList[i].Size ||
                    //Checking if X(A)+HalfOfFishLength is in the same pos with X(B)
                    aq.FishList[i - 1].XPosition + (aq.FishList[i - 1].Size / 2) == aq.FishList[i].XPosition ||
                    //Checking if X(A)+HalfOfFishLength is in the same pos with X(B)+FishLength
                    aq.FishList[i - 1].XPosition + (aq.FishList[i - 1].Size / 2) == aq.FishList[i].XPosition + aq.FishList[i].Size ||
                    //Checking if X(A)+HalfOfFishLength is in the same pos with X(B)+HalfOfFishLength
                    aq.FishList[i - 1].XPosition + (aq.FishList[i - 1].Size / 2) == aq.FishList[i].XPosition + (aq.FishList[i].Size / 2) ||
                    //Checking if X(B)+HalfOfFishLength is in the same pos with X(A)
                    aq.FishList[i].XPosition + (aq.FishList[i].Size / 2) == aq.FishList[i - 1].XPosition ||
                    //Checking if X(B)+HalfOfFishLength is in the same pos with X(A)+FishLength
                    aq.FishList[i].XPosition + (aq.FishList[i].Size / 2) == aq.FishList[i - 1].XPosition + aq.FishList[i - 1].Size ||
                    //Checking if X(B)+HalfOfFishLength is in the same pos with X(A)+HalfOfFishLength
                    aq.FishList[i].XPosition + (aq.FishList[i].Size / 2) == aq.FishList[i - 1].XPosition + (aq.FishList[i - 1].Size / 2)

                    ))
                {
                    if (aq.FishList[i - 1].Size > aq.FishList[i].Size)
                    {
                        aq.RemoveAFish(aq.FishList[i]);
                    }
                    else
                    {
                        aq.RemoveAFish(aq.FishList[i - 1]);
                    }

                }

                */

                Thread.Sleep(1);

                
                if (aq.FishList.Count == 1)
                {
                    foreach (var fish in aq.FishList)
                    {
                        Console.Clear();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine($"The only survivor is the {fish.TypeF}, also known as '{fish.BasicLook}' or '{fish.InvertedLook}'." +
                            $"\nThe 'Game' was refreshed {numberOfRefreshes} times until we had a winner." +
                            $"\nThanks for playing!" );
                    }
                    doAsLong = false;
                }
                numberOfRefreshes++;
            }

            Console.ReadLine();








            //List<CarUebung> listOfCars = new List<CarUebung>();
            //listOfCars.Add(CarUebung.AskForCar());

            //foreach (CarUebung car in listOfCars)
            //{
            //    car.ShowMyCar();
            //}
            //listOfCars[0].EngineOn();
            //listOfCars[0].Accelerate();

            //listOfCars[0].AccelerateCustom();
            //if (listOfCars[0].Speed >= listOfCars[0].MaxSpeed)
            //{
            //    Console.WriteLine("You are over the Maximum Vehicle Speed!");
            //    listOfCars[0].Speed = listOfCars[0].MaxSpeed - (listOfCars[0].MaxSpeed / 2);
            //    Console.WriteLine($"For safety reasons I will accelerate to half from the Max Speed : {listOfCars[0].MaxSpeed - (listOfCars[0].MaxSpeed / 2)} KmH!");
            //}

            //listOfCars[0].ChangeColor();
            //listOfCars[0].EngineOn();
            //listOfCars[0].Accelerate();
            //listOfCars[0].Brake();

            //listOfCars[0].EngineOff();
            //listOfCars[0].EngineOff();

            //int zahl = 5;
            //zahl.ToString();
            //Console.WriteLine(zahl);

        }

    }
}
