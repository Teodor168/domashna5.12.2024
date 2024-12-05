namespace Palindrom
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a string: ");
            string word = Console.ReadLine();

            Stack<char> stack = new Stack<char>();

            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
            }

            bool isPalindrome = true;
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] != stack.Pop())
                {
                    isPalindrome = false;
                    break;
                }
            }
            if (isPalindrome==true)
            {
                Console.WriteLine("string is palindrome");
            }
            else
            {
                Console.WriteLine("string is not palindrome");
            }
        }
    }
}