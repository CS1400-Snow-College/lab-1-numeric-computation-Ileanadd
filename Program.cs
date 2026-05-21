// Lab 01
WorkWithIntegers();
OrderPrecedence();
WorkWithDoubles();
WorkWithDecimals();

// Tutorial 1
void WorkWithIntegers()
{
    Console.WriteLine("Explore integers math");

    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);

    // substraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

// Tutorial 2
void OrderPrecedence ()
{
    Console.WriteLine("Explore order of operations");

    int a = 5;
    int b = 4;
    int c = 2;
    int d = a + b * c;
    Console.WriteLine(d);

    d = (a + b) * c;
    Console.WriteLine(d);

    d = (a + b) - 6 * c + (12 * 4) / 3 + 12;
    Console.WriteLine(d);

    int e = 7;
    int f = 4;
    int g = 3;
    int h = (e + f) / g;
    Console.WriteLine(h);

    // Tutorial 3
    Console.WriteLine("Explore integer precision and limits");

    int aa = 7;
    int bb = 4;
    int cc = 3;
    int dd = (aa + bb) / cc;
    int ee = (aa + bb) % cc;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");

    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");

    int what = max + 3;
    Console.WriteLine($"An example of overflow: {what}");
}

// Tutorial 4
void WorkWithDoubles()
{
    Console.WriteLine("Work with the double type");
    double a = 5;
    double b = 4;
    double c = 2;
    double d = (a + b) / c;
    Console.WriteLine(d);

    double aa = 19;
    double bb = 23;
    double cc = 8;
    double dd = (aa + bb) / cc;
    Console.WriteLine(dd);

    double max = double.MaxValue;
    double min = double.MinValue;
    Console.WriteLine($"The range of double is {min} to {max}");

    double third = 1.0 / 3.0;
    Console.WriteLine(third);

    // Challenge
    Console.WriteLine("Challenge");

    double x = 205;
    double y = 23;
    double z = 17;
    double g = (x - z) / y;
    Console.WriteLine(g);

    g = (y * z) / x;
    Console.WriteLine(g);

    double xx = .4;
    double yy = 2.8;
    double zz = 12.7;
    double gg = (zz + xx) * yy;
    Console.WriteLine(gg);

    gg = xx * yy;
    Console.WriteLine(gg);

    gg = zz / xx;
    Console.WriteLine(gg);
}

// Tutorial 5
void WorkWithDecimals()
{
    Console.WriteLine("Work with decimal types");

    decimal min = decimal.MinValue;
    decimal max = decimal.MaxValue;
    Console.WriteLine($"The range of the decimal type is {min} to {max}");

    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);

    // Challenge
    Console.WriteLine("Challenge");

    double r = 2.50;
    double area = Math.PI * r * r;
    Console.WriteLine($"The area of the circle is: {area}");
}