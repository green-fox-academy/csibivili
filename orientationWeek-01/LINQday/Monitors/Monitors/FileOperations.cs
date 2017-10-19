using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monitors
{
    public class FileOperations
    {
        public static string[] GetDataInLines(string filePath)
        {
            return File.ReadAllText(filePath).Split('\n');
        }
    }
}
