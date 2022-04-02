using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Coin_Information.ViewModels
{
    public enum Status1
    {
        Active,
        Deactive
    }

    public class CoinViewModels
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter Base Asset")]
        public string BaseAsset { get; set; }
        [Required(ErrorMessage = "Please enter  Quote Asset")]
        public string QuoteAsset { get; set; }
        [Required(ErrorMessage = "Please enter  Last Price")]
        public double LastPrice { get; set; }
        [Required(ErrorMessage = "Please enter Volumn 24h")]
        public double Volumn24h { get; set; }
        [Required(ErrorMessage = "Please enter Market Id")]
        public int MarketId { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public Status1 status { get; set; }
    }
}