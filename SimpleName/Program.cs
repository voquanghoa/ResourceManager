using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleName
{
    class Program
    {

        static void Main(string[] args)
        {
            var dir = @"C:\Project\WebCraping\DwList\bin\Debug\Data";

            var folders = System.IO.Directory.EnumerateDirectories(dir);
            foreach (var folder in folders)
            {
                var newName = RemoveDiacritics(folder);
                if(!newName.Equals(folder))
                System.IO.Directory.Move(folder, newName);
            }
        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return ManualyReplace(stringBuilder.ToString().Normalize(NormalizationForm.FormC));
        }

        static string ManualyReplace(string text)
        {
            var origin = "ß";
            var next = "b";
            foreach (var c in origin)
            {
                text = text.Replace(c, next[origin.IndexOf(c)]);
            }
            return text;
        }
    }
}
