using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Security;
using Microsoft.Win32;
using System.Threading;

namespace GenericTestCases
{
  
    [TestClass]
    public class GenericTestCases
    {
        //changed new1
        //[TestMethod]
        //public void TestcasePass()
        //{
        //    Assert.AreEqual(1, 1);
        //}
        //[TestMethod]wqerad
        //public void TestcaseFail()
        //{
        //    Assert.Fail();
        //}asdad
        ///// <summary>
        ///// check in for batched check ins asdada
        ///// </summary>
        // check in for pending changes

                //[TestMethod]
        //public void IsSqlServerServiceRunning()
        //{
        //    TestCases obj = new TestCases();
        //    if (obj.IsSqlServerRunning())
        //    {
        //        //Assert.AreEqual(1, 1);
        //        TimeSpan ts = new TimeSpan(0, 5, 0);
        //        // Thread.Sleep(ts);
        //         Assert.Fail();

        //    }
        //    else
        //        //Assert.Fail();
        //        Assert.AreEqual(1, 1);
        //}


      
        [TestMethod]
        [TestCategory("Sample")]

      //  [DeploymentItem(@"GenericTestCases\GenericTestCases\XMLFile.xml")]

            //
        //[DeploymentItem(@"XMLData\XMLFile1.xml","XMLData")] 
        public void Is64Bit()
        {
            TestCases obj = new TestCases();
            if (obj.Is64Bit())
                Assert.AreEqual(1, 1);
                //Assert.Fail();
            //obj
            else
                Assert.Fail();
                //Assert.Fail();

        }
        //[TestMethod] 
        //public void IsMSMQInstalled()
        //{
        //    TestCases obj = new TestCases();
        //    if (obj.IsMSMQInstalledAndRunning())
        //    {
        //        Assert.AreEqual(1, 1);
        //        TimeSpan ts = new TimeSpan(0, 5, 0);
        //        //  Thread.Sleep(ts);
        //        // Assert.Fail();

        //    }
        //    else
        //        Assert.Fail();
        //        //Assert.AreEqual(1, 1);
        //}



        [TestCategory("Nightly")]
        [TestMethod]
        public void IsDotNetFramework3_5Installed()
        {
            TestCases obj = new TestCases();
            if (obj.IsDotNetFramework3_5Installed())
            {
               Assert.Fail();
               //Assert.AreEqual(1, 1);
            }
            else
            {
                Assert.Fail();

               // Assert.AreEqual(1, 1);
               //Assert.Fail();
            }

        }

        //[TestCategory("Nightly1")]
        //[TestMethod]
        //public void IsSilverLightInstalled()
        //{
        //    TestCases obj = new TestCases();
        //    if (obj.IsSilverLightInstalled())
        //        if (obj.IsMSMQInstalledAndRunning())
        //        {
        //            //   Assert.AreEqual(1, 1);
        //            TimeSpan ts = new TimeSpan(0, 5, 0);
        //            // Thread.Sleep(ts);
        //            Assert.AreEqual(1, 1);
        //        }
        //        else
        //           Assert.Fail();
        //           // Assert.AreEqual(1, 1);

        //}

        //[TestMethod]
        //public void textfileexists()
        //{
        //    TestCases obj = new TestCases();
        //    if (System.IO.File.Exists(@"c:\temp\test.txt"))
        //        Assert.Fail();
        //    else
        //        Assert.Fail();

        //}
       


    }
}
