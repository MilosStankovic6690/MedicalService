using MedicalService.Driver;
using MedicalService.Page;

namespace MedicalService.Tests
{
    public class MedicalTests
    {
        LoginPage loginPage;
        MedicalPage medicalPage;

        [SetUp]
        public void Setup()
        {
            WebDrivers.Initialize();
            loginPage = new LoginPage();
            medicalPage = new MedicalPage();
        }
        [TearDown]

        public void Close()
        {
            WebDrivers.CleanUp();
        }

        [Test]
        public void TC01_MakeAppointment_ShouldAppointmentBeCompleted()
        {
            loginPage.AppMedic.Click();
            loginPage.Login("John Doe", "ThisIsNotAPassword");
            medicalPage.SelectFacility("Tokyo CURA Healthcare Center");
            medicalPage.CheckBox.Click();
            medicalPage.MedicaId.Click();
            medicalPage.Date.SendKeys("25/12/2022");
            medicalPage.TextComment.SendKeys("Zakazano");
            medicalPage.ButtonBookAppoiment.Submit();

            Assert.That("Appointment Confirmation", Is.EqualTo(medicalPage.Confirm.Text));
        }
    }
}