
namespace ConsoleInteraction
{
    public class Receive
    {
        public static int IntNumber()
        {
            bool validNumber = false;
            while (!validNumber)
            {
                validNumber = int.TryParse(Console.ReadLine(), out int number);
                if (validNumber)
                    return number;
                Console.WriteLine("Digite uma entrada válida");
            }

            return -1;
        }

        public static string NonNullString(string prompt)
        {
            string userInput;
            do
            {
                Console.Write(prompt);
                userInput = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(userInput));

            return userInput;
        }

        public static char NonNullChar(string prompt)
        {
            string userInput;
            do
            {
                Console.Write(prompt);
                userInput = Console.ReadLine();
            } while (!IsCharValid(userInput));

           return Convert.ToChar(userInput.ToUpper());
        }

        private static bool IsCharValid(string? userInput)
        {
            return !string.IsNullOrEmpty(userInput) && userInput.Length == 1;
        }
    }
}
