namespace Assg2_WindowsFormApplication
{
    partial class TextEditorWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditorWindow));
            this.TextEditorMenuStrip = new System.Windows.Forms.MenuStrip();
            this.FileMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.NewMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SaveMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.FileStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.LogoutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.EditMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.CutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.HelpMenuStripTab = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutMenuStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.TopToolStrip = new System.Windows.Forms.ToolStrip();
            this.NewToolStrip = new System.Windows.Forms.ToolStripButton();
            this.OpenToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveToolStrip = new System.Windows.Forms.ToolStripButton();
            this.SaveAsToolStrip = new System.Windows.Forms.ToolStripButton();
            this.TopToolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BoldToolStrip = new System.Windows.Forms.ToolStripButton();
            this.ItalicToolStrip = new System.Windows.Forms.ToolStripButton();
            this.UnderlineToolStrip = new System.Windows.Forms.ToolStripButton();
            this.FontSizeComboBoxToolStrip = new System.Windows.Forms.ToolStripComboBox();
            this.TopToolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.UsernameToolStrip = new System.Windows.Forms.ToolStripLabel();
            this.SideToolStrip = new System.Windows.Forms.ToolStrip();
            this.CutToolStrip = new System.Windows.Forms.ToolStripButton();
            this.CopyToolStrip = new System.Windows.Forms.ToolStripButton();
            this.PasteToolStrip = new System.Windows.Forms.ToolStripButton();
            this.RichTextBox = new System.Windows.Forms.RichTextBox();
            this.TextEditorMenuStrip.SuspendLayout();
            this.TopToolStrip.SuspendLayout();
            this.SideToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // TextEditorMenuStrip
            // 
            this.TextEditorMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileMenuStripTab,
            this.EditMenuStripTab,
            this.HelpMenuStripTab});
            this.TextEditorMenuStrip.Location = new System.Drawing.Point(0, 0);
            this.TextEditorMenuStrip.Name = "TextEditorMenuStrip";
            this.TextEditorMenuStrip.Size = new System.Drawing.Size(800, 24);
            this.TextEditorMenuStrip.TabIndex = 0;
            this.TextEditorMenuStrip.Text = "menuStrip1";
            // 
            // FileMenuStripTab
            // 
            this.FileMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewMenuStrip,
            this.OpenMenuStrip,
            this.FileStripSeparator1,
            this.SaveMenuStrip,
            this.SaveAsMenuStrip,
            this.FileStripSeparator2,
            this.LogoutMenuStrip});
            this.FileMenuStripTab.Name = "FileMenuStripTab";
            this.FileMenuStripTab.Size = new System.Drawing.Size(37, 20);
            this.FileMenuStripTab.Text = "File";
            // 
            // NewMenuStrip
            // 
            this.NewMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("NewMenuStrip.Image")));
            this.NewMenuStrip.Name = "NewMenuStrip";
            this.NewMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.NewMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.NewMenuStrip.Text = "New";
            this.NewMenuStrip.Click += new System.EventHandler(this.NewMenuStrip_Click);
            // 
            // OpenMenuStrip
            // 
            this.OpenMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenMenuStrip.Image")));
            this.OpenMenuStrip.Name = "OpenMenuStrip";
            this.OpenMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.OpenMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.OpenMenuStrip.Text = "Open";
            this.OpenMenuStrip.Click += new System.EventHandler(this.OpenMenuStrip_Click);
            // 
            // FileStripSeparator1
            // 
            this.FileStripSeparator1.Name = "FileStripSeparator1";
            this.FileStripSeparator1.Size = new System.Drawing.Size(143, 6);
            // 
            // SaveMenuStrip
            // 
            this.SaveMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveMenuStrip.Image")));
            this.SaveMenuStrip.Name = "SaveMenuStrip";
            this.SaveMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.SaveMenuStrip.Text = "Save";
            this.SaveMenuStrip.Click += new System.EventHandler(this.SaveMenuStrip_Click);
            // 
            // SaveAsMenuStrip
            // 
            this.SaveAsMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsMenuStrip.Image")));
            this.SaveAsMenuStrip.Name = "SaveAsMenuStrip";
            this.SaveAsMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.SaveAsMenuStrip.Text = "Save As";
            this.SaveAsMenuStrip.Click += new System.EventHandler(this.SaveAsMenuStrip_Click);
            // 
            // FileStripSeparator2
            // 
            this.FileStripSeparator2.Name = "FileStripSeparator2";
            this.FileStripSeparator2.Size = new System.Drawing.Size(143, 6);
            // 
            // LogoutMenuStrip
            // 
            this.LogoutMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("LogoutMenuStrip.Image")));
            this.LogoutMenuStrip.Name = "LogoutMenuStrip";
            this.LogoutMenuStrip.Size = new System.Drawing.Size(146, 22);
            this.LogoutMenuStrip.Text = "Logout";
            this.LogoutMenuStrip.Click += new System.EventHandler(this.LogoutMenuStrip_Click);
            // 
            // EditMenuStripTab
            // 
            this.EditMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutMenuStrip,
            this.CopyMenuStrip,
            this.PasteMenuStrip});
            this.EditMenuStripTab.Name = "EditMenuStripTab";
            this.EditMenuStripTab.Size = new System.Drawing.Size(39, 20);
            this.EditMenuStripTab.Text = "Edit";
            // 
            // CutMenuStrip
            // 
            this.CutMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("CutMenuStrip.Image")));
            this.CutMenuStrip.Name = "CutMenuStrip";
            this.CutMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.CutMenuStrip.Size = new System.Drawing.Size(144, 22);
            this.CutMenuStrip.Text = "Cut";
            this.CutMenuStrip.Click += new System.EventHandler(this.CutMenuStrip_Click);
            // 
            // CopyMenuStrip
            // 
            this.CopyMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("CopyMenuStrip.Image")));
            this.CopyMenuStrip.Name = "CopyMenuStrip";
            this.CopyMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyMenuStrip.Size = new System.Drawing.Size(144, 22);
            this.CopyMenuStrip.Text = "Copy";
            this.CopyMenuStrip.Click += new System.EventHandler(this.CopyMenuStrip_Click);
            // 
            // PasteMenuStrip
            // 
            this.PasteMenuStrip.Image = ((System.Drawing.Image)(resources.GetObject("PasteMenuStrip.Image")));
            this.PasteMenuStrip.Name = "PasteMenuStrip";
            this.PasteMenuStrip.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteMenuStrip.Size = new System.Drawing.Size(144, 22);
            this.PasteMenuStrip.Text = "Paste";
            this.PasteMenuStrip.Click += new System.EventHandler(this.PasteMenuStrip_Click);
            // 
            // HelpMenuStripTab
            // 
            this.HelpMenuStripTab.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutMenuStrip});
            this.HelpMenuStripTab.Name = "HelpMenuStripTab";
            this.HelpMenuStripTab.Size = new System.Drawing.Size(44, 20);
            this.HelpMenuStripTab.Text = "Help";
            // 
            // AboutMenuStrip
            // 
            this.AboutMenuStrip.Name = "AboutMenuStrip";
            this.AboutMenuStrip.Size = new System.Drawing.Size(116, 22);
            this.AboutMenuStrip.Text = "About...";
            this.AboutMenuStrip.Click += new System.EventHandler(this.AboutMenuStrip_Click);
            // 
            // TopToolStrip
            // 
            this.TopToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.NewToolStrip,
            this.OpenToolStrip,
            this.SaveToolStrip,
            this.SaveAsToolStrip,
            this.TopToolStripSeparator1,
            this.BoldToolStrip,
            this.ItalicToolStrip,
            this.UnderlineToolStrip,
            this.FontSizeComboBoxToolStrip,
            this.TopToolStripSeparator2,
            this.UsernameToolStrip});
            this.TopToolStrip.Location = new System.Drawing.Point(0, 24);
            this.TopToolStrip.Name = "TopToolStrip";
            this.TopToolStrip.Size = new System.Drawing.Size(800, 25);
            this.TopToolStrip.TabIndex = 1;
            this.TopToolStrip.Text = "toolStrip1";
            // 
            // NewToolStrip
            // 
            this.NewToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NewToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("NewToolStrip.Image")));
            this.NewToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NewToolStrip.Name = "NewToolStrip";
            this.NewToolStrip.Size = new System.Drawing.Size(23, 22);
            this.NewToolStrip.Text = "New";
            this.NewToolStrip.Click += new System.EventHandler(this.NewToolStrip_Click);
            // 
            // OpenToolStrip
            // 
            this.OpenToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.OpenToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("OpenToolStrip.Image")));
            this.OpenToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.OpenToolStrip.Name = "OpenToolStrip";
            this.OpenToolStrip.Size = new System.Drawing.Size(23, 22);
            this.OpenToolStrip.Text = "Open";
            this.OpenToolStrip.Click += new System.EventHandler(this.OpenToolStrip_Click);
            // 
            // SaveToolStrip
            // 
            this.SaveToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveToolStrip.Image")));
            this.SaveToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveToolStrip.Name = "SaveToolStrip";
            this.SaveToolStrip.Size = new System.Drawing.Size(23, 22);
            this.SaveToolStrip.Text = "Save";
            this.SaveToolStrip.Click += new System.EventHandler(this.SaveToolStrip_Click);
            // 
            // SaveAsToolStrip
            // 
            this.SaveAsToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveAsToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("SaveAsToolStrip.Image")));
            this.SaveAsToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveAsToolStrip.Name = "SaveAsToolStrip";
            this.SaveAsToolStrip.Size = new System.Drawing.Size(23, 22);
            this.SaveAsToolStrip.Text = "Save As";
            this.SaveAsToolStrip.Click += new System.EventHandler(this.SaveAsToolStrip_Click);
            // 
            // TopToolStripSeparator1
            // 
            this.TopToolStripSeparator1.Name = "TopToolStripSeparator1";
            this.TopToolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BoldToolStrip
            // 
            this.BoldToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("BoldToolStrip.Image")));
            this.BoldToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldToolStrip.Name = "BoldToolStrip";
            this.BoldToolStrip.Size = new System.Drawing.Size(23, 22);
            this.BoldToolStrip.Text = "Bold";
            this.BoldToolStrip.Click += new System.EventHandler(this.BoldToolStrip_Click);
            // 
            // ItalicToolStrip
            // 
            this.ItalicToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("ItalicToolStrip.Image")));
            this.ItalicToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicToolStrip.Name = "ItalicToolStrip";
            this.ItalicToolStrip.Size = new System.Drawing.Size(23, 22);
            this.ItalicToolStrip.Text = "Italic";
            this.ItalicToolStrip.Click += new System.EventHandler(this.ItalicToolStrip_Click);
            // 
            // UnderlineToolStrip
            // 
            this.UnderlineToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("UnderlineToolStrip.Image")));
            this.UnderlineToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineToolStrip.Name = "UnderlineToolStrip";
            this.UnderlineToolStrip.Size = new System.Drawing.Size(23, 22);
            this.UnderlineToolStrip.Text = "Underline";
            this.UnderlineToolStrip.Click += new System.EventHandler(this.UnderlineToolStrip_Click);
            // 
            // FontSizeComboBoxToolStrip
            // 
            this.FontSizeComboBoxToolStrip.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.FontSizeComboBoxToolStrip.Name = "FontSizeComboBoxToolStrip";
            this.FontSizeComboBoxToolStrip.Size = new System.Drawing.Size(121, 25);
            this.FontSizeComboBoxToolStrip.Text = "Font Size";
            this.FontSizeComboBoxToolStrip.TextChanged += new System.EventHandler(this.FontSizeComboBoxToolStrip_TextChanged);
            // 
            // TopToolStripSeparator2
            // 
            this.TopToolStripSeparator2.Name = "TopToolStripSeparator2";
            this.TopToolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // UsernameToolStrip
            // 
            this.UsernameToolStrip.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UsernameToolStrip.Name = "UsernameToolStrip";
            this.UsernameToolStrip.Size = new System.Drawing.Size(78, 22);
            this.UsernameToolStrip.Text = "Username: ";
            // 
            // SideToolStrip
            // 
            this.SideToolStrip.Dock = System.Windows.Forms.DockStyle.Left;
            this.SideToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CutToolStrip,
            this.CopyToolStrip,
            this.PasteToolStrip});
            this.SideToolStrip.Location = new System.Drawing.Point(0, 49);
            this.SideToolStrip.Name = "SideToolStrip";
            this.SideToolStrip.Size = new System.Drawing.Size(24, 401);
            this.SideToolStrip.TabIndex = 2;
            this.SideToolStrip.Text = "toolStrip2";
            // 
            // CutToolStrip
            // 
            this.CutToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CutToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CutToolStrip.Image")));
            this.CutToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CutToolStrip.Name = "CutToolStrip";
            this.CutToolStrip.Size = new System.Drawing.Size(21, 20);
            this.CutToolStrip.Text = "Cut";
            this.CutToolStrip.Click += new System.EventHandler(this.CutToolStrip_Click);
            // 
            // CopyToolStrip
            // 
            this.CopyToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CopyToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("CopyToolStrip.Image")));
            this.CopyToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CopyToolStrip.Name = "CopyToolStrip";
            this.CopyToolStrip.Size = new System.Drawing.Size(21, 20);
            this.CopyToolStrip.Text = "Copy";
            this.CopyToolStrip.Click += new System.EventHandler(this.CopyToolStrip_Click);
            // 
            // PasteToolStrip
            // 
            this.PasteToolStrip.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PasteToolStrip.Image = ((System.Drawing.Image)(resources.GetObject("PasteToolStrip.Image")));
            this.PasteToolStrip.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PasteToolStrip.Name = "PasteToolStrip";
            this.PasteToolStrip.Size = new System.Drawing.Size(21, 20);
            this.PasteToolStrip.Text = "Paste";
            this.PasteToolStrip.Click += new System.EventHandler(this.PasteToolStrip_Click);
            // 
            // RichTextBox
            // 
            this.RichTextBox.Location = new System.Drawing.Point(27, 52);
            this.RichTextBox.Name = "RichTextBox";
            this.RichTextBox.Size = new System.Drawing.Size(761, 386);
            this.RichTextBox.TabIndex = 3;
            this.RichTextBox.Text = "";
            this.RichTextBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.RichTextBox_MouseClick);
            this.RichTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.RichTextBox_KeyDown);
            // 
            // TextEditorWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RichTextBox);
            this.Controls.Add(this.SideToolStrip);
            this.Controls.Add(this.TopToolStrip);
            this.Controls.Add(this.TextEditorMenuStrip);
            this.MainMenuStrip = this.TextEditorMenuStrip;
            this.Name = "TextEditorWindow";
            this.Text = "Text Editor";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.TextEditorWindow_FormClosed);
            this.Load += new System.EventHandler(this.TextEditorWindow_Load);
            this.TextEditorMenuStrip.ResumeLayout(false);
            this.TextEditorMenuStrip.PerformLayout();
            this.TopToolStrip.ResumeLayout(false);
            this.TopToolStrip.PerformLayout();
            this.SideToolStrip.ResumeLayout(false);
            this.SideToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip TextEditorMenuStrip;
        private ToolStripMenuItem FileMenuStripTab;
        private ToolStripMenuItem NewMenuStrip;
        private ToolStripMenuItem OpenMenuStrip;
        private ToolStripMenuItem SaveMenuStrip;
        private ToolStripMenuItem SaveAsMenuStrip;
        private ToolStripMenuItem LogoutMenuStrip;
        private ToolStripMenuItem EditMenuStripTab;
        private ToolStripMenuItem CutMenuStrip;
        private ToolStripMenuItem CopyMenuStrip;
        private ToolStripMenuItem PasteMenuStrip;
        private ToolStripMenuItem HelpMenuStripTab;
        private ToolStripMenuItem AboutMenuStrip;
        private ToolStripSeparator FileStripSeparator1;
        private ToolStripSeparator FileStripSeparator2;
        private ToolStrip TopToolStrip;
        private ToolStripButton NewToolStrip;
        private ToolStripButton OpenToolStrip;
        private ToolStripButton SaveToolStrip;
        private ToolStripButton SaveAsToolStrip;
        private ToolStripSeparator TopToolStripSeparator1;
        private ToolStripButton BoldToolStrip;
        private ToolStripButton ItalicToolStrip;
        private ToolStripButton UnderlineToolStrip;
        private ToolStripComboBox FontSizeComboBoxToolStrip;
        private ToolStripSeparator TopToolStripSeparator2;
        private ToolStripLabel UsernameToolStrip;
        private ToolStrip SideToolStrip;
        private ToolStripButton CutToolStrip;
        private ToolStripButton CopyToolStrip;
        private ToolStripButton PasteToolStrip;
        private RichTextBox RichTextBox;
    }
}