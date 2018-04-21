using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Layered_Website_Plus_Wizards
{
    public static class String
    {
        public static string EscapeForSql(this string input)
        {
            return input.Replace("'", "''");
        }
    }
}
