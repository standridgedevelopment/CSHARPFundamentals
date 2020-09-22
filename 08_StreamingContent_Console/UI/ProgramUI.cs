using _07_RepositoryPattern_Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _08_StreamingContent_Console.UI
{
    class ProgramUI
    {
        private readonly StreamingRepository _streamingRepo = new StreamingRepository();
        public void Run()
        {
            SeedContent();
            MainMenu();
        }

        private void MainMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Welcome to Streaming Repository!");
                Console.WriteLine("What type of content do you want to work with?");
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                                  "1) Streaming Content \n" +
                                  "2) Movies \n" +
                                  "3) Shows\n" +
                                  "4) Exit");
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        StreamingContentMenu();
                        break;
                    case "2":
                        MovieMenu();
                        break;
                    case "3":
                        ShowsMenu();
                        break;
                    case "4":
                        //Exit
                        continueToRun = false;
                        break;

                    default:
                        //default
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number between 1 and 4.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }

        //Streaming Content
        private void StreamingContentMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                            "1) Add new content \n" +
                            "2) Find by title \n" +
                            "3) Show all streaming content \n" +
                            "4) Remove content\n" +
                            "5) Return to main menu");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Add new
                        CreateNewContent();
                        break;
                    case "2":
                        //Find by title
                        FindByTitle();
                        break;
                    case "3":
                        //Show All
                        ShowAllContent();
                        break;
                    case "4":
                        //Remove Content
                        RemoveContentFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        //default
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }

        }
        private void CreateNewContent()
        {
            // a new content object
            StreamingContent content = new StreamingContent();
            //Title
            Console.Clear();
            Console.WriteLine("Please enter a title");
            content.Title = Console.ReadLine();
            Console.Clear();

            //Description (string)
            Console.WriteLine($"Please enter a description for {content.Title}");
            content.Description = Console.ReadLine();
            Console.Clear();

            //Star Rating (float)
            chooseStarRating:
            Console.WriteLine($"Please enter the star rating for {content.Title}");
            try
            {
                content.StarRating = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseStarRating;
            }
            if (content.StarRating > 5)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseStarRating;
            }
            Console.Clear();

        chooseMaturityRating:
            //Maturity Rating (MaturityRating)
            Console.WriteLine($"Please select the maturity rating for {content.Title}\n" +
            "1) G \n" +
            "2) PG \n" +
            "3) PG-13 \n" +
            "4) R \n" +
            "5) NC 17");
            int MaturityResponse;
            try
            {
                MaturityResponse = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                           "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseMaturityRating;
            }
            if (MaturityResponse > 5)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseMaturityRating;
            }
            switch (MaturityResponse)
            {
                case 1:
                    content.MRating = MaturityRating.G;
                    break;
                case 2:
                    content.MRating = MaturityRating.PG;
                    break;
                case 3:
                    content.MRating = MaturityRating.PG_13;
                    break;
                case 4:
                    content.MRating = MaturityRating.R;
                    break;
                case 5:
                    content.MRating = MaturityRating.NC_17;
                    break;
            }
        //TypeOfGenre
        chooseGenre:
            Console.Clear();
            Console.WriteLine("Select a genre: \n" +
                "1) Horror\n" +
                "2) RomCom \n" +
                "3) Fantasy \n" +
                "4) Sci-Fi\n" +
                "5) Drama\n" +
                "6) Bromance\n" +
                "7) Action \n" +
                "8) Documentary \n" +
                "9) Thriller");
            int genreResponse;
            try
            {
                genreResponse = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 9.\n" +
                           "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseGenre;
            }
            if (genreResponse > 10)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 9.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseGenre;
            }
            content.TypeOfGenre = (GenreType)genreResponse;


            //a new content with properties filled out by user
            //Pass that to the add method in our repo
            _streamingRepo.AddContentToDirectory(content);
            Console.Clear();
            Console.WriteLine($"You have successfully added the streaming content, {content.Title}\n" +
                         "Press any key to continue");
            Console.ReadKey();
        }
        private void ShowAllContent()
        {
            Console.Clear();
            //Get the items from our fake database
            List<StreamingContent> listOfContent = _streamingRepo.GetContents();
            //Take Each item and display property values
            foreach (StreamingContent content in listOfContent)
            {
                DisplaySimple(content);
            }
            //Puase the program so the user can see the printed objects
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //GOAL: Show all items in our fake database
        }
        private void FindByTitle()
        {
            findByTitle:
            StreamingContent content = new StreamingContent();
            Console.Clear();
            Console.WriteLine("Enter the title of the content you would like to find");
            string title = Console.ReadLine();
            content = _streamingRepo.GetContentByTitle(title);
            Console.Clear();

            if (content == null)
            {
                string tryAgain;
                Console.WriteLine($"Could not find {title}.\nDo you want to try another search? \n1)Yes \n2)No");
                tryAgain = Console.ReadLine().ToLower();
                switch (tryAgain)
                {
                    case "1": 
                        goto findByTitle;
                    case "yes":
                        goto findByTitle;
                    case "2":
                        break;
                    case "no":
                        break;
                }
            }
            else {
                DisplaySimple(content);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void RemoveContentFromList()
        {
            removeContent:
            //Ask the user which one they want to remove
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            //need a list of the items
            List<StreamingContent> contentList = _streamingRepo.GetContents();
            int count = 0;
            foreach (var item in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {item.Title}" );
            }
            //take in user response
            int TargetContentID = int.Parse(Console.ReadLine());
            int correctIndex = TargetContentID - 1;
            if (correctIndex >= 0 && correctIndex < contentList.Count)
            {
                StreamingContent desiredContent = contentList[correctIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.Clear();
                    Console.WriteLine($"{desiredContent.Title} successfully removed!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("\nINVALID OPTION. \nDo you want to try another selection?\n1)Yes \n2)No");
                string tryAgain = Console.ReadLine().ToLower();
                switch (tryAgain)
                {
                    case "1":
                        goto removeContent;
                    case "yes":
                        goto removeContent;
                    case "2":
                        break;
                    case "no":
                        break;
                }
            }
            Console.WriteLine("Pres any key to continue....");
            Console.ReadKey();

        }
        private void DisplaySimple(StreamingContent content)
        {
            Console.WriteLine($"{content.Title} \n" +
                             $"{content.Description}\n" +
                             "----------------");
        }
        private void DisplaySimple(Movie content)
        {
            Console.WriteLine($"{content.Title} \n" +
                             $"{content.Description}\n" +
                             "----------------");
        }
        private void DisplayAllProps(StreamingContent content)
        {
            Console.WriteLine($"Title: {content.Title}");
            Console.WriteLine($"Description: {content.Description}");
            Console.WriteLine($"Star Rating: {content.StarRating}");
            Console.WriteLine($"Maturity Rating: {content.MRating}");
            Console.WriteLine($"Content is Family Friendly: {content.IsFamilyFriendly}");
            Console.WriteLine($"Genre: {content.TypeOfGenre}");
        }

        //Movies
        private void MovieMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                            "1) Add new movie \n" +
                            "2) Find movie by title \n" +
                            "3) Show all movies \n" +
                            "4) Remove movie\n" +
                            "5) Return to main menu");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Add new movie
                        CreateNewMovie();
                        break;
                    case "2":
                        //Find movie by title
                        FindMovieByTitle();
                        break;
                    case "3":
                        //Show All
                        ShowAllMovies();
                        break;
                    case "4":
                        //Remove Content
                        RemoveMovieFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        //default
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewMovie()
        {
            // a new content object
            Movie content = new Movie();
            //Title
            Console.Clear();
            Console.WriteLine("Please enter a title");
            content.Title = Console.ReadLine();
            Console.Clear();

            //Description (string)
            Console.WriteLine($"Please enter a description for {content.Title}");
            content.Description = Console.ReadLine();
            Console.Clear();

        //Star Rating (float)
        chooseStarRating:
            Console.WriteLine($"Please enter the star rating for {content.Title}");
            try
            {
                content.StarRating = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseStarRating;
            }
            if (content.StarRating > 5)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseStarRating;
            }
            Console.Clear();

        chooseMaturityRating:
            //Maturity Rating (MaturityRating)
            Console.WriteLine($"Please select the maturity rating for {content.Title}\n" +
            "1) G \n" +
            "2) PG \n" +
            "3) PG-13 \n" +
            "4) R \n" +
            "5) NC 17");
            int MaturityResponse;
            try
            {
                MaturityResponse = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                           "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseMaturityRating;
            }
            if (MaturityResponse > 5)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseMaturityRating;
            }
            switch (MaturityResponse)
            {
                case 1:
                    content.MRating = MaturityRating.G;
                    break;
                case 2:
                    content.MRating = MaturityRating.PG;
                    break;
                case 3:
                    content.MRating = MaturityRating.PG_13;
                    break;
                case 4:
                    content.MRating = MaturityRating.R;
                    break;
                case 5:
                    content.MRating = MaturityRating.NC_17;
                    break;
            }
            //TypeOfGenre
            chooseGenre:
            Console.Clear();
            Console.WriteLine("Select a genre: \n" +
                "1) Horror\n" +
                "2) RomCom \n" +
                "3) Fantasy \n" +
                "4) Sci-Fi\n" +
                "5) Drama\n" +
                "6) Bromance\n" +
                "7) Action \n" +
                "8) Documentary \n" +
                "9) Thriller");
            int genreResponse;
            try
            {
                genreResponse = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 9.\n" +
                           "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseGenre;
            }
            if (genreResponse > 10)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 9.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseGenre;
            }
            content.TypeOfGenre = (GenreType)genreResponse;

            //a new content with properties filled out by user
            chooseRuntime:
            Console.Clear();
            Console.WriteLine("Please enter a runtime");
            try { content.RunTime = double.Parse(Console.ReadLine()); }
            catch
            {
                Console.WriteLine("Please enter a valid number");
                goto chooseRuntime;
            }
            //Pass that to the add method in our repo
            _streamingRepo.AddContentToDirectory(content);
            Console.Clear();
            Console.WriteLine($"You have successfully added the movie, {content.Title}\n" +
                         "Press any key to continue");
            Console.ReadKey();
        }
        /*private void ShowAllMovies()
        {
            Console.Clear();
            //Get the items from our fake database
            List<StreamingContent> listOfContent = _movieRepo.GetContents();
            //Take Each item and display property values
            foreach (Movie content in listOfContent)
            {
                DisplaySimple(content);
            }
            //Puase the program so the user can see the printed objects
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //GOAL: Show all items in our fake database
        }*/
        private void ShowAllMovies()
        {
            Console.Clear();
            //Get the items from our fake database
            List<Movie> listOfContent = _streamingRepo.GetAllMovies();
            //Take Each item and display property values
            foreach (var content in listOfContent)
            {
                DisplaySimple(content);
            }
            //Puase the program so the user can see the printed objects
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //GOAL: Show all items in our fake database
        }
        private void FindMovieByTitle()
        {
        findByTitle:
            Movie content = new Movie();
            Console.Clear();
            Console.WriteLine("Enter the title of the content you would like to find");
            string title = Console.ReadLine();
            content = _streamingRepo.GetMovieByTitle(title);
            Console.Clear();

            if (content == null)
            {
                string tryAgain;
                Console.WriteLine($"Could not find {title}.\nDo you want to try another search? \n1)Yes \n2)No");
                tryAgain = Console.ReadLine().ToLower();
                switch (tryAgain)
                {
                    case "1":
                        goto findByTitle;
                    case "yes":
                        goto findByTitle;
                    case "2":
                        break;
                    case "no":
                        break;
                }
            }
            else
            {
                DisplaySimple(content);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void RemoveMovieFromList()
        {
        removeContent:
            //Ask the user which one they want to remove
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            //need a list of the items
            List<Movie> contentList = _streamingRepo.GetAllMovies();
            int count = 0;
            foreach (var item in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {item.Title}");
            }
            //take in user response
            int TargetContentID = int.Parse(Console.ReadLine());
            int correctIndex = TargetContentID - 1;
            if (correctIndex >= 0 && correctIndex < contentList.Count)
            {
                Movie desiredContent = (Movie)contentList[correctIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.Clear();
                    Console.WriteLine($"{desiredContent.Title} successfully removed!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("\nINVALID OPTION. \nDo you want to try another selection?\n1)Yes \n2)No");
                string tryAgain = Console.ReadLine().ToLower();
                switch (tryAgain)
                {
                    case "1":
                        goto removeContent;
                    case "yes":
                        goto removeContent;
                    case "2":
                        break;
                    case "no":
                        break;
                }
            }
            Console.WriteLine("Pres any key to continue....");
            Console.ReadKey();

        }
        //TV Shows
        private void ShowsMenu()
        {
            bool continueToRun = true;
            while (continueToRun)
            {
                Console.Clear();
                Console.WriteLine("Enter the number of the option you'd like to select:\n" +
                            "1) Add new show \n" +
                            "2) Find show by title \n" +
                            "3) Show all shows \n" +
                            "4) Remove show\n" +
                            "5) Return to main menu");

                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "1":
                        //Add new show
                        CreateNewShow();
                        break;
                    case "2":
                        //Find show by title
                        FindShowByTitle();
                        break;
                    case "3":
                        //Show All shows
                        ShowAllShows();
                        break;
                    case "4":
                        //Remove show
                        RemoveShowFromList();
                        break;
                    case "5":
                        continueToRun = false;
                        break;
                    default:
                        //default
                        Console.Clear();
                        Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue");
                        Console.ReadKey();
                        break;
                }
            }
        }
        private void CreateNewShow()
        {
            // a new content object
            Show content = new Show();
            //Title
            Console.Clear();
            Console.WriteLine("Please enter a title");
            content.Title = Console.ReadLine();
            Console.Clear();

            //Description (string)
            Console.WriteLine($"Please enter a description for {content.Title}");
            content.Description = Console.ReadLine();
            Console.Clear();

        //Star Rating (float)
        chooseStarRating:
            Console.WriteLine($"Please enter the star rating for {content.Title}");
            try
            {
                content.StarRating = float.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                            "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseStarRating;
            }
            if (content.StarRating > 5)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseStarRating;
            }
            Console.Clear();

        chooseMaturityRating:
            //Maturity Rating (MaturityRating)
            Console.WriteLine($"Please select the maturity rating for {content.Title}\n" +
            "1) G \n" +
            "2) PG \n" +
            "3) PG-13 \n" +
            "4) R \n" +
            "5) NC 17");
            int MaturityResponse;
            try
            {
                MaturityResponse = int.Parse(Console.ReadLine());
            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                           "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseMaturityRating;
            }
            if (MaturityResponse > 5)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 5.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseMaturityRating;
            }
            switch (MaturityResponse)
            {
                case 1:
                    content.MRating = MaturityRating.G;
                    break;
                case 2:
                    content.MRating = MaturityRating.PG;
                    break;
                case 3:
                    content.MRating = MaturityRating.PG_13;
                    break;
                case 4:
                    content.MRating = MaturityRating.R;
                    break;
                case 5:
                    content.MRating = MaturityRating.NC_17;
                    break;
            }
        //TypeOfGenre
        chooseGenre:
            Console.Clear();
            Console.WriteLine("Select a genre: \n" +
                "1) Horror\n" +
                "2) RomCom \n" +
                "3) Fantasy \n" +
                "4) Sci-Fi\n" +
                "5) Drama\n" +
                "6) Bromance\n" +
                "7) Action \n" +
                "8) Documentary \n" +
                "9) Thriller");
            int genreResponse;
            try
            {
                genreResponse = int.Parse(Console.ReadLine());

            }
            catch (Exception)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 9.\n" +
                           "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseGenre;
            }
            if (genreResponse > 10)
            {
                Console.Clear();
                Console.WriteLine("Please enter a valid number between 1 and 9.\n" +
                          "Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                goto chooseGenre;
            }
            content.TypeOfGenre = (GenreType)genreResponse;

            //a new content with properties filled out by user
            //Pass that to the add method in our repo
            _streamingRepo.AddContentToDirectory(content);
            Console.Clear();
            Console.WriteLine($"You have successfully added the show, {content.Title}\n" +
                         "Press any key to continue");
            Console.ReadKey();
        }
        private void ShowAllShows()
        {
            Console.Clear();
            //Get the items from our fake database
            List<Show> listOfContent = _streamingRepo.GetAllShows();
            //Take Each item and display property values
            foreach (Show content in listOfContent)
            {
                DisplaySimple(content);
            }
            //Puase the program so the user can see the printed objects
            Console.WriteLine("Press any key to continue");
            Console.ReadKey();
            Console.Clear();
            //GOAL: Show all items in our fake database
        }
        private void FindShowByTitle()
        {
        findByTitle:
            Show content = new Show();
            Console.Clear();
            Console.WriteLine("Enter the title of the content you would like to find");
            string title = Console.ReadLine();
            content =_streamingRepo.GetShowByTitle(title);
            Console.Clear();

            if (content == null)
            {
                string tryAgain;
                Console.WriteLine($"Could not find {title}.\nDo you want to try another search? \n1)Yes \n2)No");
                tryAgain = Console.ReadLine().ToLower();
                switch (tryAgain)
                {
                    case "1":
                        goto findByTitle;
                    case "yes":
                        goto findByTitle;
                    case "2":
                        break;
                    case "no":
                        break;
                }
            }
            else
            {
                DisplaySimple(content);
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
            }
        }
        private void RemoveShowFromList()
        {
        removeContent:
            //Ask the user which one they want to remove
            Console.Clear();
            Console.WriteLine("Which item would you like to remove?");
            //need a list of the items
            List<Show> contentList = _streamingRepo.GetAllShows();
            int count = 0;
            foreach (var item in contentList)
            {
                count++;
                Console.WriteLine($"{count}) {item.Title}");
            }
            //take in user response
            int TargetContentID = int.Parse(Console.ReadLine());
            int correctIndex = TargetContentID - 1;
            if (correctIndex >= 0 && correctIndex < contentList.Count)
            {
                Show desiredContent = (Show)contentList[correctIndex];
                if (_streamingRepo.DeleteExistingContent(desiredContent))
                {
                    Console.Clear();
                    Console.WriteLine($"{desiredContent.Title} successfully removed!");
                }
                else
                {
                    Console.WriteLine("I'm sorry, Dave. I'm afraid I can't do that.");
                }
            }
            else
            {
                Console.WriteLine("\nINVALID OPTION. \nDo you want to try another selection?\n1)Yes \n2)No");
                string tryAgain = Console.ReadLine().ToLower();
                switch (tryAgain)
                {
                    case "1":
                        goto removeContent;
                    case "yes":
                        goto removeContent;
                    case "2":
                        break;
                    case "no":
                        break;
                }
            }
            Console.WriteLine("Pres any key to continue....");
            Console.ReadKey();

        }

        private void SeedContent()
        {
            var titleOne = new StreamingContent("Streaming 1", "Streaming in style", 4.5f, MaturityRating.PG, GenreType.Bromance);
            var titleTwo = new StreamingContent("Streaming 2", "Stream another", 5f, MaturityRating.PG, GenreType.Bromance);
            var titleThree = new StreamingContent("Streaming 3", "Stream this instead", 4.75f, MaturityRating.PG, GenreType.Bromance);
            var titleFour = new StreamingContent("Streaming 4", "Or why not this?", 3f, MaturityRating.PG, GenreType.Bromance);
            var titleFive = new StreamingContent("Avatar: TLA", "An Avatar Air bends", 5f, MaturityRating.PG_13, GenreType.Bromance);
            var toyStory = new Movie("Toy Story", "Toys have a touching story", 4.5f, MaturityRating.PG, GenreType.Bromance, 60);
            var toyStory2 = new Movie("Toy Story 2", "Toys have another story", 5f, MaturityRating.PG, GenreType.Bromance, 80);
            var toyStory3 = new Movie("Toy Story 3", "Toys have a third story", 4.75f, MaturityRating.PG, GenreType.Bromance, 90);
            var toyStory4 = new Movie("Toy Story 4", "Toys have one more story", 3f, MaturityRating.PG, GenreType.Bromance, 120);
            var downtonAbbey = new Show("Downton Abbey", "Drama drama drama and its delicious", 4.5f, MaturityRating.PG, GenreType.Bromance);
            var reZero = new Show("Re:Zero", "Despair. Now animated", 5f, MaturityRating.PG, GenreType.Bromance);
            var HIMYM = new Show("How I Met Your Mother", "Have I ever told you the story of how I met your mother?", 4.75f, MaturityRating.PG, GenreType.Bromance);
            var korra = new Show("Legend of Korra", "It's okay", 3f, MaturityRating.PG, GenreType.Bromance);
            var atla = new Show("Avatar: TLA", "An Avatar Air bends", 5f, MaturityRating.PG_13, GenreType.Bromance);
            _streamingRepo.AddContentToDirectory(titleOne);
            _streamingRepo.AddContentToDirectory(titleTwo);
            _streamingRepo.AddContentToDirectory(titleThree);
            _streamingRepo.AddContentToDirectory(titleFour);
            _streamingRepo.AddContentToDirectory(titleFive);
            _streamingRepo.AddContentToDirectory(toyStory);
            _streamingRepo.AddContentToDirectory(toyStory2);
           _streamingRepo.AddContentToDirectory(toyStory3);
           _streamingRepo.AddContentToDirectory(toyStory4);
            _streamingRepo.AddContentToDirectory(downtonAbbey);
            _streamingRepo.AddContentToDirectory(reZero);
            _streamingRepo.AddContentToDirectory(HIMYM);
            _streamingRepo.AddContentToDirectory(korra);
            _streamingRepo.AddContentToDirectory(atla);

        }
       
    }
}
