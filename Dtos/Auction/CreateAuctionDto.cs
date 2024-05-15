using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Car;

namespace api.Dtos.Auction
{
    public class CreateAuctionDto
    {
        [Required]
        [MinLength(5, ErrorMessage = "Auction Title must be atleast 5 characters")]
        public string Title { get; set; } = string.Empty;
        
        [Required]
        public long HighestBid { get; set; }
        
        [Required]
        public DateTime StartTime { get; set; }
        
        [Required]
        public DateTime EndTime { get; set; }
    }
}