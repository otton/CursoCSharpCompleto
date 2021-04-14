using System;
using TratamentoExcecoes_Exercicio.Entities.ApplicationException;

namespace TratamentoExcecoes_Exercicio.Entities
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            if (checkOut <= checkIn)
            {
                throw new ReservationException("Check-out date must be after check-in date");
            }
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan timeSpan = CheckOut.Subtract(CheckIn);
            return (int)timeSpan.TotalDays;
        }

        
        public void UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;
            if (checkIn < now || checkOut < now)
            {
                throw new ReservationException("Reservation dates for update must be future dates");
            }
            if (checkOut <= checkIn)
            {
                throw new ReservationException("Check-out date must be after check-in date");
            }
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public override string ToString()
        {
            return "Room " + RoomNumber
                + ", check-in: " + CheckIn.ToString("dd/MM/yyyy")
                + ", check-out: " + CheckOut.ToString("dd/MM/yyyy")
                + ", " + Duration() + " nights";
        }
    }
}