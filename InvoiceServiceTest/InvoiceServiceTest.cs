using NUnit.Framework;
using CabInvoiceGenerator;
using System.Collections.Generic;

namespace InvoiceServiceTest
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void GivenDistanceAndTime_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 2.0;
            int time = 5;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            Assert.AreEqual(expected, fare);
        }

        [Test]
        public void GivenLessDistanceAndTime_ShouldReturnMinFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            double distance = 0.1;
            int time = 1;
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 5;
            Assert.AreEqual(expected, fare);
        }

        [Test]
        public void GivenMultipleRides_ShouldReturnTotalFare()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();
            string userId = "Saksham";
            Ride firstRide = new Ride(2.0, 5);
            Ride secondRide = new Ride(0.1, 1);
            List<Ride> rides = new List<Ride>{ firstRide, secondRide };
            UserAccount.AddRides(userId, rides);
            InvoiceSummary invoiceSummary =  invoiceGenerator.CalculateFare(userId);
            double expected = 30;
            Assert.AreEqual(expected, invoiceSummary.TotalFare);
        }

        [Test]
        public void GivenMultipleRides_ShouldReturnInvoiceSummary()
        {
            InvoiceGenerator invoiceGenerator = new InvoiceGenerator();

            string userId = "John";
            Ride firstRide = new Ride(3.0, 5);
            Ride secondRide = new Ride(1, 1);
            List<Ride> rides = new List<Ride> { firstRide, secondRide };
            UserAccount.AddRides(userId, rides);
            InvoiceSummary invoiceSummary = invoiceGenerator.CalculateFare(userId);
            InvoiceSummary expected = new InvoiceSummary
            {
                TotalNumberOfRides = 2,
                TotalFare = 46,
                AverageFarePerRide = 23
            };
            object.Equals(expected, invoiceSummary);
        }
    }
}