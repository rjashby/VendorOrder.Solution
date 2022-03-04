using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests
  {
    [TestMethod]
    public void OrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("My Order", "Stuff", "5", "Today");
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void OverloadOrderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("My Order");
      Assert.AreEqual(typeof(Order), order.GetType());
    }

    [TestMethod]
    public void GetTitle_ReturnsTitle_String()
    {
      //Arrange
      string title = "Order title";

      //Act
      Order order = new Order(title);
      string result = order.Title;

      //Assert
      Assert.AreEqual(title, result);
    }

    [TestMethod]
    public void SetTitle_SetTitle_String()
    {
      //Arrange
      string title = "Order title";
      Order order = new Order(title);

      //Act
      string newTitle = "Another Order";
      order.Title = newTitle;
      string result = order.Title;

      //Assert
      Assert.AreEqual(newTitle, result);
    }
  }
}