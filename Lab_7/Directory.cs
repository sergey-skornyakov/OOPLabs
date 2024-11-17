namespace Lab_7;

public class Directory
{
    private List<File> files;

    public List<File> Files => files;

    public Directory()
    {
        files = new List<File>();
    }

    public void AddFile(File file)
    {
        files.Add(file);
    }

    public int AudioFilesCount => files.Count(file => file.GetType() == typeof(Audio));
    public int VideoFilesCount => files.Count(file => file.GetType() == typeof(Video));
}