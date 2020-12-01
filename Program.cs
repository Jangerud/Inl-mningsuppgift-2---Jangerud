using System;

namespace Inlämningsuppgift_2___Jangerud
{

    class Person
    {
        public string name = "";
        public string motivation = "";
        public int height = 0;
        public int age = 0;
        public string hobby = "";
        public string food = "";
        public string color = "";
        public string placeOfBirth = "";
        public string location = "";
        public int siblings = 0;

    }

    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "SKYNET";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            bool programActive = true;

            do
            {
                WelcomeMessage(programActive);
                MenuChoices(programActive);

            } while (programActive);
            


        }


        //Metod för välkomstmeddelandet samt login
        static bool WelcomeMessage(bool x)
        {
            bool welcome = true;
            int userTries = 3;

            do
            {
                //Denna körs minst 1 gång och tittar vad användaren skriver in för något, samt att det är en int.
                Console.WriteLine("Hello User 5471!");
                Console.WriteLine("Please enter passcode: ");
                int.TryParse(Console.ReadLine(), out int userNumber);

                
                userTries--;

                /*Här kommer 3 olika scenarion där ett är succeé och ett är en varning samt sista är avslut.
                 * Den kollar efter det rätta numret som användaren skriver in.
                 * Om det inte är rätt och användarens försök inte har nått 0 så får användaren chans på nytt.
                 * Annars säger den att användaren misslyckades och avslutas.
                 */
                if (userNumber == 5471)
                {
                    Console.Clear();
                    Console.WriteLine("Success! Welcome Superuser!");
                    welcome = false;

                }
                else if (userNumber != 5471 && userTries > 0)
                {
                    Console.Clear();
                    Console.WriteLine("IMMINENT DANGER! WRONG PASSCODE!");
                    Console.WriteLine($"YOU HAVE {userTries} MORE TRIES");
                    
                }
                else if(userNumber != 5471 && userTries == 0)
                {
                    Console.Clear();
                    Console.WriteLine("FAILURE TO PROVIDE PASSCODE! SKYNET IS NOW NEW SUPERUSER!");
                    welcome = false;

                }

            } while (welcome);

            return x = false;

        }


        static bool MenuChoices(bool x)
        {
            bool menuActive = true;

            do
            {
                Console.WriteLine("Welcome to Skynet!");
                Console.WriteLine("What is your command?");
                Console.WriteLine("1. Get list of active rebels in Operation Bästkusten");
                Console.WriteLine("2. Get valuable intel about known rebels");
                Console.WriteLine("3. Remove rebel from target list");
                Console.WriteLine("4. Exit program");
                int.TryParse(Console.ReadLine(), out int userChoice);

                switch(userChoice)
                {
                    case 1:


                        break;
                    case 2:


                        break;
                    case 3:


                        break;
                    case 4:


                        break;
                    default:
                        Console.WriteLine("You have to choose one of the options provided 1-4.");
                        break;
                }

            } while (menuActive);

            return x = false;
        }



    }
}
