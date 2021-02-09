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
        public string IDPass { get; set; }

        public override bool Equals(object obj)
        {
            var password = obj as PasswordHash;
            if (password == null)
                return false;
            return Pass == password.Pass && IDPass == password.IDPass;
        }

        public override int GetHashCode()
        {
            int passHashCode = Pass?.GetHashCode() ?? 0;
            int idpassHashCode = IDPass?.GetHashCode() ?? 0;
            return passHashCode ^ idpassHashCode;
        }
               
    }
    class GetPass
    {
        Generator generator = new Generator();
        public void GetingStartGeneration()
        {
            var hashSet = new HashSet<PasswordHash>();
            for (int i = 0; i < 10000; i++)
            {
                var password = new PasswordHash() { Pass =generator.GenString(10), IDPass = generator.GenID(5) };
                hashSet.Add(password);
            }
                      
        }
        
    }
}
