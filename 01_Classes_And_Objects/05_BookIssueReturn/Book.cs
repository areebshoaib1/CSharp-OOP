using System;
using System.Collections.Generic;
using System.Text;

namespace _05_BookIssueReturn
{
    internal class Book
    {
        const string BookTitle1 = "War and Peace";
        const string BookTitle2 = "Hyperion";

        static bool Book1 = true;
        static bool Book2 = true;

        public void DisplayBooks()
        {
            if (Book1 || Book2)
            {
                Console.WriteLine("***** Available Books *****");

                if (Book1)
                {
                    Console.WriteLine($"1: {BookTitle1}");
                }
                if (Book2)
                {
                    Console.WriteLine($"2: {BookTitle2}");
                }
            }
            else
            {
                Console.WriteLine("No books available");

            }

        }



        public void issueBook()
        {
            options();
            void options()
            {
                Console.WriteLine("***** Options *****");
                if (Book1 || Book2)
                {
                    if (Book1)
                    {
                        Console.WriteLine($"1: {BookTitle1}");
                    }
                    if (Book2)
                    {
                        Console.WriteLine($"2: {BookTitle2}");
                    }
                }
                else
                {
                    Console.WriteLine("No books available");

                }

            }

            Console.WriteLine("3: Exit");
            Console.WriteLine("Enter your Choice: ");
            string Choice = Console.ReadLine() ?? "";
            if (int.TryParse(Choice, out int Choice1))
            {
                if (Choice1 == 1 || Choice1 == 2 || Choice1 == 3)
                {
                    if (Choice1 == 1)
                    {
                        if (Book1)
                        {
                            Book1 = false;
                            Console.WriteLine($"Book \"{BookTitle1}\" Issued Succesfully");
                            issueBook();
                        }
                        else
                        {
                            Console.WriteLine($"Sorry \"{BookTitle1}\" already issued to someone else ");
                            issueBook();

                        }

                    }
                    if (Choice1 == 2)
                    {
                        if (Book2)
                        {
                            Book2 = false;
                            Console.WriteLine($"Book \"{BookTitle2}\" Issued Succesfully");
                            issueBook();
                        }
                        else
                        {

                            Console.WriteLine($"Sorry \"{BookTitle2}\" already issued to someone else ");
                            issueBook();
                        }

                    }

                    if (Choice1 == 3)
                    {
                        return;
                    }
                }
                else
                {

                    Console.WriteLine("Enter correct choice!");
                    issueBook();

                }
            }


        }

        public void ReturnBook()
        {
            Console.WriteLine("***** Return Book *****");

            Console.WriteLine("Which Book you want to return?");
            Console.WriteLine($"1: {BookTitle1}");
            Console.WriteLine($"2: {BookTitle2}");
            Console.WriteLine("3: Exit");

            Console.WriteLine("Enter choice: ");
            string Choice = Console.ReadLine() ?? "";
            if (int.TryParse(Choice, out int Choice1))
            {
                if (Choice1 == 1 || Choice1 == 2 || Choice1 == 3)
                {
                    if (Choice1 == 1)
                    {
                        if (Book1 == false)
                        {
                            Book1 = true;
                            Console.WriteLine($"Book \"{BookTitle1}\" returned Succesfully");
                            ReturnBook();
                        }
                        else
                        {
                            Console.WriteLine($"Sorry book \"{BookTitle1}\" is not issued, can't return available Book ");
                            ReturnBook();

                        }

                    }
                    if (Choice1 == 2)
                    {
                        if (Book2 == false)
                        {
                            Book2 = true;
                            Console.WriteLine($"Book \"{BookTitle2}\" returned Succesfully");
                            ReturnBook();
                        }
                        else
                        {

                            Console.WriteLine($"Sorry book \"{BookTitle2}\" is not issued, can't return available Book ");

                            ReturnBook();
                        }

                    }

                    if (Choice1 == 3)
                    {
                        return;
                    }
                }
                else
                {

                    Console.WriteLine("Enter correct choice!");
                    ReturnBook();

                }
            }


        }
    }
}
