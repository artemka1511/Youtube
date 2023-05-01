using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Videos.Streams;

namespace YouTube.Commands
{
    class DownloadVideoCommand : AbstractCommand
    {
        private Receiver _receiver;

        private string _url;

        public DownloadVideoCommand(Receiver receiver, string url)
        {
            _receiver = receiver;
            _url = url;
        }

        public override void Run()
        {
            Console.WriteLine("Команда на скачивание видео отправлена");

            var youtube = new YoutubeClient();

            var streamManifest = youtube.Videos.Streams.GetManifestAsync(_url).Result;

            var streamInfo = streamManifest.GetMuxedStreams().GetWithHighestVideoQuality();

            youtube.Videos.Streams.DownloadAsync(streamInfo, $"video.{streamInfo.Container}").AsTask().Wait();

            Console.WriteLine("Загрузка видео успешно завершена");

            _receiver.Operation();
        }

        public override void Cancel()
        { }
    }
}
