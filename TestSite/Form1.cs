using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OpenQA.Selenium;
namespace TestSite
{
    public partial class Form1 : Form
    {
        IWebDriver Browser;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            Browser.Navigate().GoToUrl("http://google.com");

            IWebElement SearchInput = Browser.FindElement(By.Id("lst-ib"));
            SearchInput.SendKeys("летающие лошади" + OpenQA.Selenium.Keys.Enter);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Browser.Quit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            IWebElement element;
            //  IWebElement element = Browser.FindElement(By.Id("text"));
            //  element.SendKeys("тест");

            element = Browser.FindElement(By.ClassName("footbal_close"));
            element.Click();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Browser = new OpenQA.Selenium.Chrome.ChromeDriver();
            Browser.Manage().Window.Maximize();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            IJavaScriptExecutor JSE = Browser as IJavaScriptExecutor;
            JSE.ExecuteScript("alert('всплывающее сообщение');");
        }
    }
}
