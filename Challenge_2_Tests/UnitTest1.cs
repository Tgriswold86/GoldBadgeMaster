using System;
using System.Collections.Generic;
using System.Security.Claims;
using Challenge_2;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace Challenge_2_Tests
{
    [TestClass]
    public class UnitTest1
    {
        Queue<Item> _ClaimListTest = new Queue<Item>();

        ClaimsRepo _claimrepo = new ClaimsRepo();

        [TestMethod]
        public void ClaimRepo_AddClaim_ClaimToStack()
        {
            //Arrange
            Item i1 = new Item(1, "MEOW", "It's a claim", 13, "7/13/2018", "7/13/2018");
            _claimrepo.AddItem(i1);

            //Act
            var actual = _claimrepo.GetClaimList().Count;
            var expect = 1;

            //Assert

            Assert.AreEqual(actual, expect);
        }

        //[TestMethod]
        //public void ClaimRepo_ShouldThrowErrorIfWrongType()
        //{
        //    //Arrange
        //    claimsrepo.AddItem("text");  
        //}

        [TestMethod]
        public void ClaimRepo_GetList()
        {
            var actual = _claimrepo.GetClaimList();
            var expect = 0;
        }

        [TestMethod]
        public void ClaimRepo_SeeTopStackClaim()
        {
            Queue<Item> items = new Queue<Item>();
            Item items2 = new Item(1, "MEOW", "It's a claim", 13, "7/13/2018", "7/13/2018");
            Item items3 = new Item(1, "MEOW", "It's a claim", 13, "7/13/2018", "7/13/2018");
            _claimrepo.AddItem(items2);
            _claimrepo.AddItem(items3);
            _claimrepo.SeeCurrentClaim();

            var actual = _claimrepo.SeeCurrentClaim();
            var expect = items2;

            Assert.AreEqual(expect, actual);
        }
    }
}


//Queue<Item> _claimlist = new Queue<Item>();

//public void AddItem(Item cid)
//{
//    _claimlist.Enqueue(cid);
//}