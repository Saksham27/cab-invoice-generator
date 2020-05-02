using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class InvoiceService
    { 
        public double CalculateFare(double distance, int time, string type = "normal")
        {
            RideType rideType = new RideType(type);
            double totalFare = distance * rideType.minimumCostPerKilometer + time * rideType.costPerTime;
            if (totalFare < rideType.minimumFare)
            {
                return rideType.minimumFare;
            }
            return totalFare;
        }

        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            if (userId is null)
            {
                throw new ArgumentNullException(nameof(userId));
            }

            if (UserAccount.account.ContainsKey(userId))
            {
                double totalFare = 0;
                int numberOfRides = 0;
                InvoiceSummary invoiceSummary = new InvoiceSummary();
                foreach (Ride ride in UserAccount.account[userId])
                {
                    totalFare += this.CalculateFare(ride.distance, ride.time, ride.rideType);
                    numberOfRides++;
                }
                invoiceSummary.TotalNumberOfRides = numberOfRides;
                invoiceSummary.TotalFare = totalFare;
                invoiceSummary.CalculateAvergaeFare();
                return invoiceSummary;
            }
            else
            {
                throw new InvalidInputException(InvalidInputException.InvoiceException.invalidUserId, "Wrong user Id");
            }
            
        }
    }
}
