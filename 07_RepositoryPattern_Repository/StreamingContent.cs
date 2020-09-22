using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public enum GenreType
    {
        Horror = 1,
        RomCom,
        Fantasy,
        SciFi,
        Action,
        Drama,
        Bromance,
        Thriller,
        Documentary,
    }
    public enum MaturityRating
    {
        G,
        PG,
        PG_13,
        R,
        NC_17,
    }
    
    public class StreamingContent
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public float StarRating { get; set; }
        public MaturityRating MRating { get; set; }
        public bool IsFamilyFriendly
        {
            get
            {
                bool friendly;
                if ((int)MRating <= 2)
                {
                    friendly = true;
                }
                else
                {
                    friendly = false;
                }
                return friendly;
            }
        }
        public GenreType TypeOfGenre { get; set; }

        public StreamingContent(string title, string description, float starRating, MaturityRating mRating, GenreType tOG)
        {
            Title = title;
            Description = description;
            StarRating = starRating;
            MRating = mRating;
            TypeOfGenre = tOG;

        }
        public StreamingContent() { }
    }
}
