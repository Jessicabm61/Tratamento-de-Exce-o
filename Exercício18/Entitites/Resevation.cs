using System;
using Exercício18.Entitites.Exception;

namespace Exercício18.Entitites
{
    class Resevation
    {
        public int RoomNumber { get; set; }
        public DateTime Checkin { get; set; }
        public DateTime Checkout { get; set; }

        public Resevation()
        {
        }

        public Resevation(int roomNumber, DateTime checkin, DateTime checkout)
        {

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after ");  // E exceção pode ser lançada no construtor
            }
            RoomNumber = roomNumber;
            Checkin = checkin;
            Checkout = checkout;
        }

        public int Duration() {
            TimeSpan duration = Checkout.Subtract(Checkin); //Diferença entre duas datas e armazena em uma variável do tipo Timespan ("Tikts")
            return (int)duration.TotalDays; //converte a variável do tipo Timespan para dias, como essa função retorna um double foi utilizado um casting 
        }

        public void UpdateDates(DateTime checkin, DateTime checkout)
        {
            DateTime now = DateTime.Now;
            if (checkin < now || checkout < now)
            {
                throw new DomainException("Reservation dates for update must"); //Lança a exceção
            }

            if (checkout <= checkin)
            {
                throw new DomainException("Check-out date must be after ");  //Lança a exceção
            }
            Checkin = checkin;
            Checkout = checkout;
        }

        public override string ToString()
        {
            return "Room "
                + RoomNumber
                + ", check-in: "
                + Checkin.ToString("dd/MM/yyyy")
                + ", check-out: "
                + Checkout.ToString("dd/MM/yyyy")
                + ", "
                + Duration()
                + "nights";
        }
    }
}
