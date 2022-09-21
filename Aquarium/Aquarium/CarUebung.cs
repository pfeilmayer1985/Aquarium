using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Aquarium
{
    public class CarUebung
    {
        public int TypeId { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string TypeName { get; set; }
        public string Color { get; set; }
        public int Speed { get; set; }
        public int MaxSpeed { get; set; }
        public bool EngineOnBool { get; set; }

        public CarUebung(int typeid, string make, string model, string typename, string color, int speed)
        {
            TypeId = typeid;
            Make = make;
            Model = model;
            TypeName = typename;
            Color = color;
            Speed = speed;
        }

        public CarUebung()
        {
        }

        public static CarUebung AskForCar()
        {

            CarUebung inputFromUser = new CarUebung();
            Console.Write("ID : ");
            inputFromUser.TypeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Make : ");
            inputFromUser.Make = Console.ReadLine();
            Console.Write("Model : ");
            inputFromUser.Model = Console.ReadLine();
            Console.Write("Model type : ");
            inputFromUser.TypeName = Console.ReadLine();
            Console.Write("Color : ");
            inputFromUser.Color = Console.ReadLine();
            inputFromUser.EngineOnBool = false;
            inputFromUser.MaxSpeed = 190;
            return inputFromUser;

        }


        public void ShowMyCar()
        {
            Console.WriteLine($"Car Id is {TypeId}. It is a {Color} {Make} {Model} {TypeName}");
        }

        public void EngineOn()
        {

            if (EngineOnBool == false)
            {
                Console.WriteLine($"This {Make} {Model} has the engine Off. Starting Engine!");
                EngineOnBool = true;
            }
            else
            {
                Console.WriteLine($"This {Make} {Model} has it's engine on and moving with {Speed} kmh.");
            }
        }
        public void EngineOff()
        {

            if (EngineOnBool == true)
            {
                Console.WriteLine($"This {Make} {Model} was moving with {Speed} kmh. Breaking hard and stopping the engine!");
                Speed = 0;
                EngineOnBool = false;
            }
            else
            {
                Console.WriteLine($"This car is parked, engine allready off.");
            }

        }
        public void Accelerate()
        {
            Speed += 1;
            Console.WriteLine($"Accelerating to {Speed} kmh.");
            
        }

        public void AccelerateCustom()
        {
            Console.WriteLine("Desired speed : ");
            int askForUserSpeed = Convert.ToInt32(Console.ReadLine());
            Speed = askForUserSpeed;
        }

        public void Brake()
        {
            Speed -= 10;
            Console.WriteLine($"Breaking hard to {Speed} kmh.");
        }

        public void BrakeCustom()
        {
            Console.WriteLine("Desired speed after braking : ");
            int askForUserSpeed = Convert.ToInt32(Console.ReadLine());
            Speed -= askForUserSpeed;
            Console.WriteLine($"Breaking hard to {Speed} kmh.");
        }

        public void ChangeColor()
        {
            string oldColor = Color;
            Console.WriteLine("Desired Color : ");
            string askForUserColor = Console.ReadLine();
            Color = askForUserColor;
            Console.WriteLine($"The {Make} {Model} with ID {TypeId} used to be {oldColor} and after painting it over became {Color} ");

        }

    }
}
