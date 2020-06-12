using System;
using System.ComponentModel.DataAnnotations;

namespace Cheeze.Store
{
    public class Cheese
    {
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public decimal Price { get; set; }

        public Uri? Uri { get; set; }

        public Uri? ImageUri { get; set; }
    }
}