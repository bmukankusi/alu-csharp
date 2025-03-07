using System;
using NUnitLite;

class Program
{
  static int Main(string[] args)
  {
    Console.WriteLine("Running NUnit Tests...");
    int result = new AutoRun().Execute(args);
    Console.WriteLine("Passed!");
    return result;
  }
}
