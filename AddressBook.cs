using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBook
    {
        static int id = 1000;
       public  Person[] ppp = new Person[10];

        public void menu()
        {
            int index = 0;

            string choice;

            Person[] p = new Person[10];

            for(int i = 0; i < p.Length; i++)
            {
                p[i] = new Person();
            }

            p = init(p);

            index = 5;

            Console.WriteLine("\nNAME: VINCENT CHUI" +
                "\nDATE: 2015/10/26" +
                "\nLAB: 1" +
                "\nCOURSE: CIS 23" +
                "\nSEMIMESTER: FALL 2015");

            do
            {
                Console.Write("\nAdd" +
                    "\nDelete" +
                    "\nSearch" +
                    "\nQuit" +
                    "\nEnter: ");
                choice = Console.ReadLine().ToLower();

                switch (choice)
                {
                    case "add":
                        p = add(p, index);
                        index++;

                        if(index < p.Length - 1)
                        {
                            p = resize(p);
                        }
                        break;
                    case "delete":
                        p = delete(p);
                        break;
                    case "search":
                        search(p);
                        break;
                    case "quit":
                        Console.WriteLine("\nQUITTING");
                        break;
                    default:
                        Console.WriteLine("\nINVALID INPUT");
                        break;
                }
            } while (choice != "quit");
        }

        public Person[] init(Person[] p)
        {
            p[0].Fname = "Joe";
            p[0].Lname = "Po";
            p[0].Id = id++;

            p[1].Fname = "Dick";
            p[1].Lname = "Wang";
            p[1].Id = id++;

            p[2].Fname = "Yu";
            p[2].Lname = "Bang";
            p[2].Id = id++;

            p[3].Fname = "Steve";
            p[3].Lname = "Dude";
            p[3].Id = id++;

            p[4].Fname = "Wen";
            p[4].Lname = "Huang";
            p[4].Id = id;
            ppp = p;

            return p;
        }
        public Person this[int index]{
            get{ return ppp[index]; }
            set{ ppp[index] = value; }



        }

        public Person[] add(Person[] p, int index)
        {
            Console.Write("\nWhat is the first name? ");
            p[index].Fname = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            p[index].Lname = Console.ReadLine();

            p[index].Id = id++;

            print(p[index]);
            ppp = p;
            return p;
        }

        public Person[] delete(Person[] p)
        {
            string fname, lname;

            Console.WriteLine("\nWho to delete? This is case sensitive");

            Console.Write("\nWhat is the first name? ");
            fname = Console.ReadLine();

            Console.Write("\nWhat is the last name? ");
            lname = Console.ReadLine();

            for (int i = 0; i < p.Length; i++)
            {
                if ((fname == p[i].Fname) || (lname == p[i].Lname))
                {
                    p[i].Fname = "";
                    p[i].Lname = "";
                    p[i].Id = 0;

                    Console.WriteLine("\nThe person at index " + i +
                        " was deleted");

                    for(int x = 0; x < p.Length; x++)
                    {
                        if(p[x].Fname == "")
                        {
                            p[x].Fname = p[x + 1].Fname;
                            p[x].Lname = p[x + 1].Lname;
                            p[x].Id = p[x + 1].Id;

                            p[x + 1].Fname = "";
                            p[x + 1].Lname = "";
                            p[x + 1].Id = 0;
                        }
                    }
                }
            }
            ppp = p;

            return p;
        }

        public void search(Person[] p)
        {
            string fname, lname, choice;
            int id;

            Console.Write("\nFIRST NAME, LAST NAME, ID, OR QUIT: ");
            choice = Console.ReadLine().ToLower();

            switch (choice)
            {
                case "first name":
                    Console.Write("\nWhat is the first name (CASE SENSITIVE)? ");
                    fname = Console.ReadLine();

                    for(int i = 0; i < p.Length; i++)
                    {
                        if(fname == p[i].Fname)
                        {
                            print(p[i]);
                        }
                    }
                    break;
                case "last name":
                    Console.Write("\nWhat is the last name (CASE SENSITIVE)? ");
                    lname = Console.ReadLine();

                    for(int i = 0; i < p.Length; i++)
                    {
                        if (lname == p[i].Lname)
                        {
                            print(p[i]);
                        }
                    }
                    break;
                case "id":
                    Console.Write("\nWhat is the id? ");
                    id = Convert.ToInt32(Console.ReadLine());

                    for(int i = 0; i < p.Length; i++)
                    {
                        if(id == p[i].Id)
                        {
                            print(p[i]);
                        }
                    }
                    break;
                case "quit":
                    break;
                default:
                    Console.WriteLine("\nINVALID INPUT");
                    break;
            }
        }
        public Person[] resize(Person[] p)
        {
            Person[] temp = new Person[p.Length * 3];

            for(int i = 0; i < temp.Length; i++)
            {
                temp[i] = new Person();
            }

            for(int i = 0; i < p.Length; i++)
            {
                temp[i] = p[i];
            }

            return temp;
        }

        public void print(Person p)
        {
            Console.WriteLine("\nFIRST NAME: " + p.Fname +
                "\nLAST NAME: " + p.Lname +
                "\nID: " + p.Id);       
        }
    }
}
