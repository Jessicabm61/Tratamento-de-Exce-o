using System;
using Exercício18.Entitites;
using Exercício18.Entitites.Exception;

namespace Exercício18
{
    class Program
    {
        static void Main(string[] args)
        {
            try { 
            Console.Write("Room number:");
            int roomNumber = int.Parse(Console.ReadLine());
            Console.Write("Check-in date (dd/MM/yyyy):");
            DateTime checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy):");
            DateTime checkout = DateTime.Parse(Console.ReadLine());

            Resevation Res = new Resevation(roomNumber, checkin, checkout);

            Console.WriteLine("Reservation: " + Res); //Imprime o ToString do objeto

            Console.Write("Enter data to update the reservation: ");
            Console.Write("Check-in date (dd/MM/yyyy):");
            checkin = DateTime.Parse(Console.ReadLine());
            Console.Write("Check-out date (dd/MM/yyyy):");
            checkout = DateTime.Parse(Console.ReadLine());

            Res.UpdateDates(checkin, checkout); //Atualiza reserva
            Console.WriteLine("Reservation: " + Res); //Imprime o ToString do objeto
            }
            catch (DomainException e) //Captura a exceção 
            {
                Console.WriteLine("Error in reservation: " + e.Message); //Imprime a mensagem da exceção criada
            }
            catch (FormatException e)
            {
                Console.WriteLine("Error: " + e.Message); //Imprime a mensagem da exceção do sistema
            }
            catch (Exception e)
            {
                Console.WriteLine("Unexpected error! " + e.Message); //Exceção mais genérica por upcasting, vai coletar qualquer outra exceção
            }
        }
    }
}
