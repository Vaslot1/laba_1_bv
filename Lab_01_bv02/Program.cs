namespace Lab_01_bv02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var result = new Result();
            result = Result.Minmax(Interface.New_array());
            Console.WriteLine(Logic.Min_Max(result));
        }
    }
   public class Logic
    {
        public static String Min_Max(Result result)
        {
            string s = "";
            if (result.max_1 != result.min_1 && result.max_2 != result.min_2 && result.max_1 != result.min_2 && result.max_2 != result.min_1)
            {
                s = "Первый минимум = " + result.min_1 + " Второй минимум = " + result.min_2 + " Первый максимум = " + result.max_1 + " Второй максимум = " + result.max_2;
            }
            else if (result.max_1 != result.min_1)
            {
                s = "Минимум = " + result.min_1 + " Максимум = " + result.max_1;
            }
            else
            {
                s = "Все элементы одинаковые";
            }
            return s;
        }
    }
    class Interface
    {
        public static float[] New_array()
        {
            Console.WriteLine("Введите длину последовательности чисел");
            int amount = int.Parse(Console.ReadLine());
            while (amount <= 0)
            {
                Console.WriteLine("Ошибка");
                Console.WriteLine("Введите длину последовательности чисел");
                amount = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Введите последовательность чисел");
            float[] arr = new float[amount];
            for (int i = 0; i < amount; i++)
            {
                arr[i] = float.Parse(Console.ReadLine());
            }
            return arr;
        }
    }
    public class Result
    {
        public float max_1;
        public float max_2;
        public float min_1;
        public float min_2;
        public static Result Minmax(float[] arr)
        {
            float _max_1 = -99999999;
            float _max_2 = -99999999;
            float _min_1 = 99999999;
            float _min_2 = 99999999;
            int number = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > _max_1)
                {
                    _max_1 = arr[i];
                    number = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > _max_2 && i != number)
                {
                    _max_2 = arr[i];
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < _min_1)
                {
                    _min_1 = arr[i];
                    number = i;
                }
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < _min_2 && i != number)
                {
                    _min_2 = arr[i];
                }
            }
            return new Result { max_1 = _max_1, max_2 = _max_2, min_1 = _min_1, min_2 = _min_2 };
        }
    }
}