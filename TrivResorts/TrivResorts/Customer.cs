using System;
using System.Collections.Generic;
using System.Text;

namespace TrivResorts
{
    class Customer
    {
        /// <summary>
        /// Customer class 
        /// </summary>
        public int CustomerNumber { get; set; }
        public int BoughtTickets { get; set; }
        public int TotalTickets { get; set; }
        public string CustomerName_First { get; set; }
        public string CustomerName_Last { get; set; }
        public DateTime CreatedDate { get; }
        public string CustomerEmail { get; set; }

        /* what customer can do ? [action]
           create account or login
           buy tickets
           write feedback
        */
        #region Methods

        public int BUY(int BoughtTickets)
        {
            BoughtTickets = TotalTickets - BoughtTickets;
            return BoughtTickets;
           
        }

        #endregion
    }
}
