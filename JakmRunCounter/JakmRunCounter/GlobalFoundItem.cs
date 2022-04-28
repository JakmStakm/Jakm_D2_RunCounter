using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakmRunCounter
{
    class GlobalFoundItem
    {
        private static string _globalVar = "";

        private static Boolean _GrailOnly = false;

        public static string foundItem
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }

        public static Boolean isGrailOnly
        {
            get { return _GrailOnly; }
            set { _GrailOnly = value; }
        }
    }
}
