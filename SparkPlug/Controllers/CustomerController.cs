using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SparkPlug.Dto;
using SparkPlug.Services;


namespace SparkPlug.Controllers
{
    /// <summary>
    /// The CustomerController class is the entry point through 
    /// which request are routed to the controller methods
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {

        private ICustomerService customerService;

        public CustomerController(ICustomerService customerService)
        {
            this.customerService = customerService;
        }

        /// <summary>
        /// The CreateCustomer recieves form data request sent from the client app
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> CreateCustomer([FromForm] CustomerRequest request)
        {
            var response = await customerService.CreateCustomer(request);
            return new JsonResult(response);
        }

       
    }
}
