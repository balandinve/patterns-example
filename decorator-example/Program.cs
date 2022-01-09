using System;

namespace decorator_example
{
    class Program
    {
        static void Main(string[] args)
        {
            var repo = new BaseRepository();
            var decRepo = new PersonRepository();
            var srv = new Service(repo);
            var decSrv = new Service(decRepo);
            srv.GetResult();
            decSrv.GetResult();

        }
    }
}
