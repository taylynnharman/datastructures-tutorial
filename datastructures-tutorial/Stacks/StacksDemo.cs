namespace datastructures_tutorial.Stacks;

public class StacksDemo
{
        public static void Run()
        {
            Console.WriteLine(IsPalindrome("racecar"));// True
            Console.WriteLine(IsPalindrome("taco cat")); // False
            Console.WriteLine(IsPalindrome("Madam, I'm Adam")); // False
            Console.WriteLine(IsPalindrome("hashtag")); // False
            Console.WriteLine(IsPalindrome("madam")); // True
        }

        static string IsPalindrome(string phrase)
        {
            string inputString = phrase;

            string reversedString = ReverseStringUsingStack(inputString);

            
            if (inputString == reversedString)
            {
                return "True";
            }
            else
            {
                return $"False - Reversed String: {reversedString}";
            }
        }

        static string ReverseStringUsingStack(string input)
        {
            // Create a stack to store characters
            Stack<char> stack = new Stack<char>();

            // Push each character onto the stack
            foreach (char c in input)
            {
                stack.Push(c);
            }

            // Pop characters from the stack to reverse the string
            char[] reversedArray = new char[input.Length];
            for (int i = 0; i < input.Length; i++)
            {
                reversedArray[i] = stack.Pop();
            }

            // Create a new string from the reversed character array
            string reversedString = new string(reversedArray);

            return reversedString;
        }
    }