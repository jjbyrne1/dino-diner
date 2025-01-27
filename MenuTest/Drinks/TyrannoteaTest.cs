﻿/* TyrannoteaTest.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        //The correct default price, calories, ice, size, lemon, and sweet properties
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<double>(0.99, tt.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<uint>(8, tt.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.True(tt.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Equal<Size>(Size.Small, tt.Size);
        }

        [Fact]
        public void ShouldHaveDefaultLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Lemon);
        }

        [Fact] 
        public void ShouldHaveDefaultSweer()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.False(tt.Sweet);
        }

        //The correct price and calories after changing to small, medium, and large sizes
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal<double>(0.99, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal<uint>(8, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<double>(1.49, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal<uint>(16, tt.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<double>(1.99, tt.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal<uint>(32, tt.Calories);
        }

        //That invoking HoldIce() results in the Ice property being false
        [Fact]
        public void HoldIceShouldRemoveIce()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.False(tt.Ice);
        }

        //That invoking AddLemon() sets results in the Lemon property being true
        [Fact]
        public void AddLemonShouldAddLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.True(tt.Lemon);
        }

        //That setting the sweet property to true results in the right calories for each size
        [Fact]
        public void SweetShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Small;
            tt.AddSweet();
            Assert.Equal<uint>(8 * 2, tt.Calories);
        }

        [Fact]
        public void SweetShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.AddSweet();
            Assert.Equal<uint>(16 * 2, tt.Calories);
        }

        [Fact]
        public void SweetShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.AddSweet();
            Assert.Equal<uint>(32 * 2, tt.Calories);
        }

        //That setting the sweet property to false (after it has been set to true) results in the right calories for each size
        [Fact]
        public void SweetToUnsweetShouldHaveCorrectCaloriesForSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Small;
            tt.AddSweet();
            tt.RemoveSweet();
            Assert.Equal<uint>(8, tt.Calories);
        }

        [Fact]
        public void SweetToUnsweetShouldHaveCorrectCaloriesForMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.AddSweet();
            tt.RemoveSweet();
            Assert.Equal<uint>(16, tt.Calories);
        }

        [Fact]
        public void SweetToUnsweetShouldHaveCorrectCaloriesForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.AddSweet();
            tt.RemoveSweet();
            Assert.Equal<uint>(32, tt.Calories);
        }

        //The correct ingredients are given
        [Fact]
        public void ShouldHaveCorrectDefaultIngredients()
        {
            Tyrannotea tt = new Tyrannotea();
            List<string> ingredients = tt.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Tea", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWithSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddSweet();
            List<string> ingredients = tt.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Tea", ingredients);
            Assert.Contains("Cane Sugar", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWithLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            List<string> ingredients = tt.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Tea", ingredients);
            Assert.Contains("Lemon", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectIngredientsWithSweetAndLemon()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddSweet();
            tt.AddLemon();
            List<string> ingredients = tt.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Tea", ingredients);
            Assert.Contains("Cane Sugar", ingredients);
            Assert.Contains("Lemon", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        //Correct Description for Size
        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            Assert.Equal("Small Unsweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.Size = Size.Small;
            tt.AddSweet();
            Assert.Equal("Small Sweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            Assert.Equal("Medium Unsweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Medium;
            tt.AddSweet();
            Assert.Equal("Medium Sweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            Assert.Equal("Large Unsweet Tyrannotea", tt.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithSweet()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.Size = Size.Large;
            tt.AddSweet();
            Assert.Equal("Large Sweet Tyrannotea", tt.Description);
        }

        // Add To Special
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.Empty(tt.Special);
        }

        [Fact]
        public void AddLemonShouldAddToSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            Assert.Collection<string>(tt.Special,
                item =>
                {
                    Assert.Equal("Add Lemon", item);
                });
        }

        [Fact]
        public void HoldIceShouldAddToSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.HoldIce();
            Assert.Collection<string>(tt.Special,
                item =>
                {
                    Assert.Equal("Hold Ice", item);
                });
        }

        [Fact]
        public void AddLemonAndHoldIceShouldAddToSpecial()
        {
            Tyrannotea tt = new Tyrannotea();
            tt.AddLemon();
            tt.HoldIce();
            Assert.Collection<string>(tt.Special,
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
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Special",
                () =>
                {
                    tt.AddLemon();
                });
        }

        [Fact]
        public void HoldIceShouldNotifySpecialChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Special",
                () =>
                {
                    tt.HoldIce();
                });
        }

        //Notify Description Change
        [Fact]
        public void SizeShouldNotifyDescriptionChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Description",
                () =>
                {
                    tt.Size = Size.Medium;
                });
        }

        [Fact]
        public void AddSweetShouldNotifyDescriptionChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Description",
                () =>
                {
                    tt.AddSweet();
                });
        }

        [Fact]
        public void RemoveSweetShouldNotifyDescriptionChange()
        {
            Tyrannotea tt = new Tyrannotea();
            Assert.PropertyChanged(tt, "Description",
                () =>
                {
                    tt.RemoveSweet();
                });
        }

        // Notify Price Change
        [Fact]
        public void SizeShouldNotifyPriceChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Price",
                () =>
                {
                    jj.Size = Size.Medium;
                });
        }
    }
}
