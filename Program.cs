using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() => new[]{ 0 }.Select(InMethod).ToList();
    static int InMethod(in int param) => param;
}