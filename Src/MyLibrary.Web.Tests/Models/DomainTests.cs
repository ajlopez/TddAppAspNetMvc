namespace MyLibrary.Web.Tests.Models
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using MyLibrary.Web.Models;

    [TestClass]
    public class DomainTests
    {
        [TestMethod]
        public void GetInstance()
        {
            var instance = Domain.Instance;
            Assert.IsNotNull(instance);
            Assert.IsNotNull(instance.Subjects);
            Assert.IsTrue(instance.Subjects.Count > 0);
        }
    }
}
