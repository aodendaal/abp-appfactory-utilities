using HashidsNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Abp.AppFactory.Utilities
{
    public static class Hash
    {
        public static string Generate(string name, string salt)
        {
            var ids = name.Select(cha => Convert.ToInt32(cha)).ToArray();
            var hashIdGenerator = new Hashids(salt);
            return hashIdGenerator.Encode(ids);
        }
    }
}
