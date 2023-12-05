namespace ConsoleInteraction
{
    public class Receive
    {
        public static char Letter()
        {
            bool validLetter = false;
            while (!validLetter)
            {
                string txt = Console.ReadLine();

                validLetter = (txt.Length == 1) && Char.IsLetter(txt[0]);
                if (validLetter)
                    return txt.ToUpper()[0];
                Console.WriteLine("Digite uma entrada válida");
            }

            return '0';
        }

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
    }
}
