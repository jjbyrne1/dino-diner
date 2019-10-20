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
                this.Price = 9.99;
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
                this.Price = 5.55;
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
                this.Price = 7.77;
            }

            public override string ToString()
            {
                return "Side";
            }
        }

        class MockIMenuItem : IMenuItem
        {
            public double Price { get; } = 10.00;

            public uint Calories { get; } = 100;

            public List<string> Ingredients { get; }
        }

        [Fact]
        public void AddEntreeToOrderAddsToItems()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            o.Items.Add(me);
            Assert.Contains(me, o.Items) ;
        }
    }
}
