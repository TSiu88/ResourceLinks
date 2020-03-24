using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProjectName.Models;
using System.Collections.Generic;
using System;

namespace ProjectName.Tests
{
  [TestClass]
  public class CategoryTest : IDisposable
  {
    public void Dispose()
    {
      //Category.ClearAll();
    }
    
    [TestMethod]
    public void CategoryConstructor_CreatesInstanceOfCategory_Category()
    {
      // Category newCategory = new Category("test category");
      // Assert.AreEqual(typeof(Category), newCategory.GetType());
    }
  }
}