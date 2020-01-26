using System;
using System.Collections.Generic;
using System.Text;

namespace TrivResorts
{

    enum TypeOfTickets
    {
        WaterPark,
        Dinner,
        Movie,
        ThemePark
    }

    class Tickets
    {
      
        public static int TotalTickets = 100;
        public int BoughtTickets { get; set; }
        public int RemaningTickets { get; set; }

        public int BUY(int BoughtTickets)
        {

            RemaningTickets = TotalTickets - BoughtTickets;
            TotalTickets = RemaningTickets;
            return TotalTickets;

        }



    }
}
