using System;

Console.WriteLine("=== 문자열 처리 파이프라인 ===");
Console.WriteLine();

Console.WriteLine("--- 단계 1: 원본 출력만 ---");
Action<string> pipeline = PrintOriginal;
pipeline("Hello World");
Console.WriteLine();

Console.WriteLine("--- 단계 2: 대문자 추가 ---");
pipeline += PrintUpper;
pipeline("Hello World");
Console.WriteLine();

Console.WriteLine("--- 단계 3: 소문자, 길이 추가 ---");
pipeline += PrintLower;
pipeline += PrintLength;
pipeline("Hello World");
Console.WriteLine();

Console.WriteLine("--- 단계 4: 대문자 제거 ---");
pipeline -= PrintUpper;
pipeline("Hello World");


void PrintOriginal(string msg) => Console.WriteLine($"원본: {msg}");
void PrintUpper(string msg) => Console.WriteLine($"대문자: {msg.ToUpper()}");
void PrintLower(string msg) => Console.WriteLine($"소문자: {msg.ToLower()}");
void PrintLength(string msg) => Console.WriteLine($"길이: {msg.Length}");