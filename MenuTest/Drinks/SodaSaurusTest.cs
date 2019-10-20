/* SodaSaurusTest.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class SodaSaurusTest
    {
        //The ability to set each possible flavor
        [Fact]
        public void ShouldBeAbleToSetFlavorToCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);
        }


        [Fact]
        public void ShouldBeAbleToSetFlavorToVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);
        }

        [Fact]
        public void ShouldBeAbleToSetFlavorToLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);
        }

        //The correct default price, calories, ice, and size
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }

        [Fact]
        public void ShoudldHaveCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false.
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }

        //The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingredients = soda.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Natural Flavors", ingredients);
            Assert.Contains("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        //Correct Desciption for Size Small
        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal("Small Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal("Small Orange Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal("Small Vanilla Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal("Small Chocolate Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal("Small RootBeer Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal("Small Cherry Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithFlavorLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Small;
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal("Small Lime Sodasaurus", soda.Description);
        }

        //Correct Desctiption for Size Medium
        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal("Medium Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal("Medium Orange Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal("Medium Vanilla Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal("Medium Chocolate Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal("Medium RootBeer Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal("Medium Cherry Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithFlavorLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal("Medium Lime Sodasaurus", soda.Description);
        }

        //Correct Description for Size Large
        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorCola()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal("Large Cola Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorOrange()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal("Large Orange Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorVanilla()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal("Large Vanilla Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorChocolate()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal("Large Chocolate Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorRootBeer()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal("Large RootBeer Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorCherry()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal("Large Cherry Sodasaurus", soda.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithFlavorLime()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal("Large Lime Sodasaurus", soda.Description);
        }

        //Add To Special
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Empty(soda.Special);
        }

        [Fact]
        public void HoldShouldAddToSpecial()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.Collection<string>(soda.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        // Notify Special Change
        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Special",
                () =>
                {
                    soda.HoldIce();
                });
        }

        // Notify Description Change
        [Fact]
        public void SizeShouldNotifyDescriptionChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description",
                () =>
                {
                    soda.Size = Size.Medium;
                });
        }

        [Fact]
        public void FlavorShouldNotifyDescriptionChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Description",
                () =>
                {
                    soda.Flavor = SodasaurusFlavor.RootBeer;
                });
        }

        // Notify Price Change
        [Fact]
        public void SizeShouldNotifyPriceChange()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.PropertyChanged(soda, "Price",
                () =>
                {
                    soda.Size = Size.Medium;
                });
        }
    }
}
