using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decorator_example
{
    public class BaseRepository
    {
        public virtual List<int> List()
        {
            return new List<int> { 1, 2, 3 };
        }
        public virtual int GetSingle()
        {
            return 1;
        }
    }

    public class PersonRepository : BaseRepository
    {
        public override int GetSingle()
        {
            Console.WriteLine("Single");
            return base.GetSingle();
        }

        public override List<int> List()
        {
            Console.WriteLine("List");
            return base.List();
        }
    }

    public class Service
    {
        private BaseRepository _repo;

        public Service(BaseRepository repo)
        {
            _repo = repo;
        }
        public void GetSingle()
        {
            Console.WriteLine(_repo.GetSingle().ToString());
        }
        public void GetList()
        {
            Console.WriteLine(String.Join(',', _repo.List()));
        }

        public void GetResult()
        {
            GetSingle();
            GetList();
        }
    }

}
