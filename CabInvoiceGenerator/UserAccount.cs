using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    public class UserAccount
    {
        public static Dictionary<string, List<Ride>> account = new Dictionary<string, List<Ride>>();

        public static void AddRides(string key, List<Ride> inputRides)
        {
            try
            {
                if (key is null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                if (inputRides is null)
                {
                    throw new ArgumentNullException(nameof(inputRides));
                }
                if (account.ContainsKey(key))
                {
                    foreach (Ride ride in inputRides)
                    {
                        account[key].Add(ride);
                    }
                }
                else
                {
                    account.Add(key, inputRides);
                }
            }
            catch(Exception exception)
            {
                Console.WriteLine(exception.Message);
            }

           
        }

    }
}
