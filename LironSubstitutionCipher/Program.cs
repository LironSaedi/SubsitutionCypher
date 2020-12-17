using System;

namespace LironSubstitutionCipher
{
    class Program
    {

        static string ShuffleString(string input)
        {
            Random gen = new Random();
            char[] chrArray = input.ToCharArray();


            for (int i = 0; i < input.Length; i++)
            {
                int randIndex = gen.Next(i, input.Length);

                // swap whatever is at i with whatever is at randindex
                char temp = chrArray[i];
                chrArray[i] = chrArray[randIndex];
                chrArray[randIndex] = temp;
            }

            return new string(chrArray);
        }
        static void Main(string[] args)
        {
            string alphabet = "";
            for (char i = 'a'; i <= 'z'; i++)
            {
                alphabet += i;
            }

            string alphabetPermutation = ShuffleString(alphabet);
            Console.WriteLine(alphabet);
            Console.WriteLine(alphabetPermutation);

            string input = "karan";

            string output = Encrypt(alphabet, alphabetPermutation, input);

            Console.WriteLine(input);
            Console.WriteLine(output);
        }

        private static string Encrypt(string alphabet, string alphabetPermutation, string input)
        {
            string output = "";

            for (int i = 0; i < input.Length; i++)
            {
                char currentLetter = input[i];
                int indexInOriginal = alphabet.IndexOf(currentLetter);

                output += alphabetPermutation[indexInOriginal];
            }

            return output;
        }
    }
}
