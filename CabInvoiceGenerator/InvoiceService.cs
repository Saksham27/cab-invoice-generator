//-----------------------------------------------------------------------
// <copyright file="InvoiceService.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace CabInvoiceGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    /// <summary>
    /// class containing methods for calculating ride fare and invoice summary
    /// Method : <see cref="CalculateFare(double, int, string)"/>
    /// Method : <see cref="GetInvoiceSummary(string)"/>
    /// </summary>
    public class InvoiceService
    { 
        /// <summary>
        /// method to calculate fare for a provided ride details
        /// </summary>
        /// <param name="distance"> distance travelled in ride </param>
        /// <param name="time"> time duration of ride </param>
        /// <param name="type"> type of ride , normal if not provided </param>
        /// <returns> calculated fare </returns>
        public double CalculateFare(double distance, int time, string type = "normal")
        {
            // creating instance of RideType 
            RideType rideType = new RideType(type);

            // calculating total fare for ride
            double totalFare = (distance * rideType.MinimumCostPerKilometer) + (time * rideType.CostPerTime);

            // checking if totalFare is less than MinimumFare
            if (totalFare < rideType.MinimumFare)
            {
                return rideType.MinimumFare;
            }

            return totalFare;
        } //// end : public double CalculateFare(double distance, int time, string type = "normal")

        /// <summary>
        /// method to generate invoice summary
        /// </summary>
        /// <param name="userId"> user id </param>
        /// <returns> invoice summary </returns>
        public InvoiceSummary GetInvoiceSummary(string userId)
        {
            try
            {
                // checking if user id is null
                if (userId is null)
                {
                    throw new ArgumentNullException(nameof(userId));
                }

                // checking if user id exists in user account
                // if not : throw exception wrong user id
                if (UserAccount.Account.ContainsKey(userId))
                {
                    double totalFare = 0;
                    int numberOfRides = 0;
                    InvoiceSummary invoiceSummary = new InvoiceSummary();

                    // calculating total fare by traversing through all user rides for given user id
                    foreach (Ride ride in UserAccount.Account[userId])
                    {
                        totalFare += this.CalculateFare(ride.Distance, ride.Time, ride.RideType);
                        numberOfRides++;
                    }

                    // setting invoice summary details from the obtained result
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
            catch (ArgumentNullException exception)
            {
                throw new ArgumentNullException(exception.Message);
            }
            catch (InvalidInputException exception)
            {
                throw new InvalidInputException(InvalidInputException.InvoiceException.invalidUserId, exception.Message);
            }
            catch (Exception exception)
            {
                throw new Exception(exception.Message);
            }
        } //// end : public InvoiceSummary GetInvoiceSummary(string userId)
    } //// end : public class InvoiceService
} //// end : namespace CabInvoiceGenerator
