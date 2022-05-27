static void Main(string[] args) {
int a, b; double c;
a = 12; b = 3; c = 3.0;
Console.WriteLine(a++ - b * c);
Console.WriteLine(a / b++ * c);
Console.WriteLine("{0}/{1} = {2:0.00}", a, c, a / c);
Console.WriteLine("{0}/{1} = {2:0.00}", a, b, a / b);
Console.WriteLine(((a + b) / b - a + c) / b);
}