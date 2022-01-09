using System;

namespace builder_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var woodRoof = new WoodRoof();
            var concrete = new ConcreteBase();
            var builder = new UniversalBuilder();
            builder.MakeBase(concrete);
            builder.MakeRoof(woodRoof);
            Console.WriteLine(builder.GetResult());
        }
    }
}
