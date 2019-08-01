namespace Zeroit.Framework.SnippetEditors
{
    partial class VisualStudioEditor
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
            this.components = new System.ComponentModel.Container();
            Zeroit.Framework.SnippetEditors.Transitions.FoldSizes foldSizes1 = new Zeroit.Framework.SnippetEditors.Transitions.FoldSizes();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VisualStudioEditor));
            this.theme = new Zeroit.Framework.SnippetEditors.BaseTheme();
            this.soundBtn = new System.Windows.Forms.Button();
            this.languageIdTextBox = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.identifierLabel = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.languageTextBox = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.languageLabel = new System.Windows.Forms.Label();
            this.saveSnippetBtn = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.copyCode = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.addLangIdBtn = new System.Windows.Forms.Button();
            this.pasteText = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.langIdLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.pathTxtBox = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.languageIdCombo = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.automaticDiscovery = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.snippetNamespace = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.namespaceCombo = new System.Windows.Forms.ComboBox();
            this.namespaceDelete = new System.Windows.Forms.Button();
            this.assemblyCombo = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.namespaceAdd = new System.Windows.Forms.Button();
            this.snippetAssembly = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.assemblyDelete = new System.Windows.Forms.Button();
            this.assemblyAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.snippetAuthor = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.escapeChars = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scopeText = new System.Windows.Forms.Label();
            this.snippetLanguage = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.extensibleOutput = new Zeroit.Framework.SnippetEditors.ExtensiblePanel();
            this.outputCode = new System.Windows.Forms.RichTextBox();
            this.outputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputCopyCtxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.outputSaveCtxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.extensibleInput = new Zeroit.Framework.SnippetEditors.ExtensiblePanel();
            this.inputCode = new System.Windows.Forms.RichTextBox();
            this.inputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.paste = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.snippetShortcut = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.snippetDescription = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.snippetTitle = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.animator = new Zeroit.Framework.SnippetEditors.Transitions.ZeroitVisAnim();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.folderBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.theme.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.extensibleOutput.SuspendLayout();
            this.outputContextMenuStrip.SuspendLayout();
            this.extensibleInput.SuspendLayout();
            this.inputContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // theme
            // 
            this.theme.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.theme.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.theme.Colors = new Zeroit.Framework.SnippetEditors.Bloom[0];
            this.theme.Controls.Add(this.soundBtn);
            this.theme.Controls.Add(this.languageIdTextBox);
            this.theme.Controls.Add(this.identifierLabel);
            this.theme.Controls.Add(this.openFileBtn);
            this.theme.Controls.Add(this.languageTextBox);
            this.theme.Controls.Add(this.languageLabel);
            this.theme.Controls.Add(this.saveSnippetBtn);
            this.theme.Controls.Add(this.copyCode);
            this.theme.Controls.Add(this.addLangIdBtn);
            this.theme.Controls.Add(this.pasteText);
            this.theme.Controls.Add(this.langIdLabel);
            this.theme.Controls.Add(this.label10);
            this.theme.Controls.Add(this.pathTxtBox);
            this.theme.Controls.Add(this.languageIdCombo);
            this.theme.Controls.Add(this.label9);
            this.theme.Controls.Add(this.automaticDiscovery);
            this.theme.Controls.Add(this.groupBox1);
            this.theme.Controls.Add(this.label6);
            this.theme.Controls.Add(this.snippetAuthor);
            this.theme.Controls.Add(this.label5);
            this.theme.Controls.Add(this.escapeChars);
            this.theme.Controls.Add(this.label4);
            this.theme.Controls.Add(this.scopeText);
            this.theme.Controls.Add(this.snippetLanguage);
            this.theme.Controls.Add(this.button1);
            this.theme.Controls.Add(this.extensibleOutput);
            this.theme.Controls.Add(this.extensibleInput);
            this.theme.Controls.Add(this.label3);
            this.theme.Controls.Add(this.label2);
            this.theme.Controls.Add(this.label1);
            this.theme.Controls.Add(this.snippetShortcut);
            this.theme.Controls.Add(this.snippetDescription);
            this.theme.Controls.Add(this.snippetTitle);
            this.theme.Customization = "";
            this.theme.Dock = System.Windows.Forms.DockStyle.Fill;
            this.theme.Font = new System.Drawing.Font("Verdana", 9F);
            this.theme.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.mainIcon;
            this.theme.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.theme.ImageSize = new System.Drawing.Size(20, 20);
            this.theme.Location = new System.Drawing.Point(0, 0);
            this.theme.Movable = true;
            this.theme.Name = "theme";
            this.theme.NoRounding = false;
            this.theme.ShowIcon = true;
            this.theme.ShowText = false;
            this.theme.Sizable = false;
            this.theme.Size = new System.Drawing.Size(1113, 760);
            this.theme.SmartBounds = true;
            this.theme.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.theme.TabIndex = 0;
            this.theme.Text = "Visual Studio Snippet Editor";
            this.theme.TextAlign = System.Drawing.StringAlignment.Center;
            this.theme.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.theme.Transparent = false;
            this.theme.MouseEnter += new System.EventHandler(this.theme_MouseEnter);
            // 
            // soundBtn
            // 
            this.soundBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.soundBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.soundBtn.FlatAppearance.BorderSize = 0;
            this.soundBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.soundBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.soundBtn.ForeColor = System.Drawing.Color.White;
            this.soundBtn.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.sound_24px;
            this.soundBtn.Location = new System.Drawing.Point(18, 723);
            this.soundBtn.Name = "soundBtn";
            this.soundBtn.Size = new System.Drawing.Size(25, 24);
            this.soundBtn.TabIndex = 79;
            this.soundBtn.UseVisualStyleBackColor = false;
            this.soundBtn.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // languageIdTextBox
            // 
            this.languageIdTextBox.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.languageIdTextBox.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.languageIdTextBox.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.languageIdTextBox.FocusedColor = System.Drawing.Color.Cyan;
            this.languageIdTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.languageIdTextBox.ForeColor = System.Drawing.Color.White;
            this.languageIdTextBox.IsEnabled = true;
            this.languageIdTextBox.Location = new System.Drawing.Point(372, 113);
            this.languageIdTextBox.MaxLength = 32767;
            this.languageIdTextBox.Multiline = false;
            this.languageIdTextBox.Name = "languageIdTextBox";
            this.languageIdTextBox.PasswordChar = '\0';
            this.languageIdTextBox.Placeholder = true;
            this.languageIdTextBox.PlaceHolderText = "eg. php";
            this.languageIdTextBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.languageIdTextBox.ReadOnly = false;
            this.languageIdTextBox.Size = new System.Drawing.Size(138, 24);
            this.languageIdTextBox.TabIndex = 66;
            this.languageIdTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.languageIdTextBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.languageIdTextBox.UseSystemPasswordChar = false;
            this.languageIdTextBox.Visible = false;
            this.languageIdTextBox.WordWrap = true;
            // 
            // identifierLabel
            // 
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.identifierLabel.ForeColor = System.Drawing.Color.White;
            this.identifierLabel.Location = new System.Drawing.Point(301, 123);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(64, 14);
            this.identifierLabel.TabIndex = 71;
            this.identifierLabel.Text = "Identifier";
            this.identifierLabel.Visible = false;
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.openFile_16px;
            this.openFileBtn.Location = new System.Drawing.Point(832, 153);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(17, 17);
            this.openFileBtn.TabIndex = 78;
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // languageTextBox
            // 
            this.languageTextBox.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.languageTextBox.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.languageTextBox.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.languageTextBox.FocusedColor = System.Drawing.Color.Cyan;
            this.languageTextBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.languageTextBox.ForeColor = System.Drawing.Color.White;
            this.languageTextBox.IsEnabled = true;
            this.languageTextBox.Location = new System.Drawing.Point(372, 71);
            this.languageTextBox.MaxLength = 32767;
            this.languageTextBox.Multiline = false;
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.PasswordChar = '\0';
            this.languageTextBox.Placeholder = true;
            this.languageTextBox.PlaceHolderText = "eg. PHP";
            this.languageTextBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.languageTextBox.ReadOnly = false;
            this.languageTextBox.Size = new System.Drawing.Size(138, 24);
            this.languageTextBox.TabIndex = 69;
            this.languageTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.languageTextBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.languageTextBox.UseSystemPasswordChar = false;
            this.languageTextBox.Visible = false;
            this.languageTextBox.WordWrap = true;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Location = new System.Drawing.Point(301, 81);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(70, 14);
            this.languageLabel.TabIndex = 70;
            this.languageLabel.Text = "Language";
            this.languageLabel.Visible = false;
            // 
            // saveSnippetBtn
            // 
            this.saveSnippetBtn.AllowTransparency = true;
            this.saveSnippetBtn.AnimationInterval = 1;
            this.saveSnippetBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveSnippetBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.saveSnippetBtn.BorderWidth = 1F;
            this.saveSnippetBtn.ClickLimit = 10;
            this.saveSnippetBtn.ClickSpeed = 1;
            this.saveSnippetBtn.Corners = 10F;
            this.saveSnippetBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveSnippetBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.saveSnippetBtn.DoubleRipple = true;
            this.saveSnippetBtn.EnabledBGColor = System.Drawing.Color.DarkOrange;
            this.saveSnippetBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.saveSnippetBtn.ForeColor = System.Drawing.Color.White;
            this.saveSnippetBtn.Image = null;
            this.saveSnippetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.saveSnippetBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.saveSnippetBtn.Length = 50;
            this.saveSnippetBtn.Location = new System.Drawing.Point(869, 707);
            this.saveSnippetBtn.Mirror = false;
            this.saveSnippetBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.saveSnippetBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.saveSnippetBtn.Name = "saveSnippetBtn";
            this.saveSnippetBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.saveSnippetBtn.RippleOpacity = 25;
            this.saveSnippetBtn.ShowText = true;
            this.saveSnippetBtn.Size = new System.Drawing.Size(102, 34);
            this.saveSnippetBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.saveSnippetBtn.TabIndex = 77;
            this.saveSnippetBtn.Text = "Save Snippet";
            this.saveSnippetBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.saveSnippetBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.saveSnippetBtn.Click += new System.EventHandler(this.saveSnippetBtn_Click);
            this.saveSnippetBtn.MouseLeave += new System.EventHandler(this.saveSnippetBtn_MouseLeave);
            this.saveSnippetBtn.MouseHover += new System.EventHandler(this.saveSnippetBtn_MouseHover);
            // 
            // copyCode
            // 
            this.copyCode.AllowTransparency = true;
            this.copyCode.AnimationInterval = 1;
            this.copyCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.copyCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.copyCode.BorderWidth = 1F;
            this.copyCode.ClickLimit = 10;
            this.copyCode.ClickSpeed = 1;
            this.copyCode.Corners = 10F;
            this.copyCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.copyCode.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.copyCode.DoubleRipple = true;
            this.copyCode.EnabledBGColor = System.Drawing.Color.Red;
            this.copyCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.copyCode.ForeColor = System.Drawing.Color.White;
            this.copyCode.Image = null;
            this.copyCode.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.copyCode.ImageSize = new System.Drawing.Size(0, 0);
            this.copyCode.Length = 50;
            this.copyCode.Location = new System.Drawing.Point(763, 707);
            this.copyCode.Mirror = false;
            this.copyCode.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.copyCode.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.copyCode.Name = "copyCode";
            this.copyCode.RippleEffectColor = System.Drawing.Color.Black;
            this.copyCode.RippleOpacity = 25;
            this.copyCode.ShowText = true;
            this.copyCode.Size = new System.Drawing.Size(102, 34);
            this.copyCode.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.copyCode.TabIndex = 76;
            this.copyCode.Text = "Copy";
            this.copyCode.TextAlign = System.Drawing.StringAlignment.Center;
            this.copyCode.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.copyCode.Click += new System.EventHandler(this.copyCode_Click);
            this.copyCode.MouseLeave += new System.EventHandler(this.copyCode_MouseLeave);
            this.copyCode.MouseHover += new System.EventHandler(this.copyCode_MouseHover);
            // 
            // addLangIdBtn
            // 
            this.addLangIdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addLangIdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.addLangIdBtn.FlatAppearance.BorderSize = 0;
            this.addLangIdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLangIdBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.addLangIdBtn.ForeColor = System.Drawing.Color.White;
            this.addLangIdBtn.Location = new System.Drawing.Point(512, 36);
            this.addLangIdBtn.Name = "addLangIdBtn";
            this.addLangIdBtn.Size = new System.Drawing.Size(18, 19);
            this.addLangIdBtn.TabIndex = 68;
            this.addLangIdBtn.Text = "+";
            this.addLangIdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLangIdBtn.UseCompatibleTextRendering = true;
            this.addLangIdBtn.UseVisualStyleBackColor = false;
            this.addLangIdBtn.Visible = false;
            this.addLangIdBtn.Click += new System.EventHandler(this.addLangIdBtn_Click);
            // 
            // pasteText
            // 
            this.pasteText.AllowTransparency = true;
            this.pasteText.AnimationInterval = 1;
            this.pasteText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pasteText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pasteText.BorderWidth = 1F;
            this.pasteText.ClickLimit = 10;
            this.pasteText.ClickSpeed = 1;
            this.pasteText.Corners = 10F;
            this.pasteText.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasteText.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.pasteText.DoubleRipple = true;
            this.pasteText.EnabledBGColor = System.Drawing.Color.CadetBlue;
            this.pasteText.Font = new System.Drawing.Font("Verdana", 8F);
            this.pasteText.ForeColor = System.Drawing.Color.White;
            this.pasteText.Image = null;
            this.pasteText.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pasteText.ImageSize = new System.Drawing.Size(0, 0);
            this.pasteText.Length = 50;
            this.pasteText.Location = new System.Drawing.Point(176, 707);
            this.pasteText.Mirror = false;
            this.pasteText.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pasteText.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.pasteText.Name = "pasteText";
            this.pasteText.RippleEffectColor = System.Drawing.Color.Black;
            this.pasteText.RippleOpacity = 25;
            this.pasteText.ShowText = true;
            this.pasteText.Size = new System.Drawing.Size(163, 34);
            this.pasteText.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pasteText.TabIndex = 75;
            this.pasteText.Text = "Paste";
            this.pasteText.TextAlign = System.Drawing.StringAlignment.Center;
            this.pasteText.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.pasteText.Click += new System.EventHandler(this.pasteText_Click);
            this.pasteText.MouseLeave += new System.EventHandler(this.pasteText_MouseLeave);
            this.pasteText.MouseHover += new System.EventHandler(this.pasteText_MouseHover);
            // 
            // langIdLabel
            // 
            this.langIdLabel.AutoSize = true;
            this.langIdLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.langIdLabel.ForeColor = System.Drawing.Color.White;
            this.langIdLabel.Location = new System.Drawing.Point(301, 28);
            this.langIdLabel.Name = "langIdLabel";
            this.langIdLabel.Size = new System.Drawing.Size(70, 28);
            this.langIdLabel.TabIndex = 67;
            this.langIdLabel.Text = "Language\r\nIdentifier";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 9F);
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(534, 152);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(56, 14);
            this.label10.TabIndex = 51;
            this.label10.Text = "Save To";
            // 
            // pathTxtBox
            // 
            this.pathTxtBox.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.pathTxtBox.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.pathTxtBox.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.pathTxtBox.FocusedColor = System.Drawing.Color.Cyan;
            this.pathTxtBox.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.pathTxtBox.ForeColor = System.Drawing.Color.White;
            this.pathTxtBox.IsEnabled = true;
            this.pathTxtBox.Location = new System.Drawing.Point(634, 146);
            this.pathTxtBox.MaxLength = 32767;
            this.pathTxtBox.Multiline = false;
            this.pathTxtBox.Name = "pathTxtBox";
            this.pathTxtBox.PasswordChar = '\0';
            this.pathTxtBox.Placeholder = true;
            this.pathTxtBox.PlaceHolderText = "eg. C:/Program Files/";
            this.pathTxtBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pathTxtBox.ReadOnly = false;
            this.pathTxtBox.Size = new System.Drawing.Size(185, 24);
            this.pathTxtBox.TabIndex = 50;
            this.pathTxtBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.pathTxtBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pathTxtBox.UseSystemPasswordChar = false;
            this.pathTxtBox.WordWrap = true;
            // 
            // languageIdCombo
            // 
            this.languageIdCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.languageIdCombo.DropDownWidth = 180;
            this.languageIdCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.languageIdCombo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.languageIdCombo.FormattingEnabled = true;
            this.languageIdCombo.Items.AddRange(new object[] {
            "... Add Identifier ...",
            "ABAP\t",
            "Windows Bat\t",
            "BibTeX\t",
            "Clojure\t",
            "Coffeescript\t",
            "C\t",
            "C++\t",
            "C#\t",
            "CSS\t",
            "Diff\t",
            "Dockerfile\t",
            "F#\t",
            "Git\t ",
            "Go\t",
            "Groovy\t",
            "Handlebars\t",
            "HTML\t",
            "Ini\t",
            "Java\t",
            "JavaScript\t",
            "JavaScript React\t",
            "JSON\t",
            "JSON with Comments\t",
            "LaTeX\t",
            "Less\t",
            "Lua\t",
            "Makefile\t",
            "Markdown\t",
            "Objective-C\t",
            "Objective-C++\t",
            "Perl\t",
            "PHP\t",
            "Powershell\t",
            "Pug\t",
            "Python\t",
            "R\t",
            "Razor (cshtml)\t",
            "Ruby\t",
            "Rust\t",
            "SCSS (syntax using curly brackets)",
            "SCSS (indented syntax)\t",
            "ShaderLab\t",
            "Shell Script (Bash)\t",
            "SQL\t",
            "Swift\t",
            "TypeScript\t",
            "TypeScript React\t",
            "TeX\t",
            "Visual Basic\t",
            "XML\t",
            "XSL\t",
            "YAML\t"});
            this.languageIdCombo.Location = new System.Drawing.Point(372, 34);
            this.languageIdCombo.Name = "languageIdCombo";
            this.languageIdCombo.Size = new System.Drawing.Size(138, 22);
            this.languageIdCombo.TabIndex = 65;
            this.languageIdCombo.SelectedIndexChanged += new System.EventHandler(this.languageIdCombo_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 9F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(917, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(137, 28);
            this.label9.TabIndex = 49;
            this.label9.Text = "Automatic Clipboard \r\nDiscovery";
            // 
            // automaticDiscovery
            // 
            this.automaticDiscovery.AutoSize = true;
            this.automaticDiscovery.Font = new System.Drawing.Font("Verdana", 14F);
            this.automaticDiscovery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.automaticDiscovery.Location = new System.Drawing.Point(1080, 181);
            this.automaticDiscovery.Name = "automaticDiscovery";
            this.automaticDiscovery.Size = new System.Drawing.Size(15, 14);
            this.automaticDiscovery.TabIndex = 48;
            this.automaticDiscovery.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.snippetNamespace);
            this.groupBox1.Controls.Add(this.namespaceCombo);
            this.groupBox1.Controls.Add(this.namespaceDelete);
            this.groupBox1.Controls.Add(this.assemblyCombo);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.namespaceAdd);
            this.groupBox1.Controls.Add(this.snippetAssembly);
            this.groupBox1.Controls.Add(this.assemblyDelete);
            this.groupBox1.Controls.Add(this.assemblyAdd);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.groupBox1.Location = new System.Drawing.Point(546, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 110);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Imports";
            // 
            // snippetNamespace
            // 
            this.snippetNamespace.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetNamespace.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetNamespace.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetNamespace.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetNamespace.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetNamespace.ForeColor = System.Drawing.Color.White;
            this.snippetNamespace.IsEnabled = true;
            this.snippetNamespace.Location = new System.Drawing.Point(89, 69);
            this.snippetNamespace.MaxLength = 32767;
            this.snippetNamespace.Multiline = false;
            this.snippetNamespace.Name = "snippetNamespace";
            this.snippetNamespace.PasswordChar = '\0';
            this.snippetNamespace.Placeholder = true;
            this.snippetNamespace.PlaceHolderText = "eg. System";
            this.snippetNamespace.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetNamespace.ReadOnly = false;
            this.snippetNamespace.Size = new System.Drawing.Size(146, 24);
            this.snippetNamespace.TabIndex = 46;
            this.snippetNamespace.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetNamespace.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetNamespace.UseSystemPasswordChar = false;
            this.snippetNamespace.WordWrap = true;
            // 
            // namespaceCombo
            // 
            this.namespaceCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.namespaceCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namespaceCombo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.namespaceCombo.FormattingEnabled = true;
            this.namespaceCombo.Location = new System.Drawing.Point(351, 72);
            this.namespaceCombo.Name = "namespaceCombo";
            this.namespaceCombo.Size = new System.Drawing.Size(193, 22);
            this.namespaceCombo.Sorted = true;
            this.namespaceCombo.TabIndex = 40;
            // 
            // namespaceDelete
            // 
            this.namespaceDelete.BackColor = System.Drawing.Color.Red;
            this.namespaceDelete.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.namespaceDelete.FlatAppearance.BorderSize = 0;
            this.namespaceDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namespaceDelete.Font = new System.Drawing.Font("Verdana", 8F);
            this.namespaceDelete.ForeColor = System.Drawing.Color.White;
            this.namespaceDelete.Location = new System.Drawing.Point(297, 72);
            this.namespaceDelete.Name = "namespaceDelete";
            this.namespaceDelete.Size = new System.Drawing.Size(48, 21);
            this.namespaceDelete.TabIndex = 44;
            this.namespaceDelete.Text = "Del";
            this.namespaceDelete.UseVisualStyleBackColor = false;
            this.namespaceDelete.Click += new System.EventHandler(this.namespaceDelete_Click);
            this.namespaceDelete.MouseLeave += new System.EventHandler(this.namespaceDelete_MouseLeave);
            this.namespaceDelete.MouseHover += new System.EventHandler(this.namespaceDelete_MouseHover);
            // 
            // assemblyCombo
            // 
            this.assemblyCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.assemblyCombo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assemblyCombo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.assemblyCombo.FormattingEnabled = true;
            this.assemblyCombo.Location = new System.Drawing.Point(351, 27);
            this.assemblyCombo.Name = "assemblyCombo";
            this.assemblyCombo.Size = new System.Drawing.Size(193, 22);
            this.assemblyCombo.Sorted = true;
            this.assemblyCombo.TabIndex = 37;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 9F);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(3, 78);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 14);
            this.label8.TabIndex = 47;
            this.label8.Text = "Namespace";
            // 
            // namespaceAdd
            // 
            this.namespaceAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.namespaceAdd.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.namespaceAdd.FlatAppearance.BorderSize = 0;
            this.namespaceAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.namespaceAdd.Font = new System.Drawing.Font("Verdana", 8F);
            this.namespaceAdd.ForeColor = System.Drawing.Color.White;
            this.namespaceAdd.Location = new System.Drawing.Point(243, 71);
            this.namespaceAdd.Name = "namespaceAdd";
            this.namespaceAdd.Size = new System.Drawing.Size(48, 21);
            this.namespaceAdd.TabIndex = 43;
            this.namespaceAdd.Text = "Add";
            this.namespaceAdd.UseVisualStyleBackColor = false;
            this.namespaceAdd.Click += new System.EventHandler(this.namespaceAdd_Click);
            this.namespaceAdd.MouseLeave += new System.EventHandler(this.namespaceAdd_MouseLeave);
            this.namespaceAdd.MouseHover += new System.EventHandler(this.namespaceAdd_MouseHover);
            // 
            // snippetAssembly
            // 
            this.snippetAssembly.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetAssembly.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetAssembly.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetAssembly.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetAssembly.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetAssembly.ForeColor = System.Drawing.Color.White;
            this.snippetAssembly.IsEnabled = true;
            this.snippetAssembly.Location = new System.Drawing.Point(89, 21);
            this.snippetAssembly.MaxLength = 32767;
            this.snippetAssembly.Multiline = false;
            this.snippetAssembly.Name = "snippetAssembly";
            this.snippetAssembly.PasswordChar = '\0';
            this.snippetAssembly.Placeholder = true;
            this.snippetAssembly.PlaceHolderText = "eg. System.dll";
            this.snippetAssembly.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetAssembly.ReadOnly = false;
            this.snippetAssembly.Size = new System.Drawing.Size(146, 24);
            this.snippetAssembly.TabIndex = 38;
            this.snippetAssembly.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetAssembly.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetAssembly.UseSystemPasswordChar = false;
            this.snippetAssembly.WordWrap = true;
            // 
            // assemblyDelete
            // 
            this.assemblyDelete.BackColor = System.Drawing.Color.Red;
            this.assemblyDelete.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.assemblyDelete.FlatAppearance.BorderSize = 0;
            this.assemblyDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assemblyDelete.Font = new System.Drawing.Font("Verdana", 8F);
            this.assemblyDelete.ForeColor = System.Drawing.Color.White;
            this.assemblyDelete.Location = new System.Drawing.Point(297, 28);
            this.assemblyDelete.Name = "assemblyDelete";
            this.assemblyDelete.Size = new System.Drawing.Size(48, 21);
            this.assemblyDelete.TabIndex = 42;
            this.assemblyDelete.Text = "Del";
            this.assemblyDelete.UseVisualStyleBackColor = false;
            this.assemblyDelete.Click += new System.EventHandler(this.assemblyDelete_Click);
            this.assemblyDelete.MouseLeave += new System.EventHandler(this.assemblyDelete_MouseLeave);
            this.assemblyDelete.MouseHover += new System.EventHandler(this.assemblyDelete_MouseHover);
            // 
            // assemblyAdd
            // 
            this.assemblyAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.assemblyAdd.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.assemblyAdd.FlatAppearance.BorderSize = 0;
            this.assemblyAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.assemblyAdd.Font = new System.Drawing.Font("Verdana", 8F);
            this.assemblyAdd.ForeColor = System.Drawing.Color.White;
            this.assemblyAdd.Location = new System.Drawing.Point(243, 28);
            this.assemblyAdd.Name = "assemblyAdd";
            this.assemblyAdd.Size = new System.Drawing.Size(48, 21);
            this.assemblyAdd.TabIndex = 41;
            this.assemblyAdd.Text = "Add";
            this.assemblyAdd.UseVisualStyleBackColor = false;
            this.assemblyAdd.Click += new System.EventHandler(this.assemblyAdd_Click);
            this.assemblyAdd.MouseLeave += new System.EventHandler(this.assemblyAdd_MouseLeave);
            this.assemblyAdd.MouseHover += new System.EventHandler(this.assemblyAdd_MouseHover);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(3, 31);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 14);
            this.label7.TabIndex = 45;
            this.label7.Text = "Assembly";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 79);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 14);
            this.label6.TabIndex = 36;
            this.label6.Text = "Author";
            // 
            // snippetAuthor
            // 
            this.snippetAuthor.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetAuthor.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetAuthor.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetAuthor.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetAuthor.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetAuthor.ForeColor = System.Drawing.Color.White;
            this.snippetAuthor.IsEnabled = true;
            this.snippetAuthor.Location = new System.Drawing.Point(96, 71);
            this.snippetAuthor.MaxLength = 32767;
            this.snippetAuthor.Multiline = false;
            this.snippetAuthor.Name = "snippetAuthor";
            this.snippetAuthor.PasswordChar = '\0';
            this.snippetAuthor.Placeholder = true;
            this.snippetAuthor.PlaceHolderText = "eg. Zeroit Dev";
            this.snippetAuthor.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetAuthor.ReadOnly = false;
            this.snippetAuthor.Size = new System.Drawing.Size(198, 24);
            this.snippetAuthor.TabIndex = 35;
            this.snippetAuthor.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetAuthor.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetAuthor.UseSystemPasswordChar = false;
            this.snippetAuthor.WordWrap = true;
            this.snippetAuthor.TextChanged += new System.EventHandler(this.snippetAuthor_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 9F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(917, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 14);
            this.label5.TabIndex = 34;
            this.label5.Text = "Escape chars ( \" )\r\n";
            // 
            // escapeChars
            // 
            this.escapeChars.AutoSize = true;
            this.escapeChars.Checked = true;
            this.escapeChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.escapeChars.Font = new System.Drawing.Font("Verdana", 14F);
            this.escapeChars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.escapeChars.Location = new System.Drawing.Point(1080, 145);
            this.escapeChars.Name = "escapeChars";
            this.escapeChars.Size = new System.Drawing.Size(15, 14);
            this.escapeChars.TabIndex = 33;
            this.escapeChars.UseVisualStyleBackColor = true;
            this.escapeChars.CheckedChanged += new System.EventHandler(this.escapeChars_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 8F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(369, 736);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(375, 13);
            this.label4.TabIndex = 32;
            this.label4.Text = "Copyright © 2019 Zeroit Dev Technologies. All Rights Reserved.";
            // 
            // scopeText
            // 
            this.scopeText.AutoSize = true;
            this.scopeText.Font = new System.Drawing.Font("Verdana", 9F);
            this.scopeText.ForeColor = System.Drawing.Color.White;
            this.scopeText.Location = new System.Drawing.Point(535, 188);
            this.scopeText.Name = "scopeText";
            this.scopeText.Size = new System.Drawing.Size(70, 14);
            this.scopeText.TabIndex = 31;
            this.scopeText.Text = "Language";
            this.scopeText.Visible = false;
            // 
            // snippetLanguage
            // 
            this.snippetLanguage.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetLanguage.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetLanguage.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetLanguage.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetLanguage.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetLanguage.ForeColor = System.Drawing.Color.White;
            this.snippetLanguage.IsEnabled = true;
            this.snippetLanguage.Location = new System.Drawing.Point(635, 181);
            this.snippetLanguage.MaxLength = 32767;
            this.snippetLanguage.Multiline = false;
            this.snippetLanguage.Name = "snippetLanguage";
            this.snippetLanguage.PasswordChar = '\0';
            this.snippetLanguage.Placeholder = false;
            this.snippetLanguage.PlaceHolderText = "eg. CSharp";
            this.snippetLanguage.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetLanguage.ReadOnly = false;
            this.snippetLanguage.Size = new System.Drawing.Size(185, 24);
            this.snippetLanguage.TabIndex = 29;
            this.snippetLanguage.Text = "CSharp";
            this.snippetLanguage.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetLanguage.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetLanguage.UseSystemPasswordChar = false;
            this.snippetLanguage.Visible = false;
            this.snippetLanguage.WordWrap = true;
            this.snippetLanguage.TextChanged += new System.EventHandler(this.snippetLanguage_TextChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Verdana", 8F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1092, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(18, 19);
            this.button1.TabIndex = 27;
            this.button1.Text = "x";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.UseCompatibleTextRendering = true;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // extensibleOutput
            // 
            this.extensibleOutput.Border = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.extensibleOutput.Controls.Add(this.outputCode);
            this.extensibleOutput.Location = new System.Drawing.Point(563, 217);
            this.extensibleOutput.Name = "extensibleOutput";
            this.extensibleOutput.Size = new System.Drawing.Size(535, 484);
            this.extensibleOutput.TabIndex = 20;
            this.extensibleOutput.Text = "extensiblePanel1";
            this.extensibleOutput.MouseEnter += new System.EventHandler(this.extensibleOutput_MouseEnter);
            this.extensibleOutput.MouseLeave += new System.EventHandler(this.extensibleOutput_MouseLeave);
            // 
            // outputCode
            // 
            this.outputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.outputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCode.ContextMenuStrip = this.outputContextMenuStrip;
            this.outputCode.Font = new System.Drawing.Font("Consolas", 11F);
            this.outputCode.ForeColor = System.Drawing.Color.Cyan;
            this.outputCode.Location = new System.Drawing.Point(2, 3);
            this.outputCode.Name = "outputCode";
            this.outputCode.Size = new System.Drawing.Size(530, 478);
            this.outputCode.TabIndex = 0;
            this.outputCode.Text = "OUTPUT\n\nCODE \n\nDISPLAYS\n\nHERE\n\nDO\n\nNOT \n\nPASTE\n\nHERE\n\nENJOY!!!\n\nENJOY!!!\n\nENJOY!!" +
    "!\n\nENJOY!!!\n\nENJOY!!!\n";
            this.outputCode.MouseLeave += new System.EventHandler(this.outputCode_MouseLeave);
            this.outputCode.MouseHover += new System.EventHandler(this.outputCode_MouseHover);
            // 
            // outputContextMenuStrip
            // 
            this.outputContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.outputContextMenuStrip.Font = new System.Drawing.Font("Verdana", 8F);
            this.outputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCopyCtxtMenu,
            this.outputSaveCtxtMenu});
            this.outputContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.outputContextMenuStrip.Name = "contextMenuStrip1";
            this.outputContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.outputContextMenuStrip.ShowImageMargin = false;
            this.outputContextMenuStrip.Size = new System.Drawing.Size(126, 48);
            // 
            // outputCopyCtxtMenu
            // 
            this.outputCopyCtxtMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.outputCopyCtxtMenu.Font = new System.Drawing.Font("Verdana", 8F);
            this.outputCopyCtxtMenu.ForeColor = System.Drawing.Color.White;
            this.outputCopyCtxtMenu.Name = "outputCopyCtxtMenu";
            this.outputCopyCtxtMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.outputCopyCtxtMenu.Size = new System.Drawing.Size(125, 22);
            this.outputCopyCtxtMenu.Text = "Copy";
            this.outputCopyCtxtMenu.Click += new System.EventHandler(this.outputCopyCtxtMenu_Click);
            // 
            // outputSaveCtxtMenu
            // 
            this.outputSaveCtxtMenu.ForeColor = System.Drawing.Color.White;
            this.outputSaveCtxtMenu.Name = "outputSaveCtxtMenu";
            this.outputSaveCtxtMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.outputSaveCtxtMenu.Size = new System.Drawing.Size(125, 22);
            this.outputSaveCtxtMenu.Text = "Save";
            this.outputSaveCtxtMenu.Click += new System.EventHandler(this.outputSaveCtxtMenu_Click);
            // 
            // extensibleInput
            // 
            this.extensibleInput.Border = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.extensibleInput.Controls.Add(this.inputCode);
            this.extensibleInput.Location = new System.Drawing.Point(15, 217);
            this.extensibleInput.Name = "extensibleInput";
            this.extensibleInput.Size = new System.Drawing.Size(541, 484);
            this.extensibleInput.TabIndex = 25;
            this.extensibleInput.Text = "extensiblePanel1";
            this.extensibleInput.MouseLeave += new System.EventHandler(this.extensibleInput_MouseLeave);
            this.extensibleInput.MouseHover += new System.EventHandler(this.extensibleInput_MouseHover);
            // 
            // inputCode
            // 
            this.inputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inputCode.ContextMenuStrip = this.inputContextMenuStrip;
            this.inputCode.Font = new System.Drawing.Font("Consolas", 11F);
            this.inputCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(142)))), ((int)(((byte)(245)))));
            this.inputCode.Location = new System.Drawing.Point(3, 3);
            this.inputCode.Name = "inputCode";
            this.inputCode.Size = new System.Drawing.Size(535, 478);
            this.inputCode.TabIndex = 0;
            this.inputCode.Text = "INPUT\n\nCODE \n\nYOU \n\nINTEND \n\nTO \n\nCONVERT\n\nHERE\n\nENJOY!!!\n\nENJOY!!!\n\nENJOY!!!\n\nEN" +
    "JOY!!!\n\nENJOY!!!\n\nENJOY!!!";
            this.inputCode.TextChanged += new System.EventHandler(this.inputCode_TextChanged);
            this.inputCode.MouseEnter += new System.EventHandler(this.inputCode_MouseEnter);
            this.inputCode.MouseLeave += new System.EventHandler(this.inputCode_MouseLeave);
            // 
            // inputContextMenuStrip
            // 
            this.inputContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inputContextMenuStrip.Font = new System.Drawing.Font("Verdana", 8F);
            this.inputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.paste,
            this.clear});
            this.inputContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.inputContextMenuStrip.Name = "contextMenuStrip1";
            this.inputContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.inputContextMenuStrip.ShowImageMargin = false;
            this.inputContextMenuStrip.Size = new System.Drawing.Size(126, 48);
            // 
            // paste
            // 
            this.paste.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.paste.Font = new System.Drawing.Font("Verdana", 8F);
            this.paste.ForeColor = System.Drawing.Color.White;
            this.paste.Name = "paste";
            this.paste.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.paste.Size = new System.Drawing.Size(125, 22);
            this.paste.Text = "Paste";
            this.paste.Click += new System.EventHandler(this.paste_Click);
            // 
            // clear
            // 
            this.clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clear.Font = new System.Drawing.Font("Verdana", 8F);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Name = "clear";
            this.clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.clear.Size = new System.Drawing.Size(125, 22);
            this.clear.Text = "Clear";
            this.clear.ToolTipText = "Clears the text area";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(15, 169);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Shortcut";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(15, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Title";
            // 
            // snippetShortcut
            // 
            this.snippetShortcut.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetShortcut.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetShortcut.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetShortcut.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetShortcut.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetShortcut.ForeColor = System.Drawing.Color.White;
            this.snippetShortcut.IsEnabled = true;
            this.snippetShortcut.Location = new System.Drawing.Point(96, 162);
            this.snippetShortcut.MaxLength = 32767;
            this.snippetShortcut.Multiline = false;
            this.snippetShortcut.Name = "snippetShortcut";
            this.snippetShortcut.PasswordChar = '\0';
            this.snippetShortcut.Placeholder = true;
            this.snippetShortcut.PlaceHolderText = "eg. php-connect";
            this.snippetShortcut.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetShortcut.ReadOnly = false;
            this.snippetShortcut.Size = new System.Drawing.Size(198, 24);
            this.snippetShortcut.TabIndex = 21;
            this.snippetShortcut.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetShortcut.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetShortcut.UseSystemPasswordChar = false;
            this.snippetShortcut.WordWrap = true;
            this.snippetShortcut.TextChanged += new System.EventHandler(this.snippetShortcut_TextChanged);
            // 
            // snippetDescription
            // 
            this.snippetDescription.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetDescription.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetDescription.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetDescription.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetDescription.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetDescription.ForeColor = System.Drawing.Color.White;
            this.snippetDescription.IsEnabled = true;
            this.snippetDescription.Location = new System.Drawing.Point(96, 113);
            this.snippetDescription.MaxLength = 32767;
            this.snippetDescription.Multiline = false;
            this.snippetDescription.Name = "snippetDescription";
            this.snippetDescription.PasswordChar = '\0';
            this.snippetDescription.Placeholder = true;
            this.snippetDescription.PlaceHolderText = "eg. This is a php connection";
            this.snippetDescription.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetDescription.ReadOnly = false;
            this.snippetDescription.Size = new System.Drawing.Size(198, 24);
            this.snippetDescription.TabIndex = 20;
            this.snippetDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetDescription.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetDescription.UseSystemPasswordChar = false;
            this.snippetDescription.WordWrap = true;
            this.snippetDescription.TextChanged += new System.EventHandler(this.snippetDescription_TextChanged);
            // 
            // snippetTitle
            // 
            this.snippetTitle.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetTitle.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetTitle.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetTitle.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetTitle.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetTitle.ForeColor = System.Drawing.Color.White;
            this.snippetTitle.IsEnabled = true;
            this.snippetTitle.Location = new System.Drawing.Point(96, 24);
            this.snippetTitle.MaxLength = 32767;
            this.snippetTitle.Multiline = false;
            this.snippetTitle.Name = "snippetTitle";
            this.snippetTitle.PasswordChar = '\0';
            this.snippetTitle.Placeholder = true;
            this.snippetTitle.PlaceHolderText = "eg. PHP Database Connect";
            this.snippetTitle.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetTitle.ReadOnly = false;
            this.snippetTitle.Size = new System.Drawing.Size(198, 24);
            this.snippetTitle.TabIndex = 19;
            this.snippetTitle.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetTitle.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetTitle.UseSystemPasswordChar = false;
            this.snippetTitle.WordWrap = true;
            this.snippetTitle.TextChanged += new System.EventHandler(this.snippetName_TextChanged);
            // 
            // animator
            // 
            this.animator.AnimationType = Zeroit.Framework.SnippetEditors.Transitions.ZeroitVisAnim.GetAnimationType.YLocationEffect;
            this.animator.Delay = 0;
            this.animator.Duration = 500;
            this.animator.EasingType = Zeroit.Framework.SnippetEditors.Transitions.ZeroitVisAnim.EasingFunctionTypes.BounceEaseInOut;
            foldSizes1.MaximumSize = new System.Drawing.Size(1000, 1000);
            foldSizes1.MinimumSize = new System.Drawing.Size(500, 500);
            this.animator.FoldSizes = foldSizes1;
            this.animator.FoldStyle = Zeroit.Framework.SnippetEditors.Transitions.ZeroitVisAnim.FoldMethod.Hide;
            this.animator.Loops = 1;
            this.animator.Reverse = false;
            this.animator.Target = this;
            this.animator.ValueToReach = 170;
            // 
            // error
            // 
            this.error.BlinkRate = 500;
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.error.ContainerControl = this.theme;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // VisualStudioEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1113, 760);
            this.Controls.Add(this.theme);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "VisualStudioEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "SnippetEditor";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.VisualStudioEditor_Load);
            this.theme.ResumeLayout(false);
            this.theme.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.extensibleOutput.ResumeLayout(false);
            this.outputContextMenuStrip.ResumeLayout(false);
            this.extensibleInput.ResumeLayout(false);
            this.inputContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme theme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZeroitUltraTextBox snippetShortcut;
        private ZeroitUltraTextBox snippetDescription;
        private ZeroitUltraTextBox snippetTitle;
        private ExtensiblePanel extensibleOutput;
        private System.Windows.Forms.RichTextBox outputCode;
        private ExtensiblePanel extensibleInput;
        private System.Windows.Forms.RichTextBox inputCode;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label scopeText;
        private ZeroitUltraTextBox snippetLanguage;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox escapeChars;
        private System.Windows.Forms.GroupBox groupBox1;
        private ZeroitUltraTextBox snippetNamespace;
        private System.Windows.Forms.ComboBox namespaceCombo;
        private System.Windows.Forms.Button namespaceDelete;
        private System.Windows.Forms.ComboBox assemblyCombo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button namespaceAdd;
        private ZeroitUltraTextBox snippetAssembly;
        private System.Windows.Forms.Button assemblyDelete;
        private System.Windows.Forms.Button assemblyAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private ZeroitUltraTextBox snippetAuthor;
        public Transitions.ZeroitVisAnim animator;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox automaticDiscovery;
        private System.Windows.Forms.Label label10;
        private ZeroitUltraTextBox pathTxtBox;
        private System.Windows.Forms.ContextMenuStrip inputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem paste;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ContextMenuStrip outputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem outputCopyCtxtMenu;
        private System.Windows.Forms.ToolStripMenuItem outputSaveCtxtMenu;
        private System.Windows.Forms.ErrorProvider error;
        private Helpers.Button.ZeroitLollipopClickButton saveSnippetBtn;
        private Helpers.Button.ZeroitLollipopClickButton copyCode;
        private Helpers.Button.ZeroitLollipopClickButton pasteText;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private ZeroitUltraTextBox languageIdTextBox;
        private System.Windows.Forms.Label identifierLabel;
        private ZeroitUltraTextBox languageTextBox;
        private System.Windows.Forms.Label languageLabel;
        private System.Windows.Forms.Button addLangIdBtn;
        private System.Windows.Forms.Label langIdLabel;
        private System.Windows.Forms.ComboBox languageIdCombo;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private System.Windows.Forms.FolderBrowserDialog folderBrowser;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}