using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineaTelefonica.Entities
{
    public class RandomNumber
    {
        public int getrandom()
        {
            Random random = new Random();
            int i = random.Next(900000000, 999999999);
            return i;
        }
    }
}
