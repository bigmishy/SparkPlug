using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SparkPlug.Dto;
using SparkPlug.Models;

namespace SparkPlug.Services
{
    public interface ICustomerService
    {
        public Task<BaseResponse<Customer>> CreateCustomer(CustomerRequest request);

    }
}
