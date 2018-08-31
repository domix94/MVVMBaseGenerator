using MVVMBaseGenerator.Prototype;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBaseGenerator.Utils
{
    class WriteMVVM
    {
        public static void Build(string path)
        {
            var temp = path.Split(Path.DirectorySeparatorChar);

            var dirName = string.Empty;
            if (temp.Length > 0)
            {
                dirName = temp[temp.Length - 1];
                path = Path.Combine(path, dirName);
                WriteActionCommand(path, dirName);
                WriteVMBaseCommand(path, dirName);
            }
        }

        private static void WriteActionCommand(string path, string dirName)
        {
            var tempPath = Path.Combine(path, "ActionCommand.cs");
            if (!File.Exists(tempPath))
            {
                using (StreamWriter sw = File.CreateText(tempPath))
                {
                    sw.Write( new ActionCommand(dirName).TransformText());
                }
            }
        }

        private static void WriteVMBaseCommand(string path, string dirName)
        {
            var tempPath = Path.Combine(path, "ViewModelBase.cs");
            if (!File.Exists(tempPath))
            {
                using (StreamWriter sw = File.CreateText(tempPath))
                {
                    sw.Write(new ViewModelBase(dirName).TransformText());
                }
            }
        }
    }
}
