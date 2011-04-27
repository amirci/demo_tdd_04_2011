using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using MovieLibrary.Core;
using MavenThought.Commons.Testing;
using MvcContrib.TestHelper;
using Rhino.Mocks;
using SharpTestsEx;

namespace MovieLibrary.Website.Tests.Controllers
{
    /// <summary>
    /// Specification when listing no movies
    /// </summary>
    [Specification]
    public class When_movies_controller_lists_no_movies : MoviesControllerSpecification
    {
        /// <summary>
        /// Checks that no movies where returned
        /// </summary>
        [It]
        public void Should_not_return_any_movies()
        {
            var result = (ViewResult) this.ActualResult;

            var actual = (IEnumerable<IMovie>) result.ViewData.Model;
                
            actual.Should().Be.Empty();
        }

        /// <summary>
        /// Checks that the expected view is rendered
        /// </summary>
        [It]
        public void Should_render_the_index_view()
        {
            this.ActualResult.AssertViewRendered();
        }

        protected override void GivenThat()
        {
            base.GivenThat();

            Dep<IMovieLibrary>().Stub(lib => lib.Contents).Return(Enumerable.Empty<IMovie>());
        }

        /// <summary>
        /// Get the result
        /// </summary>
        protected override void WhenIRun()
        {
            this.ActualResult = this.Sut.Index();
        }
    }
}