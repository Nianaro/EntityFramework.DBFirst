using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework.DBFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDbEntities entities = new MyDbEntities();
            var items = entities.Names.ToList();
            foreach (var item in items) {
                Console.WriteLine("{0}. {1}", item.Id, item.Name1);
            }
        }
    }
}
