using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class OrderTests : IDisposable
  {

    public void Dispose()
    {
      Order.ClearAll();
    }

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

    [TestMethod]
    public void GetAll_ReturnsEmptyList_ItemList()
    {
      // Arrange
      List<Order> newList = new List<Order> { };

      // Act
      List<Order> result = Order.GetAll();

      // Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void GetAll_ReturnsOrders_OrderList()
    {
      //Arrange
      string title1 = "Order title";
      string title2 = "Another order title";
      Order order1 = new Order(title1);
      Order order2 = new Order(title2);
      List<Order> newList = new List<Order> { order1, order2 };

      //Act
      List<Order> result = Order.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}