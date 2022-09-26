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

            Console.Write("Your Aquarium Length (x) (min 40, max 120): ");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.Write("Your Aquarium Height (y) (min 15, max 30): ");
            double y = Convert.ToDouble(Console.ReadLine());

            Console.Clear();
            Aquarium aq = new Aquarium();


            Random randomGenerator = new Random();
            double posYC = randomGenerator.Next(1, (int)y - 1);
            double posXC = randomGenerator.Next(1, (int)x - 5);

            double posYS = randomGenerator.Next(1, (int)y - 1);
            double posXS = randomGenerator.Next(1, (int)x - 12);

            double posYB = randomGenerator.Next(1, (int)y - 1);
            double posXB = randomGenerator.Next(1, (int)x - 7);

            double posYSw = randomGenerator.Next(1, (int)y - 1);
            double posXSw = randomGenerator.Next(1, (int)x - 6);

            aq.AddCarp((int)posXC, (int)posYC);
            aq.AddShark((int)posXS, (int)posYS);
            aq.AddBlowfish((int)posXB, (int)posYB);
            aq.AddSwordfish((int)posXSw, (int)posYSw);

            bool doAsLong = true;
            bool doAsShort = true;

            while (doAsLong)
            {
                for (int i = 1; i < aq.FishList.Count; i++)
                {

                    //aici se verifica pestele actual in comparatie cu pozitia pestelui anterior. dar al ultimului cu primul nu sau al doilea

                    if (aq.FishList[i - 1].YPosition - 1 <= aq.FishList[i].YPosition && aq.FishList[i].YPosition <= aq.FishList[i - 1].YPosition + 1)
                    {
                        aq.FishList[i].YPosition = randomGenerator.Next(1, (int)y - 1);
                    }
                    else if (aq.FishList[i - 1].XPosition - 11 <= aq.FishList[i].XPosition && aq.FishList[i].XPosition <= aq.FishList[i - 1].XPosition + 11)
                    {
                        aq.FishList[i].XPosition = randomGenerator.Next(1, (int)x - 11);
                    }
                    else
                    {
                        if (i == aq.FishList.Count - 1)
                        {
                            doAsLong = false;
                        }
                    }

                }
            }


            while (true)
            {
                aq.MoveXAxis();
                aq.MoveYAxis();
                aq.AquariumLeer(x, y);

                //while (doAsShort)
                //{
                for (int i = 1; i < aq.FishList.Count; i++)
                {
                    //if ((aq.FishList[i - 1].YPosition == aq.FishList[i].YPosition) && (aq.FishList[i - 1].XPosition == aq.FishList[i].XPosition))
                    if ((aq.FishList[i - 1].YPosition == aq.FishList[i].YPosition) && (aq.FishList[i - 1].XPosition - 11 <= aq.FishList[i].XPosition && aq.FishList[i].XPosition <= aq.FishList[i - 1].XPosition + 11))
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
                    if (i == aq.FishList.Count - 1)
                    {
                        //doAsShort = false;
                    }
                    //}
                }

                Thread.Sleep(300);
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
