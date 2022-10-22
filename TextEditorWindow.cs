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
        //current file on the text window
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

        
        //text window  
        private void TextEditorWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            loginWindow.Show();
        }

        //about window
        private void AboutMenuStrip_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Text Editor v1.0\nCreator: Trong Dat Nguyen\nCo-creator: VS 2022's powerful code autocomplete feature", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //menu strip
        private void NewMenuStrip_Click(object sender, EventArgs e) //ctrl+n
        {
            //user don't want to save changes / create a new text file
            if (UnsavedChanges() != DialogResult.Cancel)
            {
                Text = "Text Editor";
                currentFile = string.Empty;
                RichTextBox.Text = string.Empty;
            }
        }

        private void OpenMenuStrip_Click(object sender, EventArgs e)//ctrl+o
        {
            //open a file dialog for the user to choose file
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Title = "Open File";
            //filter option: rtf, txt, all
            dialog.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            
            //user confirm the option
            if(dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile; //load file content
                LoadFile();
            }
        }

        private void SaveMenuStrip_Click(object sender, EventArgs e)
        {
            //simply save the file
            if (!string.IsNullOrEmpty(currentFile))
            {
                SaveFile();
            }
            //if file empty, call save as function
            else
            {
                SaveAsMenuStrip_Click(sender, e);
            }
        }

        private void SaveAsMenuStrip_Click(object sender, EventArgs e)
        {
            //save as a new file
            SaveFileDialog dialog = new SaveFileDialog();
            dialog.Title = "Save As";
            dialog.Filter = "rtf files (*.rtf)|*.rtf|txt files (*.txt)|*.txt|All files (*.*)|*.*";
            //when the user confirm the option
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                currentFile = dialog.FileName;
                Text = currentFile; //load file content
                SaveFile();
            }
        }

        private void LogoutMenuStrip_Click(object sender, EventArgs e)
        {
            Close();
            loginWindow.Show();
        }

        private void CutMenuStrip_Click(object sender, EventArgs e)
        {
            if (RichTextBox.SelectionLength > 0)
            {
                RichTextBox.Cut();
            }
        }

        private void CopyMenuStrip_Click(object sender, EventArgs e)
        {
            if (RichTextBox.SelectionLength > 0)
            {
                RichTextBox.Copy();
            }
        }

        private void PasteMenuStrip_Click(object sender, EventArgs e)
        {
            RichTextBox.Paste();
        }


        //tool strip

        private void NewToolStrip_Click(object sender, EventArgs e) //ctrl+n
        {
            NewMenuStrip_Click(sender, e);
        }

        private void OpenToolStrip_Click(object sender, EventArgs e)//ctrl+o
        {
            OpenMenuStrip_Click(sender, e);
        }

        private void SaveToolStrip_Click(object sender, EventArgs e)
        {
            SaveMenuStrip_Click(sender, e);
        }

        private void SaveAsToolStrip_Click(object sender, EventArgs e)
        {
            SaveAsMenuStrip_Click(sender, e);
        }


        private void CutToolStrip_Click(object sender, EventArgs e)
        {
            CutMenuStrip_Click(sender, e);
        }

        private void CopyToolStrip_Click(object sender, EventArgs e)
        {
            CopyMenuStrip_Click(sender, e);
        }

        private void PasteToolStrip_Click(object sender, EventArgs e)
        {
            PasteMenuStrip_Click(sender, e);
        }


        private void BoldToolStrip_Click(object sender, EventArgs e) //ctrl+b
        {
            Font currentFont = RichTextBox.SelectionFont; //selected text
            //undo bold
            if (currentFont.Bold)
            {
                //nesting style
                if (currentFont.Italic && currentFont.Underline)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic | FontStyle.Underline);
                else if (currentFont.Italic)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic);
                else if (currentFont.Underline)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Underline);
                //standalone style
                else 
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Regular);
                //uncheck bold button
                BoldToolStrip.Checked = false;
            }
            //apply bold (with existing styles)
            else
            {
                RichTextBox.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Bold);
                //check bold button
                BoldToolStrip.Checked = true;
            }
        }

        private void ItalicToolStrip_Click(object sender, EventArgs e)
        {
            Font currentFont = RichTextBox.SelectionFont; //selected text
            //undo style
            if (currentFont.Italic)
            {
                //nesting style
                if (currentFont.Bold && currentFont.Underline)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Underline);
                else if (currentFont.Bold)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Underline)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Underline);
                //standalone style
                else
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Regular);
                //uncheck style button
                ItalicToolStrip.Checked = false;
            }
            //apply style (with existing styles)
            else
            {
                RichTextBox.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Italic);
                //check style button
                ItalicToolStrip.Checked = true;
            }
        }

        private void UnderlineToolStrip_Click(object sender, EventArgs e)
        {
            Font currentFont = RichTextBox.SelectionFont; //selected text
            //undo style
            if (currentFont.Underline)
            {
                //nesting style
                if (currentFont.Bold && currentFont.Italic)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold | FontStyle.Italic);
                else if (currentFont.Bold)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Bold);
                else if (currentFont.Italic)
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Italic);
                //standalone style
                else
                    RichTextBox.SelectionFont = new Font(currentFont, FontStyle.Regular);
                //uncheck style button
                UnderlineToolStrip.Checked = false;
            }
            //apply style (with existing styles)
            else
            {
                RichTextBox.SelectionFont = new Font(currentFont, currentFont.Style | FontStyle.Underline);
                //check style button
                UnderlineToolStrip.Checked = true;
            }
        }

        //apply font size to RTB, whenever the comboBox's value changes
        private void FontSizeComboBoxToolStrip_TextChanged(object sender, EventArgs e)
        {
            //try apply font size
            if (RichTextBox.SelectionLength > 0 && Single.TryParse(FontSizeComboBoxToolStrip.Text, out Single size))
            {
                Font currentFont = RichTextBox.SelectionFont;
                if (currentFont != null)
                    RichTextBox.SelectionFont = new Font(currentFont.FontFamily, size, currentFont.Style);
            }
        }

        //capture text styles whenever a key is pressed
        private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            UpdateFontStylesState();
        }

        //capture text styles when user click on the text
        private void RichTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UpdateFontStylesState();
        }



        //Functions
        private void SaveFile()
        {
            //save the file in rtf or txt
            string fileEx = Path.GetExtension(currentFile);
            if (fileEx == ".rtf")
            {
                File.WriteAllText(currentFile, RichTextBox.Rtf);
            }
            if (fileEx == ".txt")
            {
                File.WriteAllText(currentFile, RichTextBox.Text);
            }
        }

        private void LoadFile()
        {
            //handle load rtf or txt file to the richtextbox
            string fileEx = Path.GetExtension(currentFile);
            if (fileEx == ".rtf")
            {
                RichTextBox.LoadFile(currentFile, RichTextBoxStreamType.RichText); //richtext option for rtf
            }
            if (fileEx == ".txt")
            {
                RichTextBox.LoadFile(currentFile, RichTextBoxStreamType.PlainText); //plaintext option for txt            }
            }
        }


        private DialogResult UnsavedChanges()
        {
            //monitor richtextbox contect for any new changes
            DialogResult result = DialogResult.None;

            //save changes based on user choice
            if (!string.IsNullOrEmpty(currentFile) && //currentFile not empty?
                //the rtb content is diffirent to saved file (rtf/txt)?
                File.ReadAllText(currentFile) != RichTextBox.Rtf && 
                File.ReadAllText(currentFile) != RichTextBox.Text &&
                //user click "yes"
                (result = MessageBox.Show($"Do you want to save changes to {currentFile}", "Save Changes", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)) == DialogResult.Yes)
            {
                SaveFile();
            }

            return result;
        }


        //adjust style buttons' state (B, I, U) based on the highlighted text
        private void UpdateFontStylesState()
        {
            Font currentFont = RichTextBox.SelectionFont; //the current text selection
            if (currentFont != null)
            {
                //boolean
                BoldToolStrip.Checked = currentFont.Bold; 
                ItalicToolStrip.Checked = currentFont.Italic;
                UnderlineToolStrip.Checked = currentFont.Underline;
            }
        }
    }
}
