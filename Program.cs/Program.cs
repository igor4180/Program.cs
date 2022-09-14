using System.Text;

namespace Lesson3CSharpPw111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Random random = new Random();
            int[] massive = new int[100];
            int[] unit = new int[21];
            int countOne = 0, countTwo = 0;
            int countUnit = 0;
            for (int i = 0; i < massive.Length; i++)
            {
                massive[i] = random.Next(20);
            }
            for (int i = 0; i < massive.Length; i++)
            {
                if (massive[i] % 2 == 0 || massive[i] == 0) { countOne++; }
                else { countTwo++; }
                Console.WriteLine(massive[i]);
            }
            for (int i = 0; i <= 20; i++)
            {
                foreach (int j in massive)
                {
                    if (i == j)
                    {
                        countUnit++;
                        if (countUnit > 1)
                        {
                            countUnit = 0;
                            unit[i] = 0;
                            break;
                        }
                        else
                        {
                            unit[i] = 1;
                        }
                    }
                }
            }
            Console.WriteLine("Количество четных элементов: {0}", countOne);
            Console.WriteLine("Количество нечетных элементов: {0}", countTwo);
            Console.WriteLine("Уникальные числа в массиве:");
            for (int i = 0; i <= 20; i++) { if (unit[i] == 1) { Console.WriteLine(i.ToString()); } }*/
            //

            //    Random random = new Random();
            //    int[] massive = new int[100];
            //    int counter = 0;
            //    for (int i = 0; i < massive.Length; i++)
            //    {
            //        massive[i] = random.Next(2000);
            //    }
            //    Console.WriteLine("Введите число от 0 до 1000. Будут показаны все элементы меньше вашего числа.");
            //    try
            //    {
            //        string number = Console.ReadLine();
            //        int z = int.Parse(number);
            //        for (int i = 0; i < massive.Length; i++)
            //        {
            //            if (massive[i] < z || massive[i] == 0)
            //            {
            //                counter++;
            //                Console.WriteLine("Чисел меньше {0} найдено {1} штук", z, counter);
            //            }
            //        }
            //    }
            //    catch (Exception)
            //    {
            //        Console.WriteLine("Только числа!");
            //    }
            //}



            int[] massive = new int[12] { 7, 6, 5, 3, 4, 7, 6, 5, 8, 7, 6, 5 };
            string numberText = "";
            int counter = 0;
            string searchText = "";
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < massive.Length; i++)
            {
                sb.Append(massive[i]);
            }
            numberText = sb.ToString();
            Console.WriteLine("Массив для поиска числового вхождения: \n" + numberText);
            searchText = Console.ReadLine();
            for (int i = 0; i < numberText.Length; i++)
            {

                if (numberText.Contains(searchText))
                {
                    int indexContain = numberText.IndexOf(searchText);
                    counter++;
                    numberText.Remove(0, indexContain + 1);
                }
                else
                {
                    Console.WriteLine("Число не обнаружено");
                    break;
                }
                Console.WriteLine("Искомая подстрока найдена {0} раз(а)", counter);
            }
        }
    }
}
        