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
    public void OrdderConstructor_CreatesInstanceOfOrder_Order()
    {
      Order order = new Order("My Order", "Stuff", "5", "Today");
      Assert.AreEqual(typeof(Order), order.GetType());
    }
  }
}