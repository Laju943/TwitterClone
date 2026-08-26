using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwitterClone.Domain.Entities
{
    internal class Encapsulation
    {
        public void Test()
        {
            User user= new User();
            user.FirstName = "Laju";
            user.LastName = "Ahamed";
            Console.WriteLine(user.FirstName + " " + user.LastName);
        }
    }
}
