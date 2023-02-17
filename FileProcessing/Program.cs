// See https://aka.ms/new-console-template for more information
using System.ComponentModel;
using System.Data;

Console.WriteLine("Hello, World!");
InfoFill i = new();
i.insertFile();



public class InfoFill
{
    #region custom delegate with specific event type
    // public delegate void FileProcessedEventHandler(object sender, FileProcessedEventArgs e); // here custom delegate we can use it insted of EventHandler
    //public event FileProcessedEventHandler Fileprocessed;
    #endregion

    //public event EventHandler Fileprocessed; // Here take two arguments object and instence from evenargs
    public event EventHandler<FileProcessedEventArgs> Fileprocessed; // Here take two arguments object and instence from class Type here  FileProcessedEventArgs
    internal void OnFileProcessed(FileProcessedEventArgs e)
    {

        Fileprocessed?.Invoke(this, e);
    }
    internal void insertFile()
    {
        StartProcess s = new StartProcess(new InfoFill());
        s.AddEventArgs();
        //Here Code for insert File 
        FinshedProcess f = new FinshedProcess(new InfoFill());
        f.AddEventArgs();

    }
}



public class FileProcessedEventArgs : EventArgs
{
    public string FileName { get; set; }
    public DateTime ProcessedDate { get; set; }

    public FileProcessedEventArgs(string fileName, DateTime processedDate)
    {
        FileName = fileName;
        ProcessedDate = processedDate;
    }



}

public class FinshedProcess
{
    private readonly InfoFill _info;
    const string fileName = "file-Name";
    public FinshedProcess(InfoFill info)
    {
        _info = info;
    }
    private void finshed(object sender, FileProcessedEventArgs e)
    {
        Console.WriteLine($"The File {e.FileName} processed on {e.ProcessedDate:d} done ");
    }
    public void AddEventArgs()
    {

        _info.Fileprocessed += finshed;
        _info.OnFileProcessed(new FileProcessedEventArgs(fileName, DateTime.Now));
    }
}

public class StartProcess
{
    private readonly InfoFill _info;
    const string fileName = "file-Name";

    public StartProcess(InfoFill info)
    {
        _info = info;
    }
    private void start(object sender, FileProcessedEventArgs e)
    {
        Console.WriteLine($"the file ${e.FileName} start processing at ${e.ProcessedDate:d} ,please waite ");
    }

    public void AddEventArgs()
    {
        _info.Fileprocessed += start;
        _info.OnFileProcessed(new FileProcessedEventArgs(fileName, DateTime.Now));
    }
}