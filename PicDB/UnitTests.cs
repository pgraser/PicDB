using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BIF.SWE2.Interfaces;
using NUnit.Framework.Interfaces;

namespace PicDB
{
    [TestFixture]
    class UnitTests
    { 
        [Test]
        public void ut_configfile_dbconnection()
        {
            GlobalInformation.ReadConfigFile();
            Assert.IsNotNull(GlobalInformation.ConnectionString);
        }
        [Test]
        public void ut_configfile_picturepath()
        {
            GlobalInformation.ReadConfigFile();
            Assert.IsNotNull(GlobalInformation.Path);
        }
    }
}
