using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVVMBaseGenerator.Prototype
{
    partial class ViewModelBase
    {
        public string DirName;
        public ViewModelBase(string dirName) { this.DirName = dirName; }
    }
}
