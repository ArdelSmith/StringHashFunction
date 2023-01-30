using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHashFunction
{
    public class HashGenerator : IGeneratable
    {
        public string? Password { get; set; }
        public string GenerateHash(string Key)
        {
            string result = "";
            string temp = CalculateDirection().ToString();
            for (int i = 1; i < Key.Length + 1; i++)
            {
                int d = i % temp.Length;
                char t = (char)((Key[i - 1] << (d % 128)) % 125);
                if (t > 32) result += (char)t;
                else result += (char)(t + 33);
                if (result.Length >= Password.Length << 2) break;
            }
            return result;
        }
        
        private string CalculateDirection()
        {
            string res = "";
            if (this.Password != null) foreach (var e in Password) res += (char)(e << 1);
            return res;
        }
    }
}
