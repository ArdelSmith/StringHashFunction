using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringHashFunction
{
    public interface IGeneratable
    {
        public string GenerateHash(string Key);
    }
}
