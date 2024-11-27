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

        public void checkGender(RadioButton male, RadioButton female)
        {
            if (!male.Checked && !female.Checked)
            {
                throw new Exception("Select your Gender");
            }

        }

        public void checkHobby(CheckBox one, CheckBox two)
        {
            if (!one.Checked && !two.Checked)
            {
                throw new Exception("Select your Hobby");
            }

        }

        public void checkStatus(RadioButton m, RadioButton um)
        {
            if (!m.Checked && !um.Checked)
            {
                throw new Exception("Select your Status");
            }

        }
    }
}
