namespace _2_3_Switch_Oppgave_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Hvilken dag er det i dag? Skriv inn et tall fra 1-7");

                string input = Console.ReadLine();

                try
                {
                    int whichDay = Convert.ToInt32(input);

                    switch (whichDay)
                    {
                        case 1:
                            Console.WriteLine("Det er mandag.");
                            break;
                        case 2:
                            Console.WriteLine("Det er tirsdag.");
                            break;
                        case 3:
                            Console.WriteLine("Det er onsdag.");
                            break;
                        case 4:
                            Console.WriteLine("Det er torsdag.");
                            break;
                        case 5:
                            Console.WriteLine("Det er fredag.");
                            break;
                        case 6:
                            Console.WriteLine("Det er lørdag.");
                            break;
                        case 7:
                            Console.WriteLine("Det er søndag.");
                            break;
                        default:
                            Console.WriteLine("Ugyldig tall. Vennligst velg tall på nytt.");
                            break;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Dette er ikke et tall. Skriv inn et tall.");
                }
            }
        }
    }
}