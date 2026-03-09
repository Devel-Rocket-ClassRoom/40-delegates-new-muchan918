using System;
using System.Security.Cryptography.X509Certificates;

Console.WriteLine("=== 사칙연산 대리자 ===");
Console.WriteLine();

MathOp pointer;
int a = 20;
int b = 4;

pointer = Add;
Console.WriteLine("[덧셈]");
Console.WriteLine($"{a} + {b} = {pointer(a, b)}");
Console.WriteLine();

pointer = Subtract;
Console.WriteLine("[뺄셈]");
Console.WriteLine($"{a} - {b} = {pointer(a, b)}");
Console.WriteLine();

pointer = Multiply;
Console.WriteLine("[곱셈]");
Console.WriteLine($"{a} * {b} = {pointer(a, b)}");
Console.WriteLine();

pointer = Divide;
Console.WriteLine("[나눗셈]");
Console.WriteLine($"{a} / {b} = {pointer(a, b)}");

static int Add(int a, int b) => a + b;
static int Subtract(int a, int b) => a - b;
static int Multiply(int a, int b) => a * b;
static int Divide(int a, int b) => a / b;

delegate int MathOp(int a, int b);