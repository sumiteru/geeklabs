using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CharDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = new CharDiff("ABC", " BC").count();
            Console.WriteLine(count);
            Console.ReadLine();
        }
    }

    class CharDiff
    {
        private string _str1;
        private string _str2;
        public CharDiff(string str1, string str2)
        {
            this._str1 = str1;
            this._str2 = str2;
        }
        public int count()
        {
            int result = 0;
            for (int i = 0; i < _str1.Length && i < _str2.Length; i++)
                if (!_str1[i].Equals(_str2[i]))
                    result++;

            result += Math.Abs(_str1.Length - _str2.Length);

            return result;
        }
    }
}
