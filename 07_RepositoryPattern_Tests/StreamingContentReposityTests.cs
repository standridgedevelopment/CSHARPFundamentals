using System;
using System.Collections.Generic;
using System.Net.NetworkInformation;
using System.Threading;
using _07_RepositoryPattern_Repository;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace _07_RepositoryPattern_Tests
{
    [TestClass]
    public class StreamingContentRepositoryTests
    {
        [TestMethod]
        public void AddToDirectory_ShouldGetCorrectBoolean()
        {
            // info to add (string title, string description, float starRating, string mRating, bool famFriendly, GenreType tOG

            // ARRANGE: Where we set up the pieces we need in order to perform the test we desire to run.

            StreamingContent content = new StreamingContent("Avatar: TLA", "The Best Show", 5, MaturityRating.PG, GenreType.Bromance);
            StreamingContentRepository repositry = new StreamingContentRepository();

            // ACT: Where we run the code that we want to test.

            bool addResult = repositry.AddContentToDirectory(content);


            // ASSERT: Where we prove whether the code did what we intended it to do.

            Console.WriteLine(addResult);
        }
        [TestMethod]
        public void GetDirectory_ShouldReturnCorrectCollection()
        {
            // ARRANGE
            StreamingContent newMovie = new StreamingContent();
            StreamingContent anotherMovie = new StreamingContent();
            StreamingContentRepository repo = new StreamingContentRepository();
            repo.AddContentToDirectory(newMovie);
            repo.AddContentToDirectory(anotherMovie);

            // ACT
            List<StreamingContent> listOfContents = repo.GetContents();

            // ASSERT
            bool directoryHasContent = listOfContents.Contains(newMovie);
            Console.WriteLine(directoryHasContent);
            Console.WriteLine()
                ;
            int count = listOfContents.Count;
            Console.WriteLine(count);
            Console.WriteLine();

            Console.WriteLine(listOfContents[0]);
            Console.WriteLine(listOfContents[1]);

            

        }
        //TEST INITIALIZE
        private StreamingContentRepository _repo;
        private StreamingContent _content;
        [TestInitialize]
        public void Arrange()
        {
            _repo = new StreamingContentRepository();
            _content = new StreamingContent("Avatar: TLA", "The Best Show", 5, MaturityRating.PG, GenreType.Bromance);
            _repo.AddContentToDirectory(_content);
        }


        [TestMethod]
        public void GetContentByTitle_ShouldReturnTitle()
        {
            //ACT
  
            StreamingContent searchResult = _repo.GetContentByTitle("Avatar: TLA");

            //ASSERT
            Assert.AreEqual(_content, searchResult);

        }

        [TestMethod]
        public void UpDateExistingContent_ShouldReturnCorrectBoolean()
        {
            //ARRANGE
            StreamingContent updatedContent = new StreamingContent("ATLA", "The Best Show", 5, MaturityRating.PG , GenreType.Bromance);

            //ACT
            bool updateResult = _repo.UpdateExistingContent("Avatar: TLA", updatedContent);

            //ASSERT
            Console.WriteLine(updateResult);
        }
        [TestMethod]
        public void DeleteContent_ShouldReturnTrue()
        {
            //ARRANGE
            StreamingContent foundContent = _repo.GetContentByTitle("Avatar: TLA");
            //ACT
            bool removeResult = _repo.DeleteExistingContent(foundContent);
            //ASSERT
            Console.WriteLine(removeResult);
        }

    }
}
