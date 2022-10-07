using Microsoft.AspNetCore.Mvc;
using Session_8_partone.Controllers;
using Session_8_partone.Model;
using Session_8_partone.Services;

namespace web_api_test
{
    public class UnitTest1
    {

        private readonly ProductController _controller;
        private readonly IProductService _service;

        public UnitTest1()
        {

            _service = new ProductService();
            _controller = new ProductController(_service);
        }

        [Fact]
        public void Test1()
        {
            var okResult = _controller.GetAll();
            // Assert
            Assert.IsType<OkObjectResult>(okResult as OkObjectResult);
        }

        [Fact]
        public void Get_WhenCalled_ReturnsAllItems()
        {
            // Act
            var okResult = _controller.GetAll() as OkObjectResult;
            // Assert
            var items = Assert.IsType<List<Product>>(okResult.Value);
            Assert.Equal(1, items.Count);
        }
    }
}