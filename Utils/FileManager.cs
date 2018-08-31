using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBaseGenerator.Utils
{
    static class FileManager
    {

        public static string GetNewestDirectory(string path)
        {
            Console.WriteLine(path);


            var arr = Directory.GetDirectories(path);

            var dtOld = new DateTime();
            var finalstr = string.Empty;

            foreach (string element in arr)
            {
                var dt = Directory.GetCreationTime(element);
                if (dtOld < dt)
                {
                    dtOld = dt;
                    finalstr = element;
                }
            }

            Console.WriteLine(finalstr);

            return finalstr;
        }

        public static string GetNewestDirectory()
        {
            var pathStr = Environment.CurrentDirectory;
            Console.WriteLine(pathStr);


            var arr = Directory.GetDirectories(pathStr);

            var dtOld = new DateTime();
            var finalstr = string.Empty;

            foreach (string element in arr)
            {
                var dt = Directory.GetCreationTime(element);
                if (dtOld < dt)
                {
                    dtOld = dt;
                    finalstr = element;
                }
            }

            Console.WriteLine(finalstr);

            return finalstr;
        }
    }
}
