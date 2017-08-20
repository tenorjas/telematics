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
    }
}