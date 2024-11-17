namespace Lab_7;

public class File
{
    protected string? Name { get; }
    protected string? Path { get; }
    protected long Size { get; }
    protected DateTime CreationDate { get; }

    public File(string name, string path, long size)
    {
        Name = name;
        Path = path;
        Size = size;
        CreationDate = DateTime.Now;
    }

    public override string ToString()
    {
        return $"{Path} {Name} {Size} {CreationDate}";
    }
}