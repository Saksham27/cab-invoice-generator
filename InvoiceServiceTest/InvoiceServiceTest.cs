//-----------------------------------------------------------------------
// <copyright file="InvoiceServiceTest.cs" company="BridgeLabz Solutions LLP">
//     Copyright (c) Company. All rights reserved.
// </copyright>
// <author> Saksham Singh </author>
//-----------------------------------------------------------------------
namespace InvoiceServiceTest
{
    using System.Collections.Generic;
    using CabInvoiceGenerator;
    using NUnit.Framework;

    /// <summary>
    /// class containing all the unit tests for the namespace <see cref="CabInvoiceGenerator"/>
    /// Test : <see cref="GivenDistanceAndTime_ShouldReturnTotalFare"/>
    /// Test : <see cref="GivenLessDistanceAndTime_ShouldReturnMinFare"/>
    /// Test : <see cref="GivenMultipleRides_ShouldReturnTotalFare"/>
    /// Test : <see cref="GivenUSerId_ShouldReturnInvoiceSummary"/>
    /// Test : <see cref="GivenPremiumRide_ShouldReturnInvoiceSummary"/>
    /// </summary>
    public class InvoiceServiceTest
    {
        /// <summary>
        /// instance of Invoice Service <see cref="InvoiceService"/> class
        /// </summary>
        private readonly InvoiceService invoiceGenerator = new InvoiceService();

        /// <summary>
        /// Test Case : given distance and time, <see cref="InvoiceService.CalculateFare(double, int, string)"/> should return the fare for ride
        /// </summary>
        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            // variable for ride distance 
            double distance = 2.0;

            // variable for ride time
            int time = 5;

            // Actual : calling CalculateFare method by passing distance and time of ride and storing the outcome in fare variable
            double fare = this.invoiceGenerator.CalculateFare(distance, time);

            // Expected : total expected fare of ride
            double expected = 25;
            Assert.AreEqual(expected, fare);
        } //// end : public void GivenDistanceAndTime_ShouldReturnTotalFare()

        /// <summary>
        /// Test Case : given less distance and time, <see cref="InvoiceService.CalculateFare(double, int, string)"/> should return the minimum fare for ride
        /// </summary>
        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinFare()
        {
            // variable for ride distance
            double distance = 0.1;

            // variable for ride time
            int time = 1;

            // Actual : calling CalculateFare method by passing distance and time of ride and storing the outcome in fare variable
            double fare = this.invoiceGenerator.CalculateFare(distance, time);

            // Expected : total expected fare of ride
            double expected = 5;
            Assert.AreEqual(expected, fare);
        } //// end : public void GivenLessDistanceAndTime_ShouldReturnMinFare()

        /// <summary>
        /// Test Case : given multiple rides the <see cref="InvoiceService.GetInvoiceSummary(string)"/> method should return total expected fare 
        /// </summary>
        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            // creating a user id
            string userId = "Saksham";

            // creating Ride instances for a ride
            Ride firstRide = new Ride(2.0, 5);
            Ride secondRide = new Ride(0.1, 1);

            // creating list of rides using ride instances
            List<Ride> rides = new List<Ride> { firstRide, secondRide };

            // adding user and his rides to his account
            UserAccount.AddRides(userId, rides);

            // Actual : calling GetInvoiceSummary method by passing user id and storing the outcome in totalFare
            double totalFare = this.invoiceGenerator.GetInvoiceSummary(userId).TotalFare;

            // Expected : total expected fare of ride
            double expected = 30;
            Assert.AreEqual(expected, totalFare);
        } //// end : public void GivenMultipleRides_ShouldReturnTotalFare()

        /// <summary>
        /// Test Case : given user id,<see cref="InvoiceService.GetInvoiceSummary(string)"/> method should return expected invoice summary
        /// </summary>
        [Test]
        public void GivenUSerId_ShouldReturnInvoiceSummary()
        {
            // creating a user id
            string userId = "John";

            // creating Ride instances for a ride
            Ride firstRide = new Ride(3.0, 5);
            Ride secondRide = new Ride(1, 1);

            // creating list of rides using ride instances
            List<Ride> rides = new List<Ride> { firstRide, secondRide };

            // adding user and his rides to his account
            UserAccount.AddRides(userId, rides);

            // Actual : calling GetInvoiceSummary method by passing user id and storing the outcome in invoiceSummary
            InvoiceSummary invoiceSummary = this.invoiceGenerator.GetInvoiceSummary(userId);

            // Expected : expected Invoice summary
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 46,
                AverageFarePerRide = 23
            };
            Assert.AreEqual(expected.TotalFare, invoiceSummary.TotalFare);
        } //// end : public void GivenUSerId_ShouldReturnInvoiceSummary()

        /// <summary>
        /// Test Case : given premium ride, <see cref="InvoiceService.GetInvoiceSummary(string)"/> should return expected invoice summary
        /// </summary>
        [Test]
        public void GivenPremiumRide_ShouldReturnInvoiceSummary()
        {
            // creating a user id
            string userId = "Monika";

            // creating Ride instances for a ride
            Ride firstRide = new Ride(3.0, 5, "Premium");
            Ride secondRide = new Ride(1, 1, "Normal");

            // creating list of rides using ride instances
            List<Ride> rides = new List<Ride> { firstRide, secondRide };

            // adding user and his rides to his account
            UserAccount.AddRides(userId, rides);

            // Actual : calling GetInvoiceSummary method by passing user id and storing the outcome in invoiceSummary
            InvoiceSummary invoiceSummary = this.invoiceGenerator.GetInvoiceSummary(userId);

            // Expected : expected Invoice summary
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 66,
                AverageFarePerRide = 33
            };
            Assert.AreEqual(expected.TotalFare, invoiceSummary.TotalFare);
        } //// end : public void GivenPremiumRide_ShouldReturnInvoiceSummary()
    } //// end : public class Tests
} //// end : namespace InvoiceServiceTest