using System;
using System.Collections.Generic;
using Challenge_1;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Challenge_1_Tests
{
    [TestClass]
    public class UnitTest1
    {
        MenuRepo menuRepo = new Challenge_1.MenuRepo();
        [TestMethod]
        public void MenuRepo_GetList_CountShouldBeSame()
        {
            //-- Arrange
            List<Item> itemtest = menuRepo.getList();

            //-- Act
            int actual = itemtest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_Countdown()
        {
            //-- Arrange
            
            Item item = new Item(1, "Water, far", "as the eye can see.", "Endless Ocean.", 7);
            menuRepo.removeFromList("a");
            List<Item> menuListTest = menuRepo.getList();

            //--Act
            int actual = menuListTest.Count;
            int expected = 0;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void MenuRepository_Countup()
        {
            //-- Arrange
            Item item = new Item(1, "Water, far", "as the eye can see.", "Endless Ocean.", 7);
            menuRepo.addItemToList(item);
            List<Item> menuListTest = menuRepo.getList();

            //-- Act
            int actual = menuListTest.Count;
            int expected = 1;

            //-- Assert
            Assert.AreEqual(expected, actual);
        }
    }
}