using AnalysisLibrary.Accountability;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTest
{
    [TestClass]
    public class AccountabilityTest
    {
        public static AccountabilityType accountabilityType = new AccountabilityType
        {
            Id = 1,
            Type = AccountabilityTypes.EmploymentRelationship
        };

        public static Party partyOne = new Party
        {
            Id = 1,
            Name = "Party One",
            Phone = "0700770700",
            Email = "party@one.com",
            PartyType = PartyType.Company
        };

        public static Party partyTwo = new Party
        {
            Id = 2,
            Name = "Party Two",
            Phone = "7077070700",
            Email = "party@two.com",
            PartyType = PartyType.Private
        };

        public static Accountability accountability = new Accountability
        {
            AccountabilityTypeId = 1,
            AccountabilityType = accountabilityType,

            ComissionerId = 2,
            Comissioner = partyTwo,

            ResponsibleId = 1,
            Responsible = partyOne,

            AccountabilityStart = new DateTime(2017, 10, 01),
            AccountabilityEnd = new DateTime(2018, 03, 31)
        };

        [TestMethod]
        public void TestMethod1()
        {
        }
    }
}
