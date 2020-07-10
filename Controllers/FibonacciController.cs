using NLog;
using System.Collections.Generic;
using System.Numerics;
using System.Web.Mvc;

namespace TestWebApp.Controllers
{
    public class FibonacciController : Controller
    {
        Logger log = LogManager.GetCurrentClassLogger();

        public ActionResult Index()
        {
            List<string> FibonacciStringList = new List<string>();
            List<BigInteger> FibonacciList = GenerateFibonacciSequenceList(50);

            foreach (BigInteger item in FibonacciList)
            {
                FibonacciStringList.Add(item.ToString());
            }
            return View(FibonacciStringList);
        }

        private List<BigInteger> GenerateFibonacciSequenceList(int NumberOfTerms)
        {
            List<BigInteger> FibonacciList = new List<BigInteger>();
            BigInteger t1 = 0, t2 = 1, nextTerm;

            for (int i = 1; i <= NumberOfTerms; ++i)
            {
                if (i == 1)
                {
                    nextTerm = t1;
                }
                else if (i == 2)
                {
                    nextTerm = t2;
                }
                else
                {
                    nextTerm = t1 + t2;
                    t1 = t2;
                    t2 = nextTerm;
                }

                FibonacciList.Add(nextTerm);

                log.Debug("term: {0}, value: {1}", i, nextTerm);
            }
            return FibonacciList;
        }
    }
}