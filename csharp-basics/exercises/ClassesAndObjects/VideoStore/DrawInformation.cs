using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class DrawInformation
    {
        public static void DrawAllVideo(VideoStore videoStore)
        {
            var videos = videoStore.GetAll();

            for (int i = 0; i < videos.Count; i++)
            {
                Console.WriteLine($"{i} {videos[i].GetTitle()} |{videos[i].GetRating()}| {videos[i].VidoChecked()}.");
            }
        }

        public static void DrawVideosOnTheShelves(VideoStore videoStore)
        {
            var videos = videoStore.GetAll();

            for (int i = 0; i < videos.Count; i++)
            {
                if (!videos[i].GetFlag())
                {
                    Console.WriteLine($"{i} {videos[i].GetTitle()} |{videos[i].GetRating()}| {videos[i].VidoChecked()}.");
                }
            }
        }

        public static void DrawCheckedOutVideos(VideoStore videoStore)
        {
            var videos = videoStore.GetAll();

            for (int i = 0; i < videos.Count; i++)
            {
                if (videos[i].GetFlag())
                {
                    Console.WriteLine($"{i} {videos[i].GetTitle()} |{videos[i].GetRating()}| {videos[i].VidoChecked()}.");
                }
            }
        }
    }
}
