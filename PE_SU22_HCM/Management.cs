using Services.Models;
using Services.Services;

namespace PE_SU22_HCM
{
    public partial class Management : Form
    {
        BankAccountServices _bankAccountService;
        List<BankAccount> _listAccounts;
        AccountTypeServices _accountTypeServices;

        public Management()
        {
            InitializeComponent();
            _accountTypeServices = new AccountTypeServices();
            cbType.Items.AddRange(_accountTypeServices.GetAll().Select(p => p.TypeName).ToArray());
            cbType.DropDownStyle = ComboBoxStyle.DropDownList;

            ReloadList();

        }

        private void ReloadList()
        {
            _accountTypeServices = new AccountTypeServices();

            _bankAccountService = new BankAccountServices();
            _listAccounts = _bankAccountService.GetAll()
            .Select(p =>
            {
                p.Type = _accountTypeServices.GetAll().FirstOrDefault(t => t.TypeId == p.TypeId);
                return p;
            })
            .ToList();

            dgvListAccount.DataSource = new BindingSource { DataSource = _listAccounts };
        }

        private void resetState()
        {
            txtID.Text = "";
            txtName.Text = "";
            dtpDate.Text = "";
            txtBranch.Text = "";
            txtSearch.Text = "";
            cbType.SelectedIndex = 0;

            //Utils.resetErrorMes();
            txtID.ReadOnly = false;
            btnAdd.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void dgvListAccount_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dgv = (DataGridView)sender;
            //labelMes.Text = "";
            if (e.RowIndex == dgv.Rows.Count - 1 || e.RowIndex == -1)
            {
                ReloadList();
                resetState();
            }
            else
            {
                var account = _listAccounts[e.RowIndex];
                txtID.ReadOnly = true;
                txtID.Text = account.AccountId.ToString();
                txtName.Text = account.AccountName.ToString();
                dtpDate.Value = account.OpenDate.Value;
                txtBranch.Text = account.BranchName.ToString();
                cbType.Text = account.Type.ToString();

                //update button state
                btnAdd.Enabled = false;
                btnDelete.Enabled = true;
                btnUpdate.Enabled = true;
            }
        }

        private BankAccount GetAccount()
        {
            try
            {
                BankAccount account = null;
                _accountTypeServices = new AccountTypeServices();
                String id = txtID.Text;
                String name = txtName.Text;
                String branch = txtBranch.Text;
                DateTime date = dtpDate.Value;
                String typeName = cbType.Text;

                if (!Utils.isEmpty(id) && !Utils.isEmpty(name) && !Utils.isEmpty(branch))
                {
                    if (Utils.CheckBranch(branch) && Utils.CheckDate(date))
                    {
                        String typeId = _accountTypeServices.GetAll().FirstOrDefault(p => p.TypeName == typeName).TypeId;
                        account = new BankAccount(id, name, date, branch, typeId);
                    }
                }
                else
                {
                    MessageBox.Show("fail!", "Thong bao", MessageBoxButtons.OK);
                }
                return account;
            }
            catch
            {
                MessageBox.Show("fail!", "Thong bao", MessageBoxButtons.OK);
                return null;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            _bankAccountService = new BankAccountServices();
            BankAccount account = GetAccount();
            if (account == null)
            {

            }
            else
            {
                bool flag = _bankAccountService.Create(account);
                if (!flag)
                {
                    MessageBox.Show("fail!", "Thong bao", MessageBoxButtons.OK);

                }
                ReloadList();
                resetState();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            String id = txtID.Text;
            _bankAccountService = new BankAccountServices();
            BankAccount account = _bankAccountService.GetAccount(id);
            if (account != null)
            {
                _bankAccountService.Remove(account);
                ReloadList();
                resetState();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _bankAccountService = new BankAccountServices();
            BankAccount account = GetAccount();
            if (account == null)
            {

            }
            else
            {
                _bankAccountService.Update(account);
                ReloadList();
                resetState();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string branch = txtSearch.Text;
            resetState();
            if (!string.IsNullOrWhiteSpace(branch))
            {
                _accountTypeServices = new AccountTypeServices();

                _bankAccountService = new BankAccountServices();
                _listAccounts = _bankAccountService.GetAccountByBranch(branch)
                .Select(p =>
                {
                    p.Type = _accountTypeServices.GetAll().FirstOrDefault(t => t.TypeId == p.TypeId);
                    return p;
                })
                .ToList();

                dgvListAccount.DataSource = new BindingSource { DataSource = _listAccounts };
            }
        }
    }
}
