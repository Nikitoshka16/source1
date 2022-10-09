using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject1
{
    public class Class1
    {
        string name;
        public Class1(string name)
        {
            this.name = name;

        }
        public void Print() => Console.WriteLine($"Name: {name}");
    }
}