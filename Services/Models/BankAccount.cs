#nullable disable

namespace Services.Models
{
    public partial class BankAccount
    {

        public string AccountId { get; set; }
        public string AccountName { get; set; }
        public DateTime? OpenDate { get; set; }
        public string BranchName { get; set; }
        public string TypeId { get; set; }

        public BankAccount()
        {

        }
        public BankAccount(string accountId, string accountName, DateTime? openDate, string branchName, string typeId)
        {
            AccountId = accountId;
            AccountName = accountName;
            OpenDate = openDate;
            BranchName = branchName;
            TypeId = typeId;
        }


        public virtual AccountType Type { get; set; }


    }
}
