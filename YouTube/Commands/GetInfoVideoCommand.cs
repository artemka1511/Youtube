using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;

namespace YouTube.Commands
{
    class GetInfoVideoCommand : AbstractCommand
    {
        private Receiver _receiver;

        private string _url;

        public GetInfoVideoCommand(Receiver receiver, string url)
        {
            _receiver = receiver;
            _url = url;
        }

        public override void Run()
        {
            Console.WriteLine("Команда на получение данных о видео отправлена");
            var youtube = new YoutubeClient();

            var video = youtube.Videos.GetAsync(_url).Result;
            Console.WriteLine($"Название видео: {video.Title}");
            Console.WriteLine($"Описание: {video.Description}");
            _receiver.Operation();
        }

        public override void Cancel() { }
    }
}
