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

            if (path2[0] == pathSeparator)
            {
                path2 = path2.Substring(1, path2.Length - 1);
            }

            if (path1[path1.Length - 1] != pathSeparator)
            {
                return path1 + pathSeparator + path2;
            }

            return path1 + path2;
        }

        public static string Combine(string path, params string[] paths)
        {
            if (path == null)
            {
                throw new ArgumentNullException("path");
            }

            if (paths == null)
            {
                throw new ArgumentNullException("paths");
            }

            var result = path;

            foreach (var p in paths)
            {
                result = Combine(result, p);
            }

            return result;
        }
    }
}
