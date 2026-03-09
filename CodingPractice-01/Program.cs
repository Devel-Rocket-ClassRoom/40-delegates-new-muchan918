using System;
using System.Transactions;


SayDelegate sayPointer = new SayDelegate(Hello);

sayPointer();

sayPointer.Invoke();

static void Hello() => Console.WriteLine("Hello Delegate");

static void Hi() => Console.WriteLine("안녕하세요");
SayDelegate say = Hi;
say();

var hi = new SayDelegate(Hi);
hi();

static double GetArea(int r) => 3.14 * r * r;

GetAreaDelegate pointer = GetArea;

Console.WriteLine(pointer.Invoke(10));
Console.WriteLine(pointer(10));

MathOperation pow = Math.Pow;
double result = pow(2, 10);
Console.WriteLine(result);

Calculator calc = new Calculator();
Transformer t = calc.Multiply;
Console.WriteLine(t(5));

ProgressReporter reporter = WriteToConsole;
reporter += WriteToFile;

for (int i = 0; i <= 100; i += 25)
{
    reporter(i);
    Console.WriteLine();
}

static void WriteToConsole(int percent)
{
    Console.WriteLine($"진행률: {percent}%");
}

static void WriteToFile(int percent)
{
    Console.WriteLine($"[파일 기록] {percent}%");
}

RunnerCall(Go);
Console.WriteLine();
RunnerCall(Back);

static void Go() => Console.WriteLine("직진");
static void Back() => Console.WriteLine("후진");

static void RunnerCall(Runner runner)
{
    Console.WriteLine("=== 실행 시작 ===");
    runner();
    Console.WriteLine("=== 실행 종료 ===");
}

Action greet = () => Console.WriteLine("안녕하세요");
greet();

Action<string> print = (msg) => Console.WriteLine(msg);
print("Hello, Action");

Action<string, int> printRepeat = (msg, count) =>
{
    for (int i = 0; i < count; i++)
    {
        Console.WriteLine(msg);
    }
};
printRepeat("반복", 3);

Func<int> getNumber = () => 42;
Console.WriteLine(getNumber());

Func<int, int> square = (x) => x * x;
Console.WriteLine(square(5));

Func<int, int, int> add = (a, b) => a + b;
Console.WriteLine(add(3, 7));

Func<int, int, string> addToString = (a, b) => (a + b).ToString();
Console.WriteLine(addToString(3, 5));

Predicate<int> isEven = (x) => x % 2 == 0;
Predicate<int> isPositive = (x) => x > 0;

Console.WriteLine(isEven(4));
Console.WriteLine(isEven(7));
Console.WriteLine(isPositive(5));
Console.WriteLine(isPositive(-3));

SayDelegate say1 = delegate ()
{
    Console.WriteLine("반갑습니다");
};

say1();

delegate void SayDelegate();
delegate double GetAreaDelegate(int r);
delegate double MathOperation(double x, double y);
delegate int Transformer(int x);
delegate void ProgressReporter(int percent);
delegate void Runner();