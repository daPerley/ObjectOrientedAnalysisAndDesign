using BengansBowlinghallLibrary;
using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Data.Entity;

namespace BengansBowlinghallTest
{
    [TestClass]
    public class PartyRepositoryTest
    {
        [TestMethod]
        public void AddParty_WithGivenCredentials_ShouldReturnPartyWithGivenName()
        {
            PartyRepositoryInMemory sut = new PartyRepositoryInMemory();

            sut.AddParty("Sane", true).Name.ShouldBeEquivalentTo("Sane");
        }

        [TestMethod]
        public void CanCreateDatabase()
        {
            var dbContext = new BengansBowlingDbContext();

            dbContext.Database.EnsureDeleted();

            var created = dbContext.Database.EnsureCreated();

            Assert.IsTrue(created);

            dbContext.Database.EnsureDeleted();
        }

        [TestMethod]
        public void GetParty_WithGivenId_ShouldReturnPartyWithGivenName_SQL()
        {
            var dbContext = new BengansBowlingDbContext();

            dbContext.Database.EnsureCreated();

            PartyRepositorySQL sut = new PartyRepositorySQL(dbContext);

            sut.AddParty("Galen", false);

            sut.Get(1).Name.ShouldAllBeEquivalentTo("Galen");

            dbContext.Database.EnsureDeleted();
        }

    }
}
