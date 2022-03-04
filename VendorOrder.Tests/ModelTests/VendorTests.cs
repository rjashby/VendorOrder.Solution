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
  }
}