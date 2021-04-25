using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalesControls.Models
{
    public class Sale
    {
        public int SaleId { get; set; }

        public string ProductDescripton { get; set; }

        public DateTime? DateBuy { get; set; }

        public DateTime? DateSale { get; set; }

        public double? PriceSale { get; set; }

        public double? PriceBuy { get; set; }

        public DateTime? DeliveryDate { get; set; }

        public string TrackingCode { get; set; }

        public string PurchaseEmail { get; set; }
    }
}
