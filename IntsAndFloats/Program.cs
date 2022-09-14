// See https://aka.ms/new-console-template for more information
Console.WriteLine("Ints and Floats!");


void WorkWithIntegers()
{
    int a = 18;
    int b = 6;
    int c = a + b;
    Console.WriteLine(c);


    // subtraction
    c = a - b;
    Console.WriteLine(c);

    // multiplication
    c = a * b;
    Console.WriteLine(c);

    // division
    c = a / b;
    Console.WriteLine(c);
}

void Precision() {
    int a = 7;
    int b = 4;
    int c = 3;
    int d = (a + b) / c;
    int e = (a + b) % c;
    Console.WriteLine($"quotient: {d}");
    Console.WriteLine($"remainder: {e}");
}

void MinMax() {
    int max = int.MaxValue;
    int min = int.MinValue;
    Console.WriteLine($"The range of integers is {min} to {max}");
}

void Decimals() {
    double a = 1.0;
    double b = 3.0;
    Console.WriteLine(a / b);

    decimal c = 1.0M;
    decimal d = 3.0M;
    Console.WriteLine(c / d);
}

double AreaOfCircle(double radius) {
    return Math.Pow(radius,2)*Math.PI;
}

//WorkWithIntegers();
Precision();
MinMax();
Decimals();
double radius = 2.5;
double res = AreaOfCircle(radius);
Console.WriteLine($"Area of Circle radius {radius} is {res}");