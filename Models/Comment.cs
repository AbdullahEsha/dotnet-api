using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace dotnet_api.Models
{
    public class Comment
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Content { get; set; } = string.Empty;

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public int? StockId { get; set; }

        // StockId is a foreign key to the Stock table
        // The question mark in the type declaration makes the property nullable
        public Stock? Stock { get; set; }
        // Stock is a navigation property that allows us to navigate from a Comment to the Stock that the comment is associated with
    }
}
