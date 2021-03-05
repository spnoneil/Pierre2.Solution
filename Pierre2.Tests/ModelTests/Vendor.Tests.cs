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
    [TestMethod]
    public void GetNameAndDescription_ReturnsVendorNameAndDescription_String()
    {
      string name = "test vendor";
      string description = "this vendor is a test";
      Vendor testVendor = new Vendor(name, description);
      string nameResult = testVendor.VendorName;
      string descriptionResult = testVendor.VendorDescription;
      Assert.AreEqual(name, nameResult);
      Assert.AreEqual(description, descriptionResult);
    }
  }
}