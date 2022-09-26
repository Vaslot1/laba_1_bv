namespace Lab_01_bv03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Запишите предложение");
            string text = Console.ReadLine();
            Console.WriteLine(Logic.Reverse_Str(text));
        }
    }
    public class Logic
    {
        public static String Reverse_Str(string text)
        {
            string reversed_Text = "";
            string[] words = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = words.Length - 1; i > -1; i--)
            {
                reversed_Text = reversed_Text + words[i] + " ";
            }
            reversed_Text = reversed_Text.Remove(reversed_Text.Length - 1);
            return reversed_Text;
        }
    }
}