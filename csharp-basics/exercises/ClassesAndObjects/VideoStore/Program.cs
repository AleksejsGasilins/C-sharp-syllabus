﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class Program
    {
        private const int _countOfMovies = 3;
        private static VideoStore _videoStore = new VideoStore();
        private static void Main(string[] args)
        {
            var testVideo = new VideoStoreTest(_videoStore);

            while (true)
            {
                Console.WriteLine("Choose the operation you want to perform ");
                Console.WriteLine("Choose 0 for EXIT");
                Console.WriteLine("Choose 1 to fill video store");
                Console.WriteLine("Choose 2 to rent video (as user)");
                Console.WriteLine("Choose 3 to return video (as user)");
                Console.WriteLine("Choose 4 to list inventory");

                int n = Convert.ToByte(Console.ReadLine());

                switch (n)
                {
                    case 0:
                        return;
                    case 1:
                        FillVideoStore();
                        break;
                    case 2:
                        RentVideo();
                        break;
                    case 3:
                        ReturnVideo();
                        break;
                    case 4:
                        ListInventory();
                        break;
                    default:
                        return;
                }
            }
        }

        private static void ListInventory()
        {
           DrawInformation.DrawAllVideo(_videoStore);
        }

        private static void FillVideoStore()
        {
            for (var i = 0; i < _countOfMovies; i++)
            {
                Console.WriteLine("Enter movie name");
                string movieName = Console.ReadLine();

                Console.WriteLine("Enter rating");
                int rating = Convert.ToInt16(Console.ReadLine());

                _videoStore.AddVideo(new Video(movieName, rating));
            }

            DrawInformation.DrawAllVideo(_videoStore);
        }

        private static void RentVideo()
        {
            Console.WriteLine("Enter index of video to rent");
            int indexMovie = Convert.ToInt32(Console.ReadLine());
            _videoStore.checkOut(indexMovie);
        }

        private static void ReturnVideo()
        {
            Console.WriteLine("Enter index of video to return");
            int indexMovie = Convert.ToInt32(Console.ReadLine());
            _videoStore.ReturnVideo(indexMovie);
        }
    }
}
