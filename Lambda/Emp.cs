using System;
using System.Collections.Generic;
using System.Text;

namespace Lambda
{
    public class Emp
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int ID { get; set; }
        public Emp(string _firstName, string _lastName, int _ID)
        {
            firstname = _firstName;
            lastname = _lastName;
            ID = _ID;
        }
    }
}
