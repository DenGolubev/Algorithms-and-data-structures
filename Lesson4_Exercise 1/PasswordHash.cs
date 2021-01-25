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
        
        public override bool Equals(object obj)
        {
            var password = obj as PasswordHash;

            if (password == null)
                return false;

            return Pass == password.Pass;
        }

        public override int GetHashCode()
        {
            int PassHashCode = Pass?.GetHashCode() ?? 0;
            return PassHashCode;
        }

        public HashSet<string> GenStringstoHashSet()
        {
            var hashSet = new HashSet<string>();
            var pass =  generator.GenString(10);
            hashSet.Add(pass);
            return hashSet;
        }

    }
}
