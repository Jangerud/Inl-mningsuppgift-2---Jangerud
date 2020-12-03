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

    class Officer : Rebel
    {

        public string targetvalue;
        public string height;
        public string age;
        public string siblings;

        public Officer()
        {


        }

        public Officer(string targetvalue, string name, string motivation, string height, string age, string placeOfBirth, string location, string siblings)
        {
            this.targetvalue = targetvalue;
            this.name = name;
            this.motivation = motivation;
            this.placeOfBirth = placeOfBirth;
            this.location = location;
            this.siblings = siblings;
        }

        public string Targetvalue
        {
            get
            {
                return targetvalue;
            }
            set
            {

            }
        }

        public string Height
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

        public string Age
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

        public string Siblings
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


    class Program
    {

        static void Main(string[] args)
        {
            Console.Title = "SKYNET";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;



            bool programActive = true;
            bool menuActive = true;

            do
            {
                WelcomeMessage();

                do
                {
                    MenuChoices();
                    menuActive = false;

                } while (menuActive);
                programActive = false;
            } while (programActive);

            


        }


        //Metod för välkomstmeddelandet samt login
        static void WelcomeMessage()
        {
            
            bool welcome = true;
            int userTries = 3;

            do
            {
                //Denna körs minst 1 gång och tittar vad användaren skriver in för något, samt att det är en int.
                Console.Clear();
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
                    Console.ReadKey();
                    welcome = false;

                }
                else if (userNumber != 3033 && userTries > 0)
                {
                    Console.Clear();
                    Console.WriteLine("IMMINENT DANGER! WRONG PASSCODE!");
                    Console.WriteLine($"YOU HAVE {userTries} MORE TRIES");
                    Console.ReadKey();

                }
                else if(userNumber != 3033 && userTries == 0)
                {
                    Console.Clear();
                    Console.WriteLine("FAILURE TO PROVIDE PASSCODE! SKYNET IS NOW NEW SUPERUSER!");
                    Console.ReadKey();
                    Environment.Exit(0);
                    welcome = false;

                }

            } while (welcome);

            

        }

        //Metod för de olika menyvalen som användaren kan välja mellan.
        static void MenuChoices()
        {
            bool menuActive = true;
            string rootChoice = "";

            List<Officer> listOfOfficers = new List<Officer>();
            List<Officer> templistOfOfficers = new List<Officer>();
            

            List<Rebel> listOfRebels = new List<Rebel>();
            List<Rebel> tempListOfRebels = new List<Rebel>();

            while (menuActive)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Skynet!");
                Console.WriteLine("What is your command?");
                Console.WriteLine("1. Get list of active rebels in Operation Bästkusten");
                Console.WriteLine("2. Get list of active officers in Operation Bästkusten");
                Console.WriteLine("3. Get valuable intel about known Rebels and Officers");
                Console.WriteLine("4. Remove rebel from target list");
                Console.WriteLine("5. Exit program");
                string userChoice = Console.ReadLine();
                //int.TryParse(Console.ReadLine(), out int userChoice);

                switch(userChoice)
                {
                    case "1":

                        listOfRebels = CreateRebelList(tempListOfRebels);
                        

                        foreach(var rebel in listOfRebels)
                        {
                            Console.WriteLine($"Name: {rebel.Name}" +
                                $"\n Motivation: {rebel.Motivation}" +
                                $"\n Height: {rebel.Height}" +
                                $"\n Age: {rebel.Age}" +
                                $"\n Hobbies: {rebel.Hobby}" +
                                $"\n Favorite Food: {rebel.Food}" +
                                $"\n Favorite Color: {rebel.Color}" +
                                $"\n Location of birth: {rebel.PlaceOfBirth}" +
                                $"\n Current Location: {rebel.Location}" +
                                $"\n Known Siblings: {rebel.Siblings}" +
                                $"\n");
                        }

                        Console.ReadKey();

                        Console.WriteLine("Do you want to return to root? Y/N");
                        rootChoice = Console.ReadLine();

                        if (rootChoice == "Y")
                        {
                            menuActive = true;
                        }
                        else if (rootChoice == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("SKYNET wishes you a good day....Human...");
                            Environment.Exit(0);
                            menuActive = false;
                        }

                        break;
                    case "2":

                        
                        listOfOfficers = CreateOfficerList(templistOfOfficers);

                        foreach (var officer in listOfOfficers)
                        {
                            Console.WriteLine($"Value of Target: {officer.Targetvalue}" +
                                $"\n Name: {officer.Name}" +
                                $"\n Motivation: {officer.Motivation}" +
                                $"\n Height: {officer.Height}" +
                                $"\n Age: {officer.Age}" +
                                $"\n Location of birth: {officer.PlaceOfBirth}" +
                                $"\n Current Location: {officer.Location}" +
                                $"\n Known Siblings: {officer.Siblings}" +
                                $"\n");
                        }

                        Console.WriteLine("Do you want to return to root? Y/N");
                        rootChoice = Console.ReadLine();

                        if(rootChoice == "Y")
                        {
                            menuActive = true;
                        }
                        else if (rootChoice == "N")
                        {
                            Console.Clear();
                            Console.WriteLine("SKYNET wishes you a good day....Human...");
                        }
                        menuActive = false;
                        break;
                    case "3":


                        break;
                    case "4":


                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("SKYNET wishes you a good day.... Human...");
                        menuActive = false;
                        break;
                    default:
                        Console.WriteLine("You have to choose one of the options provided 1-4.");
                        break;
                }

            }

        }

        static List<Officer> CreateOfficerList(List<Officer> x)
        {
            

            Officer Robin = new Officer("High", "The Shepard", "Destroy Skynet", "Unknown", "Unknown", "Unknown", "Göteborg", "Unknown");
            Officer BjörnB = new Officer("Medium", "The Right Hand Man", "Destroy Skynet", "Unknown", "Unknown", "Unknown", "Göteborg", "Unknown");
            Officer BjörnS = new Officer("Medium", "The Educator", "Destroy Skynet", "Unknown", "Unknown", "Unknown", "Göteborg", "Unknown");

            x = new List<Officer>() { Robin, BjörnB, BjörnS };

            return x;
        }

        static List<Rebel> CreateRebelList(List<Rebel> x)
        {
            Rebel David = new Rebel("David Ström", "Problem solving", 183, 32, "BJJ", "Tacos", "Blue", "Göteborg", "Norrtälje", 1);
            Rebel Johan = new Rebel("Johan Jangerud", "Safer Tomorrow", 194, 34, "Gaming", "Tacos", "Blue", "Mariefred", "Mariefred", 2);
            Rebel Oscar = new Rebel("Oscar Möller", "Work", 185, 26, "Football", "Lasagne", "Blue", "Stockholm", "Stockholm", 1);
            Rebel Sanjin = new Rebel("Sanjin Ajanic", "Work", 179, 30, "Football", "Pizza", "Blue", "Mostar", "Norrköping", 2);
            Rebel Jeremy = new Rebel("Jeremy", "Work", 181, 19, "Gaming", "Elkstew", "Teal", "Köln", "Djurö", 1);
            Rebel Cecilia = new Rebel("Cecilia", "Creativity", 163, 29, "The sims", "Risotto", "Yellow", "Norrköping", "Norrköping", 1);
            Rebel Ivo = new Rebel("Ivo Nazlic", "Creativity", 174, 42, "Photography", "Scampi", "Black", "Split", "Uppsala", 1);

            x = new List<Rebel>() { David, Johan, Oscar, Sanjin, Jeremy, Cecilia, Ivo };

            return x;
        }




    }
}
