using System;
using YouTube.Commands;
using YoutubeExplode;

namespace YouTube
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ссылку на видео на YouTube: ");
            string url = Console.ReadLine();

            var sender = new Sender();
            var receiver = new Receiver();

            sender.SetCommand(new GetInfoVideoCommand(receiver, url));
            sender.Run();

            sender.SetCommand(new DownloadVideoCommand(receiver, url));
            sender.Run();



        }
    }
}
