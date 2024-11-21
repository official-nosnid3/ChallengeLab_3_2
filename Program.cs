namespace ChallengeLab_3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Challenge Lab 3.2
             * Sum digits in string
             * Given a string, write a method which returns sum 
             * of all digits in that string. Assume that string 
             * contains only single digits.
             * 
             * Expected input and output
             * SumDigitsInString("1q2w3e") → 6 SumDigitsInString("L0r3m.1p5um") → 9
             * SumDigitsInString("") → 0
             */

            Console.WriteLine("Sum Digits In String\n\n");
            Console.WriteLine("This program will add every individual digit into a total.");
            Console.Write("Enter a long number: ");
            string numbers = Console.ReadLine();

            if ( !double.TryParse( numbers, out _ ) )
                Console.WriteLine("\n\nOnly numbers are allowed.");
            else
            {
                // Run program
                int total = sumOfAllDigits(numbers);
                Console.WriteLine($"\n\nThese numbers add up to: {total}");
                Console.ReadLine();
            };
        }

        static int sumOfAllDigits(string Numbers_)
        {
            int total = 0;
            
            for (int i = 0; i < Numbers_.Length; i++)
            {
                total += Convert.ToInt32( Numbers_[i].ToString() );
            }
            return total;
        }
    }
}
