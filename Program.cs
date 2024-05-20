using System.Collections;


namespace CSharp_L7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point3D point = new Point3D(3, 4, 2);
            Console.WriteLine(point.ToString());



            /*
            Dictionary<string, string> RusToEng = new Dictionary<string, string>()
            {
                {"Россия", "Russia" },
                {"США", "USA" },
                {"Франция", "France" }
            };

            Dictionary<string, string> EngToRus = new Dictionary<string, string>()
            {
                { "Russia", "Россия" },
                { "USA", "США" },
                { "France", "Франция" }
            };
            Console.WriteLine("Выберите направление перевода: ");
            Console.WriteLine("1. Английский -> Русский ");
            Console.WriteLine("2. Русский -> Английский ");
            int choice = int.Parse(Console.ReadLine());

            if (choice == 1)
            {
                Console.WriteLine("Введите слово на английском: ");
                string word = Console.ReadLine();

                if (EngToRus.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на русский: {EngToRus[word]}");
                }
                else
                    Console.WriteLine("Перевод не найден");

            }

            else if (choice == 2)
            {
                Console.WriteLine("Введите слово на русском: ");
                string word = Console.ReadLine();

                if (RusToEng.ContainsKey(word))
                {
                    Console.WriteLine($"Перевод на английский: {RusToEng[word]}");
                }
                else
                    Console.WriteLine("Перевод не найден");

            }
            else Console.WriteLine("Нет такой команды");



            List<string> list = new List<string>();
            Stack<string> stack = new Stack<string>();
            Queue<string> strings = new Queue<string>();
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            ArrayList arrayList = new ArrayList();
            HashSet<string> keys = new HashSet<string>();

            list.Add("asd");
            list.Remove("asd");
            list.Contains("asd");
            list.Clear();
            int c = list.Count;
            keyValuePairs.Clear();
            int c2 = keyValuePairs.Count;
            keyValuePairs.Add(1, "Alice");
            keyValuePairs.Remove(1);
            keyValuePairs.ContainsKey(1);
            keys.Add("asd");
            keys.Remove("asd");
            keys.Contains("asd");
            keys.Clear();
            int c4 = keys.Count;
            */
        }
    }
}
