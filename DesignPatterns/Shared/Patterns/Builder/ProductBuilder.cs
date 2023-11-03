using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Shared.Patterns.Builder {
    public class ProductBuilder {

        #region Properities
        private bool _includeName { get; set; } = false;
        private bool _includeDescription { get; set; } = false;
        private bool _includePrice { get; set; } = false;
        #endregion

        public ProductBuilder IncludeName() {
            _includeName = true;
            return this;
        }
        public ProductBuilder IncludeDescription() {
            _includeDescription = true;
            return this;
        }
        public ProductBuilder IncludePrice() {
            _includePrice = true;
            return this;
        }

        public Product Build() {
            Product product = new Product();

            if(_includeName) {
                product.Name = "Product A";
            }

            if (_includeDescription) {
                product.Description = "A Description for Product A";
            }

            if(_includePrice) {
                product.Price = 10m;
            }
            
            return product;
        }
    }
}
