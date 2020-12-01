using System;

namespace Inlämningsuppgift_2___Jangerud
{

    class Person
    {
        public string motivation = "";

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


        }



    }
}
