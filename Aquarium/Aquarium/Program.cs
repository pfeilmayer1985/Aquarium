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


            Console.WriteLine("Your Aquarium Length (x) : ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your Aquarium Height (y) : ");
            int y = Convert.ToInt32(Console.ReadLine());

            Console.Clear();
           // Aquarium.AquariumLeer(x, y);

            Random positionYC = new Random();
            int posYC = positionYC.Next(1, y - 1);
            Random positionXC = new Random();
            int posXC = positionXC.Next(1, x - 1);

            Random positionYS = new Random();
            int posYS = positionYS.Next(1, y - 1);
            Random positionXS = new Random();
            int posXS = positionXS.Next(1, x - 1);

            Aquarium.AddCarp(posXC, posYC);
            Aquarium.AddShark(posXS, posYS);


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



            Console.ReadLine();



        }

    }
}
