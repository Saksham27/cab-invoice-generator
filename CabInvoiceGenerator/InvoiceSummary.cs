//-----------------------------------------------------------------------
// <copyright file="InvoiceSummary.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace CabInvoiceGenerator
{
    using System;
    using System.Collections.Generic;
    using System.Dynamic;
    using System.Text;

    /// <summary>
    /// class containing invoice summary details
    /// Property : <see cref="TotalNumberOfRides"/>
    /// Property : <see cref="TotalFare"/>
    /// Property : <see cref="AverageFarePerRide"/>
    /// Method : <see cref="CalculateAvergaeFare"/>
    /// </summary>
    public class InvoiceSummary
    {
        /// <summary>
        /// Gets or sets total number of rides for the user
        /// </summary>
        public int TotalNumberOfRides { get; set; }

        /// <summary>
        /// Gets or sets total fare of all the rides
        /// </summary>
        public double TotalFare { get; set; }

        /// <summary>
        /// Gets or sets average fare per ride for user
        /// </summary>
        public double AverageFarePerRide { get; set; }

        /// <summary>
        /// method to calculate average fare
        /// </summary>
        public void CalculateAvergaeFare()
        {
            this.AverageFarePerRide = this.TotalFare / this.TotalNumberOfRides;
        } //// end : public void CalculateAvergaeFare()
    } //// end : public class InvoiceSummary
} //// end : namespace CabInvoiceGenerator
