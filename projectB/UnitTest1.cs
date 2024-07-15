using java.sql;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace projectB
{
    public class Tests
    {
        [TestFixture]
        public class GoogleSearchTest//למה אסתי אמרה שלא צריך
        {
            private IWebDriver driver;  
            private Alert alert;
            private Window window;

        }
        [SetUp]
        public void Setup()
        {
            string path = "C:\\Users\\user1\\Desktop\\shufra\\year B\\otomatzya Efrat Fishbein\\projectB\\projectB";
       driver=new ChromeDriver(path+@"\drivers\");
            
            Alert alert =new Alert();
        Window window = new Window();

          
                }

        [Test]
        public void TestHandleAlert()
        {
            DriverCommand.Navigate().GoToUrl("https://demoqa.com/alerts");
            var alertButton = DriverCommand.FindElement(By.Id("timerAlertButton"));
            alertButton.Click();
            IAlert alert= WaitForAlert(DriverCommand,TimeSpan.FromSeconds(10));
            Assert.IsNotNull(alert, "Alert Was not displayed.");
            alert.Accept();

        }
        [Test]
        public void TestSwitchBetweenWindowsAndTabs()
        { DriverCommand.Navigate()GoToUrl("https://demoqa.com/browser-windows");
            var windowButton = DriverCommand.FindElement(By.Id("windowButton"));
            ((IJavaScriptExecutor)driver).ExecuteScript("argumennts[0].click;"windowButton);
            string originalWindow = driver.CurrentWindowHandle;
            waitForNewWindow(driver, 2);

            foreach (string windowHandle in driver.WindowHandles)
            {
                if (windowHandle == originalWindow)
                {
                    driver.SwitchTo().Window(windowHandle);
                    break;
                }

            } By.Id("sampleHeading");
            ClassicAssert.AreEqual("This is a sample page", newTabHeading.Text);

            driver.Close();
            driver.SwitchTo().window(originalWindow);
        }
            var newTabHeading = DriverCommand.FindElement()

        }
        [TearDown]
        public void TearDown()
        {
            driver.Dispose();
        }
    }
}