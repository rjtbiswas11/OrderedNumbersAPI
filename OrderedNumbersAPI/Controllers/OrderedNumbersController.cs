using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderedNumbersAPI.Controllers
{
    [ApiController]
    //[Route("[controller]")]
    public class OrderedNumbersController : ControllerBase
    {
        private readonly ILogger<OrderedNumbersController> _logger;

        public OrderedNumbersController(ILogger<OrderedNumbersController> logger)
        {
            _logger = logger;
        }

        [HttpPost("/SaveSortedNumbers/", Name = "Save Sorted Numbers")]
        public async Task<IActionResult> SaveOrderedNumbers([FromBody] SaveSortedNumbersRequest saveOrderedNumbersRequest)
        {
            Utility utility = new Utility();
            utility.BubbleSort(saveOrderedNumbersRequest.ArrayToSort);
            utility.SaveToText(saveOrderedNumbersRequest.ArrayToSort, saveOrderedNumbersRequest.FileName);
            return Ok(saveOrderedNumbersRequest.ArrayToSort);
        }

        [HttpGet("/GetSortedNumbers/", Name = "Get Sorted Numbers")]
        public async Task<IActionResult> GetOrderedNumbers([FromQuery] GetSortedNumbersRequest getSortedNumbersRequest)
        {
            Utility utility = new Utility();
            string response = utility.ReadFromFile(getSortedNumbersRequest.FileName);
            return Ok(response);
        }
    }
}
