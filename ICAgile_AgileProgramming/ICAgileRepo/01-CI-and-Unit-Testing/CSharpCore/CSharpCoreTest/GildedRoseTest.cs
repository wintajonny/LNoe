using Xunit;
using System.Collections.Generic;
using FluentAssertions;

namespace CSharpCore.Test
{
    public class GildedRoseTest
    {
        [Fact]
        public void UpdateQuality_ItemNameTestItemAndSellInGreterOne_ReturnQualtiyMinusOne()
        {
            // Arrage
            var quality = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 1, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality - 1);
        }

        [Fact]
        public void UpdateQuality_ItemNameSulfurasAndSellInGreterOne_ReturnQualtiyUnchanged()
        {
            // Arrage
            var quality = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 1, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality);
        }

        [Fact]
        public void UpdateQuality_ItemNameTestItemAndQualityEqualsZeroAndSellInGreterOne_ReturnQualtiyZero()
        {
            // Arrage
            var quality = 0;
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 1, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality);
        }

        [Fact]
        public void UpdateQuality_ItemNameAgedBrieAndQualityLessThan50AndSellInGreterOne_ReturnQualtiyIncreased()
        {
            // Arrage
            var quality = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality+1);
        }
        
        [Fact]
        public void UpdateQuality_ItemNameAgedBrieAndQualityGreaterThan50AndSellInGreterOne_ReturnQualtiyUnchanged()
        {
            // Arrage
            var quality = 51;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 1, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality);
        }

        [Fact]
        public void UpdateQuality_ItemNameBackStagePassAndQualityGreaterThan50AndSellInGreterOne_ReturnQualtiyUnchanged()
        {
            // Arrage
            var quality = 51;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 1, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality);
        }

        [Fact]
        public void UpdateQuality_ItemNameBackStagePassAndQualityLessThan50AndSellInLessThanEleven_ReturnQualtiyIncreased()
        {
            // Arrage
            var quality = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality+2);
        }

        [Fact]
        public void UpdateQuality_ItemNameBackStagePassAndQualityGreaterLessThan50AndSellInLessThanSix_ReturnQualtiyIncreased()
        {
            // Arrage
            var quality = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality+3);
        }

        [Fact]
        public void UpdateQuality_ItemNameBackStagePassAndQualityCloseTo50AndSellInLessThanEleven_ReturnQualtiyIncreased()
        {
            // Arrage
            var quality = 49;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 10, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality + 1);
        }


        [Fact]
        public void UpdateQuality_ItemNameBackStagePassAndQualityCloseTo50AndSellInLessThanSix_ReturnQualtiyIncreased()
        {
            // Arrage
            var quality = 49;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 4, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality + 1);
        }

        [Fact]
        public void UpdateQuality_ItemNameNotSulfurasAndSellEquals2_ReturnSellInMinusOne()
        {
            // Arrage
            var sellIn = 2;
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = sellIn, Quality = 5 } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(sellIn - 1);
        }

        [Fact]
        public void UpdateQuality_ItemNameSulfurasAndSellEquals2_ReturnSellInUnchanged()
        {
            // Arrage
            var sellIn = 2;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = sellIn, Quality = 5 } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].SellIn.Should().Be(sellIn);
        }

        [Fact]
        public void UpdateQuality_ItemNameAgedBrieAndQualityLessThan50AndSellInLessThanZero_ReturnQualtiyPlusTwo()
        {
            // Arrage
            var quality = 5;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality + 2);
        }

        [Fact]
        public void UpdateQuality_ItemNameAgedBrieAndQualityGreaterThan50AndSellInLessThanZero_ReturnQualtiyUnchanged()
        {
            // Arrage
            var quality = 51;
            IList<Item> Items = new List<Item> { new Item { Name = "Aged Brie", SellIn = 0, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality);
        }

        [Fact]
        public void UpdateQuality_ItemNameBackStagePassAndSellInLessThanZero_ReturnQualtiyZero()
        {
            // Arrage
            var quality = 51;
            IList<Item> Items = new List<Item> { new Item { Name = "Backstage passes to a TAFKAL80ETC concert", SellIn = 0, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(0);
        }

        [Fact]
        public void UpdateQuality_ItemNameSulfurasPassAndSellInLessThanZero_ReturnQualtiyUnchanged()
        {
            // Arrage
            var quality = 51;
            IList<Item> Items = new List<Item> { new Item { Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality);
        }

        [Fact]
        public void UpdateQuality_ItemNameTestItemPassAndSellInLessThanZero_ReturnQualtiyMinusTwo()
        {
            // Arrage
            var quality = 51;
            IList<Item> Items = new List<Item> { new Item { Name = "TestItem", SellIn = 0, Quality = quality } };
            GildedRose app = new GildedRose(Items);

            // Act
            app.UpdateQuality();

            // Assert
            Items[0].Quality.Should().Be(quality - 2);
        }
    }
}
