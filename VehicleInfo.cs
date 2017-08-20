using System;

namespace telematics
{
    public class VehicleInfo
    {
        public int VIN {get; set;}
        public double odometer {get; set;}
        public double consumption {get; set;}
        public double odoLastOilChange {get; set;}
        public double engineLiters {get; set;}

        public override string ToString()
        {
            return $"{VIN},{odometer},{consumption},{odoLastOilChange},{engineLiters}";
        }

        public VehicleInfo()
        {

        }

        public VehicleInfo(string[] data)
        {
            VIN = int.Parse(data[0]);
            odometer = double.Parse(data[1]);
            consumption = double.Parse(data[2]);
            odoLastOilChange = double.Parse(data[3]);
            engineLiters = double.Parse(data[4]);
        }
    }
}