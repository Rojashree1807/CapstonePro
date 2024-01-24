using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibBlog
{
   
    [TestFixture]
    class NUnitTestEmp
    {
        [TestCase]
        public void EmailId()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.Equals("aishu12@gmail.com", "aishu12@gmail.com");
        }

        [TestCase]
        public void PassCode()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.Equals(1234, 1234);
        }
    }
}
