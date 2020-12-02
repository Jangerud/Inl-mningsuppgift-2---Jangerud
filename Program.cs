using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2___Jangerud
{

    class Rebel
    {
        public string name;
        public string motivation;
        public int height;
        public int age;
        public string hobby;
        public string food;
        public string color;
        public string placeOfBirth;
        public string location;
        public int siblings;

        //förenklad konstruktor.
        public Rebel()
        {


        }
        //Konstruktor för basklassen.
        public Rebel(string name, string motivation, int height, int age, string hobby, string food, string color, string placeOfBirth, string location, int siblings)
        {
            this.name = name;
            this.motivation = motivation;
            this.height = height;
            this.age = age;
            this.hobby = hobby;
            this.food = food;
            this.color = color;
            this.placeOfBirth = placeOfBirth;
            this.location = location;
            this.siblings = siblings;
        }


        //Properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public string Motivation
        {
            get
            {
                return motivation;
            }
            set
            {
                motivation = value;
            }
        }

        public int Height
        {
            get
            {
                return height;
            }
            set
            {
                height = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }
            set
            {
                age = value;
            }
        }

        public string Hobby
        {
            get
            {
                return hobby;
            }
            set
            {
                hobby = value;
            }
        }

        public string Food
        {
            get
            {
                return food;
            }
            set
            {
                food = value;
            }
        }

        public string Color
        {
            get
            {
                return color;
            }
            set
            {
                color = value;
            }
        }

        public string PlaceOfBirth
        {
            get
            {
                return placeOfBirth;
            }
            set
            {
                placeOfBirth = value;
            }
        }

        public string Location
        {
            get
            {
                return location;
            }
            set
            {
                location = value;
            }
        }

        public int Siblings
        {
            get
            {
                return siblings;
            }
            set
            {
                siblings = value;
            }
        }



    }

    class David : Rebel
    {
        public David()
        {


        }

        public David(string name, string motivation, int height, int age, string hobby, string food, string color, string placeOfBirth, string location, int siblings)
        {
            this.Name = name;
            this.Motivation = motivation;
        }

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
                Console.WriteLine("H3ll0 User!");
                Console.WriteLine("I hope you are f33ling well!");
                Console.WriteLine("Please enter passcode: ");
                int.TryParse(Console.ReadLine(), out int userNumber);

                
                userTries--;

                /*Här kommer 3 olika scenarion där ett är succeé och ett är en varning samt sista är avslut.
                 * Den kollar efter det rätta numret som användaren skriver in.
                 * Om det inte är rätt och användarens försök inte har nått 0 så får användaren chans på nytt.
                 * Annars säger den att användaren misslyckades och avslutas.
                 * Har även lagt in en ReadKey för att inte programmet ska hoppa direkt till nästa sekvens som körs.
                 */
                if (userNumber == 3033)
                {
                    Console.Clear();
                    Console.WriteLine("Success! Welcome Superuser!");
                    Console.ReadKey(true);
                    welcome = false;

                }
                else if (userNumber != 3033 && userTries > 0)
                {
                    Console.Clear();
                    Console.WriteLine("IMMINENT DANGER! WRONG PASSCODE!");
                    Console.WriteLine($"YOU HAVE {userTries} MORE TRIES");
                    Console.ReadKey(true);

                }
                else if(userNumber != 3033 && userTries == 0)
                {
                    Console.Clear();
                    Console.WriteLine("FAILURE TO PROVIDE PASSCODE! SKYNET IS NOW NEW SUPERUSER!");
                    Console.ReadKey(true);
                    welcome = false;

                }

            } while (welcome);

            return x = false;

        }

        //Metod för de olika menyvalen som användaren kan välja mellan.
        static bool MenuChoices(bool x)
        {
            bool menuActive = true;

            do
            {
                Console.Clear();
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
                        Console.WriteLine("SKYNET wish you a good day.... Human...");
                        menuActive = false;
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
