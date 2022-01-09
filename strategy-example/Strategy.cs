using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace strategy_example
{
    public interface IParser
    {
        void Parse();
    }
    public class XmlParser: IParser
    {
        public void Parse()
        {
            Console.WriteLine("Xml parser");
        }
    }
    public class ExcelParser : IParser
    {
        public void Parse()
        {
            Console.WriteLine("Excel parser");
        }
    }
    public class DocumentParser
    {
        public void ParseDocument(IParser parser)
        {
            parser.Parse();
        }
    }
}
