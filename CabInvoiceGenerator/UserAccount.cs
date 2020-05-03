//-----------------------------------------------------------------------
// <copyright file="UserAccount.cs" company="BridgeLabz Solutions LLP">
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
    /// class containing details about a user aka user id, rides
    /// Property : <see cref="Account"/>
    /// Method : <see cref="AddRides(string, System.Collections.Generic.List{Ride})"/>
    /// </summary>
    public class UserAccount
    {
        /// <summary>
        /// Gets or sets key value map to store rides for specific user id
        /// </summary>
        public static Dictionary<string, List<Ride>> Account = new Dictionary<string, List<Ride>>();

        /// <summary>
        /// method to add rides for a user having his user id
        /// </summary>
        /// <param name="key"> user id </param>
        /// <param name="inputRides"> user's rides </param>
        public static void AddRides(string key, List<Ride> inputRides)
        {
            try
            {
                // checking if key is null
                if (key is null)
                {
                    throw new ArgumentNullException(nameof(key));
                }

                // checking if inputRides is null
                if (inputRides is null) 
                {
                    throw new ArgumentNullException(nameof(inputRides));
                }

                // checking if user already exits in account list
                // if not : adding user to account and his rides
                if (Account.ContainsKey(key))
                {
                    // adding new rides at the end of user ride list
                    foreach (Ride ride in inputRides)
                    {
                        Account[key].Add(ride);
                    }
                }               
                else
                {
                    Account.Add(key, inputRides);
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        } //// end : public static void AddRides(string key, List<Ride> inputRides)
    } //// end : public class UserAccount
} //// end : namespace CabInvoiceGenerator
