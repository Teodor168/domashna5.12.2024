namespace ReverseIzrechenie
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Give a sentence: ");
            string[] sentence = Console.ReadLine().Split(" ").ToArray();
            Stack<string> stack = new Stack<string>();
            for (int i = 0; i < sentence.Length; i++)
            {
                stack.Push(sentence[i]);
            }
            Console.WriteLine($"count of words is {stack.Count}");
            Console.WriteLine(string.Join(" ", stack));



        }
    }
}
