using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arun_Project_Part1
{
    class Program
    {
        static void Main(string[] args)
        {
            string repeat;
            bool filmvalue;
            bool agevalue;
            int number = 0;


            
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to our multiplex");
                Console.WriteLine("We are currently showing:");
                Console.WriteLine("1: Rush (15)");
                Console.WriteLine("2: How i live you (15)");
                Console.WriteLine("3: Thor: The Dark World (12)");
                Console.WriteLine("4: Filth (18)");
                Console.WriteLine("5: Planes (4)");

                //Reading film number selection from user


                Console.Write("Enter the number of the film you wish to see : ");
               
                do
                {
                    try   //to catch exception
                    {
                        filmvalue = false;
                        number = int.Parse(Console.ReadLine());
                        if (number < 1 || number > 5)
                        {
                            filmvalue = true;
                            Console.WriteLine("This film number is invalid");
                            Console.Write("Enter Valid film number: ");
                        }
}
                    catch (Exception )
                    {
                        filmvalue = true;
                        Console.WriteLine("This film number is invalid");
                        Console.Write("Enter Valid film number: ");
                    }
                } while (filmvalue);


                //Reading user age

                Console.Write("enter the age : ");



                int age = 0;

                do
                {
                    try  //to catch exception
                    {
                        agevalue = false;
                        age = int.Parse(Console.ReadLine());

                        if (age >= 120)
                        {
                            Console.WriteLine("This age is invalid.");
                        }
                        else if (age< 5)
                        {
                            Console.WriteLine("This age is invalid.");
                        }
                       
                        else
                        {
                            switch (number)  // Comparing user age with the given age restrictions
                            {
                                case 1:
                                    if (age >= 15)
                                    {
                                        Console.WriteLine("You selected movie :Rush (15) ");
                                        Console.WriteLine("Enjoy the film");
                                    }
                                    else
                                    {
                                        Console.WriteLine("Access denied - you are too young.");
                                    }
                                    break;
                                case 2:
                                    if (age >= 15)
                                    {
                                        Console.WriteLine("You selected movie :How i live you (15) ");
                                        Console.WriteLine("Enjoy the film");
                                    }
                                    else
                                        Console.WriteLine("Access denied - you are too young.");
                                    break;
                                case 3:
                                    if (age >= 12)
                                    {
                                        Console.WriteLine("You selected movie :Thor: The Dark World (12)");
                                        Console.WriteLine("Enjoy the film");
                                    }
                                    else
                                        Console.WriteLine("Access denied - you are too young.");
                                    break;
                                case 4:
                                    if (age >= 18)
                                    {
                                        Console.WriteLine("You selected movie :Filth (18)");
                                        Console.WriteLine("Enjoy the film");
                                    }
                                    else
                                        Console.WriteLine("Access denied - you are too young.");
                                    break;
                                case 5:
                                    if (age >= 4)
                                    {
                                        Console.WriteLine("You selected movie :Planes");
                                        Console.WriteLine("Enjoy the film");
                                    }
                                    else
                                        Console.WriteLine("Access denied - you are too young");
                                    break;
                            }
                        }
                    }

                    catch (Exception )
                    {
                        agevalue = true;
                        Console.WriteLine("This age is invalid.");
                        Console.Write("Enter valid age : ");
                        
                    }
                } while (agevalue);

                //Checking whether to repeat the procedure
                Console.Write("Another customer? (Y or N):");
                repeat = Console.ReadLine();
                repeat = repeat.ToUpper();



            }
            while (repeat == "Y");
        }
    }
    }



