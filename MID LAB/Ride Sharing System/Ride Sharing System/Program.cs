using System;
using System.Collections.Generic;


namespace ridesharing
{
    public class  User
    {
        public string user_id { get; set; }
        public string name { get; set; }
        public string phonenumber { get; set; }


        public void Register()
        { 
            Console.Write("Enter your name:");
            name=Console.ReadLine();
            Console.Write("Enter your phone Number:");
            phonenumber = Console.ReadLine();

            Console.WriteLine("Register Successfully!");
        }

        public void Login()
        {

        }

        public void displayprofile()
        {
            Console.WriteLine($"Your Name is: {name}");
            Console.WriteLine($"Your PhoneNumber is: {phonenumber}");
        }
    }



    public class Rider : User
    {
        public List<Trip> ridehistory = new List<Trip>();

        Trip t=new Trip();

        public void request_ride()
        {
            Console.WriteLine("Enter your Current Loctaion:");
            //ridehistory.
            t.start_location= Console.ReadLine();

            ridehistory.Add(t);

            Console.WriteLine("Enter your Destination:");
            //ridehistory.
            t.destination = Console.ReadLine();

            ridehistory.Add(t);


        }

        public void viewridehistory()
        {

            Trip tr = new Trip();
            tr.trip_id = "001";

                Console.WriteLine($"{tr.trip_id} From:{tr.start_location} To:{tr.destination} Fare:{tr.Fare}");
               
            
        }
    }




    public class Driver : User
    {
        public string driver_id { get; set; }
        public string vehicledetails { get; set; }
        public string isavailable { get; set; }


        public List<Trip> triphistory = new List<Trip>();

        Trip t = new Trip("Hamza");

        public void acceptride()
        {
            Console.WriteLine($"{t.driver_name} accepted the ride request from {name}");
        }

        public void viewtriphistory()
        {
            Trip tr = new Trip();
            tr.trip_id = "001";
            tr.Fare = 45;

            Console.WriteLine($"{tr.trip_id} From:{tr.start_location} To:{tr.destination} Fare:{tr.Fare}$");
        }

        public void toggleavailability()
        {
            Console.WriteLine($"Yes, Available");
        }
    }


    public class Trip
    {
        public string trip_id { get; set; }
        public string rider_name { get; set; }
        public string driver_name { get; set; }

        public string start_location { get; set; }
        public string destination { get; set; }
        public int Fare { get; set; }

        public string status { get; set; }

       public Trip(string n)
        {
            driver_name = n;
        }

        public Trip() {}

        public List<Trip> triphistory = new List<Trip>();

        public void register_driver()
        {
            trip_id = "001";
            Console.WriteLine("Enter Driver Name:");
            driver_name = Console.ReadLine();

            Console.WriteLine("Driver Registered Successfully......");
        }

        public void start_trip()
        {
            Console.WriteLine("trip started.......");
        }

        public void end_trip()
        {
            Console.WriteLine("trip Ended.......");
        }

        public void Display_tripdetails()
        {

        }
    }

    public class rideSharingSystem
    {
        public List<Rider> registered_riders = new List<Rider>();

        public List<Driver> registered_drivers = new List<Driver>();

        public List<Trip> available_trips = new List<Trip>();

        Trip t=new Trip();

        public void register_user()
        {

        }

        public void request_ride()
        {

        }

        public void findavailabledriver()
        {
            Console.WriteLine("Yes, Driver Available......");
        }

        public void complete_trip()
        {
            Console.WriteLine($"trip From {t.start_location} to {t.destination} has been Completed. Fare is:{t.Fare}");
        }

        public void display_all_trips()
        {
            Trip tr = new Trip();
            tr.trip_id = "001";

            Console.WriteLine($"{tr.trip_id} From:{tr.start_location} To:{tr.destination} Fare:{tr.Fare}");
        }





    }






    class program
    {

        static void Main()
        {
            int choice;

            //  Trip t = new Trip("Hamza");
            Trip t = new Trip();
            Rider rid = new Rider();
            rideSharingSystem rss = new rideSharingSystem();
            Driver d = new Driver();



            Console.WriteLine("1.Register as Rider");
            Console.WriteLine("2.Register as Driver");
            Console.WriteLine("3.Request a Ride");
            Console.WriteLine("4.Accept a Ride(Driver)");
            Console.WriteLine("5.Complete a Trip (Driver)");
            Console.WriteLine("6.View Ride History (Rider)");
            Console.WriteLine("7.View Trip History (Driver)");
            Console.WriteLine("8.Display All Trips");
            Console.WriteLine("9.Exit");


            do
            {
                Console.Write("Enter Your Choice:");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                       // Rider rid = new Rider();

                        rid.Register();

                        rid.displayprofile();

                        break;

                    case 2:
                       // Trip t= new Trip();
                        t.register_driver();
                        break;

                    case 3:
                        //Rider rider = new Rider();

                        rid.request_ride();
                        break;

                    case 4:
                        //Driver d = new Driver();
                        d.acceptride();
                        break;

                    case 5:
                       // rideSharingSystem rss = new rideSharingSystem();

                        rss.complete_trip();
                        break;

                    case 6:
                        //Rider ri = new Rider();
                        rid.viewridehistory();
                        break;

                    case 7:
                        //Driver dr = new Driver();
                        d.viewtriphistory();
                        break;


                    case 8:
                        //rideSharingSystem rs = new rideSharingSystem();

                        rss.display_all_trips();
                        break;


                    case 9:
                        Console.WriteLine("Exit Successfully!");
                        break;

                    default:
                        Console.WriteLine("Invalid Choice!");
                        break;


                }
            }while(choice!=9);



        }


    }





}



