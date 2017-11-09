using System.Linq;

namespace BengansBowlinghallLibrary
{
    public class PartyRepositorySQL : IPartyRepository
    {
        private BengansBowlingDbContext _context;

        public PartyRepositorySQL(BengansBowlingDbContext context)
        {
            _context = context;
        }

        public Party AddParty(string name, bool isMember)
        {
            Party newParty = new Party()
            {
                Name = name,
                IsMember = isMember
            };

            _context.Parties.Add(newParty);
            _context.SaveChanges();

            return newParty;
        }

        public Party Get(int id)
        {
            return _context.Parties.FirstOrDefault(p => p.Id == id);
        }
    }
}
