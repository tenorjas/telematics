using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace telematics
{
    public class TelematicsService
    {
        public void Report(VehicleInfo vehicleInfo)
        {
            // declare variable for readability
            int VIN = vehicleInfo.VIN;

            // open file for writing
            using (var writer = new StreamWriter(File.Open($"{VIN}.json",FileMode.OpenOrCreate)))
            {
                // write one vehicle's telematics data to a file
                writer.WriteLine(JsonConvert.SerializeObject(vehicleInfo));
            }
        }

        public void ReadFiles(VehicleInfo vehicleInfo)
        {
            string[] files = System.IO.Directory.GetFiles("/Users/theironyard/tenorjas/telematics/telematics","*.json");
            // LIST CREATION GOES HERE
            List<object> vehicleList = new List<object>();
            foreach (var item in files)
            {
                using (StreamReader file = File.OpenText(item))
                {
                    var vehicleInfo2 = JsonConvert.DeserializeObject<VehicleInfo>(file.ReadToEnd());
                    vehicleList.Add(vehicleInfo2);
                    Console.WriteLine($"VIN: {vehicleInfo2.VIN}");
                    Console.WriteLine($" Current odometer reading: {vehicleInfo2.Odometer} miles");
                    Console.WriteLine($"Consumption rate: {vehicleInfo2.Consumption} mpg");
                    Console.WriteLine($"Odometer reading at last oil change: {vehicleInfo2.OdometerLastOilChange} miles");
                    Console.WriteLine($"Engine size: {vehicleInfo2.EngineSize} liters");
                    Console.WriteLine("\n");
                }
            }
        }
    }
}