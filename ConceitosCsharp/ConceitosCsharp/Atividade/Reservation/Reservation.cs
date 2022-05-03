using ConceitosCsharp.Atividade.Reservation.Execptions;
using System;

namespace ConceitosCsharp.Atividade.Reservation
{
    public class Reservation
    {
        public Reservation(int roomNumber, DateTime checkin, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            Checkin = checkin;
            CheckOut = checkOut;
        }
        public Reservation(){  }

        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime CheckOut { get; set; }


        public int Duration()
        {
            //calcula a diferença das datas
            TimeSpan duration = CheckOut.Subtract(Checkin);
            return (int)duration.TotalDays;
        }

        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            if(checkIn < DateTime.Now || checkOut < DateTime.Now)
            {
                throw new DomainException ("Reservation dates for update must be future dates");
            }
            if(checkIn <= checkOut)
            {
                throw new DomainException("Check-out date must be after checkout");
            }
            Checkin = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room"
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + CheckOut.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + " nights";
        }
    }
}
