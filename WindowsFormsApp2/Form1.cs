using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void Pause()
        {
            System.Threading.Thread.Sleep(10000);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://zionet-selenium.bubbleapps.io/version-test";
            for (int i = 0; i < 2; i++)
            {
                using (IWebDriver driver = new ChromeDriver())
                {
                    driver.Navigate().GoToUrl(url);
                
                    IWebElement aTag = driver.FindElement(By.CssSelector("div[class='clickable-element bubble-element Group baTaGzaS bubble-r-container flex row']"));
                    if (aTag != null)
                    {
                        aTag.Click();

                    }
                    IWebElement username = driver.FindElement(By.CssSelector("input[placeholder='Username']"));
                    if (username != null)
                    {
                        username.SendKeys("salim sheene");
                    }
                    IWebElement Email = driver.FindElement(By.CssSelector("input[placeholder='Email Address']"));
                    if (Email != null)
                    {
                        Email.SendKeys($"salim{i}@gmail.com");
                    }
                    IWebElement Password = driver.FindElement(By.CssSelector("input[placeholder='Password']"));
                    if (Password != null)
                    {
                        Password.SendKeys("123456789");
                    }
                    IWebElement ConfirmPassword = driver.FindElement(By.CssSelector("input[placeholder='Confirm Password']"));
                    if (ConfirmPassword != null)
                    {
                        ConfirmPassword.SendKeys("123456789");
                    }
                    IWebElement CreateAccount = driver.FindElement(By.CssSelector("div[class='bubble-element Text baTaHaMaI bubble-r-vertical-center clickable-element']"));
                    if (CreateAccount != null)
                    {
                        CreateAccount.Click();
                        Pause();

                    }


                    driver.Quit();



                }
            }


        }
    }
}
