using AssignmentOOP01.Classes;
using AssignmentOOP01.Enums;
using AssignmentOOP01.Struct;
using System.Net.Sockets;

namespace AssignmentOOP01
{

    #region Part01
    #region Q1

    //class Student
    //{
    //    public int Id;
    //    public int age;
    //    // Can use Inheritance

    //}

    //struct Color
    //{
    //    // Cant use inheritance
    //    public string Name;
    //}

    #endregion

    #region Q2
    //class Person
    //{
    //    public int Id; // i can access from any file or project 
    //    private string? passowrd; // cant access outside this scope only
    //}
    #endregion

    #region Q3
    /* 1-Create a Class Library Project
     * 2-Add a Class Inside the Library
     * 3-Build the Library
     * 4-Reference the Class Library in Another Project
     * 5-Use the Library
     
     */

    #endregion

    #region Q4
    /*
        Class Library is project contain reusable code to use in another projects to prevent code repeat
     */
    #endregion
    #endregion


    internal class Program
    {
        static void Main(string[] args)
        {

            //// Class
            //Student s1 = new Student();
            //Student s2 = new Student();

            //s1.age = 24;
            //s2 = s1;

            //Console.WriteLine(s2.age);

            //// Same age because theyre poinitng to same object in heap
            //// I have to make object to work with class


            //// Struct
            //Color C1;
            //C1.Name = "Green";
            //Color C2;
            //C2 = C1;
            //C2.Name = "Red";
            //Console.WriteLine(C1.Name);
            //// Still Green because it only copies data not the object


            #region Part 2

            

            //Console.WriteLine("Enter Movie Name: ");
            //string? movieName = Console.ReadLine();
            //Console.WriteLine("Enter Ticket Type(0 = Standard, 1 = VIP, 2= IMAX)");
            //TicketsType ticketType = Enum.Parse<TicketsType>(Console.ReadLine());
            //Console.WriteLine("Enter Seat Row(A,B,C....)");
            //char seat = char.Parse(Console.ReadLine());
            //Console.WriteLine("enter seat number");
            //int seatNumber = int.Parse(Console.ReadLine());
            //Seats seat1 = new Seats(seat,seatNumber);
            //Console.WriteLine("Enter Price");
            //double price = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Discount amount");
            //double discountAmount = double.Parse(Console.ReadLine());

            //Ticket T1 = new Ticket(movieName,price, ticketType,seat1);


            //Console.WriteLine("\n===== Ticket Info =====");
            //T1.PrintTicket();

            //Console.WriteLine("\n===== After Discount =====");
            //Console.WriteLine($"Discount Before : {discountAmount}");

            //discountAmount = T1.ApplyDiscount(discountAmount);
            //Console.WriteLine($"Discount After  : {discountAmount}");
            //T1.PrintTicket();
            #endregion

        }
    }
}
