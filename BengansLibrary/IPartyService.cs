namespace BengansBowlinghallLibrary
{
    public interface IPartyService
    {
        Party GetChampion(string year);
        Party GetWinner(int gameId);
    }
}
