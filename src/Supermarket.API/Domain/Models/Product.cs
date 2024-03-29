using System.Collections.Generic;
using System.ComponentModel;

namespace Supermarket.API.Domain.Models{
    public class Product{
        public int Id { get; set; }
        public string Name { get; set; }
        public short QuantityInPackage { get; set; }
        public EUnitOfMeasurement UnitOfMeasurement { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public enum EUnitOfMeasurement:byte
        {
            [Description("UN")]
            Unity=1,
            [Description("MG")]
            Milligram=2,
            [Description("KG")]
            Kilogram=4,
            [Description("L")]
            Liter=5
        }
    }


}