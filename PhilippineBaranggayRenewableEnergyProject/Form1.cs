namespace PhilippineBaranggayRenewableEnergyProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            if ((txtUsername.Text == "joy123") && (txtPassword.Text == "sayapal123") || (txtUsername.Text == "andrei123") && (txtPassword.Text == "valdez123"))
            {
                dashboard.Show();
                this.Hide();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}