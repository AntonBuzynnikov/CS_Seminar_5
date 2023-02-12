// 51. С клавиатуры вводится число N. Затем вводится N чисел.
// Определить сколько чисел, введённых с клавиатуры, больше 0

namespace GeekBrains
{
    namespace Introduction
    {
        class Task051
        {
            static void Main()
            {
                System.Console.Write("Введите количество чисел: ");
                int N = Int32.Parse(Console.ReadLine());
                int k = 0;
                System.Console.WriteLine("Введите числа: ");
                for(int i = 0; i<N;i++)
                {
                    int n = int.Parse(Console.ReadLine());
                    if (n>0) k++;
                }
                System.Console.WriteLine($"Количество чисел больше 0: {k}");
                //GeekBrains.Introduction.Task051.Main();
            }
        }
    }
}
