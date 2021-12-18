using System;
using System.Collections.Generic;
using System.Linq;

namespace VideoStore
{
    class Video
    {
        private string _title;
        private List<float> _rating = new List<float>();
        private bool _flag = false;

        public Video(string title, float startRating)
        {
            _title = title;
            SetRating(startRating);
        }

        public void SetRating(float rating)
        {
            _rating.Add(rating);
        }

        public void SetFlag(bool flag)
        {
            _flag = flag;
        }

        public string getTitle()
        {
            return _title;
        }

        public string getRating()
        {
            return string.Format("{0:0.00}", (_rating.Sum(x => (x)) / _rating.Count));
        }

        public bool getFlag()
        {
            return _flag;
        }

        public string VidoChecked()
        {
            if (getFlag())
            {
                return "Checked out";
            }
            else
            {
                return "On the shelves";
            }
        }
    }
}
