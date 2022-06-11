using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    abstract class Vehicle
    {
        public string Type { get;}
        public double AverageFuel { get;}
        public int PetrolTankVolume { get;}
        public int Speed { get; }
        

          public double DistanceVechicle(int PetrolTankVolume, double AverageFuel)
          {
            double Distance = (PetrolTankVolume * 100) / AverageFuel;
              return Math.Round(Distance,1);
          }

        public abstract double TimeVechicle(double Distance);
        public abstract void DistanceWithWeight(int PetrolTankVolume, int Weight, double AverageFuel);

    }

    class Car : Vehicle
    {
        public override double TimeVechicle(double Distance)
        {
            double Time = Distance / 80;
            return Math.Round(Time,1);
        }

        public override void DistanceWithWeight(int PetrolTankVolume, int Weight, double AverageFuel)
        {
            double distanceWithWeigh;
            const double y = 0.6;
            switch (Weight)

            {
                case 1:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (Weight * y)));
                    Console.WriteLine(Math.Round(distanceWithWeigh,1));
                    break;
                case 2:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (Weight * y)));
                    Console.WriteLine(Math.Round(distanceWithWeigh, 1));
                    break;
                case 3:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (Weight * y)));
                    Console.WriteLine(Math.Round(distanceWithWeigh, 1));
                    break;
                case 4:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (Weight * y)));
                    Console.WriteLine(Math.Round(distanceWithWeigh, 1));
                    break;
                default:
                    distanceWithWeigh = PetrolTankVolume * AverageFuel;
                    Console.WriteLine(Math.Round(distanceWithWeigh, 1));
                    break;
            }
        }
    }

    class Truck : Vehicle
    {
        public override double TimeVechicle(double Distance)
        {
            double Time = Distance / 60;
            return Math.Round(Time,1);
        }
        public override void DistanceWithWeight(int PetrolTankVolume, int Weight, double AverageFuel)
        {
            double distanceWithWeigh;
            const double x = 0.4;
            switch (Weight)
            {
                case <= 200:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (x)));
                    Console.WriteLine("Distance depending on weight" + Math.Round(distanceWithWeigh, 1));
                    break;
                case > 200 and <= 400:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (2 * x)));
                    Console.WriteLine("Distance depending on weight" + Math.Round(distanceWithWeigh, 1));
                    break;
                case > 400 and <= 600:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (3 * x)));
                    Console.WriteLine("Distance depending on weight" + Math.Round(distanceWithWeigh, 1));
                    break;
                case > 600 and <= 800:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (4 * x)));
                    Console.WriteLine("Distance depending on weight" + Math.Round(distanceWithWeigh, 1));
                    break;
                case > 800 and <= 1000:
                    distanceWithWeigh = PetrolTankVolume * ((AverageFuel - (5 * x)));
                    Console.WriteLine("Distance depending on weight" + Math.Round(distanceWithWeigh, 1));
                    break;
                default:
                    distanceWithWeigh = PetrolTankVolume * AverageFuel;
                    Console.WriteLine("Distance depending on weight" + Math.Round(distanceWithWeigh, 1));
                    break;
            }
        }
    }

    class SportCar : Vehicle
    {
        public override double TimeVechicle(double Distance)
        {
            double Time = Distance / 100;
            return Math.Round(Time,1);
        }
        public override void DistanceWithWeight(int PetrolTankVolume, int Weight, double AverageFuel)
        {
            throw new NotImplementedException();
        }
    }
}
