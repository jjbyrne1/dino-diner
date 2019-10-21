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
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockEntree me = new MockEntree();
            order.Add(me);
            o.Items = order;
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(me, item);
                });
        }

        [Fact]
        public void AddSideToOrderAddsToItems()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockSide ms = new MockSide();
            order.Add(ms);
            o.Items = order;
            Assert.Collection<IOrderItem>(o.Items,
                item =>
                {
                    Assert.Equal(ms, item);
                });
        }

        [Fact]
        public void AddDrinkToOrderAddsToItems()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockDrink md = new MockDrink();
            order.Add(md);
            o.Items = order;
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
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockEntree me = new MockEntree();
            order.Add(me);
            o.Items = order;
            order.Remove(me);
            o.Items = order;
            Assert.Empty(o.Items);
        }

        [Fact]
        public void RemoveSideFromOrderRemovesFromItems()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockSide ms = new MockSide();
            order.Add(ms);
            o.Items = order;
            order.Remove(ms);
            o.Items = order;
            Assert.Empty(o.Items);
        }

        [Fact]
        public void RemoveDrinkFromOrderRemovesFromItems()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockDrink md = new MockDrink();
            order.Add(md);
            o.Items = order;
            order.Remove(md);
            o.Items = order;
            Assert.Empty(o.Items);
        }

        [Fact]
        public void SubtotalCostIsSumOfAllItemPrices()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockEntree me = new MockEntree();
            MockSide ms = new MockSide();
            MockDrink md = new MockDrink();
            order.Add(me);
            order.Add(ms);
            order.Add(md);
            o.Items = order;
            Assert.Equal(6.00, o.SubtotalCost);
        }

        [Fact]
        public void SalesTaxIsCorrectWhenSet()
        {
            Order o = new Order();
            Assert.Equal(.03, o.SalesTaxRate);
        }

        [Fact]
        public void SalesTaxCostIsCorrect()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockEntree me = new MockEntree();
            order.Add(me);
            o.Items = order;
            Assert.Equal(0.03*1.00, o.SalesTaxCost);
        }

        [Fact]
        public void TotalCostIsCorrect()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            MockSide ms = new MockSide();
            order.Add(ms);
            o.Items = order;
            Assert.Equal(0.03 * 3.00 + 3.00, o.TotalCost);
        }

        [Fact]
        public void TotalCostCannotBeNegative()
        {
            ObservableCollection<IOrderItem> order = new ObservableCollection<IOrderItem>();
            Order o = new Order();
            FakeMockIMenuItem fake = new FakeMockIMenuItem();
            order.Add(fake);
            o.Items = order;
            Assert.Equal(0, o.TotalCost);
        }
    }
}
