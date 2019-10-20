/* WaterTest.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        //The correct default price, calories, ice, size, and lemon properties.
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Water w = new Water();
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Water w = new Water();
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Water w = new Water();
            Assert.True(w.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Water w = new Water();
            Assert.Equal<Size>(Size.Small, w.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Water w = new Water();
            Assert.False(w.Lemon);
        }

        //The correct price and calories after changing to small, medium, and large sizes.
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal<uint>(0, w.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<double>(0.1, w.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal<uint>(0, w.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void HoldIceShouldHoldIce()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.False(w.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true.
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.True(w.Lemon);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Water w = new Water();
            List<string> ingredients = w.Ingredients;
            Assert.Contains("Water", ingredients);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Water w = new Water();
            w.AddLemon();
            List<string> ingredients = w.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Lemon", ingredients);
        }

        // Correct Desctiption for Size
        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            w.Size = Size.Small;
            Assert.Equal("Small Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            Water w = new Water();
            w.Size = Size.Medium;
            Assert.Equal("Medium Water", w.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            Water w = new Water();
            w.Size = Size.Large;
            Assert.Equal("Large Water", w.Description);
        }

        // Add To Special
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Water w = new Water();
            Assert.Empty(w.Special);
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            Assert.Collection<string>(w.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Water w = new Water();
            w.HoldIce();
            Assert.Collection<string>(w.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonAndHoldIceShouldAddToSpecial()
        {
            Water w = new Water();
            w.AddLemon();
            w.HoldIce();
            Assert.Collection<string>(w.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                },
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        // Notify Special Change
        [Fact]
        public void AddLemonShouldNotifySpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special",
                () =>
                {
                    w.AddLemon();
                });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Special",
                () =>
                {
                    w.HoldIce();
                });
        }

        //Notify Description Change
        [Fact]
        public void SizeShouldNotifyDescriptionChange()
        {
            Water w = new Water();
            Assert.PropertyChanged(w, "Description",
                () =>
                {
                    w.Size = Size.Medium;
                });
        }
    }
}
