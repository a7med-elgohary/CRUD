using CRUD_Operation;
using System.Data;
using System.IO;

internal class Program
{
    private static void Main(string[] args)
    {

       
       


        int processNumber = 0;
        while (true)
        {
            if (processNumber==0)
                App.screen(processNumber);
            processNumber++;

            if (processNumber > 0)
            {
                Console.Write("\nDo you want to try anything else ?\n   y for yes || n for no !!\n>> ");
                int chooise2 = char.Parse(Console.ReadLine());
                if (chooise2 == 'y')
                {
                    App.screen(processNumber);
                }
                else 
                {
                    Console.WriteLine("baye");
                    break;
                }
            }


        }
    }
}