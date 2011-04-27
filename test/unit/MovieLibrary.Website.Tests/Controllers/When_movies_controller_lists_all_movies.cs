using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MavenThought.Commons.Extensions;
using MovieLibrary.Core;
using MvcContrib.TestHelper;
using Rhino.Mocks;
using MavenThought.Commons.Testing;
using SharpTestsEx;

namespace MovieLibrary.Website.Tests.Controllers
{
    /// <summary>
    /// Specification when I have some movies
    /// </summary>
    [Specification]
    public class When_movies_controller_lists_all_movies : MoviesControllerSpecification
    {
        private IEnumerable<IMovie> _movies;

        /// <summary>
        /// Checks that the expected view is rendered
        /// </summary>
        [It]
        public void Should_render_the_index_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        /// <summary>
        /// Checks that all the movies are returned
        /// </summary>
        [It]
        public void Should_return_all_the_movies()
        {
            var result = (ViewResult)this.ActualResult;

            var actual = (IEnumerable<IMovie>) result.ViewData.Model;

            actual.Should().Have.SameValuesAs(this._movies);
        }

        /// <summary>
        /// Setup all the movies
        /// </summary>
        protected override void GivenThat()
        {
            base.GivenThat();

            this._movies = 10.Times(() => Mock<IMovie>());

            Dep<IMovieLibrary>().Stub(lib => lib.Contents).Return(_movies);
        }

        /// <summary>
        /// List all contents
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Index();
        }
    }
}