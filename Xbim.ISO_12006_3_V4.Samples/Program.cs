using System;
using System.Diagnostics;

namespace Xbim.ISO_12006_3_V4.Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            var w = Stopwatch.StartNew();

            ConstraintsExample.Run();
            Console.WriteLine($"Executed: {nameof(ConstraintsExample)}");

            ValuesExample.Run();
            Console.WriteLine($"Executed: {nameof(ValuesExample)}");

            SchemaMappingExample.Run();
            Console.WriteLine($"Executed: {nameof(SchemaMappingExample)}");

            ComplexUnitsExample.Run();
            Console.WriteLine($"Executed: {nameof(ComplexUnitsExample)}");

            w.Stop();
            Console.WriteLine($"Samples executed in {w.ElapsedMilliseconds}ms");
        }
    }
}
