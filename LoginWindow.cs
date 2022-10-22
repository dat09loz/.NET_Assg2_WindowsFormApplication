namespace Assg2_WindowsFormApplication
{
    public partial class LoginWindow : Form
    {
        public LoginWindow()
        {
            InitializeComponent();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //check credentials
            bool success = false;
            string[] splitChar = {" ", ","};
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users)
            {
                string[] userInfo = user.Split(splitChar, StringSplitOptions.RemoveEmptyEntries); //convert each line to an array, with splitChar as split indicator
                if (UsernameTextBox.Text == userInfo[0] && PasswordTextBox.Text == userInfo[1]) //correct username and password?
                {
                    success = true;
                    Hide();
                    //username, password, usertype, firstname, lastname, DOB
                    string name = $"{userInfo[3]} {userInfo[4]}";
                    new TextEditorWindow(this, name, userInfo[2]).Show();
                    break;
                }
            }
            //login failed
            if (!success)
            {
                MessageBox.Show("Invalid Credentials!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //clear textbox
            UsernameTextBox.Text = string.Empty;
            PasswordTextBox.Text = string.Empty;
        }

        private void NewUserBtn_Click(object sender, EventArgs e)
        {
            Hide();
            new NewUserWindow(this).Show();// pass this session in to be called later
        }
    }
}