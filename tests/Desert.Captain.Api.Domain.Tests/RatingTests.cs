using Microsoft.VisualStudio.TestTools.UnitTesting;
using Desert.Captain.Domain.Catalog;


namespace _Desert_Captain_API_.Domain.Tests
{
[TestClass]
public class RatingTests
{
    [TestMethod]
    public void Can_Create_New_Rating()
    {
        //Arrange
        var rating = new Rating(1, "Mike", "Great fit!");

        //Act (empty)

        //Assert
        Assert.AreEqual(1, rating.Stars);
        Assert.AreEqual("Mike", rating.UserName);
        Assert.AreEqual("Great fit!", rating.Review);

    }
}
}