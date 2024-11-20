using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.StaticClass
{
    public static class Cache {
        private static readonly Dictionary <string,object> _data = new Dictionary<string, object>();

        public static void Add(string key, object value)
        {
            _data[key] = value;
        }
        public static object Get(string key) { 
            return _data.ContainsKey(key) ? _data[key] : null;
        }   
    }
}
