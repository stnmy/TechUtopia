using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace API.Models.Product
{
    public class ProductAttributeValue
    {
        public int Id { get; set; }
        public int ProductId { get; set; }

        public required string Name {get; set;}
        public required string Value { get; set; }
        public required string SpecificationCategory {get; set;}
    }
}