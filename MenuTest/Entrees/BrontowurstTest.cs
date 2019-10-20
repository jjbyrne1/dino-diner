/* BrontowurstTest.cs
 * Author: Nathan Bean
 */
using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnions();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }

        // Correct Desciption
        [Fact]
        public void DescriptionShouldBeCorrect()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal("Brontowurst", bw.Description);
        }

        // Add To Special
        [Fact]
        public void SpecialShouldBeEmptyByDefault()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Empty(bw.Special);
        }

        [Fact]
        public void HoldBunShouldAddToSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                });
        }

        [Fact]
        public void HoldPeppersShouldAddToSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                });
        }

        [Fact]
        public void HoldOnionsShouldAddToSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnions();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                });
        }

        [Fact]
        public void HoldPeppersAndOnionsShouldAddToSpecial()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            bw.HoldPeppers();
            bw.HoldOnions();
            Assert.Collection<string>(bw.Special,
                item =>
                {
                    Assert.Equal("Hold Bun", item);
                },
                item =>
                {
                    Assert.Equal("Hold Peppers", item);
                },
                item =>
                {
                    Assert.Equal("Hold Onions", item);
                });
        }

        //Notify Special Change
        [Fact]
        public void HoldingBunShouldNotifySpecialChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special",
                () =>
                {
                    bw.HoldBun();
                });
        }

        [Fact]
        public void HoldingPeppersShouldNotifySpecialChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special",
                () =>
                {
                    bw.HoldPeppers();
                });
        }

        [Fact]
        public void HoldingOnionsShouldNotifySpecialChange()
        {
            Brontowurst bw = new Brontowurst();
            Assert.PropertyChanged(bw, "Special",
                () =>
                {
                    bw.HoldOnions();
                });
        }
    }
}
