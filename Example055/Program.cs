// 55. Написать программу масштабирования фигуры
// Тут для тех кто далеко улетел, чтобы задавались вершины фигуры списком (одной строкой)
// например: "(0,0) (2,0) (2,2) (0,2)"
// коэффициент масштабирования k задавался отдельно - 2 или 4 или 0.5
// В результате показать координаты, которые получатся.
// при k = 2 получаем "(0,0) (4,0) (4,4) (0,4)"
System.Console.WriteLine("Введите координаты вершин фигуры в таком виде\n(x1,y1) через пробел, например\n(1,1) (2,2) и т.д.");
string? coordinates = Console.ReadLine();
System.Console.Write("Введите коэффициент масштабирования: ");
double k = System.Convert.ToDouble(Console.ReadLine());

shapeScalling(coordinates,k);

void shapeScalling(string strAll, double K)
{
    char[] separators = new char[] { ' ', ',', '(', ')' };
    string[] subs = strAll.Split(separators, StringSplitOptions.RemoveEmptyEntries);
    double[] x = new double[subs.Length/2];
    double [] y = new double[subs.Length/2];
    int count = 0;
    int i = 0;
    int j = 0;
    foreach (string sub in subs)
    {
        if(count%2==0)
        {
            x[i] = System.Convert.ToDouble(sub);
            i++; 
        }
        else 
        {
            y[j] = System.Convert.ToDouble(sub);
            j++; 
        }
        count++;
    }
    printResult(x,y,K);
}
void printResult(double[] arr1,double[] arr2, double kf)
{
    System.Console.Write("Новые координаты вершин: ");
    for(int i = 0;i<arr1.Length;i++)
    {
        System.Console.Write($"({kf*arr1[i]};{kf*arr2[i]}) ");
    }
}