using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class Ride
    {
        public double distance;
        public int time;

        public Ride(double inputDistance, int inputTime)
        {
            distance = inputDistance;
            time = inputTime;
        }
    }
}
