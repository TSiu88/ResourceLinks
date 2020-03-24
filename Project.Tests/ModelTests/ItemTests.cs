using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System.Collections.Generic;
using System;
using MySql.Data.MySqlClient;

namespace ProjectName.Tests
{
  [TestClass]
  public class ItemTests : IDisposable
  {
    public void Dispose()
    {
      // Teardown Methods
      // Item.ClearAll();
    }
    
    // Test methods go here for custom methods only

    // [TestMethod]
    // public void NameOfMethodWeAreTesting_DescriptionOfBehavior_ExpectedReturnValue()
    // {
    //   Item newItem = new Item("property");
    //   string result = newItem.Description;
    //   Assert.AreEqual("property", result);
    // }
  }
}