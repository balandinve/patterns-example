using System;

namespace strategy_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var document = new DocumentParser();
            var xmlParser = new XmlParser();
            var excelParser = new ExcelParser();
            document.ParseDocument(xmlParser);
            document.ParseDocument(excelParser);
        }
    }
}
