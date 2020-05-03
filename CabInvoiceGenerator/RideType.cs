//-----------------------------------------------------------------------
// <copyright file="RideType.cs" company="BridgeLabz Solutions LLP">
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
    /// class containing types of rides available for user
    /// constructor : <see cref="RideType.RideType(string)"/>
    /// Property : <see cref="RideType.NormalRide"/>
    /// Property : <see cref="RideType.PremiumRide"/>
    /// Property : <see cref="RideType.CostPerTime"/>
    /// Property : <see cref="RideType.MinimumCostPerKilometer"/>
    /// Property : <see cref="RideType.MinimumFare"/>
    /// </summary>
    public class RideType
    {
        /// <summary>
        /// string variables for normal ride type
        /// </summary>
        public static readonly string NormalRide = "normal";

        /// <summary>
        /// string variables for premium ride type
        /// </summary>
        public static readonly string PremiumRide = "premium";

        /// <summary>
        /// Initializes a new instance of the <see cref="RideType"/> class
        /// method to set cost per time and cost per kilometer according to ride type
        /// </summary>
        /// <param name="rideType"> ride type </param>
        public RideType(string rideType)
        {
            // checking if ride is premium ride then setting ride properties for premium
            // if not : setting ride properties for normal
            if (rideType.ToLower() == PremiumRide)
            {
                this.CostPerTime = 2;
                this.MinimumCostPerKilometer = 15;
                this.MinimumFare = 20;
            }
            else
            {
                this.CostPerTime = 1;
                this.MinimumCostPerKilometer = 10;
                this.MinimumFare = 5;
            }
        } //// end : public RideType(string rideType)

        /// <summary>
        /// Gets or sets variable for cost per time for ride
        /// </summary>
        public int CostPerTime { get; set; }

        /// <summary>
        /// Gets or sets variable for cost per kilometer
        /// </summary>
        public double MinimumCostPerKilometer { get; set; }

        /// <summary>
        /// Gets or sets variable for minimum fare
        /// </summary>
        public double MinimumFare { get; set; }
    } //// end  : class RideType
} //// end  : namespace CabInvoiceGenerator
