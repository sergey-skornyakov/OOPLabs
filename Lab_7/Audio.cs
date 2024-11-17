namespace Lab_7;

public class Audio : File
{
    public int Duration { get; }
    public int BitRate { get; }
    public string Format { get; }

    public Audio(string name, string path, long size, int duration, int bitRate, string format)
        : base(name, path, size)
    {
        Duration = duration;
        BitRate = bitRate;
        Format = format;
    }

    //TODO: Уникальный метод

    public override string ToString()
    {
        return base.ToString() + $" {Duration} {BitRate} {Format}";
    }

}