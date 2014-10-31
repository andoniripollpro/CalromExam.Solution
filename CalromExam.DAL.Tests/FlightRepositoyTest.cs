using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CalromExam.DAL.Repositiries;
using System.Collections.Generic;
using CalromExam.BL;

namespace CalromExam.DAL.ITests
{
    [TestClass]
    public class FlightRepositoyTest
    {
        #region MembershipEntities

        [TestMethod]
        public void MembershipEntities_NA_AllMembers()
        {
            //Arrange
            int expectedCount = 3;
            string expectedMemberName = "Mr Don Hall";
            MembershipRepository toTest = new MembershipRepository();

            //Act
            List<MembershipEntity> actual = toTest.MembershipEntities;

            //Assert
            Assert.AreEqual(expectedCount, actual.Count);
            Assert.IsNotNull (actual.Find(m => m.MemberName == expectedMemberName));
        }

        #endregion
    }
}
