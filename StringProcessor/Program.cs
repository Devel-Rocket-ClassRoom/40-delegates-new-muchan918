using System;

Console.WriteLine("=== 문자열 가공기 ===");
Console.WriteLine();

string input = "Hello World";

Console.WriteLine($"원본: {input}");
Console.WriteLine();

Console.WriteLine("[대문자 변환]");
Console.WriteLine(ProcessAndPrint(input, ToUpperCase));
Console.WriteLine();

Console.WriteLine("[소문자 변환]");
Console.WriteLine(ProcessAndPrint(input, ToLowerCase));
Console.WriteLine();

Console.WriteLine("[괄호 추가]");
Console.WriteLine(ProcessAndPrint(input, AddBrackets));
Console.WriteLine();

Console.WriteLine("[문자열 뒤집기]");
Console.WriteLine(ProcessAndPrint(input, Reverse));

string ProcessAndPrint(string input, StringProcessor processor)
{
    return $"{processor(input)}";
}

string ToUpperCase(string s) => s.ToUpper();
string ToLowerCase(string s) => s.ToLower();
string AddBrackets(string s) => "[" + s + "]";
string Reverse(string s)
{
    char[] arr = s.ToCharArray();
    Array.Reverse(arr);
    return new string(arr);
}

delegate string StringProcessor(string s);