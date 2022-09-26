using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Your Aquarium Length (x) min 50 : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Aquarium Height (y) max 40: ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
            Aquarium aq = new Aquarium();


            Random randomGenerator = new Random();
            int posYC = randomGenerator.Next(1, y - 1);
            int posXC = randomGenerator.Next(1, x - 4);

            int posYS = randomGenerator.Next(1, y - 1);
            int posXS = randomGenerator.Next(1, x - 11);

            int posYB = randomGenerator.Next(1, y - 1);
            int posXB = randomGenerator.Next(1, x - 6);

            int posYSw = randomGenerator.Next(1, y - 1);
            int posXSw = randomGenerator.Next(1, x - 5);

            aq.AddCarp(posXC, posYC);
            aq.AddShark(posXS, posYS);
            aq.AddBlowfish(posXB, posYB);
            aq.AddSwordfish(posXSw, posYSw);

            bool doAsLong = true;
            while (doAsLong)
            {
                for (int i = 1; i < aq.FishList.Count; i++)
                {
                
                    //aici se verifica pestele actual in comparatie cu pozitia pestelui anterior. dar al ultimului cu primul nu sau al doilea

                    if (aq.FishList[i-1].YPosition-1 <= aq.FishList[i].YPosition && aq.FishList[i].YPosition <= aq.FishList[i - 1].YPosition+1)
                    {
                        aq.FishList[i].YPosition = randomGenerator.Next(1, y-1);
                    }
                    else if (aq.FishList[i - 1].XPosition - 11 <= aq.FishList[i].XPosition && aq.FishList[i].XPosition <= aq.FishList[i - 1].XPosition + 11)
                    {
                        aq.FishList[i].XPosition = randomGenerator.Next(1, x-11);
                    }
                    else
                    {
                        if (i == aq.FishList.Count-1)
                        {
                            doAsLong = false;
                        }
                    }
                    
                }
            }



            aq.AquariumLeer(x, y);

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
