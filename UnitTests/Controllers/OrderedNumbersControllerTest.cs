using Microsoft.Extensions.Logging;
using NSubstitute;
using NUnit.Framework;
using OrderedNumbersAPI;
using OrderedNumbersAPI.Controllers;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests.Controllers
{
    public class OrderedNumbersControllerTest
    {
        private ILogger<OrderedNumbersController> logger;
        private OrderedNumbersController controller = null;

        [SetUp]
        public void TestSetup()
        {
            logger = Substitute.For<ILogger<OrderedNumbersController>>();
        }

        [TestCase()]
        public async Task SaveOrderedNumbersTest()
        {
            SaveSortedNumbersRequest saveSortedNumbersRequest = new SaveSortedNumbersRequest()
            {
                ArrayToSort = new int[] { -8, 34, 25, 12, 22, 11, 90 },
                FileName = "Random"
            };
            controller = new OrderedNumbersController(logger);
            var response = await controller.SaveOrderedNumbers(saveSortedNumbersRequest);
            Assert.IsNotNull(response);
        }

        [TestCase()]
        public async Task GetOrderedNumbersTest()
        {
            GetSortedNumbersRequest getSortedNumbersRequest = new GetSortedNumbersRequest()
            {
                FileName = "Random"
            };
            controller = new OrderedNumbersController(logger);
            var response = await controller.GetOrderedNumbers(getSortedNumbersRequest);
            Assert.IsNotNull(response);
        }
    }
}
