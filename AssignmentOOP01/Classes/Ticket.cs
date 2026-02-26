using AssignmentOOP01.Enums;
using AssignmentOOP01.Struct;
using System;
using System.Collections.Generic;
using System.Text;

namespace AssignmentOOP01.Classes
{
    internal class Ticket
    {
        public string MovieName;
        private double Price;
        public TicketsType TicketsT;
        public Seats Seat;
        private const double TaxPercent = 14;

        public Ticket(string _MovieName, double _Price, TicketsType _TicketT, Seats _Seat)
        {
            MovieName = _MovieName;
            Price = _Price;
            TicketsT = _TicketT;
            Seat = _Seat;
        }

        public Ticket(string _MovieName):this(_MovieName,50,TicketsType.Standard, new Seats('A',1))
        {
            
        }


        public double CalcTotal(double TaxPercent)
        {
            double taxAmount = Price * (TaxPercent / 100);
            return Price + taxAmount;
        }

        public double ApplyDiscount(double discountAmount)
        {
            if (discountAmount>0 && discountAmount<= Price)
            {
                Price = Price - discountAmount;
                return 0;
            }
            return discountAmount;
        }

        public void PrintTicket()
        {
            Console.WriteLine($"Movie Name : {MovieName}");
            Console.WriteLine($"Type : {TicketsT}");
            Console.WriteLine($"Seat : {Seat}");
            Console.WriteLine($"Price : {Price}");
            Console.WriteLine($"Total ({TaxPercent}% tax) : {CalcTotal(TaxPercent)}");


        }
    }
}
