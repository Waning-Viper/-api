using Waning_Viper_API.Domain.Catalog;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Waning_Viper.Domain.Tests;

[TestClass]
public class ItemTests
{
    [TestMethod]
    public void Can_Create_New_Item()
    {

    var item = new Item("Name", "Description", "Brand", 10.00m);

    Assert.AreEqual("Name", item.Name);
    Assert.AreEqual("Description", item.Description);
    Assert.AreEqual("Brand", item.Brand);
    Assert.AreEqual(10.00m, item.Price);
    
    }

    [TestMethod]
    public void Can_Create_Add_Rating() {
        var item = new Item("Name", "Description", "Brand", 10.00m);
        var rating = new Rating(5, "Name", "Review");

        item.AddRating(rating);

        Assert.AreEqual(rating, item.Ratings[0]);
    }
}