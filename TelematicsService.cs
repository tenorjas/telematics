using System;
using System.Collections.Generic;
using System.IO;

namespace telematics
{
    public class TelematicsService
    {
        void Report(VehicleInfo vehicleInfo)
        {
            // declare variables for readability
            int VIN = vehicleInfo.VIN;
            double odo = vehicleInfo.odometer;
            double consumption = vehicleInfo.consumption;
            double lastOilChange = vehicleInfo.odoLastOilChange;
            double liters = vehicleInfo.engineLiters;

            // open file for writing
            using (var writer = new StreamWriter(File.Open($"{VIN}.json",FileMode.OpenOrCreate)))
            {
                // write one vehicle's telematics data to a file
                writer.WriteLine($"{odo},{consumption},{lastOilChange},{liters}");
            }

            // variable for reading from a file
            var vehiclesFromFiles = new List<VehicleInfo>();

            // open all json files for reading
            using (var reader = new StreamReader(File.Open("*.json",FileMode.OpenOrCreate)))
            {
                
            }
        }
    }
}