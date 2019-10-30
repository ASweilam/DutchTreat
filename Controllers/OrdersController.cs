using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DutchTreat.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace DutchTreat.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class OrdersController : ControllerBase
    {
        private readonly IDutchRepository _repository;
        private readonly ILogger<OrdersController> _logger;

        public OrdersController(IDutchRepository repository, ILogger<OrdersController> logger)
        {
            _repository = repository;
            _logger = logger;
        }

        public IActionResult Get()
        {

            try
            {
                return Ok(_repository.GetAllOrders());
            }
            catch (Exception ex)
            {

                _logger.LogError($"Failed to get Order: {ex}");
                return BadRequest("Failed to get orders");
            }
        }

    }


}