using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Coin_Information.Models
{
    public enum Status2
    {
        Active,
        Deactive
    }
    public class Coin
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BaseAsset { get; set; }
        public string QuoteAsset { get; set; }
        public double LastPrice { get; set; }
        public double Volumn24h { get; set; }
        public int MarketId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status2 status { get; set; }
    }
}