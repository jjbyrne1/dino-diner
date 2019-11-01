/* JurrasicJavaTest.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest.Drinks
{
    public class JurrasicJavaTest
    {
        //The correct default price, calories, ice, size, and SpaceForCream properties
        [Fact]
        public void ShouldHaveDefaultPrice()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveDefaultCalories()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveDefaultIce()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.Ice);
        }

        [Fact]
        public void ShouldHaveDefaultSize()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Equal<Size>(Size.Small, jj.Size);
        }

        [Fact]
        public void ShouldHaveDefaultSpaceForCream()
        {
            JurassicJava jj = new JurassicJava();
            Assert.False(jj.SpaceForCream);
        }

        //The correct price and calories after changing to small, medium, and large sizes
        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<double>(0.59, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal<uint>(2, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<double>(0.99, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal<uint>(4, jj.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectPriceAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<double>(1.49, jj.Price);
        }

        [Fact]
        public void ShouldHaveCorrectCaloriesAfterSettingLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal<uint>(8, jj.Calories);
        }

        //That invoking AddIce() results in the Ice property being true
        [Fact]
        public void AddIceShouldAddIce()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.True(jj.Ice);
        }

        //That invoking LeaveSpaceForCream() results in the SpaceForCream property being true
        [Fact]
        public void LeaveSpaceForCreamShouldLeaveSpaceForCream()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.True(jj.SpaceForCream);
        }

        //The correct ingredients are given.
        [Fact]
        public void ShouldHaveCorrectIngredients()
        {
            JurassicJava jj = new JurassicJava();
            List<string> ingredients = jj.Ingredients;
            Assert.Contains("Water", ingredients);
            Assert.Contains("Coffee", ingredients);
            Assert.Equal<int>(2, ingredients.Count);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            Assert.Equal("Small Jurassic Java", jj.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForSmallWithDecaf()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Size = Size.Small;
            jj.Decaf = true;
            Assert.Equal("Small Decaf Jurassic Java", jj.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            Assert.Equal("Medium Jurassic Java", jj.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMediumWithDecaf()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Medium;
            jj.Decaf = true;
            Assert.Equal("Medium Decaf Jurassic Java", jj.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            Assert.Equal("Large Jurassic Java", jj.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLargeWithDecaf()
        {
            JurassicJava jj = new JurassicJava();
            jj.Size = Size.Large;
            jj.Decaf = true;
            Assert.Equal("Large Decaf Jurassic Java", jj.Description);
        }

        //Add to Special
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            JurassicJava jj = new JurassicJava();
            Assert.Empty(jj.Special);
        }

        [Fact]
        public void AddIceShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.AddIce();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }

        [Fact]
        public void LeaveSpaceForCreamShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Leave Space For Cream", item);
                });
        }

        [Fact]
        public void LeaveSpaceForCreamAndAddIceShouldAddToSpecial()
        {
            JurassicJava jj = new JurassicJava();
            jj.LeaveRoomForCream();
            jj.AddIce();
            Assert.Collection<string>(jj.Special,
                item =>
                {
                    Assert.Equal("Leave Space For Cream", item);
                },
                item =>
                {
                    Assert.Equal("Add Ice", item);
                });
        }

        // Notify Special Change
        [Fact]
        public void LeaveSpaceForCreamShouldNotifySpecialChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special",
                () =>
                {
                    jj.LeaveRoomForCream();
                });
        }

        [Fact]
        public void AddIceShouldNotifySpecialChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Special",
                () =>
                {
                    jj.AddIce();
                });
        }

        //Notify Description Change
        [Fact]
        public void SizeShouldNotifyDescriptionChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description",
                () =>
                {
                    jj.Size = Size.Medium;
                });
        }

        [Fact]
        public void DecafShouldNotifyDescriptionChange()
        {
            JurassicJava jj = new JurassicJava();
            Assert.PropertyChanged(jj, "Description",
                () =>
                {
                    jj.Decaf = true;
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
