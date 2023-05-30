using Services.Models;

namespace Services.Services
{
    public class BankAccountServices : ServiceBase<BankAccount>
    {
        public BankAccount GetAccount(string id)
        {
            BankAccount bankAccount;
            bankAccount = this.GetAll().FirstOrDefault(p => p.AccountId == id, null);
            return bankAccount;
        }

        public List<BankAccount> GetAccountByBranch(string branch)
        {
            List<BankAccount> list;
            list = this.GetAll().Where(p => p.BranchName.ToLower().Contains(branch)).ToList();
            return list;
        }
    }
}
