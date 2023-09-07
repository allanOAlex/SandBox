using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace SandBox.Console
{
    internal static class AppExtensions
    {
        public static bool IsValidString(string input)
        {
            //string pattern = @"^\d(\.\d+)*$";
            string pattern = @"^\d+(\.\d+)*$";

            return Regex.IsMatch(input, pattern);

        }

        public static string PadVersionString(string version)
        {
            // Split the version string into parts
            string[] parts = version.Split('.');

            // Pad with zeros to ensure there are four parts
            while (parts.Length < 4)
            {
                version += ".0";
                parts = version.Split('.');
            }

            return version;
        }
    }
}
