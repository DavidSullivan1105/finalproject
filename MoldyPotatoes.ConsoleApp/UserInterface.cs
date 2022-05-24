using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoldyPotatoes.Repository;


namespace MoldyPotatoes.ConsoleApp
{
    public class UserInterface
    {
        MovieRepository _repo = new MovieRepository();
        ICustomConsole _console;

        public UserInterface(ICustomConsole console)
        {
            _console = console;
        }

        bool isRunning = true;

        public void Run()
        {
            _repo.SeedMovieData();

            while(isRunning)
            {
                _console.PrintMainMenu();
                string userInput = _console.GetUserInput();

                //UserInputPortal(userInput);
            }
        }
        private void UserInputPortal(string inputFromUser)
        {
            switch(inputFromUser)
            {
                case "1":
                    CreateNewMovie();
                break;
                case "2":
                    ViewAllMovies();
                break;
                case "3":
                    //GetMovieByTitle();
                break;
                case "4":
                    SearchByTitle();
                break;
                case "5":
                    //EditMovie();
                break;
                case "6":
                    DeleteAMovie();
                break;
                case "7":
                    Exit();
                break;
                default:
                    //InvalidInputReturnToMainMenu();
                break;


            }
        }
        private void CreateNewMovie()
        {
            _console.EnterATitle();
            string title = _console.GetUserInput();

            _console.EnterDirectorName();
            string director = _console.GetUserInput();

            _console.GenreSelectionMenu();
            string genreSelection = _console.GetUserInput();

            Genre? movieGenre = GenreSelection(genreSelection);

            _console.RatingSelectionMenu();
            string ratingSelection = _console.GetUserInput();

            Rating? movieRating = RatingSelection(ratingSelection);

            bool isKidFriendly = IsKidFriendlySelection(movieRating);
            
            _console.EnterStars();
            int stars = _console.GetUserInputInt();

            //Constructor
            Movie newMovie = new Movie(title, director, movieGenre, movieRating, stars);

            _repo.AddMovieToDatabase(newMovie);

            _console.PressAnyKeyToContinue();

        }

        private void ViewAllMovies()
        {
            List<Movie> allMovies = _repo.GetAllMovies();

            _console.PrintMovies(allMovies);

            _console.PressAnyKeyToContinue();
        }

        private void SearchByTitle()
        {
            _console.SearchMovie();
            string searchInput = _console.GetUserInput();

            List<Movie> films = _repo.GetMoviesByTitleSearch(searchInput);
            
            _console.PrintMovies(films);

            _console.PressAnyKeyToContinue();
        }

        private void DeleteAMovie()
        {
            ViewAllMovies();

            _console.EnterATitleToDelete();

            string movieTitleToDelete = _console.GetUserInput();

            Movie movieToDelete = _repo.GetMovieByTitle(movieTitleToDelete);

            if(movieToDelete != null)
            {
                bool isSuccess = _repo.DeleteMovieFromDatabase(movieToDelete);

                if(isSuccess)
                {
                    _console.MovieSuccessfullyDeleted(movieToDelete);
                }
                else
                {
                    _console.SomethingWentWrong();
                   
                }
                
            }
            else
            {
                _console.MovieNotFound(movieTitleToDelete);
                
            }
            _console.PressAnyKeyToContinue();
        }

        private void Exit()
        {
            isRunning = false;

            _console.ExitMessage();

            _console.PressAnyKeyToContinue();
        }
        //CRUD ^^^
        //HELPER vvv


        private bool IsKidFriendlySelection(Rating? movieRating)
        {
            if (movieRating == Rating.G || movieRating == Rating.PG)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        private Rating? RatingSelection (string userRatingInput)
        {
            switch (userRatingInput)
            {
                case "1":
                    return Rating.G;
                
                case "2":
                    return Rating.PG;
                
                case "3":
                    return Rating.PG_13;
                
                case "4":
                    return Rating.R;
                
                case "5":
                    return Rating.MA;
                
                default:
                    return null;
                
            }
        }

        private Genre? GenreSelection (string userGenreInput)
        {
            switch (userGenreInput)
            {
                case "1":
                    return Genre.Action;
                
                case "2":
                    return Genre.Comedy;
                
                case "3":
                    return Genre.Drama;
                
                case "4":
                    return Genre.Romance;
                
                case "5":
                    return Genre.RomCom;
                
                case "6":
                    return Genre.Thriller;
                
                case "7":
                    return Genre.SciFi_Fantasy;
                
                default:
                    return null;
                
            }
        }


    }
}