using System;
using System.Collections.Generic;
using System.Text;

namespace TrivResorts
{
    class Mmgt
    {
        #region Properties
        /// <summary>
        /// Mgmt class
        /// </summary>
        public int MgmtNumber { get; set; }
        public string MgmtName_First { get; set; }
        public string MgmtName_Last { get; set; }
        public DateTime CreatedDate { get;}
        public string MgmtEmail { get; set; }

        #endregion


        /* what mgmt can do ? [action]
          create account or login
          check number of tickets sold
          check total number of user
        */

    }
}
