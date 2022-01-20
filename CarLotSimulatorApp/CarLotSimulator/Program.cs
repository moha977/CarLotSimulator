using CarLotSimulator;
using System;
using System.Collections.Generic;

namespace classesexercise2
    {
    internal class Program
    {
        public static object MakeEngineNoise { get;  set; }
        public static object MakeHonkNoise { get; set; }

        public static void Main(string[] args)
        {
            //TODO

            //Create a seperate class file called Car //Done
            //Car shall have the following properties: Year, Make, Model, EngineNoise, HonkNoise, IsDriveable //Done
            //Car shall have the following methods: MakeEngineNoise(), MakeHonkNoise() //Done
            //The methods should take one string parameter: the respective noise property //Done


            //Now that the Car class is created we can instanciate 3 new cars //Done   

            var bmw = new Car("BMW", "X6", 2019, "VonVon", "Beeeep", true);
            var ford = new Car("Ford", "Fusion", 2015, "HonHon", "heeep", false);
            var merceds = new Car("Mercesds", "Benz", 2014, "WonWon", "Weeeep", true);

            var carList = new System.Collections.Generic.List<Car>() { bmw, ford, merceds };


            //Set the properties for each of the cars //Done
            foreach (var vehicle in carList)
            {
                Console.WriteLine($"{vehicle.Make} {vehicle.Model} {vehicle.Year} {vehicle.EngineNoise} {vehicle.HonkNoise} {vehicle.IsDriveable}");
            }
            //Call each of the methods for each car
            bmw.MakeEngineNoise();
            ford.MakeEngineNoise();
            merceds.MakeEngineNoise();

            bmw.MakeHonkNoise();
            ford.MakeHonkNoise();
            merceds.MakeHonkNoise();

            //*************BONUS*************//

            // Set the properties utilizing the 3 different ways we learned about, one way for each car

            //*************BONUS X 2*************//

            //Create a CarLot class
            //It should have at least one property: a List of cars
            //Instanciate the a Carlot at the beginning of the program and as you create a car add the car to the list.
            //At the end iterate through the list printing each of car's Year, Make, and Model to the console
        }
    }
}

