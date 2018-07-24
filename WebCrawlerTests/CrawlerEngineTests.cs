using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebCrawler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebCrawler.Tests
{
    [TestClass()]
    public class CrawlerEngineTests
    {
        [TestMethod()]
        public void GoogleSearchTest()
        {
            ICrawler crawler = new CrawlerEngine();
            SearchResult result=crawler.Search(new GoogleSearchEngine(), "Java script");


            Assert.IsTrue(result.Value>0);
        }
        [TestMethod()]
        public void MSNSearchTest()
        {
            ICrawler crawler = new CrawlerEngine();
            SearchResult result = crawler.Search(new MsnSearchEngine(), "Java script");


            Assert.IsTrue(result.Value > 0);
        }
    }
}