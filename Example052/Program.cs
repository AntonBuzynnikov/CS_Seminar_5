// 52. Перевести число из десятичной в двоичную
int N = int.Parse(Console.ReadLine());
while(N!=0)
{
    System.Console.Write(N%2);
    N/=2;
}
