using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assg2_WindowsFormApplication
{
    public partial class NewUserWindow : Form
    {
        LoginWindow loginWindow;
        public NewUserWindow(LoginWindow loginWindow)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;

        }

        private void CancelBtn_Click(object sender, EventArgs e)
        {
            Close();
            loginWindow.Show();
        }

        //show the login screen after this form is closed
        private void NewUserWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginWindow.Show();
        }

        //create a new user
        private void CreateUserBtn_Click(object sender, EventArgs e)
        {
            //field check
            if (FNameTextBox.Text == "") //first name field left blank
            {
                MessageBox.Show("First Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } 
            else if (LNameTextBox.Text == "") //last name field left blank
            {
                MessageBox.Show("Last Name cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UserTypeComboBox.SelectedItem == null) //combobox not selected
            {
                MessageBox.Show("Please select an user type!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UsernameTextBox.Text == "") //username field left blank
            {
                MessageBox.Show("Username cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (UsernameExists(UsernameTextBox.Text)) //username exists
            {
                MessageBox.Show("Username exists!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTextBox.Text == "") //password field left blank
            {
                MessageBox.Show("Password cannot be blank!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (ConfirmPasswordTextBox.Text == "") //password field left blank
            {
                MessageBox.Show("Please re-enter your password!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (PasswordTextBox.Text != ConfirmPasswordTextBox.Text) //password does not match
            {
                PasswordTextBox.Text = string.Empty;
                ConfirmPasswordTextBox.Text = string.Empty;
                MessageBox.Show("Passwords do mot match!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //create an user entry inside login.txt
            {
                string newUserEntry = $"\n{UsernameTextBox.Text},{PasswordTextBox.Text},{UserTypeComboBox.SelectedItem},{FNameTextBox.Text},{LNameTextBox.Text},{DOBPicker.Text}";
                
                File.AppendAllText("login.txt", newUserEntry);

                MessageBox.Show("User successfully created!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Close();
                loginWindow.Show();
            }
        }

        //check if the username exists in the database
        private Boolean UsernameExists(string username)
        {
            string[] users = File.ReadAllLines("login.txt");
            foreach (string user in users)
            {
                string[] splitChar = { " ", "," };
                string[] info = user.Split(splitChar, StringSplitOptions.RemoveEmptyEntries); //split and remove empty strings
                if (username == info[0])
                {
                    return true;
                }

            }
            return false;
        }
    }
}
