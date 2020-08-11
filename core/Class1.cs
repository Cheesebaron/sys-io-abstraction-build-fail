using System;
using System.IO;
using System.IO.Abstractions;

namespace core
{
    public class Class1
    {
        public string Herp()
        {
            var file = new FileSystem();
            using var stream = file.File.OpenRead("herp");
            using var reader = new StreamReader(stream);
            var content = reader.ReadToEnd();
            return content;
        }
    }
}
