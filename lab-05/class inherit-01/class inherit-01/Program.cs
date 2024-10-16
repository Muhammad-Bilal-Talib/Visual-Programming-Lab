using System;
using System.Linq;

namespace act3
{
    

    public class WorkItem
    {
        private static int currentID;

        protected int ID { get; set; }

        protected string Title { get; set; }

        protected string Description { get; set; }

        protected TimeSpan jobLength { get; set; }

        public WorkItem()
        {
            ID = 0;
            Title = "Default Title";
            Description = "Default Description";
            jobLength = new TimeSpan();
        }

        public WorkItem(string tit, string desc, TimeSpan joblen)
        {
            this.ID = GetNextID();
            this.Title = tit;
            this.Description = desc;
            this.jobLength = joblen;
        }

        static WorkItem()
        {
            currentID = 0;
        }

        protected int GetNextID()
        {
            return ++currentID;
        }

        public void update(string titl, TimeSpan joblen)
        {
            this.Title = titl;
            this.jobLength = joblen;
        }

        public override string ToString()
        {
              return String.Format($"{0}-{1}",this.ID,this.Title);
        }


    }

    public class ChangeRequest : WorkItem
    {
        protected int originalItemID { get; set; }

        // Constructors. Because neither constructor calls a base-class
        // constructor explicitly, the default constructor in the base class
        // is called implicitly. The base class must contain a default
        // constructor.

        // Default constructor for the derived class.
        public ChangeRequest() { }

        // Instance constructor that has four parameters.
        public ChangeRequest(string title, string desc, TimeSpan jobLen, int originalID)
        {
            // The following properties and the GetNexID method are inherited
            // from WorkItem.
            this.ID = GetNextID();
            this.Title = title;
            this.Description = desc;
            this.jobLength = jobLen;

            // Property originalItemId is a member of ChangeRequest, but not
            // of WorkItem.
            this.originalItemID = originalID;
        }

        public ChangeRequest(int originalItemID)
        {
            this.originalItemID = originalItemID;
        }
    }

    public class Program
    {
        static void Main(string[] args)
        {
            //result = SafeDivision(a, b);

            //Console.WriteLine($"{a} divided by {b} = {result}");

            //TestCatch2();

            // Create an instance of WorkItem by using the constructor in the
            // base class that takes three arguments.

            WorkItem item = new WorkItem("Fix Bugs", "Fix all bugs in my code branch", new TimeSpan(3, 4, 0, 0));

            // Create an instance of ChangeRequest by using the constructor in
            // the derived class that takes four arguments.

            ChangeRequest change = new ChangeRequest("Change Base Class Design", "Add members to the class", new TimeSpan(4, 0, 0), 1);

            // Use the ToString method defined in WorkItem.

            Console.WriteLine(item.ToString());

            // Use the inherited Update method to change the title of the
            // ChangeRequest object.

            change.update("Change the Design of the Base Class", new TimeSpan(4, 0, 0));

            // ChangeRequest inherits WorkItem's override of ToString.

            Console.WriteLine(change.ToString());

            // Keep the console open in debug mode.

            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();
        }
    }





       




}


