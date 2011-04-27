using System;
using TechTalk.SpecFlow;

namespace MovieLibrary.Acceptance.Tests.Steps
{
    /// <summary>
    /// Steps that involve accessing the library
    /// </summary>
    [Binding]
    public class LibrarySteps
    {
        /// <summary>
        /// Setup no movies exist
        /// </summary>
        [Given(@"I have no movies")]
        public void ClearMovies()
        {
        }

        /// <summary>
        /// Setup the movies in the library
        /// </summary>
        [Given(@"I have the following movies:")]
        public void SetupMovies(Table movies)
        {
        }

        /// <summary>
        /// Adds a movie to the media library
        /// </summary>
        /// <param name="title">Title of the movie to add</param>
        private static void AddMovieToStorage(string title)
        {
        }
    }
}
