using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests
  {
    [TestMethod]
    public void VendorConstructor_CreateInstanceOfVendor_Vendor()
    {
      Vendor testVendor = new Vendor("test vendor", "this vendor is a test");
      Assert.AreEqual(typeof(Vendor), testVendor.GetType());
    }
  }
}