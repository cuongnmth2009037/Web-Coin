using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebCoin.Models
{
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }
        public double LastPrice { get; set; }
        public double Volumn24h { get; set; }
        [ForeignKey("Market")]
        public int MarketId { get; set; }
        public virtual Market Market { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; }
    }
}