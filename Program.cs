namespace password_codecademy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minLength = 8;
            string uppercase = "QWERTYUIOPÅÄÖLKJHGFDSAZXCVBNM";
            string lowercase = "qwertyuiopåäölkjhgfdsazxcvbnm";
            string digits = "1234567890";
            string specialChars = "!#¤%&/()=?`^*_:;,.-'¨´+}][{€$£@§½";

            int score = 0;

            Console.Write("Choose a password: ");
            string password = Console.ReadLine();

            if (password.Length > minLength)
            {
                score++;
            }

            foreach (char c in password)
            {
                if (uppercase.Contains(c))
                {
                    score++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (lowercase.Contains(c))
                {
                    score++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (digits.Contains(c))
                {
                    score++;
                    break;
                }
            }
            foreach (char c in password)
            {
                if (specialChars.Contains(c))
                {
                    score++;
                    break;
                }
            }
            Console.WriteLine("Your passwordscore is " + score + ".");

            switch (score)
            {
                case 1:
                    Console.WriteLine("Worst password sercurity.");
                    break;
                case 2:
                    Console.WriteLine("Still not so good password.");
                    break;
                case 3:
                    Console.WriteLine("Good Password!");
                    break;
                case 4:
                    Console.WriteLine("Excellent passowrd!");
                    break;
                case 5:
                    {
                        Console.WriteLine("The password couldn't be better or more secure. ^^");
                        break;
                    }
                default:
                    Console.WriteLine("Du måste ju skriva något?");
                    break;
            }
        }
    }
}