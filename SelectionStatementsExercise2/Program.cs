namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your favortie school subject?");
            string subject = (Console.ReadLine());
            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Math is cool");
                    break;
                case "science":
                    Console.WriteLine("Science is cool");
                    break;
                case "pe":
                    Console.WriteLine("P.E. is not my thing");
                    break;
                case "history":
                    Console.WriteLine("History is okay");
                    break;
                case "english":
                    Console.WriteLine("English is epic");
                    break;
                default:
                    Console.WriteLine("I don't know what that is.");
                    break; 
            }

        }
    }
}