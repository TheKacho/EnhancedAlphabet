using System;
using System.Text;

namespace EnhancedAlphabet
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(CreateAlphabet());
            Console.WriteLine(CreateAlphabet().ToLower()); // creates a lower case version of the alphabet
            
            string reverse = CreateAlphabetReverse(); // this will store the values as a string
            Console.WriteLine(reverse); // as the console will print the string

            Console.Write("How many letters would you like to jump: ");
            string userInput = Console.ReadLine(); //string userInput will take user input and stores it
            int numberToJump = int.Parse(userInput); //this will convert the int to a string value
            string jumpUp = CreateAlphabetJump(numberToJump);
            Console.WriteLine(jumpUp);
            


            //string jumpUp = CreateAlphabetJump(2); // this is here for readability purposes does the same thing as the line above



        }

        static string CreateAlphabet() //TODO replace void with STRING, while making method Print to CREATE
        {
            StringBuilder alphabet = new StringBuilder(); // can also use StringBuilder method
            for (char alpha = 'A'; alpha <= 'Z'; alpha++)
            {
                alphabet.Append(alpha); // alphabet += alpha is normal, but can also use alphabet.Append(alpha) for stringbuilder
            }
            return alphabet.ToString(); // this will convert it to
            

        }

        static string CreateAlphabetReverse() // the data is still stored under void, but will return nothing
                                              // String clarifies what the output is, as it is CREATED
        {
            string alphabetReverse = "";
            for (char alpha = 'Z'; alpha >= 'A'; alpha--)
            {
                alphabetReverse += alpha;
            }
            return alphabetReverse;
            
        }

        static string CreateAlphabetJump(int jump)
        {
            string alphabetJump = "";
            for (char alpha = 'A'; alpha <= 'Z';) //can use alpha++, alpha++ or alpha = (char)(alpha +2) for same process
            {
                alphabetJump += alpha;

                for(int i = 1; i <= jump; i++) // this is a nested loop
                {
                    alpha++;
                }
            }
            return alphabetJump;
            

        }
    }
}
