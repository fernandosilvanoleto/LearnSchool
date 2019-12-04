using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearnSchool.EntitiesErrors
{
    class Reservation
    {
        public int RoomNumber { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }

        public Reservation()
        { }

        public  Reservation(int roomNumber, DateTime checkIn, DateTime checkOut)
        {
            RoomNumber = roomNumber;
            CheckIn = checkIn;
            CheckOut = checkOut;
        }

        public int Duration()
        {
            TimeSpan duration = CheckOut.Subtract(CheckIn);
            return (int)duration.TotalDays;
        }

        public string UpdateDates(DateTime checkIn, DateTime checkOut)
        {
            DateTime now = DateTime.Now;

            if (checkIn < now || checkOut < now)
            {
                return "Erro na hora de reservar!!! As datas devem ser futuras!!! Verifique novamente!!!";
            }
            else if (checkOut <= checkIn)
            {
                return "Data Check-In menor que Check-Out!!! Inválidos os dados inseridos!!!";
            }
            else
            {
                CheckIn = checkIn;
                CheckOut = checkOut;
                return null;
            }
          
        }

        public override string ToString()
        {
            return "Room "
                    + RoomNumber
                    + ", check-in: "
                    + CheckIn.ToString("dd/MM/yyyy")
                    + ", check-out: "
                    + CheckOut.ToString("dd/MM/yyyy")
                    + ", "
                    + Duration()
                    + " nights!!!";
        }
    }
}
