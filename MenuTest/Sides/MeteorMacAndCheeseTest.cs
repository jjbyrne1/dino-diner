/* MeteorMacAndCheeseTest.cs
 * Author: Nathan Bean
 */
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Sides
{
    public class MeteorMacAndCheeseTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal(0.99, mmc.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<uint>(420, mmc.Calories);
        }

        [Fact]
        public void ShouldHaveCorrectIngedients()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Contains<string>("Macaroni Noodles", mmc.Ingredients);
            Assert.Contains<string>("Cheese Product", mmc.Ingredients);
            Assert.Contains<string>("Pork Sausage", mmc.Ingredients);
            Assert.Equal<int>(3, mmc.Ingredients.Count);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultSize()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Equal<Size>(Size.Small, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal(1.45, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<uint>(490, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, mmc.Size);
        }

        [Fact]
        public void ShouldUseCorrectPriceForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal(1.95, mmc.Price, 2);
        }

        [Fact]
        public void ShouldUseCorrectCaloriesForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<uint>(520, mmc.Calories);
        }

        [Fact]
        public void ShouldBeAbleToSetSizeToLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, mmc.Size);
        }

        // Correct Desctiption for Size
        [Fact]
        public void DescriptionShouldBeCorrectForSmall()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            mmc.Size = Size.Small;
            Assert.Equal("Small Meteor Mac and Cheese", mmc.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForMedium()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Medium;
            Assert.Equal("Medium Meteor Mac and Cheese", mmc.Description);
        }

        [Fact]
        public void DescriptionShouldBeCorrectForLarge()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            mmc.Size = Size.Large;
            Assert.Equal("Large Meteor Mac and Cheese", mmc.Description);
        }

        // Add To Special
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.Empty(mmc.Special);
        }

        // Notify Description Change
        [Fact]
        public void SizeShouldNotifyDescriptionChange()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.PropertyChanged(mmc, "Description",
                () =>
                {
                    mmc.Size = Size.Medium;
                });
        }

        // Notify Price Change
        [Fact]
        public void SizeShouldNotifyPriceChange()
        {
            MeteorMacAndCheese mmc = new MeteorMacAndCheese();
            Assert.PropertyChanged(mmc, "Price",
                () =>
                {
                    mmc.Size = Size.Medium;
                });
        }
    }
}
