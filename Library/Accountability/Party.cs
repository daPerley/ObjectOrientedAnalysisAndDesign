﻿namespace AnalysisLibrary.Accountability
{
    public class Party
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string LegalId { get; set; }
        public PartyType PartyType { get; set; }
    }

    public enum PartyType
    {
        Private, Company
    }
}
