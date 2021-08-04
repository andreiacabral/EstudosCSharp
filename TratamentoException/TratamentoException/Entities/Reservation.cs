using System;
using System.Collections.Generic;
using System.Text;

namespace TratamentoException.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime  ChecKIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        {

        }

        public Reservation(int roomNumber, DateTime checKIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            ChecKIn = checKIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(ChecKIn);
            return (int)duration.TotalDays;
            

        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
        }


    }
}
