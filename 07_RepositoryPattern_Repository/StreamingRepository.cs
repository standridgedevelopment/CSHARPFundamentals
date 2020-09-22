using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_RepositoryPattern_Repository
{
    public class StreamingRepository : StreamingContentRepository
    {

        //GetAll
        public List<Show> GetAllShows()
        {
            // Make a space to save all shows
            List<Show> allShows = new List<Show>();
            //pull one item and see if it is a show
            //make sure to save that off to the side
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show is Show)
                {
                    allShows.Add((Show)show);
                }
                //return that list
                return allShows;
            }
            return null;
        }
        public List<Movie> GetAllMovies()
        {
            List<Movie> allMovies = new List<Movie>();
            //pull one item and see if it is a show
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie is Movie)
                {
                    allMovies.Add((Movie)movie);
                }
                return allMovies;
            }
            return null;
        }

        //GetByTitle
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.Title.ToLower() == title.ToLower() && movie.GetType() == typeof(Movie))
                {
                    return (Movie)movie;
                }
            }
            return null;
        }

        //GetByDescription
        public Show GetShowByDescription(string description)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Description.ToLower() == description.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        public Movie GetMovieByDescription(string description)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.Description.ToLower() == description.ToLower() && movie.GetType() == typeof(Movie))
                {
                    return (Movie)movie;
                }
            }
            return null;
        }

        //GetByStarRating
        public Show GetShowByStarRating(float starRating)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.StarRating == starRating && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        public Movie GetMovieByStarRating(float starRating)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.StarRating == starRating && movie.GetType() == typeof(Movie))
                {
                    return (Movie)movie;
                }
            }
            return null;
        }

        //GetByMaturityRating
        public Show GetShowByMaturityRating(MaturityRating mRating)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.MRating == mRating && show.GetType() == typeof(Show))
                    {
                        return (Show)show;
                    }
            }
            return null;
        }
        public Movie GetMovieByMaturityRating(MaturityRating mRating)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.MRating == mRating && movie.GetType() == typeof(Movie))
                {
                    return (Movie)movie;
                }
            }
            return null;
        }

        //GetByFamilyFriendly
        public Show GetShowByFamilyFriendly(bool fFriendly)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.IsFamilyFriendly == fFriendly && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        public Movie GetMovieByFamilyFriendly(bool fFriendly)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.IsFamilyFriendly == fFriendly && movie.GetType() == typeof(Movie))
                {
                    return (Movie)movie;
                }
            }
            return null;
        }


        //GetByGenre
        public Show GetShowByGenre(GenreType gType)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.TypeOfGenre == gType && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }
            return null;
        }
        public Movie GetMovieByGenre(GenreType gType)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                if (movie.TypeOfGenre == gType && movie.GetType() == typeof(Movie))
                {
                    return (Movie)movie;
                }
            }
            return null;
        }

        //Get Shows with over x episode

        //going to pass in a value for episodes
        public List<Show> GetAllShowsOverEpisodeCount(int episodeCount)
        //single out all shows from my list(aka fake database)
        {
            List<Show> finalList = new List<Show>();
            List<Show> listofAllShows = GetAllShows();
            // now I have a list of shows
            foreach (Show show in listofAllShows)
            {
                // use parameter Episodes to get episode count
                if (show.Episodes.Count() >= episodeCount)
                {
                    finalList.Add((Show)show);
                }
            }
            return finalList;
        }
     

    }
}
