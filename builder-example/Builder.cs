using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace builder_example
{

    public interface IRoof
    {
        string MakeRoof();
    }
    public class WoodRoof: IRoof
    {
        public string MakeRoof()
        {
            return "Roof from wood";
        }
    }
    public interface IBase
    {
        string MakeBase();
    }
    public class ConcreteBase: IBase {
        public string MakeBase()
        {
            return "Concrete Base";
        }
    }

    public abstract class Builder
    {
        public abstract void MakeRoof(IRoof roof);
        public abstract void MakeBase(IBase @base);
    }
    public class House
    {
        public string Roof { get; set; }
        public string Base { get; set; }
    }

    public class UniversalBuilder : Builder
    {
        private readonly House _house;
        public UniversalBuilder()
        {
            _house = new House();
        }
        public override void MakeBase(IBase @base)
        {
            _house.Base = @base.MakeBase();
        }

        public override void MakeRoof(IRoof roof)
        {
            _house.Roof = roof.MakeRoof();
        }
        public string GetResult()
        {
            return $"House with {_house.Roof} and {_house.Base}";
        }
    }
}
