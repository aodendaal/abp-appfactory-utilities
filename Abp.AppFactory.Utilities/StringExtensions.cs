using System;
using System.Collections.Generic;
using System.Text;

namespace Abp.AppFactory.Utilities
{
    public static class StringExtensions
    {
        public static byte[] ToByteArray(this string input)
        {
            var encoding = new UnicodeEncoding();
            var bytes = encoding.GetBytes(input);
            var uf16bytes = new List<byte>();
            for (int i = 0; i < bytes.Length; i++)
            {
                if (i % 2 == 0)
                {
                    uf16bytes.Add(bytes[i]);
                }
            }

            return uf16bytes.ToArray();
        }
    }
}
