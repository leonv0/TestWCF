using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSV_Inegration
{
    internal class CSV_FolderWatch
    {
        private FileSystemWatcher _watcher = new FileSystemWatcher();

        internal CSV_FolderWatch(string path)
        {
            _watcher = new FileSystemWatcher(path,@"*.csv");
        }
        internal void WatchFolder()
        {
            _watcher.NotifyFilter = NotifyFilters.LastAccess | NotifyFilters.LastWrite | NotifyFilters.FileName; 
            _watcher.Changed += new FileSystemEventHandler(OnChanged);
            _watcher.Changed += new FileSystemEventHandler(OnCreated);
            _watcher.EnableRaisingEvents = true;
        }

        private void OnChanged(object source, FileSystemEventArgs e)
        {
            //Copies file to another directory.
        }

        private void OnCreated(object sender, FileSystemEventArgs e)
        {
            DataSender ds = new DataSender(e.FullPath);
            ds.Send();
        }

        private void OnError(object sender, ErrorEventArgs e) =>
            PrintException(e.GetException());

        //for shot way print to console
        private void PrintException(Exception ex)
        {
            if (ex != null)
            {
                Console.WriteLine($"Message: {ex.Message}");
                Console.WriteLine("Stacktrace:");
                Console.WriteLine(ex.StackTrace);
                Console.WriteLine();
                PrintException(ex.InnerException);
            }
        }
        public void Dispose()
        {
            // avoiding resource leak
            _watcher.Changed -= OnChanged;
            this._watcher.Dispose();
        }

    }
}
