using System;


namespace CSV_Inegration
{
    public class CSVIntegratonService
    {
        private readonly IDisposable _disposable;

        public CSVIntegratonService()
        {
            _disposable = new DisposableResource();
        }

        public void Start(string WatchPath)
        {
            CSV_FolderWatch FldWatcher = new CSV_FolderWatch(WatchPath);
            FldWatcher.WatchFolder();
        }

        public void Stop()
        {
            _disposable.Dispose();
        }
    }

    public class DisposableResource : IDisposable
    {
        public DisposableResource()
        {
            Console.WriteLine("DisposableResource created.");
        }

        public void Dispose()
        {
            Console.WriteLine("DisposableResource disposed.");
        }
    }
}