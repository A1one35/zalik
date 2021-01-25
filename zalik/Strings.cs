using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalik
{
    abstract class Strings
    {
        protected StringBuilder str;

        public Strings(string str)
        {
            this.str = new StringBuilder(str);
        }

        public override string ToString()
        {
            return "Рядк" + " " + str;
        }

        public abstract int CountLenght();
        public abstract void edit(string s);
    }
}
