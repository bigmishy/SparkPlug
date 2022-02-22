using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Driver;
using SparkPlug.Dto;
using SparkPlug.Models;

namespace SparkPlug.Services.Impl
{
    public class CustomerServiceImpl : ICustomerService
    {
        private IMongoClient client;

        public CustomerServiceImpl(IMongoClient client)
        {
            this.client = client;
        }

        /// <summary>
        /// The CreateCustomer method persist the data captured by
        /// the controller to mongo database
        /// </summary>
        /// <param name="request"></param>
        /// <returns></returns>
        public async Task<BaseResponse<Customer>> CreateCustomer(CustomerRequest request)
        {
            try
            {
                //Map data from CustomerRequest object to Customer object
                Customer customer = new Customer() {
                    Id = Guid.NewGuid().ToString(),
                    CustomerName = request.CustomerName,
                    CustomerEmail = request.CustomerEmail,
                    CustomerMessage = request.CustomerMessage
                };

                //persist Customer object to mongodb collection
                var database = client.GetDatabase("SparkPlugDB");
                var collection = database.GetCollection<Customer>("Customer");
                await collection.InsertOneAsync(customer);

                return new BaseResponse<Customer>() { Success = true, Message = "Customer saved successfully", Result = customer };
            }
            catch (MongoException me)
            {
                return new BaseResponse<Customer>() { Success = false, Message = me.Message, Result = null };
            }
        }

    }
}
