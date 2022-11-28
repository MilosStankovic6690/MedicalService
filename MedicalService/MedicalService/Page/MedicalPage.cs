using MedicalService.Driver;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace MedicalService.Page
{
    public class MedicalPage
    {
        private IWebDriver driver = WebDrivers.Instance;

        public void SelectFacility(string text)
        {
            SelectElement element = new SelectElement(driver.FindElement(By.Id("combo_facility")));
            element.SelectByText(text);
        }

        public IWebElement CheckBox => driver.FindElement(By.Id("chk_hospotal_readmission"));
        public IWebElement MedicaId => driver.FindElement(By.Id("radio_program_medicaid"));
        public IWebElement Date => driver.FindElement(By.Id("txt_visit_date"));
        public IWebElement TextComment => driver.FindElement(By.Id("txt_comment"));
        public IWebElement ButtonBookAppoiment => driver.FindElement(By.Id("btn-book-appointment"));
        public IWebElement Confirm => driver.FindElement(By.CssSelector(".text-center h2"));
    }
}
