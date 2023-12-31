namespace StoreItemTest
{
    [TestClass]
    public class StoreItemTest
    {
        [TestMethod]
        public void Price_Valid()
        {
            // Arrange
            double price = 100.0;
            StoreItem storeItem = new StoreItem(price, 5, Items.Headphones);

            // Act
            double result = storeItem.Price;

            // Assert
            Assert.AreEqual(price, result);
        }

        [TestMethod]
        public void Price_Invalid()
        {
            // Arrange
            double invalidPrice = -50.0;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new StoreItem(invalidPrice, 5, Items.Headphones));
        }

        [TestMethod]
        public void QuantityInStock_Valid()
        {
            // Arrange
            int quantity = 10;
            StoreItem storeItem = new StoreItem(75.0, quantity, Items.Mouse);

            // Act
            int result = storeItem.QuantityInStock;

            // Assert
            Assert.AreEqual(quantity, result);
        }

        [TestMethod]
        public void QuantityInStock_Invalid()
        {
            // Arrange
            int invalidQuantity = -5;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new StoreItem(50.0, invalidQuantity, Items.PowerBank));
        }

        [TestMethod]
        public void Items_Valid()
        {
            // Arrange
            Items item = Items.Keyboard;
            StoreItem storeItem = new StoreItem(30.0, 15, item);

            // Act
            Items result = storeItem.Item;

            // Assert
            Assert.AreEqual(item, result);
        }

        [TestMethod]
        public void Items_Invalid()
        {
            // Arrange
            Items invalidItem = (Items)99;

            // Act and Assert
            Assert.ThrowsException<ArgumentException>(() => new StoreItem(20.0, 8, invalidItem));
        }
    
    }
}