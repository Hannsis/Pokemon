namespace Pokemon
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*
            Start
            wild pokemon appeared
            attack or block
            random number generator
            attack - switch 
             
             */

            string användarensVal = "";
            
            Console.WriteLine("Pick a move, or run away");

            // Visa menyn om och om igen så länge användaren inte väljer "3"
            //byta till switch
            while (användarensVal != "5")
            {
                // Tom rad för tydlighetens skull
                Console.WriteLine();

                Console.WriteLine("Vilken attack vill du välja?");
                Console.WriteLine("1. TACKLE");
                Console.WriteLine("2. BUBBLE");
                Console.WriteLine("3. WATERGUN");
                Console.WriteLine("4. TAIL WHIP");
                Console.WriteLine("5. RUN (Avsluta programmet)");


                användarensVal = Console.ReadLine();

                // Utför det val som användaren ville göra
                switch (användarensVal)
                {
                    case "1":
                        Console.WriteLine("Squirtle used TACKLE");
                        
                        break;

                    case "2":
                        Console.WriteLine("Squirtle used BUBBLE");

                        break;

                    case "3":
                        Console.WriteLine("Squirtle used WATERGUN");

                        break;

                    case "4":
                        Console.WriteLine("Squirtle used TAILWHIP");

                        break;

                    case "5":
                        Console.WriteLine("You have run away");
                        break;

                    default:
                        Console.WriteLine("Du valde inte ett giltigt alternativ.");
                        break;
                }
            }



        }
    }
}