using Lab_7;

namespace Lab_7
{
    static class Program
    {
        static void Main(string[] args)
        {
            Directory dir = new Directory();
            File f1 = new File("file1.txt", "C:\\", 132);
            File f2 = new File("file2.txt", "C:\\", 12);
            Audio audio1 = new Audio("a.mp3", "C:\\User\\", 12341, 142, 256, "mp3");
            Audio audio2 = new Audio("voice.ogg", "C:\\User\\", 5435, 15, 128, "ogg");
            Video video1 = new Video("new year 2024.mp4", "C:\\User\\Videos\\", 1123545, 1024, 756, 50);
            dir.AddFile(audio1);
            dir.AddFile(audio2);
            dir.AddFile(video1);
            dir.AddFile(f1);
            dir.AddFile(f2);

            foreach (File file in dir.Files)
            {
                Console.WriteLine(file);
            }
            
            Console.WriteLine($"Audio: {dir.AudioFilesCount} шт.\nVideo: {dir.VideoFilesCount} шт.");
        }
    }
}