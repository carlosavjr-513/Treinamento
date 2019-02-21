using Acme.Common;
using System;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }

        public Product(int productId)
        {
            this.ProductId = productId;
        }

        public Decimal? CurrentPrice { get; set; }
        public int ProductId { get; private set; }
        public string ProductDescription { get; set; }

        private String _ProductName;
        public String ProductName
        {
            get { return _ProductName.InsertSpaces(); }
            set { _ProductName = value; }
        }
        
        public override bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(ProductName)) isValid = false;
            if (CurrentPrice == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return ProductName;
        }

        public string Log()
        {
            var logString = ProductId + ": " + ProductName + " " +
                            "Detail: " + ProductDescription + " " +
                            "Status: " + EntityState.ToString();
            return logString;
        }
    }
}
