using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace telematics
{
    public class TelematicsService
    {
        void Report(VehicleInfo vehicleInfo)
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

        public void GenerateHTMLReport(VehicleInfo vehicleInfo)
        {
            string[] files = System.IO.Directory.GetFiles("/Users/tenorjas/projects/tiy/week_8/telematics","*.json");
            // LIST CREATION GOES HERE
            
        }
    }
}