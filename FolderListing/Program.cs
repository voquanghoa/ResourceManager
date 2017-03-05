using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using CommonShared;
using Newtonsoft.Json;

namespace FolderListing
{
    class Program
    {
        static void Main(string[] args)
        {
            var dataPath = @"C:\Project\WebCraping\DwList\bin\Debug\Data";
            var folders = Directory.EnumerateDirectories(dataPath);

            var dataItem = new DataItem()
            {
                Children = folders.Select(Folder2DataItem).ToList()
            };

            File.WriteAllText(Path.Combine(Directory.GetCurrentDirectory(), "data.json"), JsonConvert.SerializeObject(dataItem));
        }

        private static DataItem Folder2DataItem(string path)
        {
            var dataItem = new DataItem();
            var lesson = JsonConvert.DeserializeObject<Lesson>(File.ReadAllText(Path.Combine(path, "lesson.json")));

            dataItem.FileName = Path.GetFileName(path);
            dataItem.Display = lesson.Title;

            return dataItem;
        }
    }
}
