static void Main(string[] args) {
int x = -8;
int y = 5;
double z = 5.0;
if (x > 0) Console.WriteLine(1);
if (x < 0 && y > 3) Console.WriteLine(2);
if (!(x < 0) && y > 3) Console.WriteLine(3);
if (!(x > 0 || y <= z)) Console.WriteLine(4);
if (!(!(x >= -8) && !(y <= 3))) Console.WriteLine(5);
}