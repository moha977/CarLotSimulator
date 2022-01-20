using System;
using System.Collections.Generic;
using System.Text;

namespace CarLotSimulator
{
    public class Car
    {
        public Car(string make, string model, int year, string engineNoise, string honkNoise, bool isDriveable)
        {
            Make = make;
            Model = model;
            Year = year;
            EngineNoise = engineNoise;  
            HonkNoise = honkNoise;  
            IsDriveable = isDriveable;  


        }
        public Car()
        { }
         public string Make { get; set; }    
         public string Model { get; set; }
         public int Year { get; set; }   
         
         public string EngineNoise { get; set; }

         public string HonkNoise { get; set;}

         public bool IsDriveable { get; set;}
        
        public void MakeEngineNoise()
        {
            Console.WriteLine($"{Make} car engine will {EngineNoise}" );
        }
        public void MakeHonkNoise()
        {
            Console.WriteLine($"{Make} car Honk will {HonkNoise}");
        }
        
       

    }
}
