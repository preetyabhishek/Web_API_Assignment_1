using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using Calculator_Logic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Calculator_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;
        private readonly Calculator calc;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
            calc = new Calculator();
        }

        // Create an API route for addition operation via HttpGet request
        // with left and right query params specified on the HttpRequest URL
        [HttpGet]
        [Route("add/{left}/{right}")]
        public double Add(double left, double right)
        {
            return calc.Add(left, right);
        }

        // Create an API route for subtraction operation via HttpGet request
        // with left and right query params specified on the HttpRequest URL
        [HttpGet]
        [Route("subtract/{left}/{right}")]
        public double Subtract(double left, double right)
        {
            return calc.Subtract(left, right);
        }

        // Create an API route for multiplication operation via HttpGet request
        // with left and right query params specified on the HttpRequest URL
        [HttpGet]
        [Route("multiply/{left}/{right}")]
        public double Multiply(double left, double right)
        {
            return calc.Multiply(left, right);
        }

        // Create an API route for division operation via HttpGet request
        // with left and right query params specified on the HttpRequest URL.
        // This will return response with "400 Bad Request" HttpStatusCode
        // and "Attempted to divide by zero." message if
        // the HttpRequest URL contains "right" parameter as number 0.
        [HttpGet]
        [Route("divide/{left}/{right}")]
        public ObjectResult Divide(double left, double right)
        {
            try
            {
                return Ok(calc.Divide(left, right));
            }
            catch (Exception ex)
            {
                return Problem(detail: ex.Message, statusCode: (int)HttpStatusCode.BadRequest);
            }
        }
    }
}

