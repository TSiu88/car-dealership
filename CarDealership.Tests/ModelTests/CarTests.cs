using Microsoft.VisualStudio.TestTools.UnitTesting;
using CarDealership.Models;
using System;

namespace CarDealership.Tests
{
  [TestClass]
  public class ItemTests
  {
    // Test methods go here
    [TestMethod]
    public void ItemConstructor_CreatesInstanceOfItem_Item()
    {
      Item newItem = new Item("property");
      Assert.AreEqual(typeof(Item), newItem.GetType());
    }

    [TestMethod]
    public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    {
      Item newItem = new Item("property");
      string result = newItem.Property;
      Assert.AreEqual("Expected", result);
    }
  }
}