using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBook
{
    class AddressBookTester
    {
        static void Main(string[] args)
        {
            AddressBook a = new AddressBook();

            a.menu();
            

        }
    }
}
/*OUTPUT

NAME: VINCENT CHUI
DATE: 2015/10/26
LAB: 1
COURSE: CIS 23
SEMIMESTER: FALL 2015

Add
Delete
Search
Quit
Enter: add

What is the first name? Vincent

What is the last name? Xu

FIRST NAME: Vincent
LAST NAME: Xu
ID: 1004

Add
Delete
Search
Quit
Enter: search

FIRST NAME, LAST NAME, ID, OR QUIT: first name

What is the first name (CASE SENSITIVE)? Vincent

FIRST NAME: Vincent
LAST NAME: Xu
ID: 1004

Add
Delete
Search
Quit
Enter: search

FIRST NAME, LAST NAME, ID, OR QUIT: last name

What is the last name (CASE SENSITIVE)? Xu

FIRST NAME: Vincent
LAST NAME: Xu
ID: 1004

Add
Delete
Search
Quit
Enter: search

FIRST NAME, LAST NAME, ID, OR QUIT: id

What is the id? 1004

FIRST NAME: Wen
LAST NAME: Huang
ID: 1004

FIRST NAME: Vincent
LAST NAME: Xu
ID: 1004

Add
Delete
Search
Quit
Enter: quit

QUITTING
Press any key to continue . . .
*/
