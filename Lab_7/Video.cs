namespace Lab_7;

public class Video : File
{
    public int Width { get; }
    public int Height { get; }
    public int FrameRate { get; }

    public Video(string name, string path, long size, int width, int height, int frameRate) : base(name, path, size)
    {
        Width = width;
        Height = height;
        FrameRate = frameRate;
    }

    //TODO: Уникальный метод

    public override string ToString()
    {
        return base.ToString() + $" {Width}x{Height} {FrameRate}";
    }
}