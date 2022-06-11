using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicleCar = new Car();
            Vehicle vehicleTruck = new Truck();
           Vehicle vehicleSportCar = new SportCar();


            Console.WriteLine("Enter the vehicle Type: ");
            string vehicleType = Console.ReadLine();

            Console.WriteLine("Enter the vehicle Petrol Tank Volume: ");
            int PetrolTankVolume = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Enter the vehicle Average Fuel: ");
            double AverageFuel = Double.Parse(Console.ReadLine());


            double distance;
            double time;
            int Weight;
            switch (vehicleType)
                    {
                        case "car":
                    distance = vehicleCar.DistanceVechicle(PetrolTankVolume, AverageFuel);
                    Console.WriteLine("Distance: " + distance);

                    time = vehicleCar.TimeVechicle(distance);
                    Console.WriteLine("Time: " + time);

                    do
                    {
                        Console.WriteLine("Enter the number of passengers: ");
                         Weight = Int32.Parse(Console.ReadLine());

                        if (Weight > 4)
                        {
                            Console.WriteLine("Number of passengers should be less then 5. Re enter.");
                        }
                        else
                        {
                            vehicleCar.DistanceWithWeight(PetrolTankVolume, Weight, AverageFuel);
                        }
                        
                    } while (Weight > 4);
                            break;

                        case "truck":
                    distance = vehicleCar.DistanceVechicle(PetrolTankVolume, AverageFuel);
                    Console.WriteLine("Distance: " + distance);

                    time = vehicleCar.TimeVechicle(distance);
                    Console.WriteLine("Time: " + time);

                    do
                    {
                        Console.WriteLine("Enter the weight of cargo: ");
                        Weight = Int32.Parse(Console.ReadLine());

                        if (Weight > 1000)
                        {
                            Console.WriteLine("Цeight of cargo should be less then 1000. Re enter.");
                        }
                        else
                        {
                            vehicleCar.DistanceWithWeight(PetrolTankVolume, Weight, AverageFuel);
                        }

                    } while (Weight > 1000);
                    break;

                        case "sportcar":
                    distance = vehicleCar.DistanceVechicle(PetrolTankVolume, AverageFuel);
                    Console.WriteLine("Distance: " + distance);

                    time = vehicleCar.TimeVechicle(distance);
                    Console.WriteLine("Time: " + time);
                    break;
                        default:
                            break;
                    }
        } 
    }
}

