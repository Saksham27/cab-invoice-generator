using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceGenerator
    {
        private static readonly int costPerTime = 1;
        private static readonly double minimumCostPerKilometer = 10;
        private static readonly double minimumFare = 5;

        public double CalculateFare(double distance, int time)
        {
            double totalFare = distance * minimumCostPerKilometer + time * costPerTime;
            if (totalFare < minimumFare)
            {
                return minimumFare;
            }
            return totalFare;
        }

        public InvoiceSummary CalculateFare(Ride[] rides)
        {
            double totalFare = 0;
            int numberOfRides = 0;
            double averageFare = 0;
            InvoiceSummary invoiceSummary = new InvoiceSummary();
            foreach (Ride ride in rides)
            {
                totalFare += this.CalculateFare(ride.distance, ride.time);
                numberOfRides++;
            }
            invoiceSummary.TotalNumberOfRides = numberOfRides;
            invoiceSummary.TotalFare = totalFare;
            invoiceSummary.CalculateAvergaeFare();
            return invoiceSummary;
        }
    }
}
