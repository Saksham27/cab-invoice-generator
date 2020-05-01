﻿using System;
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
    }
}
