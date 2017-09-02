using System;
using System.Collections.Generic;
using System.IO;

namespace telematics
{
    class Program
    {
        static void Main(string[] args)
        {
            // GET INPUT
            Console.WriteLine("What is the VIN?:");
            var vinInput = int.Parse(Console.ReadLine());

            Console.WriteLine("What is the odometer reading?:");
            var odometerInput = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the consumption rate?:");
            var consumptionInput = double.Parse(Console.ReadLine());

            Console.WriteLine("What was the odometer reading the last time the oil was changed?:");
            var odometerLastOilChangeInput = double.Parse(Console.ReadLine());

            Console.WriteLine("What is the engine size?:");
            var engineSizeInput = double.Parse(Console.ReadLine());

            var newVehicle = new VehicleInfo(vinInput,odometerInput,consumptionInput,odometerLastOilChangeInput,engineSizeInput);

            new TelematicsService().Report(newVehicle);
            new TelematicsService().ReadFiles(newVehicle);

        }
    }
}
