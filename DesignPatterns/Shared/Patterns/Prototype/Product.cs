using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Prototype {
    public class Product {

        #region Properities
        public string Name { get; set; }

        public string Description { get; set; }

        public decimal? Price { get; set; }

        #endregion

        public override string ToString() {
            string value = "";
            if (Name != null) {
                value += $"Name: {Name}\n";
            }
            if (Description != null) {
                value += $"Description: {Description}\n";
            }

            if (Price.HasValue) {
                value += $"Price £{Price}";
            }
            return value;
        }

        public Product Clone() {
            return new Product() {
                Name = this.Name,
                Description = this.Description,
                Price = this.Price
            };
        }
    }
}
