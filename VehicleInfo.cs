using System;

namespace telematics
{
    public class VehicleInfo
    {
        public int VIN {get; set;}
        public double Odometer {get; set;}
        public double Consumption {get; set;}
        public double OdoLastOilChange {get; set;}
        public double EngineLiters {get; set;}

        public override string ToString()
        {
            return $"VIN:{VIN}, Odometer: {Odometer}, Consumption: {Consumption},Last Oil Change Odometer Reading:{OdoLastOilChange}, Engine Size:{EngineLiters}";
        }

        public VehicleInfo()
        {

        }

        public VehicleInfo(int vin, double odometer, double consumption, double odometerLastOilChange, double engineSize)
        {
            VIN = vin;
            Odometer = odometer;
            Consumption = consumption;
            OdoLastOilChange = odometerLastOilChange;
            EngineLiters = engineSize;
        }
    }
}