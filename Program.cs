using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace example_program_console
{
    public class Program
    {
        const int EXIT_VALUE = 0;

        static void Main(string[] args)
        {
            int menu_selection;
            Swaping_Integers_Main Swap = new Swaping_Integers_Main();
            Sorting Sort = new Sorting();
            Searching Search = new Searching();

            while (get_response() == 'y')
            {
                do
                {
                    Console.WriteLine("\n\n\n   Please select a program from the menu:");
                    Console.WriteLine("       1. Swapping");
                    Console.WriteLine("       2. Sorting");
                    Console.WriteLine("       3. Searching");
                    Console.WriteLine($"\n\n       {EXIT_VALUE}. Exit Menu");
                    menu_selection = Console.ReadKey().KeyChar;

                    switch (menu_selection)
                    {
                        case 1:
                            Swap.Display_Directions();
                            break;
                        case 2:
                            Sort.Display_Directions();
                            break;
                        case 3:
                            Search.Display_Directions();
                            break;
                        case EXIT_VALUE:
                            Console.WriteLine("\n\n\n   Thank you for trying these programs!");
                            break;
                        default:

                            break;

                    }

                } while (menu_selection != EXIT_VALUE);

            }

            Console.WriteLine("\nThanks for using this program.  Have a nice day! ;-)");
            Console.WriteLine("\n\n\n\n\n\n");
            return;
        }

        // Prints menu for user to choose what program to run
        static void print_menu()
        {
            Console.WriteLine("\n\n\n   This program has a menu of various");
            Console.WriteLine("    \n   functions that you can run and learn");
            Console.WriteLine("    \n   how they work.");
            return;
        }

        // Gets a response from the user
        static char get_response()
        {
            char response;

            print_menu();
            Console.WriteLine("\n\n");
            do
            {
                Console.WriteLine("   Do you want to open the menu (y or n)?");
                response = Console.ReadKey().KeyChar;
            } while (Char.ToLower(response) != 'y' && Char.ToLower(response) != 'n');

            return response;
        }
    }
}
