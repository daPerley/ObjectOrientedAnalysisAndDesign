using System.Collections.Generic;

namespace BengansBowlinghallLibrary.FakeData
{
    public class FakeSets
    {
        public static readonly FakeSets _instance = new FakeSets();

        public List<Set> GetSets()
        {
            return new List<Set>
        {
            Set.RandomSet(1, 1, 1),
            Set.RandomSet(2, 1, 2),
            Set.RandomSet(3, 1, 3),
            Set.RandomSet(4, 2, 1),
            Set.RandomSet(5, 2, 2),
            Set.RandomSet(6, 2, 3),
            Set.RandomSet(7, 3, 1),
            Set.RandomSet(8, 3, 2),
            Set.RandomSet(9, 3, 3),
            Set.RandomSet(10, 4, 1),
            Set.RandomSet(11, 4, 2),
            Set.RandomSet(12, 4, 3),
            Set.RandomSet(13, 5, 1),
            Set.RandomSet(14, 5, 2),
            Set.RandomSet(15, 5, 3),
            Set.RandomSet(16, 6, 1),
            Set.RandomSet(17, 6, 2),
            Set.RandomSet(18, 6, 3),
            Set.RandomSet(19, 7, 1),
            Set.RandomSet(20, 7, 2),
            Set.RandomSet(21, 7, 3),
        };
        }

        FakeSets() { }
    }
}
