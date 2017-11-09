namespace BengansBowlinghallLibrary
{
    public interface IBowlingService
    {
        Party GetChampion(string year);
        Party GetWinner(int gameId);

        Party GetIM(int id);
        Party AddPartyIM(string name, bool isMember);
    }
}
