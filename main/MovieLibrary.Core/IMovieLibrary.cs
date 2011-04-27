namespace MovieLibrary.Core
{
    /// <summary>
    /// Library to store movies
    /// </summary>
    public interface IMovieLibrary
    {
        /// <summary>
        /// Clear the library
        /// </summary>
        void Clear();

        /// <summary>
        /// Add a movie
        /// </summary>
        /// <param name="movie">movie to be added</param>
        void Add(IMovie movie);
    }
}