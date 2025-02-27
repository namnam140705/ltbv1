using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bai2
{
    [TestClass]
    public sealed class Test1
    {
        private IWebDriver driver;
        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
        }
        [TestMethod]
        public void TestMethod1()
        {
            // Mở google.com
            driver.Navigate().GoToUrl("https://www.google.com");

            // Tìm kiếm "Udemy"
            var searchBox = driver.FindElement(By.Name("q"));
            searchBox.SendKeys("Udemy: Online Courses");
            searchBox.SendKeys(Keys.Enter);

            // Chờ trang kết quả tìm kiếm tải
            System.Threading.Thread.Sleep(30000);


            // Tìm đến link "Udemy: Online Courses ..."
            var udemyLink = driver.FindElement(By.PartialLinkText("Udemy: Online Courses"));
            System.Threading.Thread.Sleep(2000);

            udemyLink.Click();

            // Chờ trang Udemy tải
            System.Threading.Thread.Sleep(2000);

            // In thông báo kết thúc
            Console.WriteLine("Test completed successfully.");
        }

        [TestCleanup]
        public void TearDown()
        {
            // Đóng trình duyệt và giải phóng tài nguyên
            if (driver != null)
            {
                driver.Quit();
            }
        }
    }
}
