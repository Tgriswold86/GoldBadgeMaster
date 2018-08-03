using Challenge_3;
using Microsoft.VisualStudio.TestTools.UnitTesting;

[TestClass]
public class OutingsRepo_Test
{
    OutingRepository oRepo = new OutingRepository();

    [TestMethod]
    public void Challenge3Q()
    {
        Outings one = new Outings((Event)4, 13, "07/13/1986", 777, 1);
        oRepo.AddOutingToList(one);

        var actual = oRepo.GetList().Count;
        var expected = 1;

        Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void Challenge1_OutingsRepo_List()
    {
        var actual = oRepo.GetList().Count;
        var expected = 0;

        Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void Challenge1_OutingsRepo_TA()
    {
        Outings one = new Outings((Event)4, 13, "07/13/1986", 777, 1);
        Outings two = new Outings((Event)4, 13, "07/13/1986", 777, 1);
        oRepo.AddOutingToList(one);
        oRepo.AddOutingToList(two);

        var actual = oRepo.TotalAllOutings();
        var expected = 2;

        Assert.AreEqual(actual, expected);
    }

    [TestMethod]
    public void Challenge1_OutingsRepo_TABT()
    {
        Outings one = new Outings((Event)4, 13, "07/13/1986", 777, 1);
        Outings two = new Outings((Event)4, 13, "07/13/1986", 777, 1);
        oRepo.AddOutingToList(one);
        oRepo.AddOutingToList(two);

        var actual = oRepo.TotalAllOutingsByType((Event)4);
        var expected = 2;

        Assert.AreEqual(actual, expected);
    }

}

