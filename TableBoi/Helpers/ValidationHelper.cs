using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TableBoi.Controllers.Helpers
{
    public static class ValidationHelper
    {
        public static bool ValidateName(string name, string descr)
        {
            if (name == null || descr == null)
            {
                return false;
            }

            if (String.IsNullOrEmpty(name) || String.IsNullOrEmpty(descr))
            {
                return false;
            }

            return !name.Contains('!');
        }
    }
}