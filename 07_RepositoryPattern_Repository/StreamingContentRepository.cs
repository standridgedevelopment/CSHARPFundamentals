using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingContentRepository
    {
        protected readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();
        //CRUD Create Read Update Delete

        public bool AddContentToDirectory(StreamingContent content)
        {
            int _startingCount = _contentDirectory.Count;
            _contentDirectory.Add(content);
            bool wasAdded = (_contentDirectory.Count > _startingCount) ? true : false;
            return wasAdded;
        }
        //READ ALL
        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        //READ ONE
        public StreamingContent GetContentByTitle(string title)
        {
            foreach(StreamingContent singleContent in _contentDirectory)
            {
                if (singleContent.Title.ToLower() == title.ToLower())
                {
                    return singleContent;
                }

            }
            return null;
        }
        public StreamingContent GetContentByDescription (string description)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.Description.ToLower() == description.ToLower())
                {
                    return movie;
                }
            }
            return null;
        }
        public StreamingContent GetContentByStarRating(float rating)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.StarRating == rating)
                {
                    return movie;
                }
            }
            return null;
        }
        public StreamingContent GetContentByMaturityRating(MaturityRating mRating)
        {
            foreach (StreamingContent movie in _contentDirectory )
            {
                if (movie.MRating == mRating)
                {
                    return movie;
                }
            }
            return null;
        }

        //UPDATE
        public bool UpdateExistingContent(string originalTitle, StreamingContent newContent)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContent.Title;
                oldContent.Description = newContent.Description;
                oldContent.StarRating = newContent.StarRating;
                oldContent.MRating = newContent.MRating;
                oldContent.TypeOfGenre = newContent.TypeOfGenre;

                return true;
            }
            else return false;

        }

        //DELETE

        public bool DeleteExistingContent(StreamingContent existingContent)
        {
            bool deleteResult = _contentDirectory.Remove(existingContent);
            return deleteResult;
        }


    }
}
