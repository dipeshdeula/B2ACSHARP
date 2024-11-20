using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.StaticClass
{
    public static class AppSettings
    {
        public static string APIBaseURL => "https://localhost:44300/api/";
        public static string ConnectionString => "Server=.;Database=fullStackOops;Trusted_Connection=True;";
    }
}
