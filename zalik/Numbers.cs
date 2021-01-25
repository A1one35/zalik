using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalik
{
    class Numbers : Strings
    {
        public Numbers(string str ) : base()
        {
            try
            {
                int n = int.Parse(str);
                this.str = new StringBuilder(n.ToString());
            }
            catch (Exception exp)
            {
                Console.WriteLine("не є числом");
                this.str = new StringBuilder("");

            }
        }

        public override int CountLenght()
        {
            return str.Length;
        }

        public override void edit(string s)
        {
            char[] arr = s.ToCharArray();
            bool point = false;
            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsLetter(arr[i]))
                {
                    throw new Exception("буква");
                }
                else
                {
                    point = true;
                }
            }
            if (point)
            {
                this.str.Append(s);
            }
        }
        public void Up()
        {
            int n = 2 * int.Parse(this.str.ToString());
            this.str.Remove(0, str.Lenght);
            this.str.Append(n.ToString());
        }
        

        public override string ToString()
        {
            return this.str.ToString();
        }
        
    }
}
