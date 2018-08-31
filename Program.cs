using MVVMBaseGenerator.Utils;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBaseGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var dir = FileManager.GetNewestDirectory();
            WriteMVVM.Build(dir);
        }
    }
}
