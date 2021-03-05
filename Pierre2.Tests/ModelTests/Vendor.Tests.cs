using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {
    public void Dispose()
    {
      Vendor.ClearAll();
    }
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
    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      string name = "test vendor";
      string description = "this vendor is a test";
      Vendor testVendor = new Vendor(name, description);
      int result = testVendor.Id;
      Assert.AreEqual(1, result);
    }
    [TestMethod]
    public void GetAll_ReturnAllVendorObjects_VendorList()
    {
      Vendor testVendor1 = new Vendor("test name", "test desc");
      Vendor testVendor2 = new Vendor("test name", "test desc");
      List<Vendor> vendorList = new List<Vendor> { testVendor1, testVendor2 };
      List<Vendor> result = Vendor.GetAll();
      CollectionAssert.AreEqual(vendorList, result);
    }
    [TestMethod]
    public void Find_ReturnsVendor_Vendor()
    {
      Vendor testVendor1 = new Vendor("test name", "test desc");
      Vendor testVendor2 = new Vendor("test name", "test desc");
      Vendor result = Vendor.Find(2);
      Assert.AreEqual(testVendor2, result);
    }
  }
}