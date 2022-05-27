static void Main(string[] args) {
int a, b; double c;
a = 10; b = 3; c = 3.0;
Console.WriteLine(a++ + b * c);
Console.WriteLine(a % b++ * c);
Console.WriteLine("{0}/{1} = {2:0.00}", a, b, a / b);
Console.WriteLine("{0}/{1} = {2:0.00}", b, c, b / c);
Console.WriteLine(((a - b) / b - a + b) / c);
}