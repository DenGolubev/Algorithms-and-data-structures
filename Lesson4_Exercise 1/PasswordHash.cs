using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_Exercise_1
{
    class PasswordHash
    {
        public string Pass { get; set; }
        Generator generator = new Generator();

        
        public HashSet<string> GenStringstoHashSet()
        {
            var hashSet = new HashSet<string>();
            
            for (int i = 0; i < 10000; i++)
            {
                var pass = generator.GenStringData(10);
                hashSet.Add(pass);
            }
            
            return hashSet;
        }

    }
}
