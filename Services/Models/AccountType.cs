#nullable disable

namespace Services.Models
{
    public partial class AccountType
    {
        public AccountType()
        {
            BankAccounts = new HashSet<BankAccount>();
        }

        public string TypeId { get; set; }
        public string TypeName { get; set; }
        public string TypeDesc { get; set; }

        public virtual ICollection<BankAccount> BankAccounts { get; set; }

        public override string ToString()
        {
            return TypeName;
        }
    }
}
