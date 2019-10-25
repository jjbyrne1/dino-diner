/* OrderTests.cs
 * Author: Jason Byrne
 */
using System;
using System.Collections.Generic;
using System.Text;
using DinoDiner.Menu;
using Xunit;
using System.Collections.ObjectModel;

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
        }

        class MockDrink : Drink
        {
            public MockDrink()
            {
                this.Price = 2.00;
            }
        }

        class MockSide : Side
        {
            public MockSide()
            {
                this.Price = 3.00;
            }
        }

        class FakeMockIMenuItem : Entree
        {
            public override double Price { get; protected set; } = -10;
        }

        // Add Order Item
        [Fact]
        public void AddEntreeToOrderAddsToItems()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            o.Add(me);
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
            MockSide ms = new MockSide();
            o.Add(ms);
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(ms, item);
                });
        }

        [Fact]
        public void AddDrinkToOrderAddsToItems()
        {
            Order o = new Order();
            MockDrink md = new MockDrink();
            o.Add(md);
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(md, item);
                });
        }

        //Remove Menu Item
        [Fact]
        public void RemoveEntreeFromOrderRemovesFromItems()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            o.Add(me);
            o.Remove(me);
            Assert.Empty(o.Items);
        }

        [Fact]
        public void RemoveSideFromOrderRemovesFromItems()
        {
            Order o = new Order();
            MockSide ms = new MockSide();
            o.Add(ms);
            o.Remove(ms);
            Assert.Empty(o.Items);
        }

        [Fact]
        public void RemoveDrinkFromOrderRemovesFromItems()
        {
            Order o = new Order();
            MockDrink md = new MockDrink();
            o.Add(md);
            o.Remove(md);
            Assert.Empty(o.Items);
        }

        [Fact]
        public void SubtotalCostIsSumOfAllItemPrices()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            MockSide ms = new MockSide();
            MockDrink md = new MockDrink();
            o.Add(me);
            o.Add(ms);
            o.Add(md);
            Assert.Equal(6.00, o.SubtotalCost);
        }

        [Fact]
        public void SalesTaxIsCorrectWhenSet()
        {
            Order o = new Order();
            o.SalesTaxRate = .03;
            Assert.Equal(.03, o.SalesTaxRate);
        }

        [Fact]
        public void SalesTaxCostIsCorrect()
        {
            Order o = new Order();
            MockEntree me = new MockEntree();
            o.Add(me);
            o.SalesTaxRate = .03;
            Assert.Equal(0.03*1.00, o.SalesTaxCost);
        }

        [Fact]
        public void TotalCostIsCorrect()
        {
            Order o = new Order();
            MockSide ms = new MockSide();
            o.Add(ms);
            o.SalesTaxRate = .03;
            Assert.Equal(0.03 * 3.00 + 3.00, o.TotalCost);
        }

        [Fact]
        public void TotalCostCannotBeNegative()
        {
            Order o = new Order();
            FakeMockIMenuItem fake = new FakeMockIMenuItem();
            o.Add(fake);
            Assert.Equal(0, o.TotalCost);
        }
    }
}
