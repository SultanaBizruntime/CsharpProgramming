using Microsoft.VisualStudio.TestTools.UnitTesting;
using AdditionTestCase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdditionTestCase
{
    [TestClass()]
    public class AdditionTests
    {
        [TestMethod()]
        public void AddTest()
        {
            AdditionTests a1 = new AdditionTests();
            var result = a1.AddTest(10, 20);
            var flag = false;
            if (result.Equals(30))
                flag = true;
           Assert.IsTrue(flag);

        }

        private object AddTest(int v1, int v2)
        {
            throw new NotImplementedException();
        }
    }
}