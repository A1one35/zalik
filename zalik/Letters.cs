﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zalik
{
    class Letters : String
    {
        public Letters(string str) : base()
        {
            try
            {
                int n = int.Parse(str);
                this.str = new StringBuilder(n.ToString());
            }
            catch (Exception exp)
            {
                Console.WriteLine("не ");
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
                if (char.IsDigit(arr[i]))
                {
                    throw new Exception("число");
                }
                else
                {
                    point = true;
                }
            }
            if (point)
            {
                this.str.Remove(0, str.Lenght);
                this.str.Append(s);
            }
        }
        public void Revarse()
        {
            for (int i = str.Lenght; i < 0; i--)
            {
                str.Append(str[i]);
            }
        }
    }
}
