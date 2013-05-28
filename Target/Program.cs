using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Shared;

namespace Target
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new FoobarFactory();
            Console.Out.WriteLine(factory.CreateFoobar());
        }
    }
}
