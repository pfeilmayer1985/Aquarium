using System;
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

            bool continueGame = false;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("How many CARPs do you want: ");
                int carpZahl = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many SWORDFISHes do you want: ");
                int swordFishZahl = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many BLOWFISHes do you want: ");
                int blowFishZahl = Convert.ToInt32(Console.ReadLine());
                Console.Write("How many SHARKs do you want: ");
                int sharkZahl = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("How much FOOD do you want: ");
                int foodZahl = Convert.ToInt32(Console.ReadLine());
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Your Aquarium Length (x) (min 50, max 100): ");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Your Aquarium Height (y) (min 15, max 30): ");
                int y = Convert.ToInt32(Console.ReadLine());

                Console.Clear();
                Aquarium aq = new Aquarium();


                Random randomGenerator = new Random();


                for (int i = 0; i < carpZahl; i++)
                {
                    aq.AddCarp(randomGenerator.Next(3, x - 5), randomGenerator.Next(1, y - 1));
                }
                for (int i = 0; i < swordFishZahl; i++)
                {
                    aq.AddSwordfish(randomGenerator.Next(3, x - 6), randomGenerator.Next(1, y - 1));
                }
                for (int i = 0; i < blowFishZahl; i++)
                {
                    aq.AddBlowfish(randomGenerator.Next(3, x - 7), randomGenerator.Next(1, y - 1));
                }
                for (int i = 0; i < sharkZahl; i++)
                {
                    aq.AddShark(randomGenerator.Next(3, x - 12), randomGenerator.Next(1, y - 1));
                }
                for (int i = 0; i < foodZahl; i++)
                {
                    aq.AddFood(randomGenerator.Next(1, x - 2), randomGenerator.Next(1, y - 1));
                }


                bool doAsLong = true;

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
                                    if (aq.FishList[i].Size == aq.FishList[j].Size)
                                    {
                                        continue;
                                    }

                                    else if (aq.FishList[i].Size > aq.FishList[j].Size)
                                    {
                                        //the first fish, being bigger, eats the second, smaller fish
                                        aq.FishList[i].Size += aq.FishList[j].Size;
                                        aq.RemoveAFish(aq.FishList[j]);
                                        i--;
                                        j--;
                                        i = Math.Max(0, i);
                                        j = Math.Max(0, j);

                                    }
                                    else
                                    {
                                        //the second fish, being bigger, eats the first, smaller fish
                                        aq.FishList[j].Size += aq.FishList[i].Size;
                                        aq.RemoveAFish(aq.FishList[i]);
                                        i--;
                                        j--;
                                        i = Math.Max(0, i);
                                        j = Math.Max(0, j);

                                    }
                                }
                            }
                        }
                    }


                    Thread.Sleep(50);


                    if (aq.FishList.Where(w => w.Size > 1).ToList().Count == 1)
                    //if (aq.FishList.Count == 1)
                    {
                        foreach (var fish in aq.FishList)
                        {
                            if (fish.Size > 1)
                            {
                                Console.Clear();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine($"The only survivor is a {fish.TypeF}, also known as '{fish.BasicLook}' or '{fish.InvertedLook}'." +
                                    $"\nOur winner was an overweight {fish.TypeF} size {fish.Size}." +
                                    $"\nThe 'Game' was refreshed {numberOfRefreshes} times until our {fish.TypeF} ate it's way to victory." +
                                    $"\nThanks for playing!\n");

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Do you want to play again (y/n)?");
                                string replayGame = Console.ReadLine();

                                while (replayGame != "y" && replayGame != "n")
                                {
                                    Console.Clear();
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Let's try again. This time try to pay attention!");
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Do you want to play again (y/n)?");
                                    replayGame = Console.ReadLine();
                                }

                                switch (replayGame)
                                {
                                    case "y":
                                        continueGame = true;
                                        Console.Clear();
                                        break;
                                    case "n":
                                        continueGame = false;
                                        break;
                                    default:
                                        Console.WriteLine("Something weird happen!");
                                        break;
                                }
                            }
                        }
                        doAsLong = false;
                    }
                    numberOfRefreshes++;
                }
            } while (continueGame);



        }

    }
}
