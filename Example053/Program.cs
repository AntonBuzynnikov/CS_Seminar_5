// 53. Найти точку пересечения двух прямых заданных уравнением y = k1 * x + b1, y = k2 * x + b2, b1 k1 и b2 и k2 заданы
int k1 = 3;
int b1 = 5;
int b2 = 1;
int k2 = -3;
double x,y;
//y - y = k1*x + b1 - k2*x - b2
//0 = k1*x + b1 - k2*x - b2
//k2*x - k1*x = b1 - b2
//x(k2 - k1) = b1 - b2
x = (b1-b2)/(k2-k1);
y = k1 * x + b1;
System.Console.WriteLine($"Точка пересечения двух прямых x = {x}, y = {y}");
