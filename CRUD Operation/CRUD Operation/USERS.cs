using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CRUD_Operation
{
    internal class USERS
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public static List<USERS> MyData = new List<USERS>();
        

        public static void addUser()
        {
            Console.WriteLine("=============== Add User ===============");
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();
            Console.Write("Enter Email: ");
            string email = Console.ReadLine();
            Console.Write("Enter PhoneNumber: ");
            string number = Console.ReadLine();
            USERS newUser = new USERS { UserName=name ,Email= email,PhoneNumber= number };
            MyData.Add(newUser);
            Console.WriteLine("=============== user information you add ===============");
            Console.WriteLine($"Name: {newUser.UserName}\nEmail: {newUser.Email}\nPhone number: {newUser.PhoneNumber}");
        }
        public static void print()
        {
            Console.WriteLine("=============== Users infomation ===============");

            int n = 1;
            foreach (var item in MyData)
            {
                Console.WriteLine($"User {n}\nName: {item.UserName}\nEmail: {item.Email}\nPhone number: {item.PhoneNumber}");
                n =n+1;
                Console.WriteLine("========");
            }
        }
        public static void Edit() 
        {
            Console.Write("Enter User Phone Number you want to Edit: \n");
            string phone = Console.ReadLine();  
            foreach (var item in MyData)
            {
                if (item.PhoneNumber == phone )
                {
                    Console.Write("Enter Name: ");
                    
                    item.UserName = Console.ReadLine();
                    Console.Write("Enter Email: ");
                    item.Email = Console.ReadLine();
                    Console.Write("Enter PhoneNumber: ");
                    item.PhoneNumber = Console.ReadLine();
                    Console.WriteLine($"Edit the name : {item.UserName}\nEdit the email : {item.Email}\nEdit the phon number : {item.PhoneNumber }");
                    Console.WriteLine("=============== Process is done ===============");

                }
            }

        }
        public static void Remove()
        {
            Console.Write("Enter User Phone Number you want to remove: ");
            string phone = Console.ReadLine();
            
            for (var item =MyData.Count-1;item >= 0; item--)
            {
                if (MyData[item].PhoneNumber == phone)
                {
                        MyData.Remove(MyData[item]);
                    Console.WriteLine("=============== Process is done ===============");

                }
            }
           
        }


    }
}
