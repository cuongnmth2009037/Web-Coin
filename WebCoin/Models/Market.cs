using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebCoin.Models
{
    public class Market
    {
        public int Id { get; set; }
        public string Name { get; set; }       
        public string Description { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public int Status { get; set; }

    }
}