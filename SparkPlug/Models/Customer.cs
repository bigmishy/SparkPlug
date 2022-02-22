using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson.Serialization.IdGenerators;
using Newtonsoft.Json;

namespace SparkPlug.Models
{
    /// <summary>
    /// The Customer model that will be persisted to mongo collection
    /// </summary>
    public class Customer
    {

        public String Id { get; set; }

        public String CustomerName { get; set; }

        public String CustomerEmail { get; set; }

        public String CustomerMessage { get; set; }

    }
}
