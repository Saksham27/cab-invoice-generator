using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceGenerator
{
    class InvalidInputException : Exception
    {

        public enum InvoiceException
        {
            invalidUserId
        }

        private readonly InvoiceException invoiceException;

        public InvalidInputException(InvoiceException exception, string message):base(message)
        {
            this.invoiceException = exception;
        }
    }
}
