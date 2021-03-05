using Microsoft.VisualStudio.TestTools.UnitTesting;
using Bakery.Models;
using System.Collections.Generic;
using System;

namespace Bakery.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {
    public void Dispose()
    {
      Order.ClearAll();
    }

    [TestMethod]
    public void OrderConstructor_CreateInstanceOfOrder_Order()
    {
      Order testOrder = new Order("test title", "test desc", 8, "test date");
      Assert.AreEqual(typeof(Order), testOrder.GetType());
    }
    [TestMethod]
    public void GetProperties_ReturnsProperties_StringOrInt()
    {
      string title = "test title";
      string desc = "test desc";
      int price = 8;
      string date = "test date";
      Order testOrder = new Order(title, desc, price, date);
      string resultTitle = testOrder.OrderTitle;
      string resultDesc = testOrder.OrderDescription;
      int resultPrice = testOrder.OrderPrice;
      string resultDate = testOrder.OrderDate;
      Assert.AreEqual(title, resultTitle);
      Assert.AreEqual(desc, resultDesc);
      Assert.AreEqual(price, resultPrice);
      Assert.AreEqual(date, resultDate);
    }
    [TestMethod]
    public void SetProperties_SetsProperties_String()
    {
      Order testOrder = new Order("test title", "test desc", 8, "test date");
      string newTitle = "new test title";
      string newDesc = "new test desc";
      int newPrice = 0;
      string newDate = "new test date";
      testOrder.OrderTitle = newTitle;
      testOrder.OrderDescription = newDesc;
      testOrder.OrderPrice = newPrice;
      testOrder.OrderDate = newDate;
      string titleResult = testOrder.OrderTitle;
      string descResult = testOrder.OrderDescription;
      int priceResult = testOrder.OrderPrice;
      string dateResult = testOrder.OrderDate;
      Assert.AreEqual(newTitle, titleResult);
      Assert.AreEqual(newDesc, descResult);
      Assert.AreEqual(newPrice, priceResult);
      Assert.AreEqual(newDate, dateResult);
    }
  }
}