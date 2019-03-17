using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1_NETS319
{
    class M1NET_S319_EJ3
    {
        static void Main(string[] args)
        {
            var b = new D.B();
            Console.WriteLine(b.GetValue());
        }
    }
    public class D
    {
        private int value = 10;
        public class B : D
        {
            public int GetValue()
            {
                return this.value;
            }
        }
    }
    public class C : D.B
    {
        
         public int RetornarValores(){            
            return this.GetValue();
         }
        
    }

}
