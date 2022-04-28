using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JakmRunCounter
{
    public static class UsedProfile
    {
        private static string _globalVar = "";

        public static string usedProfile
        {
            get { return _globalVar; }
            set { _globalVar = value; }
        }
    }
}
