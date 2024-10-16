using System;
using System.Reflection.Metadata.Ecma335;

namespace labtask
{

    public class Customer
    {
        public int customerId { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zipCode { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
    }

    public class RetailCustomer : Customer
    {
        public string creditCardType { get; set; }
        public string creditCardNo { get; set; }
    }

    public class CorporateCustomer : Customer
    {
        public string companyName { get; set; }
        public int frequentFlyerPts { get; set; }
        public string billingAccountNo { get; set; }
    }

    public class Reservation
    {
        public int reservationNo { get; set; }
        public DateTime date { get; set; }
        public int customerId { get; set; } 
        public Seat seat1 { get; set; }
        public Seat seat2 { get; set; }
    }

    public class Seat
    {
        public int rowNo { get; set; }
        public int seatNo { get; set; }
        public decimal price { get; set; }
        public string status { get; set; } 
    }

    public class Flight
    {
        public int flightId { get; set; }
        public DateTime date { get; set; }
        public string origin { get; set; }
        public string destination { get; set; }
        public DateTime departureTime { get; set; }
        public DateTime arrivalTime { get; set; }
        public int seatingCapacity { get; set; }
        public Reservation reservation1 { get; set; }
        public Reservation reservation2 { get; set; } 
    }

    class Program
    {
        static void Main(string[] args)
        {
            
            RetailCustomer customer = new RetailCustomer();
          
            customer.customerId = 1;
            customer.lastName = "Ali";
            customer.firstName = "Akbar";
            customer.creditCardType = "Visa";
            customer.creditCardNo = "36303-9678785-6";
            customer.street = "No-05";
            customer.city = "Multan";
            customer.zipCode = "59510";
            customer.phone = "03082345678";
            customer.email = "hellog123@gmail.com";


            Reservation reservation = new Reservation();

            reservation.reservationNo = 1;
            reservation.date = DateTime.Now;
            reservation.customerId = customer.customerId;
            reservation.seat1 = new Seat { rowNo = 5, seatNo = 1, price = 15000, status = "Available" };
            reservation.seat2 = new Seat { rowNo = 5, seatNo = 2, price = 15000, status = "Available" };

            CorporateCustomer corporateCustomer = new CorporateCustomer();
            corporateCustomer.companyName = "Acme Corporation";
            corporateCustomer.frequentFlyerPts = 10000;
            corporateCustomer.billingAccountNo = "1234567890";


            Flight flight = new Flight();

                flight.flightId = 1;
                flight.date = DateTime.Now;
                flight.origin = "Lahore";
                flight.destination = "Karachi";
                flight.departureTime =DateTime.Now;
                flight.arrivalTime = DateTime.Now;
                flight.seatingCapacity = 100;
                flight.reservation1 = reservation;



            Console.WriteLine("***Customer Information***");
            Console.WriteLine("ID: " + customer.customerId);
            Console.WriteLine("Name: " + customer.firstName + " " + customer.lastName);
            Console.WriteLine("Credit Card Type: " + customer.creditCardType);
            Console.WriteLine("Credit Card Number: " + customer.creditCardNo);
            Console.WriteLine("Street: " + customer.street);
            Console.WriteLine("City: " + customer.city);
            Console.WriteLine("ZipCode: " + customer.zipCode);
            Console.WriteLine("Phone Number: " + customer.phone);
            Console.WriteLine("Email ID: " + customer.email);
            Console.WriteLine();


            Console.WriteLine("***Reservation Information***");
            Console.WriteLine("Reservation Number: " + reservation.reservationNo);
            Console.WriteLine("Date: " + reservation.date.ToString("yyyy-MM-dd"));
            Console.WriteLine("Customer ID: " + reservation.customerId);
            Console.WriteLine("Seat 1: Row " + reservation.seat1.rowNo + ", Seat " + reservation.seat1.seatNo + ", Price: " + reservation.seat1.price);
            Console.WriteLine("Seat 2: Row " + reservation.seat2.rowNo + ", Seat " + reservation.seat2.seatNo + ", Price: " + reservation.seat2.price);
            Console.WriteLine();

            Console.WriteLine("Company Name: " + corporateCustomer.companyName);
            Console.WriteLine("Frequent Flyer Points: " + corporateCustomer.frequentFlyerPts);
            Console.WriteLine("Billing Account Number: " + corporateCustomer.billingAccountNo);


            Console.WriteLine("***Flight Information***");
            Console.WriteLine("Flight ID: " + flight.flightId);
            Console.WriteLine("Date: " + flight.date.ToString("yyyy-MM-dd"));
            Console.WriteLine("Origin: " + flight.origin);
            Console.WriteLine("Destination: " + flight.destination);
            Console.WriteLine("Departure Time: " + flight.departureTime.ToString("HH:mm:ss"));
            Console.WriteLine("Arrival Time: " + flight.arrivalTime.ToString("HH:mm:ss"));
            Console.WriteLine("Seating Capacity: " + flight.seatingCapacity);
            Console.WriteLine("Reservation 1: " + flight.reservation1.reservationNo);
        }
    }

}
