using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dbFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            using (TESTEntities db = new TESTEntities())
            {
                var users = db.Users;
                foreach (User u in users)
                    Console.WriteLine("{0}.{1} - {2}", u.ID, u.Name, u.Age);
            }
        }
    }
}
