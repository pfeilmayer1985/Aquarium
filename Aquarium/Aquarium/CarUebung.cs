using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
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

        public CarUebung() { }

        public static CarUebung AskForCar()
        {

            CarUebung inputFromUser = new CarUebung();
            Console.Write("ID :");
            inputFromUser.TypeId = Convert.ToInt32(Console.ReadLine());
            Console.Write("Make :");
            inputFromUser.Make = Console.ReadLine();
            Console.Write("Model :");
            inputFromUser.Model = Console.ReadLine();
            Console.Write("ID :");
            inputFromUser.TypeName = Console.ReadLine();
            Console.Write("ID :");
            inputFromUser.Color = Console.ReadLine();

            return inputFromUser;

        }


        public void ShowMyCar()
        {
            Console.Write($"Car Id is {TypeId}. It is a {Color} {Make} {Model} {TypeName}");
        }

        public void EngineOn()
        {

            if (EngineOnBool == false)
            {
                Console.Write("This car is resting with the engine Off. Starting Engine!");
                EngineOnBool = true;
            }
            else
            {
                Console.Write($"This car has it's engine on and moving with {Speed} kmh.");
            }
        }
        public void EngineOff()
        {

            if (EngineOnBool == true)
            {
                Console.Write("This car was moving. Reducing speed and stopping the engine!");
                Speed = 0;
                EngineOnBool = true;
            }
            else
            {
                Console.Write($"This car is parked, engine allready off.");
            }

        }


    }
}
