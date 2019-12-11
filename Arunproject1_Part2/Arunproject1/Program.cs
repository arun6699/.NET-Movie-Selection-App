using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arunproject1
{
    class Program
    {
        static void Main(string[] args)
        {


            string repeat;
            string[] filmNames = new string[5];
            int age=0, number=0, total = 0,count=0;
            int[] agerestriction = new int[5];
            bool value;

            //Storing old film names in array

                filmNames[0] = "1.Rush(15)";
                filmNames[1] = "2.How I Live Now(15)";
                filmNames[2] = "3.Thor: The Dark World(12A)";
                filmNames[3] = "4.Filth(18)";
                filmNames[4] = "5.Planes(U)";


            // Displaying the old movie list

                Console.WriteLine("Old Movies list\n");
                for (int i = 0; i < filmNames.Length; i = i + 1)
                {
                    
                    Console.WriteLine(""  + filmNames[i]);
                }

            Console.WriteLine("\nPress Enter to Continue");
                Console.ReadLine();
                Console.Clear();

            //Reading the number of new movies

                Console.Write(" \nEnter the total number  of films to be entered  :");

            do
            {

                try   //to catch exception
                {
                    value = false;
                    total = int.Parse(Console.ReadLine());

                    if ((total < 1) || (total > 100))
                    {
                        count = 0;
                        Console.WriteLine("\nIts not valid number. Please try again ");

                    }



                    else if ((total > 1) || (total < 100))
                    {
                        count = 1;
                    }

                    else
                    {
                        Console.WriteLine("\nIts not valid number. Please try again ");
                    }
                }
                catch (Exception)
                {
                    value = true;
                    Console.WriteLine("\nIts not valid number. Please try again ");
                    
                }

            
        } while (count == 0 || value );




            //Read the film names
            for (int i = 0; i < total; i = i + 1)
                {
                    int displayNumber = i + 1;
                    Console.Write("\nEnter the name of film number " + displayNumber + ": ");
                    filmNames[i] = Console.ReadLine();
                    Console.Write("\nEnter the age restriction for the movie" + displayNumber + ": ");

                   
                do
                {

                    try   //to catch exception
                    {
                        value = false;

                        agerestriction[i] = int.Parse(Console.ReadLine());

                        if ((agerestriction[i] < 5) || (agerestriction[i] > 120))
                        {
                            count = 0;
                            Console.WriteLine("\nIts not valid age. Please try again ");

                        }



                        else if ((agerestriction[i] > 5) || (agerestriction[i] < 120))
                        {
                            count = 1;
                        }

                        else
                        {
                            Console.WriteLine("\nIts not valid age. Please try again ");
                        }
                    }

                    catch (Exception)
                    {
                        value = true;
                        Console.WriteLine("\nIts not valid age. Please try again ");

                    }


                } while (count == 0 || value);

           
            }



                // Repeating the movie list for customer selection
            do
            {
                Console.Clear();
                Console.WriteLine("\nNew Movies list\n");
                for (int i = 0; i < total; i = i + 1)
                {
                    
                    Console.WriteLine( i + 1 +":" + filmNames[i] + "("+ (agerestriction[i])+ ")");
                }
               

                // Reading the film choice 
                Console.WriteLine("\nEnter the number of the film you wish to see: ");
                do
                {
                    try   //to catch exception
                    {
                        value = false;
                        number = int.Parse(Console.ReadLine());

                    if ((number < 1) || (number > total))
                    {
                        count = 0;
                        Console.WriteLine("\nIts not a valid film number. Please try again ");
                      
                    }
                    else if ((number > 1) || (number < total))
                    {
                        count = 1;
                    }

                    else
                    {
                        Console.WriteLine("\nIts not a valid film number. Please try again ");
                    }

                    }

                    catch (Exception)
                    {
                        value = true;
                        Console.WriteLine("\nIts not a valid film number. Please try again ");

                    }


                } while (count == 0 || value);


                number = number - 1;

                Console.WriteLine("\n\nYou Selected the Film: " + filmNames[number] + " Age:" + agerestriction[number]);

                Console.WriteLine("\nEnter your age:");
                

                do
                {

                    try   //to catch exception
                    {
                        value = false;

                        age = int.Parse(Console.ReadLine());

                    if ((age < 5) || (age > 120))
                    {
                        count = 0;
                        Console.WriteLine("\nIts not valid age. Please try again ");

                    }



                    else if ((age > 5) || (age < 120))
                    {
                        count = 1;
                    }

                    else
                    {
                        Console.WriteLine("\nIts not valid age. Please try again ");
                    }

                    }

                    catch (Exception)
                    {
                        value = true;
                        Console.WriteLine("\nIts not valid age. Please try again ");

                    }


                } while (count == 0 || value);

                //Validating age restriction



                if (age >= agerestriction[number])
                    {
                        Console.WriteLine("\nEnjoy your movie");
                    Console.WriteLine(" \nPress Enter to Continue");
                    Console.ReadLine();


                }
                    else if (age < agerestriction[number])
                    {

                        Console.WriteLine("\nAccess Denied: You are too young");
                    Console.WriteLine("\nPress Enter to Continue");
                    Console.ReadLine();
                } 

                



                //Checking whether to repeat the procedure
                Console.Write("\nAnother customer? (Y or N):");
                repeat = Console.ReadLine();
                repeat = repeat.ToUpper();



                }
            while (repeat == "Y");
        }
    }
}
