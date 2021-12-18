﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_4
{
    class Movie
    {
        public Movie(string title, string studio, string rating)
        {
            _title = title;
            _studio = studio;
            Rating = rating;
        }

        public Movie(string title, string studio)
        {
            _title = title;
            _studio = studio;
            Rating = "PG";
        }

        private string _title { get; set; }
        private string _studio { get; set; }
        public string Rating { get; private set; }

        public string Display()
        {
            return $"{_title} {_studio} {Rating}";
        }

        public override string ToString()
        {
            return $"{_title} {_studio} {Rating}";
        }
    }
}