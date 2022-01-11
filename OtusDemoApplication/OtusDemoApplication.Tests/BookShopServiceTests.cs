using System;
using FluentAssertions;
using NUnit.Framework;
using OtusDemoApplication.ApplicationServices;
using OtusDemoApplication.ApplicationServices.Models;

namespace OtusDemoApplication.Tests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void ShouldSuccessfullyAddBookToShop()
        {
            //arrange
            var bookShopService = new BookShopService();
            
            //act
            bookShopService.AddBookToShop(new Book
            {
                Name = "Harry Potter"
            });
            
            //assert
            bookShopService.GetBooksCount().Should().Be(1);
        }
        
        [Test]
        public void ShouldSuccessfullyBuyRandomBook()
        {
            //arrange
            var bookShopService = new BookShopService(3);
            
            //act
            bookShopService.BuyRandomBook();
            
            //assert
            bookShopService.GetBooksCount().Should().Be(2);
        }
        
        [Test]
        public void ShouldThrowAnExceptionOnBuyBookFromEmptyShop()
        {
            //arrange
            var bookShopService = new BookShopService();
            
            //act
            Action act = () => bookShopService.BuyRandomBook();
            
            //assert
            act.Should().Throw<ArgumentNullException>();
        }
    }
}