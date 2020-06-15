using System;
using System.Collections.Generic;

namespace Cheeze.Store
{
    public static class Cheeses
    {
        private static readonly IEnumerable<Cheese> AllCheeses = new[] {
            new Cheese
            {
                Id = Guid.Parse("1468841a-5fbe-41c5-83b3-ab136b7ae70c"),
                Name = "Colston Bassett Stilton",
                Description = "An intensely rich and creamy Stilton , with a deep, lingering, complex flavour.",
                Price = 6.25M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/colston-bassett-stilton"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/image/500x500/9df78eab33525d08d6e5fb8d27136e95/c/b/cb_stilton_b__8.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("daad6d7f-3003-4d65-a194-88d0ad15f3da"),
                Name = "Pitchfork Somerset Cheddar",
                Description = "A brand new Artisan Somerset Cheddar made by Todd and Maugan Trethowan, just seven miles from Cheddar Gorge. Moist and succulent in texture, it is full-flavoured with a hint of tropical fruit.",
                Price = 7.69M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/pitchfork"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/p/i/pitchfork-by-fcc-june-20-1_b_.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("a8a0f3b4-bfa9-4dc6-badf-bff6a0fc4dd3"),
                Name = "Little Rollright",
                Description = "A semi soft, washed rind cheese wrapped in a spruce band. When ready, the paste is glossy, rich and voluptuous, and the taste is buttery, complex and resinous.",
                Price = 11.10M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/little-rollright"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/image/9df78eab33525d08d6e5fb8d27136e95/r/o/rollright-fcc-april-2020-1_b__1.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("7b015f8d-bf81-419c-889d-1e7c00157e57"),
                Name = "Ogleshield",
                Description = "A washed rind cheese made by Jamie Montgomery, from the milk of his own herd of Jersey cows. Similar to Raclette, it melts beautifully.",
                Price = 11.10M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/ogleshield"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/o/g/ogleshield-2020--dsc_0108_b_.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("c0010d0b-752e-4c9b-97fe-f4129c282e60"),
                Name = "Berkswell Cheese",
                Description = "An unpasteurised English sheep's milk cheese, Berkswell has a fruity tang and a creamy finish.",
                Price = 8.95M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/berkswell"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/b/e/berkswell-2017-7_b_.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("63e277c6-317d-4112-bb80-7a9a89db05ef"),
                Name = "Burrata di Bufala",
                Description = "A ball of the finest, buffalo milk mozzarella, filled with cream. Tear it apart and let the cream spill on to your plate. Rich, luscious and supremely delicious.",
                Price = 2.90M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/burrata-di-bufala"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/l/a/la-baronia-burrata-3_b_.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("12d1f6bd-d1f4-44f5-95f8-b4c19bfd3b5f"),
                Name = "Crème Fraiche",
                Description = "Rich, smooth and velvety with refreshing acidity. Lush and delicious.",
                Price = 3.10M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/creme-fraiche"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/n/y/nyc-dairy-products-2020-creme-fraiche--dsc_0052_b_.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("43586014-9b56-4fd9-8423-50d220ff678d"),
                Name = "Wigmore",
                Description = "Delicate and creamy sheep’s milk cheese with a gentle flavour. Its heavenly texture and delicacy make this cheese of real refinement.",
                Price = 7.50M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/wigmore"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/w/i/wigmore-2017-by-fcc--4_b_.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("b8a59269-9db1-498e-a2d9-861b210d34f9"),
                Name = "Montgomery's Cheddar",
                Description = "A traditional, cloth-wrapped, unpasteurised Cheddar cheese, made in Somerset by Jamie Montgomery.",
                Price = 5.95M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/montgomery-s-cheddar"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/m/o/montogomery-cut_b__3.jpg")
            },
            new Cheese
            {
                Id = Guid.Parse("8b92ed30-702c-4727-ba01-cece89992731"),
                Name = "Hafod Cheddar",
                Description = "A Welsh organic Cheddar cheese, hand-made by the Holden family from the milk of their Ayrshire herd. Buttery, rich and nutty.",
                Price = 7.40M,
                Uri = new Uri("https://www.finecheese.co.uk/our-cheeses/hafod"),
                ImageUri = new Uri("https://www.finecheese.co.uk/media/catalog/product/cache/1/thumbnail/84x84/9df78eab33525d08d6e5fb8d27136e95/i/m/image_275_4.jpg")
            }
        };

        public static IEnumerable<Cheese> All => AllCheeses;
    }
}
