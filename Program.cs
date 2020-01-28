using System;

namespace Lab_8_Get_To_Know_Classmate
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student1 = { "Clayton", "Flat Rock", "Potato Curry" };
            string[] student2 = { "Heather", "Marysville", "Donuts" };
            string[] student3 = { "Reggie", "Detroit", "Pizza" };

            bool resume = true;

            while (resume == true)
            {
                try
                {
                    int studentNumber = int.Parse(GetUserInput("Which student would you like to research? Choose between 1 and 3."));
                    if (studentNumber == 1)
                    {
                        GetStudentInfo(student1);
                        Console.WriteLine("Would you like to go again? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        resume = AskToTryAgain(input);


                    }
                    else if (studentNumber == 2)
                    {
                        GetStudentInfo(student2);
                        Console.WriteLine("Would you like to go again? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        resume = AskToTryAgain(input);

                    }
                    else if (studentNumber == 3)
                    {
                        GetStudentInfo(student3);
                        Console.WriteLine("Would you like to go again? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        resume = AskToTryAgain(input);
                    }
                    else if (studentNumber > 3 || studentNumber < 1)
                    {
                        Console.WriteLine("Student doesn't exist");
                        Console.WriteLine("Would you like to go again? (y/n)");
                        string input = Console.ReadLine().ToLower();
                        resume = AskToTryAgain(input);
                    }

                }
                catch (FormatException)
                {
                    Console.WriteLine("Wrong format.");
                    resume = true;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("Wrong input.");
                    resume = true;
                }


            }

        }




        static string GetUserInput(string message)
        {
            Console.WriteLine(message);
            return Console.ReadLine();
        }

        static bool AskToTryAgain(string input)
        {
            
                if (input[0] == 'y')
                {
                    return true;
                }
                else if (input[0] == 'n')
                {
                    return false;
                }
                else
                {
                     return false;
                }
            
            

        }




        static void GetStudentInfo(string[] student)
        {
            try
            {
                string name = student[0];
                string response = GetUserInput($"Your student is {name}. Would you like to learn about his hometown or favorite food?").ToLower();
                if (response[0] == 'h')
                {
                    string hometown = student[1];
                    Console.WriteLine($"{name}'s hometown is {hometown}.");

                }
                else if (response[0] == 'f')
                {
                    string favoriteFood = student[2];
                    Console.WriteLine($"{name}'s favorite food is {favoriteFood}.");
                }
                else
                {
                }
            }
            catch (FormatException)
            {

                Console.WriteLine("Not a valid format.");
            }
            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Not a valid index.");
            }
        }
    }
}