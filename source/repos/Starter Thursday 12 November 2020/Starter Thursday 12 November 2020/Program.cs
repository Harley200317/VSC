using System;

namespace Starter_Thursday_12_November_2020
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                //Welcome Message
                Console.WriteLine("Please Enter your credentials");
                //line spacing 
                Console.WriteLine("");
                
                Console.WriteLine("What is your First Name?");
                string First_Name = Console.ReadLine();
                
                //Same for Surname
                Console.WriteLine("What is your Surname?");                        
                string Surname = Console.ReadLine();

                //User's age
                Console.WriteLine("What is your age?");
                string Age = Console.ReadLine();

                //Users ID
                Console.WriteLine("What is your ID?");
                string ID = Console.ReadLine();


                               
                //put both strings together
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("First Name is: " + First_Name);
                Console.WriteLine("Surname is: " + Surname);
                Console.WriteLine("Your age is: " + Age);
                Console.WriteLine("Your ID is: " + ID);
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                {
                    DateTime currentDateTime = DateTime.Now;
                    

                    Console.WriteLine($"This process was completed at : {currentDateTime}");
                   

                }
            }



        }
        }
    }




