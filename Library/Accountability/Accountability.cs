namespace AnalysisLibrary.Accountability
{
    public class Accountability
    {
        public int AccountabilityTypeId { get; set; }
        public AccountabilityType AccountabilityType { get; set; }

        public int ComissionerId { get; set; }
        public Party Comissioner { get; set; }

        public int ResponsibleId { get; set; }
        public Party Responsible { get; set; }
    }
}
