using System.IO;

namespace Common.Extentions
{
    public static class Database
    {
        public static string GetPath()
        {
            string path = Directory.GetCurrentDirectory();
            for (int i = 0; i < 3; i++)
            {
                path = Directory.GetParent(path).FullName;
            }
            return path;
        }
    }
}
