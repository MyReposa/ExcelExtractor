using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExcelExtractor
{
    public class TranslationItem
    {
        public string worksheetName;
        public int row;
        public int column;
        public string sourceText;
        public string translatedText;
    }
}
