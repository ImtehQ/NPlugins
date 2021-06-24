using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NPluginTest
{
    public static class Statics
    {
        public static T Last<T>(this List<T> list)
        {
            return list[list.Count - 1];
        }
    }
}
