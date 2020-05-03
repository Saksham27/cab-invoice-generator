//-----------------------------------------------------------------------
// <copyright file="Ride.cs" company="BridgeLabz Solutions LLP">
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
    /// class containing ride details like distance, time and type of ride 
    /// constructor : <see cref="Ride.Ride(double, int, string)"/>
    /// Property : <see cref="Distance"/>
    /// Property : <see cref="Time"/>
    /// Property : <see cref="RideType"/>
    /// </summary>
    public class Ride
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Ride"/> class
        /// </summary>
        /// <param name="inputDistance"> distance travelled during one ride </param>
        /// <param name="inputTime"> time duration of ride </param>
        /// <param name="inputRideType"> ride type </param>
        public Ride(double inputDistance, int inputTime, string inputRideType = "normal")
        {
            this.Distance = inputDistance;
            this.Time = inputTime;
            this.RideType = inputRideType;
        } //// end : public Ride(double inputDistance, int inputTime, string inputRideType = "normal")

        /// <summary>
        /// Gets or sets variable for distance travelled during one ride
        /// </summary>
        public double Distance { get; set; }

        /// <summary>
        /// Gets or sets variable for time duration of ride
        /// </summary>
        public int Time { get; set; }

        /// <summary>
        /// Gets or sets variable for ride type : normal or premium
        /// </summary>
        public string RideType { get; set; }
    } //// end :  public class Ride
} //// end : namespace CabInvoiceGenerator
