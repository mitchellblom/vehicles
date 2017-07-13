using System;
using System.Linq;
using System.Collections.Generic;

namespace vehicles
{

    public interface IVehicle
    {
        int PassengerCapacity { get; set; }
        string TransmissionType { get; set; }
        double EngineVolume { get; set; }
        void Start();
        void Stop();
    }

    public interface IDoors
    {
        int Doors { get; set; }
    }

    public interface IWheels
    {
        int Wheels { get; set; }
    }

    public interface IWaterCraft
    {
        double MaxWaterSpeed { get; set; }
    }

    public interface IAirCraft
    {
        void Fly();
        double MaxAirSpeed { get; set; }
        bool Winged { get; set; }
    }

    public interface ILandCraft
    {
        void Drive();
        double MaxLandSpeed { get; set; }
    }

    public class JetSki : IVehicle, IWaterCraft
    {
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; }
        public double EngineVolume { get; set; }
        public double MaxWaterSpeed { get; set; }

        public void Drive()
        {
            Console.WriteLine("Jet ski drive.");
        }

        public void Start()
        {
            Console.WriteLine("Jet ski start.");
        }

        public void Stop()
        {
            Console.WriteLine("Jet ski stop.");
        }
    }

    public class Motorcycle : IVehicle
    {
        public int Wheels { get; set; } = 2;
        public int Doors { get; set; } = 0;
        public int PassengerCapacity { get; set; }
        public string TransmissionType { get; set; } = "Manual";
        public double EngineVolume { get; set; } = 1.3;
        public double MaxLandSpeed { get; set; } = 160.4;

        public void Drive()
        {
            Console.WriteLine("The motorcycle screams down the highway");
        }

        public void Start()
        {
            Console.WriteLine("The motorcycle started.");
        }

        public void Stop()
        {
            Console.WriteLine("The motorcycle stopped.");
        }
    }

    public class Cessna : IVehicle, ILandCraft, IAirCraft
    {
    public int Wheels { get; set; } = 3;
    public int Doors { get; set; } = 3;
    public int PassengerCapacity { get; set; } = 113;
    public bool Winged { get; set; } = true;
    public string TransmissionType { get; set; } = "None";
    public double EngineVolume { get; set; } = 31.1;
    public double MaxLandSpeed { get; set; }
    public double MaxAirSpeed { get; set; } = 309.0;

    public void Drive()
    {
        Console.WriteLine("Cessna drive. This is when it taxis before or after flight.");
    }

    public void Fly()
    {
        Console.WriteLine("The Cessna effortlessly glides through the clouds like a gleaming god of the Sun");
    }

    public void Start()
    {
        Console.WriteLine("Cessna start.");
    }

    public void Stop()
    {
        Console.WriteLine("Cessna stop.");
    }
    }


    public class Program
    {

        public static void Main() {

            // Build a collection of all vehicles that fly

            // With a single `foreach`, have each vehicle Fly()



            // Build a collection of all vehicles that operate on roads

            // With a single `foreach`, have each road vehicle Drive()



            // Build a collection of all vehicles that operate on water
            
            // With a single `foreach`, have each water vehicle Drive()
        }

    }
}
