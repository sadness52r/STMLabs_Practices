using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice7_ThreadsConsole
{
    internal record Config
    {
        public int Delay { get; set; }
        public int ItemsToLoad { get; set; }
    }
}
