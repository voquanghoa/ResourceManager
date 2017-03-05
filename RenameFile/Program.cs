using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace RenameFile
{
    class Program
    {
        static void Main(string[] args)
        {
            new Program().RenameFolder(@"Y:\project\english4all\app\src\main\assets");
        }

        private void RenameFolder(string path)
        {
            Directory.EnumerateDirectories(path).ToList().ForEach(RenameFolder);

            Directory.EnumerateFiles(path, "*.json").ToList().ForEach(RenameFile);
        }

        private void RenameFile(string path)
        {
            if (path.Contains("练习"))
            {
                var newPath = path.Replace("练习", "").Replace(".json","");
                if (!string.Equals(path, newPath))
                {
                    File.Move(path, newPath);
                }
            }
            
        }
    }
}
