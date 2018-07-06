using System;

namespace Abp.AppFactory.Utilities
{
    public static class UrlPath
    {
        private const char pathSeparator = '/';

        public static string Combine(string path1, string path2)
        {
            if (path1 == null)
            {
                throw new ArgumentNullException("path1");
            }

            if (path2 == null)
            {
                throw new ArgumentNullException("path2");
            }

            if (path1.Length == 0)
            {
                return path2;
            }

            if (path2.Length == 0)
            {
                return path1;
            }

            var p1end = path1[path1.Length - 1];
            if (p1end != pathSeparator)
            {
                return path1 + pathSeparator + path2;
            }

            return path1 + path2;
        }
    }
}
