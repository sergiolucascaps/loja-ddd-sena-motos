using System.Threading;

namespace SM.UI.Mvc.Classes
{
    public class Util
    {
        public static string SaveTxtFileOnServer(string path, string valor)
        {
            ReaderWriterLockSlim _lock = new ReaderWriterLockSlim();
            _lock.EnterWriteLock();
            try
            {

                System.IO.FileInfo file = new System.IO.FileInfo(path);
                file.Directory.Create();
                System.IO.File.WriteAllText(file.FullName, valor);

                return file.FullName;
            }
            finally
            {
                _lock.ExitWriteLock();
            }
        }

        public static string ReadFileOnServer(string caminho)
        {
            if (System.IO.File.Exists(caminho))
                return System.IO.File.ReadAllText(caminho);
            else
                return string.Empty;
        }
    }
}