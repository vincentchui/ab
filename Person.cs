using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class Person
    {
        private string fname;
        private string lname;
        private int id;
        

        public string Fname
        {
            get
            {
                return fname;
            }
            set
            {
                fname = value;
            }
        }

        public string Lname
        {
            get
            {
                return lname;
            }
            set
            {
                lname = value;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }
        }

        public int Index
        {
            get
            {
                return Index;
            }
            set
            {
                Index = value;
            }
        }
            
    }
}
