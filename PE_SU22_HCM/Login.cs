using Services.Models;

namespace PE_SU22_HCM
{
    public partial class Login : Form
    {
        BankAccountTypeContext _context;
        bool _isAdmin = false;
        public Login()
        {
            _context = new BankAccountTypeContext();
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;

            User user = new User();
            var check = _context.Users.Where(p => p.UserId.Equals(username) && p.Password.Equals(password)).FirstOrDefault();

            if (check != null)
            {
                user = check;
                if (user.UserRole == 1)
                {
                    //MessageBox.Show("Dang nhap thanh cong", "Thong bao", MessageBoxButtons.OK);
                    this.Hide();
                    Form frmanagement = new Management();
                    frmanagement.ShowDialog();
                }
            }
            else
            {
                //fail
                MessageBox.Show("You are not allowed to access this function!", "Thong bao", MessageBoxButtons.OK);
            }
        }
    }
}