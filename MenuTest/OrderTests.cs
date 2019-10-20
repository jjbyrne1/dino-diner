using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;

namespace MenuTest
{
    public class OrderTests
    {
        class MockEntree : Entree
        {
            public MockEntree()
            {
                this.Price = 1.00;
            }

            public override string ToString()
            {
                return "Entree";
            }
        }

        class MockDrink : Drink
        {
            public MockDrink()
            {
                this.Price = 2.00;
            }

            public override string ToString()
            {
                return "Drink";
            }
        }

        class MockSide : Side
        {
            public MockSide()
            {
                this.Price = 3.00;
            }

            public override string ToString()
            {
                return "Side";
            }
        }

        class FakeMockIMenuItem : IMenuItem
        {
            public double Price { get; } = -10;

            public uint Calories { get; } = 100;

            public List<string> Ingredients { get; }
        }

        [Fact]
        public void AddEntreeToOrderAddsToItems()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            o.Items.Add(me);
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(me, item);
                });
        }

        [Fact]
        public void AddSideToOrderAddsToItems()
        {
            Order o = new Order();
            MockSide me = new MockSide();
            o.Items.Add(me);
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(me, item);
                });
        }

        [Fact]
        public void AddDrinkToOrderAddsToItems()
        {
            Order o = new Order();
            MockDrink me = new MockDrink();
            o.Items.Add(me);
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(me, item);
                });
        }

        [Fact]
        public void RemoveEntreeToOrderAddsToItems()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            o.Items.Add(me);
            o.Items.Remove(me);
            Assert.Empty(o.Items);
        }

        [Fact]
        public void RemoveSideToOrderAddsToItems()
        {
            Order o = new Order();
            MockSide ms = new MockSide();
            o.Items.Add(ms);
            o.Items.Remove(ms);
            Assert.Empty(o.Items);
        }

        [Fact]
        public void RemoveDrinkToOrderAddsToItems()
        {
            Order o = new Order();
            MockDrink md = new MockDrink();
            o.Items.Add(md);
            o.Items.Remove(md);
            Assert.Empty(o.Items);
        }

        [Fact]
        public void SubTotalCostIsCorrectForAllItems()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            MockSide ms = new MockSide();
            MockDrink md = new MockDrink();
            o.Items.Add(me);
            o.Items.Add(ms);
            o.Items.Add(md);
            Assert.Equal(6, o.SubtotalCost);
        }

        [Fact]
        public void TotalCostCannotBeNegative()
        {
            Order o = new Order();
            FakeMockIMenuItem fake = new FakeMockIMenuItem();
            Assert.Equal(0, o.SubtotalCost);
        }
    }
}
