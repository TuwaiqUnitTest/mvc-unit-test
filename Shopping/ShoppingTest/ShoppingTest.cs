using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Shopping.Controllers;
using Shopping.Models;

namespace ShoppingTest
{
    [TestClass]
    public class ShoppingTest
    {

        [TestMethod]
        public void Get_AllProducts_InTheStore()
        {
            // Arrange
            List<ProductModel> expectedProducts = new List<ProductModel>(){
            new ProductModel() {Id = 1,Name="Iphone 12 Pro",Price=1200.3f, Image = "https://creativecenter.bg/uploads//products/235/3506d54c9404706e0e1f57508045e500.jpeg"},
            new ProductModel() { Id = 2, Name = "Iphone 8", Price = 720.0f, Image = "https://i.ebayimg.com/images/g/pGUAAOSwsAdd0txg/s-l640.jpg" },
            new ProductModel() { Id = 3, Name = "samsung 2000", Price = 900.1f, Image = "https://cdn.alloallo.media/catalog/product/samsung/galaxy-s/galaxy-s10/galaxy-s10-prism-black.jpg" },
            new ProductModel() { Id = 4, Name = "I phone S10", Price = 8001.5f, Image = "https://m.xcite.com/media/catalog/product/cache/3/image/9df78eab33525d08d6e5fb8d27136e95/p/r/primary_white__1_2.jpg" } };

            ProductsController products = new ProductsController();

            // Act
            List<ProductModel> actualProducts = products.AllProducts();

            // Assert
            int expectedFirstId = expectedProducts[0].Id;
            int actualFirstId = actualProducts[0].Id;
            Assert.AreEqual(expectedFirstId, actualFirstId, "The first Id is correct");

            int expectedNumProducts = expectedProducts.Count;
            int actualNumProducts = actualProducts.Count;
            Assert.AreEqual(expectedNumProducts, actualNumProducts, "All Product count has been recieved correctly");
        }

        [TestMethod]
        public void Query_Product_WithInvalid_Id()
        {
            // Arrange
            int id = 8;
            ProductsController products = new ProductsController();

            // Act
            // Assert
            Assert.ThrowsException<NullReferenceException>(() => products.QueriedProduct(id));

        }


        [TestMethod]
        public void Query_Product_WithValid_Id()
        {
            // Arrange
            int id = 3;
            ProductsController products = new ProductsController();

            // Act
            ProductModel actualProduct = products.QueriedProduct(id);

            // Assert
            int expectedProductId = 3;
            string expectedProductName = "samsung 2000";
            float expectedProductPrice = 900.1f;

            Assert.AreEqual(expectedProductId, actualProduct.Id, "The Queried Id is correct");
            Assert.AreEqual(expectedProductName, actualProduct.Name, "The Queried name is correct");
            Assert.AreEqual(expectedProductPrice, actualProduct.Price, "The Queried price is correct");
        }


        [TestMethod]
        public void Add_Product_WithInValid_Id()
        {
            // Arrange
            ProductsController products = new ProductsController();

            // Act
            // Assert
            Assert.ThrowsException<Exception>(() => products.AddProduct(2, "Test 128", 1.00f, "img.png"));

        }


        [TestMethod]
        public void Add_Product_WithValid_Params()
        {
            // Arrange
            ProductsController products = new ProductsController();

            // Act
            products.AddProduct(9, "Test 128", 1.00f, "img.png");

            // Assert
            ProductModel actualProduct = products.QueriedProduct(9);

            Assert.AreEqual(9, actualProduct.Id, "The added product's id has added to the list of products");
            Assert.AreEqual("Test 128", actualProduct.Name, "The added product's name has added to the list of products");
            Assert.AreEqual(1.00f, actualProduct.Price, "The added product's price has added to the list of products");
        }

        [TestMethod]
        public void Remove_Product_WithInValid_Id()
        {
            // Arrange
            ProductsController products = new ProductsController();

            // Act
            // Assert
            Assert.ThrowsException<NullReferenceException>(() => products.RemoveProduct(20));

        }


        [TestMethod]
        public void Remove_Product_WithValid_Id()
        {
            // Arrange
            ProductsController products = new ProductsController();
            List<ProductModel> actualProducts = products.AllProducts();

            // Check the list count before removing
            Assert.AreEqual(4, actualProducts.Count);

            // Act
            products.RemoveProduct(1);

            // Assert
            Assert.AreEqual(3, actualProducts.Count);

        }

    }
}
