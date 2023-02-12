// 56. Написать программу копирования массива
System.Console.Write("Введите размер массива: ");
int N = int.Parse(Console.ReadLine());
int[] array = new int [N];
int[] array2 = new int[N];

createArray(array);
System.Console.Write("Старый массив: ");
printArray(array);
System.Console.WriteLine();
System.Console.Write("Новый массив: ");
cloneArray(ref array2, array);
printArray(array2);






void createArray(int [] arr)
{
    for(int i = 0;i < arr.Length;i++)
    {
        Random rand = new Random();
        arr[i] = rand.Next(1,11);
    }
}

void cloneArray(ref int [] arr2,int[] arr)
{
    int j = 0;
    for(int i = 0;i < arr.Length;i++)
    {
        arr2[i] = arr[j];
        j++;
    }
}

void printArray(int[] arr)
{
    for(int i = 0;i < arr.Length;i++)
    {
        System.Console.Write($"{arr[i]} ");
    }
}
