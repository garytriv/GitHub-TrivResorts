using System;
using System.Collections.Generic;
using System.Text;

namespace TrivResorts
{
    class Customer
    {
        private static int LastCustomerNumber = 1;
        public int CustomerNumber { get; private set; }
        public string CustomerName_First { get; set; }
        public string CustomerName_Last { get; set; }
        public DateTime CreatedDate { get; private set; }
        public string CustomerEmail { get; set; }
        public int BoughtTickets { get; set; }

        #region Constructor

        public Customer()
        {

            LastCustomerNumber = LastCustomerNumber + 1;
            CustomerNumber = LastCustomerNumber;

            CreatedDate = DateTime.UtcNow;
        }

        #endregion
    }
}
