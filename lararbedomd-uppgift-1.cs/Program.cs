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

            }
        }






        // Alla metoder
        static void ShowMenu()
        {
            Console.WriteLine("1. Enter your name and age");
            Console.WriteLine("2. Show when you will turn 100");
            Console.WriteLine("3. Exit");
        }
    }
}
