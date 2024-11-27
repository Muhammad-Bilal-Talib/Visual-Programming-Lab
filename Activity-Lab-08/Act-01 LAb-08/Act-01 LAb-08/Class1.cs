using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Act_01_LAb_08
{
    public class Class1
    {

        public void CheckCustomerName(string customerName)
        {
            if(customerName.Length>10)
            {
                 throw new Exception("Name should be within 10 characters.");
                 
            }
            else if(customerName=="")
            {
                throw new Exception("Name is Required!");
            }
        }
    }
}
