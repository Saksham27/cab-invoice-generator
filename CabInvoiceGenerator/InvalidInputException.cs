//-----------------------------------------------------------------------
// <copyright file="InvalidInputException.cs" company="BridgeLabz Solutions LLP">
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
    /// class for invalid input exception
    /// constructor : <see cref="InvalidInputException"/>
    /// Enum : <see cref="InvoiceException"/>
    /// </summary>
    public class InvalidInputException : Exception
    {
        /// <summary>
        /// variable for invoice exception
        /// </summary>
        private readonly InvoiceException invoiceException;

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidInputException"/> class
        /// </summary>
        /// <param name="exception"> exception </param>
        /// <param name="message"> exceptionMessage </param>
        public InvalidInputException(InvoiceException exception, string message) : base(message)
        {
            this.invoiceException = exception;
        } //// end : public InvalidInputException(InvoiceException exception, string message):base(message)

        /// <summary>
        /// enumeration for invoice exception
        /// </summary>
        public enum InvoiceException
        {
            /// <summary>
            /// constant for invalid user id
            /// </summary>
            invalidUserId
        } //// end : public enum InvoiceException
    } //// end : class InvalidInputException : Exception
} //// end : namespace CabInvoiceGenerator
