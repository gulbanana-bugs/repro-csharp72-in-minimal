using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main() => new[]{ "" }.Select(InMethod).ToList();
    static string InMethod(in string param) => param;
}