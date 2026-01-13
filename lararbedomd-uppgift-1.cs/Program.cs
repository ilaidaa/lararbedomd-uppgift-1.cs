namespace lararbedomd_uppgift_1.cs
{
    internal class Program
    {

        // Dessa variabler är static eftersom Main-metoden är static.
        // En static metod kan bara använda andra static variabler och metoder och sista metoden ska använda variablerna
        // Därför behöver namn och ålder vara static för att kunna användas i hela programmet.
        static string name = ""; // Tom variabel ska fyllas senare
        static int age = 0;


        static void Main(string[] args)
        {
            // Variabel som styr om programmet ska fortsätta köra
            bool running = true;


            // Menyn körs i en while-loop tills användaren väljer att avsluta
            while (running)
            {
                ShowMenu();

                // Läser in användarens menyval från metoden och konverterar till int
                int choice = int.Parse(Console.ReadLine());

                // Switch meny      
                switch (choice)
                {
                    case 1:
                        EnterNameAndAge();
                        break;
                    case 2:
                        ShowYearWhenTurning100();
                        break;
                    case 3:
                        Console.WriteLine("Programmet avslutas . . .");
                        Thread.Sleep(1000); // Paus så använfaren kan läsa meddelande
                        running = false;
                        break;
                    default:
                        Console.WriteLine("Ogiltig inmatning.");
                        break;

                }
            }
        }






        // Alla Metoder
        static void ShowMenu()
        {
            Console.WriteLine("1. Enter your name and age");
            Console.WriteLine("2. Show when you will turn 100");
            Console.WriteLine("3. Exit");

            Console.Write("\nYour choice: ");
        }


        // Metod 1
        static void EnterNameAndAge()
        {
            Console.Write("\nEnter name: ");
            name = Console.ReadLine();

            Console.Write("\nEnter age: ");
            age = int.Parse(Console.ReadLine());
        }


        // Metod 2
        static void ShowYearWhenTurning100()
        {
            // Kontrollerar att användaren har matat in namn och ålder
            if (name == "" || age == 0)
            {
                Console.WriteLine("You must enter name and age first.");
                return;
            }

            // Hämtar nuvarande år
            int currentYear = DateTime.Now.Year;

            // Räknar ut året då användaren fyller 100
            int yearTurning100 = currentYear + (100 - age);

            // Skriver ut resultatet
            Console.WriteLine($"{name}, you will turn 100 in the year {yearTurning100}.");

        }
    }
}
