using EasyAutomationFramework;

namespace BotWhatsApp
{
    public class WhatsAppSendMessage : Web
    {
        public void SendMessage(string message, string to)
        {
            StartBrowser(TypeDriver.GoogleChorme, "C:\\Users\\Marina\\AppData\\Local\\Google\\Chrome\\User Data");
            Navigate("https://web.whatsapp.com/");
            WaitForLoad();
            Thread.Sleep(TimeSpan.FromSeconds(3));
            var elementSearch = AssignValue(TypeElement.Xpath, "//*[@id=\"side\"]/div[1]/div/div[2]/div[2]", to);
            elementSearch.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            var elementMessage = AssignValue(TypeElement.Xpath, "//*[@id=\"main\"]/footer/div[1]/div/span[2]/div/div[2]/div[1]/div/div[1]", message);

            elementMessage.element.SendKeys(OpenQA.Selenium.Keys.Enter);

            CloseBrowser();
        }
    }
}
