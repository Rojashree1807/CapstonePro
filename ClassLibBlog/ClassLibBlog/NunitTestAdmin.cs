using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibBlog
{
    
    [TestFixture]
    class NUnitTestAdmin
    {
        [TestCase]
        public void EmailId()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.Equals("pravin@gmail.com", "pravin@gmail.com");
        }

        [TestCase]
        public void Password()
        {
            AdminInfo adminInfo = new AdminInfo();
            Assert.Equals("pravin@12", "pravin@12");
        }
    }
}