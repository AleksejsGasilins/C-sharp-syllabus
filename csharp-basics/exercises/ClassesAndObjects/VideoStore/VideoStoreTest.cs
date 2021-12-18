using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    class VideoStoreTest
    {
        private VideoStore _videoStore;

        public VideoStoreTest(VideoStore videoStore)
        {
            _videoStore = videoStore;
            Tests();
        }

        private void Tests()
        {
            _videoStore.AddVideo(new Video("The Matrix", 2));
            _videoStore.AddVideo(new Video("Godfather ", 1));
            _videoStore.AddVideo(new Video("Star Wars Episode IV: A New Hope", 10));

            DrawInformation.DrawAllVideo(_videoStore);
            _videoStore.checkOut(0);
            DrawInformation.DrawAllVideo(_videoStore);
            _videoStore.ReturnVideo(0);
            DrawInformation.DrawAllVideo(_videoStore);

        }

    }
}
