using System;

Action driver = GoForward;
driver += GoLeft;
driver += GoRight;
driver();

static void GoForward() => Console.WriteLine("직진");
static void GoLeft() => Console.WriteLine("좌회전");
static void GoRight() => Console.WriteLine("우회전");

driver += delegate ()
{
    Console.WriteLine("익명 메서드 추가");
};
driver();