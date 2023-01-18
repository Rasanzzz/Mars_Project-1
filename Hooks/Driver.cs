using Mars_Project.Utilities;
using TechTalk.SpecFlow;

namespace Mars_Project.Hooks
{
    [Binding]
    public sealed class Driver : CommonDriver
    { 

        [BeforeScenario]
        public void Setup()
        {
            //launch the browser
            Initialize();

        }

        [AfterScenario]
        public void TearDown()
        {
            CloseTestRun();
        }
    }
}             