static void Main(string[] args) {
int a, b; double c; string d;
a = 8;
b = 3;
c = 4.0;
d = "5";
Console.WriteLine("a = " + a + ", b = " + b);
Console.WriteLine("a / b = {0}", a / b);
Console.WriteLine("{0}{1}{0}{2}{0}{3}", a, b, c, d);
Console.WriteLine("{0} / {1} = {2:0.00}", a + c, b, (a + c) / b);
Console.WriteLine(a + c + (a + a) / b + c);
}