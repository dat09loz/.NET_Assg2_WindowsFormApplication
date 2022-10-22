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
    public partial class TextEditorWindow : Form
    {
        //store login window session and logged in user details
        LoginWindow loginWindow;
        string name, userType;
        //file object for this text window
        string currentFile;

        public TextEditorWindow(LoginWindow loginWindow, string name, string userType)
        {
            InitializeComponent();
            this.loginWindow = loginWindow;
            this.name = name;
            this.userType = userType;
        }

        //if the user type is "view", disable all tools
        private void TextEditorWindow_Load(object sender, EventArgs e)
        {
            UsernameToolStrip.Text = $"User Name: {name} | User Type: {userType}";
            if(userType == "View")
            {
                NewMenuStrip.Enabled = false;
                SaveMenuStrip.Enabled = false;
                SaveAsMenuStrip.Enabled = false;
                EditMenuStripTab.Enabled = false;
                NewToolStrip.Enabled = false;
                SaveToolStrip.Enabled = false;
                SaveAsToolStrip.Enabled = false;
                BoldToolStrip.Enabled = false;
                ItalicToolStrip.Enabled = false;
                UnderlineToolStrip.Enabled = false;
                FontSizeComboBoxToolStrip.Enabled = false;
                CutToolStrip.Enabled = false;
                CopyToolStrip.Enabled = false;
                PasteToolStrip.Enabled = false;
            }
        }

        private void LogoutMenuStrip_Click(object sender, EventArgs e)
        {
            Close();
            loginWindow.Show();
        }

        private void TextEditorWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginWindow.Show();
        }






    }
}
