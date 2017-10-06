using System.Collections.Generic;

namespace AnalysisLibrary.Accountability
{
    public class AccountabilityType
    {
        public int Id { get; set; }
        public AccountabilityTypes Type { get; set; }

        public IEnumerable<Accountability> Accountabilities { get; set; }
    }

    public enum AccountabilityTypes
    {
        // Company - Private
        EmploymentRelationship = 1,
        CommersialSalesRelationship = 2,

        // Company - Company
        SupplierRelationship = 4
    }
}
