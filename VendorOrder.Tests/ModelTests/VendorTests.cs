using Microsoft.VisualStudio.TestTools.UnitTesting;
using VendorOrder.Models;
using System.Collections.Generic;
using System;

namespace VendorOrder.Tests
{
  [TestClass]
  public class VendorTests : IDisposable
  {

    public void Dispose()
    {
      Vendor.ClearAll();
    }

    [TestMethod]
    public void VendorConstructor_CreatesInstanceOfVendor_Vendor()
    {
      Vendor vendor = new Vendor("test vendor");
      Assert.AreEqual(typeof(Vendor), vendor.GetType());
    }

    [TestMethod]
    public void GetName_ReturnsName_String()
    {
      //Arrange
      string name = "Test Vendor";
      Vendor vendor = new Vendor(name);

      //Act
      string result = vendor.Name;

      //Assert
      Assert.AreEqual(name, result);
    }

    [TestMethod]
    public void GetId_ReturnsCategoryId_Int()
    {
      //Arrange
      string name = "Test Category";
      Vendor vendor = new Vendor(name);

      //Act
      int result = vendor.Id;

      //Assert
      Assert.AreEqual(1, result);
    }

    [TestMethod]
    public void GetAll_ReturnsAllVendorObjects_VendorList()
    {
      //Arrange
      string name1 = "Work";
      string name2 = "School";
      Vendor vendor1 = new Vendor(name1);
      Vendor vendor2 = new Vendor(name2);
      List<Vendor> newList = new List<Vendor> { vendor1, vendor2 };

      //Act
      List<Vendor> result = Vendor.GetAll();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }

    [TestMethod]
    public void Find_ReturnsCorrectVendor_Vendor()
    {
      //Arrange
      string name1 = "Work";
      string name2 = "School";
      Vendor vendor1 = new Vendor(name1);
      Vendor vendor2 = new Vendor(name2);

      //Act
      Vendor result = Vendor.Find(2);

      //Assert
      Assert.AreEqual(vendor2, result);
    }

    [TestMethod]
    public void AddOrder_AssociatesOrderWithVendor_OrderList()
    {
      //Arrange
      string title = "Order title";
      Order order = new Order(title);
      List<Order> newList = new List<Order> { order };
      string name = "Bob's Bagels";
      Vendor vendor = new Vendor(name);
      vendor.AddOrder(order);

      //Act
      List<Order> result = new List<Order>();

      //Assert
      CollectionAssert.AreEqual(newList, result);
    }
  }
}