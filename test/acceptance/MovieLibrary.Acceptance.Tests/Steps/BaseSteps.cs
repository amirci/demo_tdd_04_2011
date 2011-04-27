using MovieLibrary.Acceptance.Tests.Infrastructure;
using TechTalk.SpecFlow;

namespace MovieLibrary.Acceptance.Tests.Steps
{
    public class BaseSteps
    {
        public Browser Browser
        {
            get { return ScenarioContext.Current.Get<Browser>(); }
        }
    }
}