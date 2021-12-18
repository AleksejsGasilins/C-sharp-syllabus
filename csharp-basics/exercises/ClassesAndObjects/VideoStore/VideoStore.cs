using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class VideoStore
    {
        private List<Video> _videos = new List<Video>();

        public void AddVideo(Video video)
        {
            
            _videos.Add(video);
        }
        
        public List<Video> GetAll()
        {
            if ((_videos != null))
            {
                return _videos;
            }

            return new List<Video>();
        }

        public Video GetVideoByIndex(int index)
        {
            if (_videos != null && _videos.ElementAtOrDefault(index) != null)
            {
                return _videos[index];
            }

            return null;
        }

        public void checkOut(int index)
        {
            var video = GetVideoByIndex(index);
            if (video != null && !video.getFlag())
            {
                video.SetFlag(true);
                Console.WriteLine("Great choice");
            }
            else if (video != null && video.getFlag())
            {
                Console.WriteLine("Sorry, video is checked out");
            }
            else
            {
                Console.WriteLine($"Video with {index} id don't exist");
            }
        }

        public void ReturnVideo(int index)
        {
            var video = GetVideoByIndex(index);

            if (video != null && video.getFlag())
            {
                video.SetFlag(false);
                setRating(video);
            }
            else if (video != null && !video.getFlag())
            {
                Console.WriteLine($"You don't have the video with {index} id");
            }
            else
            {
                Console.WriteLine($"Video with {index} id don't exist");
            }
        }

        private bool setRating(Video video)
        {
            while (true)
            {
                Console.WriteLine("Rate the video from 0 to 10: ");
                var rating = Convert.ToInt32(Console.ReadLine());

                if (rating > 10 || rating < 0)
                {
                    Console.WriteLine("Rating can be smallest than 0, or biggest than 10");
                }
                else
                {
                    video.SetRating(rating);
                    Console.WriteLine("Thanks for rent. See you soon !");
                    return false;
                }
            }
        }
    }
}
