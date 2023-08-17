using BCDTest.Drivers;
using BCDTest.PageObjects;
using TechTalk.SpecFlow;

namespace BCDTest.Steps
{
    [Binding]
    public sealed class AppointmentsStepDefinitions
    {
        private readonly HomePageObject _homePageObject;

        public AppointmentsStepDefinitions(BrowserDriver browserDriver)
        {
            _homePageObject = new HomePageObject(browserDriver.Current);
        }

        [Given("I go to the Home page")]
        public void GivenIGoToTheHomePage()
        {
            _homePageObject.OpenPage();
        }
    }
}