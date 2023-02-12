// 54. С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

System.Console.Write("Введите число: ");
int N = int.Parse(Console.ReadLine());
int[] f = new int [N];

fibDigit(f);
printArray(f);







void fibDigit(int[] arr)
{
    int count = 0;
    System.Console.WriteLine("Введите первые два числа последовательности: ");
    for(int i = 0;i<2;i++)
    {
        arr[i] = int.Parse(Console.ReadLine());
        count++;
    }
    fib(arr, count);
}

void fib(int [] arr, int j)
{
    for(int i = j;i < arr.Length;i++)
    {
        arr[i] = arr[i-2]+arr[i-1];
    }
}

void printArray(int[] arr)
{
    for(int i = 0;i < arr.Length;i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
