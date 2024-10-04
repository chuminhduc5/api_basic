using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Comment;

namespace api.Dtos.Stock
{
    public class StockDto
    {
        
        public int Id { get; set; }

        // Đặt thành 1 chuỗi rỗng
        public string Symbol { get; set; } = string.Empty;

        public string CompanyNme { get; set; } = string.Empty;

        public decimal Purchase { get; set; }

        public decimal LastDiv { get; set; }

        public string Industry { get; set; } = string.Empty;

        public long MarketCap { get; set; }

        public List<CommentDto> Comments  { get; set; }
    }
}