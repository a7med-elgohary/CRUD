using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation
{
    internal class App
    {

        public static void screen(int processNumber)
        {
            Console.WriteLine("1- Add User\n2- Update Data Of User\n3- Delete User\n4- Print All User\n");
            char Chooise = char.Parse(Console.ReadLine());
            if (Chooise == '1')
            {
                // Call Add user method
                USERS.addUser();
                processNumber = 1;

            }
            else if (Chooise == '2')
            {
                // Call Update data method
                USERS.Edit();
                processNumber++;

            }
            else if (Chooise == '3')
            {
                // Call delete user method
                USERS.Remove();
                processNumber++;

            }
            else if (Chooise == '4')
            {
                // Call print user method
                USERS.print();
                processNumber++;

            }
            

        }
    }


}

