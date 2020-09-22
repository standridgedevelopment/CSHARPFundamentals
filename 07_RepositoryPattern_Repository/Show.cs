﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class Show : StreamingContent 
    {
        public int SeasonCount { get; set; }
        public int EpisodeCount { get; set; }
        public double AverageRunTime { get; set; }
        public List<Episode> Episodes { get; set; }
        public Show()
        {
            Episodes = new List<Episode>();
        }
        public Show(string title, string description, float starRating, MaturityRating mRating, GenreType tOG) 
            :base(title, description, starRating, mRating, tOG)
        {

        }
    }
    public class Episode
    {
        public string Title { get; set; }
        public double RunTime { get; set; }
        public int SeasonNumber { get; set; }
    }
}
