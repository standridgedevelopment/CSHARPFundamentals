using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentTests
    {
        [TestMethod]
        public void StreamingContentNotes()
        {
            StreamingContent baseObject = new StreamingContent();
            Movie movieObject = new Movie();
            Show tvShow = new Show();
            Episode episodeOfTvShow = new Episode();

            tvShow.Episodes.Add(episodeOfTvShow);
            Movie venom = new Movie("Venom", "The best romance movie of our age", 9005, MaturityRating.PG_13, true, GenreType.Bromance, 132);
            StreamingRepository repo = new StreamingRepository();
            repo.AddContentToDirectory(tvShow);
            
        }


        //populates different variables for your test
        [DataTestMethod]
        [DataRow(MaturityRating.G, true)]
        [DataRow(MaturityRating.PG, true)]
        [DataRow(MaturityRating.PG_13, true)]
        [DataRow(MaturityRating.R, false)]

        public void SetMaturityRating_ShouldGetCorrectBool(MaturityRating rating, bool isFamilyFriendly)
        {
            StreamingContent content = new StreamingContent("Insert Title Here", "Description Here", 5, rating, GenreType.Documentary);
            bool actual = content.IsFamilyFriendly;
            bool expected = isFamilyFriendly;
            Assert.AreEqual(expected, actual);
        }
    }
}
