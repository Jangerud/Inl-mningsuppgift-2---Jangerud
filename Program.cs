using System;
using System.Collections.Generic;

namespace Inlämningsuppgift_2___Jangerud
{
    //Basklassen Rebel skapas här.
    class Rebel
    {
        //Fälten som vi väljer att ha med skrivs här.
        public string name;
        public string motivation;
        public string height;
        public string age;
        public string hobby;
        public string food;
        public string color;
        public string placeOfBirth;
        public string location;
        public string siblings;

        //förenklad konstruktor.
        public Rebel()
        {


        }
        //Konstruktor för basklassen.
        public Rebel(string name, string motivation, string height, string age, string hobby, string food, string color, string placeOfBirth, string location, string siblings)
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


        //Properties för basklassen.
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

    //Subklass till klassen Rebel skapas här.
    class Officer : Rebel
    {
        //Fält för subklassen Officer.
        public string targetValue;

        //Förenklad konstruktor.
        public Officer()
        {


        }

        //Konstruktor nr 2.
        public Officer(string name, string targetvalue, string motivation, string height, string age, string placeOfBirth, string location, string siblings)
        {
            
            this.name = name;
            this.targetValue = targetvalue;
            this.motivation = motivation;
            this.height = height;
            this.age = age;
            this.placeOfBirth = placeOfBirth;
            this.location = location;
            this.siblings = siblings;
        }

        //Properties för subklassen Officer.
        public string TargetValue
        {
            get
            {
                return targetValue;
            }
            set
            {
                targetValue = value;
            }
        }




    }

    //Klassen Program som ska köra programmet.
    class Program
    {

        //Listor skapas i dessa fält.
        static List<Officer> listOfOfficers = new List<Officer>();
        static List<Officer> templistOfOfficers = new List<Officer>();


        static List<Rebel> listOfRebels = new List<Rebel>();
        static List<Rebel> tempListOfRebels = new List<Rebel>();

        

        static void Main(string[] args)
        {
            //UI inställningarna.
            Console.Title = "SKYNET";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Green;

            //Listorna populeras här.
            listOfOfficers = CreateOfficerList(templistOfOfficers);
            listOfRebels = CreateRebelList(tempListOfRebels);


            bool programActive = true;
            bool menuActive = true;

            //Do-while loop som startar hela programmet samt håller igång det.
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



            while (menuActive)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Skynet!");
                Console.WriteLine("What is your command?");
                Console.WriteLine("1. Get list of active rebels in Operation Bästkusten");
                Console.WriteLine("2. Get list of active officers in Operation Bästkusten");
                Console.WriteLine("3. Get valuable intel about known Rebels and Officers");
                Console.WriteLine("4. Remove rebel or high valued target from target list");
                Console.WriteLine("5. Exit program");
                string userChoice = Console.ReadLine();
                

                switch(userChoice)
                {
                    case "1":

                        //Foreach loop som listar alla rebeller i den specifierade listan.
                        foreach(var rebel in listOfRebels)
                        {
                            Console.WriteLine($"Name: {rebel.Name}" +
                                $"\n");
                        }

                        //Här använder jag mig utav ReadKey för att inte programmet ska fortsätta rulla på. Utan att användaren har lite kontroll när det fortsätter.
                        Console.ReadKey();

                        //Denna fråga använder jag mig utav mer i programmet för att se om användaren vill avsluta efter sitt val eller gå tillbaka till menyvalen.
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
                            /*Environment.Exit gjorde det enkelt för mig att avsluta programmet vid detta val, då while loopen krånglade med att avslutas.
                             * */
                            Environment.Exit(0);
                            menuActive = false;
                        }

                        break;
                    case "2":

                        //Foreach loop som listar alla officers i den specifierade listan.
                        foreach (var officer in listOfOfficers)
                        {
                            Console.WriteLine($"Name: {officer.Name}" +
                                $"\n Value of Target: { officer.TargetValue}" +
                                $"\n");
                        }

                        Console.WriteLine("Do you want to return to root? Y/N");
                        rootChoice = Console.ReadLine();

                        if(rootChoice == "Y" || rootChoice == "y")
                        {
                            menuActive = true;
                        }
                        else if (rootChoice == "N" || rootChoice == "n")
                        {
                            Console.Clear();
                            Console.WriteLine("SKYNET wishes you a good day....Human...");
                            menuActive = false;
                        }
                        
                        break;
                    case "3":

                        //Detta valet listar båda listornas(rebeller och officers) innehåll samt de attributer/properties som de objekten har.
                        Console.WriteLine("------Officers-----" +
                            "\n ");

                        foreach (var officer in listOfOfficers)
                        {
                            Console.WriteLine($"Value of Target: {officer.TargetValue}" +
                                $"\n Name: {officer.Name}" +
                                $"\n Motivation: {officer.Motivation}" +
                                $"\n Height: {officer.Height}" +
                                $"\n Age: {officer.Age}" +
                                $"\n Location of birth: {officer.PlaceOfBirth}" +
                                $"\n Current Location: {officer.Location}" +
                                $"\n Known Siblings: {officer.Siblings}" +
                                $"\n");
                        }

                        Console.WriteLine("------Rebels-----" +
                            "\n ");

                        foreach (var rebel in listOfRebels)
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

                        Console.WriteLine("Do you want to return to root? Y/N");
                        rootChoice = Console.ReadLine();

                        if (rootChoice == "Y" || rootChoice == "y")
                        {
                            menuActive = true;
                        }
                        else if (rootChoice == "N" || rootChoice == "n")
                        {
                            Console.Clear();
                            Console.WriteLine("SKYNET wishes you a good day....Human...");
                            menuActive = false;
                        }
                        

                        break;
                    case "4":
                        //Det här valet hanterar borttagning av rebel eller officer.
                        Console.Clear();
                        Console.WriteLine("Have you eliminated a rebel or an officer?");
                        string targetChoice = Console.ReadLine();

                        //If sats som kollar om valet är Rebel eller Officer samt överensstämmer namnet användaren skriver in med den aktuella listan för att se om målet finns med.
                        if(targetChoice == "Rebel" || targetChoice == "rebel")
                        {
                            Console.WriteLine("Type in the name of the Rebel.");
                            string rebelName = Console.ReadLine();

                            for(int i = 0; i < listOfRebels.Count; i++)
                            {
                                //If-sats som checkar om namnet användaren skriver in finns med i listan. Om det finns med så tar den bort den rebellen där namnet överensstämmer.
                                if (listOfRebels[i].name == rebelName)
                                {
                                    Console.Clear();
                                    listOfRebels.RemoveAt(i);
                                    Console.WriteLine("Target has been removed. Well done!");
                                    Console.ReadKey();
                                    i = listOfRebels.Count;
                                    menuActive = true;
                                }
                                else if(listOfRebels[i].name != rebelName)
                                {
                                    Console.Clear();
                                    Console.WriteLine("Could not find the specified Rebel. Please try again.");
                                    Console.ReadKey();
                                    i = listOfRebels.Count;
                                    menuActive = true;
                                }
                                
                            }
                        //Samma som ovan fast för Officer och listOfOfficers.
                        }else if(targetChoice == "Officer" || targetChoice == "officer")
                        {
                            Console.WriteLine("Type in the name of the Officer.");
                            string officerName = Console.ReadLine();

                            for (int i = 0; i < listOfOfficers.Count; i++)
                            {

                                if (listOfRebels[i].name == officerName)
                                {
                                    listOfOfficers.RemoveAt(i);
                                    Console.Clear();
                                    Console.WriteLine("Target has been removed. Well done!");
                                    Console.ReadKey();
                                    menuActive = true;
                                }
                                else
                                {
                                    Console.Clear();
                                    Console.WriteLine("Could not find the specified Officer. Make sure you type the full name of the target.");
                                    Console.ReadKey();
                                    menuActive = true;
                                }
                            }
                        }

                        break;

                        //Sista valet där man avslutar programmet.
                    case "5":
                        Console.Clear();
                        Console.WriteLine("SKYNET wishes you a good day.... Human...");
                        menuActive = false;
                        break;
                        //Default som måste vara med i en switch-sats.
                    default:
                        Console.WriteLine("You have to choose one of the options provided 1-4.");
                        break;
                }

            }

        }

