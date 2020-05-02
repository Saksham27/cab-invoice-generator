using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;
        public string rideType;

        public Ride(double inputDistance, int inputTime, string inputRideType = "normal")
        {
            distance = inputDistance;
            time = inputTime;
            rideType = inputRideType;
        }
    }
}
