using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpConcept
{
    interface IWebDriverDemo
    {
        public abstract void GetTitle();
        void Quit();
       // string Url {  get; set; }
    }
    class ChromeDriverDemo : IWebDriverDemo
    {
    //    public string Url { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void GetTitle()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            Console.WriteLine("chrome quit");
        }
    }

    class EdgeDriverDemo : IWebDriverDemo
    {
        public void GetTitle()
        {
            throw new NotImplementedException();
        }

        public void Quit()
        {
            Console.WriteLine("edge quit");
        }
    }

    public class Demo7Interface
    {
        static void Main(string[] args)
        {
            IWebDriverDemo driver = new EdgeDriverDemo();

            driver.Quit();
        }
    }
}