        //Metod som populerar listan av Officerare. Här skapar den objekt av klassen Officer och skriver in den information som klassen och basklassen(Rebel) behöver för att skapa objekten.
        static List<Officer> CreateOfficerList(List<Officer> x)
        {
            

            Officer Robin = new Officer("Robin 'The Shepard' Kamo", "High", "Destroy Skynet", "Unknown", "Unknown", "Unknown", "Göteborg", "Unknown");
            Officer BjörnB = new Officer("Björn 'The Right Hand Man' Bergquist", "Medium", "Destroy Skynet", "Unknown", "Unknown", "Unknown", "Göteborg", "Unknown");
            Officer BjörnS = new Officer("Björn 'The Educator' Strömberg", "Medium", "Destroy Skynet", "Unknown", "Unknown", "Unknown", "Göteborg", "Unknown");

            x = new List<Officer>() { Robin, BjörnB, BjörnS };

            return x;
        }

        //Metod som populerar listan av rebeller. Här skapar den objekt av klassen Rebel och skriver in den information som klassen behöver för att skapa objekten.
        static List<Rebel> CreateRebelList(List<Rebel> x)
        {
            Rebel David = new Rebel("David Ström", "Problem solving", "183", "32", "BJJ", "Tacos", "Blue", "Göteborg", "Norrtälje", "1");
            Rebel Johan = new Rebel("Johan Jangerud", "Safer Tomorrow", "194", "34", "Gaming", "Tacos", "Blue", "Mariefred", "Mariefred", "2");
            Rebel Oscar = new Rebel("Oscar Möller", "Work", "185", "26", "Football", "Lasagne", "Blue", "Stockholm", "Stockholm", "1");
            Rebel Sanjin = new Rebel("Sanjin Ajanic", "Work", "179", "30", "Football", "Pizza", "Blue", "Mostar", "Norrköping", "2");
            Rebel Jeremy = new Rebel("Jeremy", "Work", "181", "19", "Gaming", "Elkstew", "Teal", "Köln", "Djurö", "1");
            Rebel Cecilia = new Rebel("Cecilia", "Creativity", "163", "29", "The sims", "Risotto", "Yellow", "Norrköping", "Norrköping", "1");
            Rebel Ivo = new Rebel("Ivo Nazlic", "Creativity", "174", "42", "Photography", "Scampi", "Black", "Split", "Uppsala", "1");

            x = new List<Rebel>() { David, Johan, Oscar, Sanjin, Jeremy, Cecilia, Ivo };

            return x;
        }




    }
}
