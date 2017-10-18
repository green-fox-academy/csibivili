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
        public static List<string> GetDataInLines(string filePath)
        {
            var lines = File.ReadAllLines(filePath).ToList();
            return lines;
        }
    }
}
