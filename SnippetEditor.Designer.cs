// ***********************************************************************
// Assembly         : Zeroit Dev Snippet Editor
// Author           : ZEROIT
// Created          : 06-21-2019
//
// Last Modified By : ZEROIT
// Last Modified On : 06-27-2019
// ***********************************************************************
// <copyright file="SnippetEditor.Designer.cs" company="Zeroit Dev Technologies">
//     Copyright © 2019 Zeroit Dev Technologies. All Rights Reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************


namespace Zeroit.Framework.SnippetEditors
{
    partial class SnippetEditor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SnippetEditor));
            Zeroit.Framework.SnippetEditors.AndroidColors androidColors2 = new Zeroit.Framework.SnippetEditors.AndroidColors();
            Zeroit.Framework.SnippetEditors.iOSColors iOSColors2 = new Zeroit.Framework.SnippetEditors.iOSColors();
            Zeroit.Framework.SnippetEditors.MaterialColors materialColors2 = new Zeroit.Framework.SnippetEditors.MaterialColors();
            this.baseTheme2 = new Zeroit.Framework.SnippetEditors.BaseTheme();
            this.appendCode = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.copyCode = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.pasteTextBtn = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.resetBtn = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.lastAppendedLabel = new System.Windows.Forms.Label();
            this.soundBtn = new System.Windows.Forms.Button();
            this.closeBtn = new Zeroit.Framework.SnippetEditors.TransparentText();
            this.minimizeBtn = new Zeroit.Framework.SnippetEditors.TransparentText();
            this.globalSnippCheckBox = new System.Windows.Forms.CheckBox();
            this.globalSnippLabel = new System.Windows.Forms.Label();
            this.identifierLabel = new System.Windows.Forms.Label();
            this.languageLabel = new System.Windows.Forms.Label();
            this.languageTextBox = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.addLangIdBtn = new System.Windows.Forms.Button();
            this.langIdLabel = new System.Windows.Forms.Label();
            this.languageIdTextBox = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.languageIdCombo = new System.Windows.Forms.ComboBox();
            this.warnAppendCheckBox = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.openFileBtn = new System.Windows.Forms.Button();
            this.snippetFileLabel = new System.Windows.Forms.Label();
            this.pathTxtBox = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.automaticDiscovery = new System.Windows.Forms.CheckBox();
            this.escapeCharsLabel = new System.Windows.Forms.Label();
            this.escapeChars = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.scopeText = new System.Windows.Forms.Label();
            this.snippetScope = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.tab = new Zeroit.Framework.SnippetEditors.ZeroitHorizontalTab();
            this.extensibleOutput = new Zeroit.Framework.SnippetEditors.ExtensiblePanel();
            this.choicePanel = new System.Windows.Forms.Panel();
            this.choiceOKBtn = new Zeroit.Framework.SnippetEditors.Helpers.Button.ZeroitLollipopClickButton();
            this.choiceTextBox = new System.Windows.Forms.TextBox();
            this.outputCode = new System.Windows.Forms.TextBox();
            this.VSCodeOutputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.outputCopyCtxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.outputAppendCtxtMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.Insert = new System.Windows.Forms.ToolStripMenuItem();
            this.TabStop = new System.Windows.Forms.ToolStripMenuItem();
            this.PlaceholderStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.singleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nestedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ChoiceStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.VariableStripMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.GeneralToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMSELECTEDTEXTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMCURRENTLINEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMCURRENTWORDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMLINEINDEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMLINENUMBERToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMFILENAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMFILENAMEBASEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMDIRECTORYToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMFILEPATHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cLIPBOARDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wORKSPACENAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.DateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTYEARToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTYEARSHORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTMONTHToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTMONTHNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTMONTHNAMESHORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTDATEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTDAYNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTDAYNAMESHORTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTHOURToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTMINUTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cURRENTSECONDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.BlockCommentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOCKCOMMENTSTARTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bLOCKCOMMENTENDToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lINECOMMENTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defineAVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.extensibleInput = new Zeroit.Framework.SnippetEditors.ExtensiblePanel();
            this.zoomLabel = new System.Windows.Forms.Label();
            this.inputCode = new System.Windows.Forms.RichTextBox();
            this.inputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.pasteInsertionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.replace = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.snippetPrefix = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.snippetDescription = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.snippetName = new Zeroit.Framework.SnippetEditors.ZeroitUltraTextBox();
            this.openFile = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.AtomOutputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.SublimeOutputContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.placeholderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cDATAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.commentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loremIpsumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.longTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.shortTagToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLProcessingInstructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usrbindevToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.envrionmentVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pARAMPARAMnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sELCTIONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMCURRENTLINEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMCURRENTWORDToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMDIRECTORYToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMFILENAMEToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMFILEPATHToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMFULLNAMEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMLINEINDEXToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMLINENUMBERToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMSELECTEDTEXTToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tMSCOPEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMSOFTTABSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tMTABSIZEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.substitutionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.withoutOptionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zeroitSplashScreen1 = new Zeroit.Framework.Components.ZeroitSplashScreen();
            this.baseTheme2.SuspendLayout();
            this.extensibleOutput.SuspendLayout();
            this.choicePanel.SuspendLayout();
            this.VSCodeOutputContextMenuStrip.SuspendLayout();
            this.extensibleInput.SuspendLayout();
            this.inputContextMenuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.AtomOutputContextMenuStrip.SuspendLayout();
            this.SublimeOutputContextMenuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // baseTheme2
            // 
            this.baseTheme2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.baseTheme2.BorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.baseTheme2.Colors = new Zeroit.Framework.SnippetEditors.Bloom[0];
            this.baseTheme2.Controls.Add(this.appendCode);
            this.baseTheme2.Controls.Add(this.copyCode);
            this.baseTheme2.Controls.Add(this.pasteTextBtn);
            this.baseTheme2.Controls.Add(this.resetBtn);
            this.baseTheme2.Controls.Add(this.lastAppendedLabel);
            this.baseTheme2.Controls.Add(this.soundBtn);
            this.baseTheme2.Controls.Add(this.closeBtn);
            this.baseTheme2.Controls.Add(this.minimizeBtn);
            this.baseTheme2.Controls.Add(this.globalSnippCheckBox);
            this.baseTheme2.Controls.Add(this.globalSnippLabel);
            this.baseTheme2.Controls.Add(this.identifierLabel);
            this.baseTheme2.Controls.Add(this.languageLabel);
            this.baseTheme2.Controls.Add(this.languageTextBox);
            this.baseTheme2.Controls.Add(this.addLangIdBtn);
            this.baseTheme2.Controls.Add(this.langIdLabel);
            this.baseTheme2.Controls.Add(this.languageIdTextBox);
            this.baseTheme2.Controls.Add(this.languageIdCombo);
            this.baseTheme2.Controls.Add(this.warnAppendCheckBox);
            this.baseTheme2.Controls.Add(this.label7);
            this.baseTheme2.Controls.Add(this.openFileBtn);
            this.baseTheme2.Controls.Add(this.snippetFileLabel);
            this.baseTheme2.Controls.Add(this.pathTxtBox);
            this.baseTheme2.Controls.Add(this.label6);
            this.baseTheme2.Controls.Add(this.automaticDiscovery);
            this.baseTheme2.Controls.Add(this.escapeCharsLabel);
            this.baseTheme2.Controls.Add(this.escapeChars);
            this.baseTheme2.Controls.Add(this.label4);
            this.baseTheme2.Controls.Add(this.scopeText);
            this.baseTheme2.Controls.Add(this.snippetScope);
            this.baseTheme2.Controls.Add(this.tab);
            this.baseTheme2.Controls.Add(this.extensibleOutput);
            this.baseTheme2.Controls.Add(this.extensibleInput);
            this.baseTheme2.Controls.Add(this.label3);
            this.baseTheme2.Controls.Add(this.label2);
            this.baseTheme2.Controls.Add(this.label1);
            this.baseTheme2.Controls.Add(this.snippetPrefix);
            this.baseTheme2.Controls.Add(this.snippetDescription);
            this.baseTheme2.Controls.Add(this.snippetName);
            this.baseTheme2.Customization = "";
            this.baseTheme2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.baseTheme2.Font = new System.Drawing.Font("Verdana", 9F);
            this.baseTheme2.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.mainIcon;
            this.baseTheme2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.baseTheme2.ImageSize = new System.Drawing.Size(20, 20);
            this.baseTheme2.Location = new System.Drawing.Point(0, 0);
            this.baseTheme2.Movable = true;
            this.baseTheme2.Name = "baseTheme2";
            this.baseTheme2.NoRounding = false;
            this.baseTheme2.ShowIcon = true;
            this.baseTheme2.ShowText = false;
            this.baseTheme2.Sizable = false;
            this.baseTheme2.Size = new System.Drawing.Size(966, 750);
            this.baseTheme2.SmartBounds = true;
            this.baseTheme2.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.baseTheme2.TabIndex = 0;
            this.baseTheme2.Text = "Snippet Editor";
            this.baseTheme2.TextAlign = System.Drawing.StringAlignment.Near;
            this.baseTheme2.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.baseTheme2.Transparent = false;
            this.baseTheme2.MouseEnter += new System.EventHandler(this.baseTheme2_MouseEnter);
            // 
            // appendCode
            // 
            this.appendCode.AllowTransparency = true;
            this.appendCode.AnimationInterval = 1;
            this.appendCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.appendCode.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.appendCode.BorderWidth = 1F;
            this.appendCode.ClickLimit = 10;
            this.appendCode.ClickSpeed = 1;
            this.appendCode.Corners = 10F;
            this.appendCode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.appendCode.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.appendCode.DoubleRipple = true;
            this.appendCode.EnabledBGColor = System.Drawing.Color.DarkOrange;
            this.appendCode.Font = new System.Drawing.Font("Verdana", 8F);
            this.appendCode.ForeColor = System.Drawing.Color.White;
            this.appendCode.Image = null;
            this.appendCode.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.appendCode.ImageSize = new System.Drawing.Size(0, 0);
            this.appendCode.Length = 50;
            this.appendCode.Location = new System.Drawing.Point(718, 690);
            this.appendCode.Mirror = false;
            this.appendCode.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.appendCode.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.appendCode.Name = "appendCode";
            this.appendCode.RippleEffectColor = System.Drawing.Color.Black;
            this.appendCode.RippleOpacity = 25;
            this.appendCode.ShowText = true;
            this.appendCode.Size = new System.Drawing.Size(163, 34);
            this.appendCode.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.appendCode.TabIndex = 74;
            this.appendCode.Text = "Append Snippet";
            this.appendCode.TextAlign = System.Drawing.StringAlignment.Center;
            this.appendCode.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.appendCode.Click += new System.EventHandler(this.appendCode_Click);
            this.appendCode.MouseLeave += new System.EventHandler(this.appendCode_MouseLeave);
            this.appendCode.MouseHover += new System.EventHandler(this.appendCode_MouseHover);
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
            this.copyCode.Location = new System.Drawing.Point(542, 690);
            this.copyCode.Mirror = false;
            this.copyCode.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.copyCode.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.copyCode.Name = "copyCode";
            this.copyCode.RippleEffectColor = System.Drawing.Color.Black;
            this.copyCode.RippleOpacity = 25;
            this.copyCode.ShowText = true;
            this.copyCode.Size = new System.Drawing.Size(163, 34);
            this.copyCode.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.copyCode.TabIndex = 73;
            this.copyCode.Text = "Copy";
            this.copyCode.TextAlign = System.Drawing.StringAlignment.Center;
            this.copyCode.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.copyCode.Click += new System.EventHandler(this.copyCode_Click);
            this.copyCode.MouseLeave += new System.EventHandler(this.copyCode_MouseLeave);
            this.copyCode.MouseHover += new System.EventHandler(this.copyCode_MouseHover);
            // 
            // pasteTextBtn
            // 
            this.pasteTextBtn.AllowTransparency = true;
            this.pasteTextBtn.AnimationInterval = 1;
            this.pasteTextBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pasteTextBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pasteTextBtn.BorderWidth = 1F;
            this.pasteTextBtn.ClickLimit = 10;
            this.pasteTextBtn.ClickSpeed = 1;
            this.pasteTextBtn.Corners = 10F;
            this.pasteTextBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pasteTextBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.pasteTextBtn.DoubleRipple = true;
            this.pasteTextBtn.EnabledBGColor = System.Drawing.Color.CadetBlue;
            this.pasteTextBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.pasteTextBtn.ForeColor = System.Drawing.Color.White;
            this.pasteTextBtn.Image = null;
            this.pasteTextBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.pasteTextBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.pasteTextBtn.Length = 50;
            this.pasteTextBtn.Location = new System.Drawing.Point(162, 690);
            this.pasteTextBtn.Mirror = false;
            this.pasteTextBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.pasteTextBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.pasteTextBtn.Name = "pasteTextBtn";
            this.pasteTextBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.pasteTextBtn.RippleOpacity = 25;
            this.pasteTextBtn.ShowText = true;
            this.pasteTextBtn.Size = new System.Drawing.Size(163, 34);
            this.pasteTextBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.pasteTextBtn.TabIndex = 72;
            this.pasteTextBtn.Text = "Paste";
            this.pasteTextBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.pasteTextBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.pasteTextBtn.Click += new System.EventHandler(this.pasteTextBtn_Click);
            this.pasteTextBtn.MouseLeave += new System.EventHandler(this.pasteTextBtn_MouseLeave);
            this.pasteTextBtn.MouseHover += new System.EventHandler(this.pasteTextBtn_MouseHover);
            // 
            // resetBtn
            // 
            this.resetBtn.AllowTransparency = true;
            this.resetBtn.AnimationInterval = 1;
            this.resetBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.resetBtn.BorderWidth = 1F;
            this.resetBtn.ClickLimit = 10;
            this.resetBtn.ClickSpeed = 1;
            this.resetBtn.Corners = 1F;
            this.resetBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.resetBtn.DoubleRipple = false;
            this.resetBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.resetBtn.ForeColor = System.Drawing.Color.White;
            this.resetBtn.Image = global::Zeroit.Framework.SnippetEditors.Properties.Resources.reset_20px;
            this.resetBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.resetBtn.ImageSize = new System.Drawing.Size(20, 20);
            this.resetBtn.Length = 50;
            this.resetBtn.Location = new System.Drawing.Point(432, 129);
            this.resetBtn.Mirror = false;
            this.resetBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.resetBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.resetBtn.Name = "resetBtn";
            this.resetBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.resetBtn.RippleOpacity = 25;
            this.resetBtn.ShowText = true;
            this.resetBtn.Size = new System.Drawing.Size(29, 33);
            this.resetBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.resetBtn.TabIndex = 2;
            this.resetBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.resetBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.resetBtn.Click += new System.EventHandler(this.resetBtn_Click);
            this.resetBtn.MouseEnter += new System.EventHandler(this.resetBtn_MouseEnter);
            this.resetBtn.MouseLeave += new System.EventHandler(this.resetBtn_MouseLeave);
            // 
            // lastAppendedLabel
            // 
            this.lastAppendedLabel.AutoSize = true;
            this.lastAppendedLabel.Font = new System.Drawing.Font("Verdana", 7F);
            this.lastAppendedLabel.ForeColor = System.Drawing.Color.Violet;
            this.lastAppendedLabel.Location = new System.Drawing.Point(738, 728);
            this.lastAppendedLabel.Name = "lastAppendedLabel";
            this.lastAppendedLabel.Size = new System.Drawing.Size(101, 12);
            this.lastAppendedLabel.TabIndex = 71;
            this.lastAppendedLabel.Text = "Last Appended : ";
            this.toolTip1.SetToolTip(this.lastAppendedLabel, "This is the last snippet name that was saved.");
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
            this.soundBtn.Location = new System.Drawing.Point(18, 714);
            this.soundBtn.Name = "soundBtn";
            this.soundBtn.Size = new System.Drawing.Size(25, 24);
            this.soundBtn.TabIndex = 69;
            this.toolTip1.SetToolTip(this.soundBtn, "Sound Enabled");
            this.soundBtn.UseVisualStyleBackColor = false;
            this.soundBtn.Click += new System.EventHandler(this.soundBtn_Click);
            // 
            // closeBtn
            // 
            this.closeBtn.AllowTransparency = true;
            this.closeBtn.BackColor = System.Drawing.Color.Transparent;
            this.closeBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.closeBtn.ForeColor = System.Drawing.Color.White;
            this.closeBtn.Location = new System.Drawing.Point(945, 2);
            this.closeBtn.Name = "closeBtn";
            this.closeBtn.Size = new System.Drawing.Size(18, 19);
            this.closeBtn.TabIndex = 68;
            this.closeBtn.Text = "x";
            this.closeBtn.Click += new System.EventHandler(this.closeBtn_Click);
            this.closeBtn.MouseLeave += new System.EventHandler(this.closeBtn_MouseLeave);
            this.closeBtn.MouseHover += new System.EventHandler(this.closeBtn_MouseHover);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.AllowTransparency = true;
            this.minimizeBtn.BackColor = System.Drawing.Color.Transparent;
            this.minimizeBtn.Font = new System.Drawing.Font("Comic Sans MS", 10F);
            this.minimizeBtn.ForeColor = System.Drawing.Color.White;
            this.minimizeBtn.Location = new System.Drawing.Point(924, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(18, 19);
            this.minimizeBtn.TabIndex = 1;
            this.minimizeBtn.Text = "_";
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            this.minimizeBtn.MouseLeave += new System.EventHandler(this.minimizeBtn_MouseLeave);
            this.minimizeBtn.MouseHover += new System.EventHandler(this.minimizeBtn_MouseHover);
            // 
            // globalSnippCheckBox
            // 
            this.globalSnippCheckBox.AutoSize = true;
            this.globalSnippCheckBox.Font = new System.Drawing.Font("Verdana", 14F);
            this.globalSnippCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.globalSnippCheckBox.Location = new System.Drawing.Point(366, 115);
            this.globalSnippCheckBox.Name = "globalSnippCheckBox";
            this.globalSnippCheckBox.Size = new System.Drawing.Size(15, 14);
            this.globalSnippCheckBox.TabIndex = 66;
            this.globalSnippCheckBox.UseVisualStyleBackColor = true;
            this.globalSnippCheckBox.CheckedChanged += new System.EventHandler(this.globalSnippCheckBox_CheckedChanged);
            // 
            // globalSnippLabel
            // 
            this.globalSnippLabel.AutoSize = true;
            this.globalSnippLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.globalSnippLabel.ForeColor = System.Drawing.Color.White;
            this.globalSnippLabel.Location = new System.Drawing.Point(249, 115);
            this.globalSnippLabel.Name = "globalSnippLabel";
            this.globalSnippLabel.Size = new System.Drawing.Size(98, 14);
            this.globalSnippLabel.TabIndex = 65;
            this.globalSnippLabel.Text = "Global Snippet";
            // 
            // identifierLabel
            // 
            this.identifierLabel.AutoSize = true;
            this.identifierLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.identifierLabel.ForeColor = System.Drawing.Color.White;
            this.identifierLabel.Location = new System.Drawing.Point(683, 108);
            this.identifierLabel.Name = "identifierLabel";
            this.identifierLabel.Size = new System.Drawing.Size(64, 14);
            this.identifierLabel.TabIndex = 64;
            this.identifierLabel.Text = "Identifier";
            this.identifierLabel.Visible = false;
            // 
            // languageLabel
            // 
            this.languageLabel.AutoSize = true;
            this.languageLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.languageLabel.ForeColor = System.Drawing.Color.White;
            this.languageLabel.Location = new System.Drawing.Point(416, 107);
            this.languageLabel.Name = "languageLabel";
            this.languageLabel.Size = new System.Drawing.Size(70, 14);
            this.languageLabel.TabIndex = 63;
            this.languageLabel.Text = "Language";
            this.languageLabel.Visible = false;
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
            this.languageTextBox.Location = new System.Drawing.Point(521, 99);
            this.languageTextBox.MaxLength = 32767;
            this.languageTextBox.Multiline = false;
            this.languageTextBox.Name = "languageTextBox";
            this.languageTextBox.PasswordChar = '\0';
            this.languageTextBox.Placeholder = true;
            this.languageTextBox.PlaceHolderText = "eg. PHP";
            this.languageTextBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.languageTextBox.ReadOnly = false;
            this.languageTextBox.Size = new System.Drawing.Size(130, 24);
            this.languageTextBox.TabIndex = 62;
            this.languageTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.languageTextBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.languageTextBox.UseSystemPasswordChar = false;
            this.languageTextBox.Visible = false;
            this.languageTextBox.WordWrap = true;
            // 
            // addLangIdBtn
            // 
            this.addLangIdBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.addLangIdBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.addLangIdBtn.FlatAppearance.BorderSize = 0;
            this.addLangIdBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addLangIdBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.addLangIdBtn.ForeColor = System.Drawing.Color.White;
            this.addLangIdBtn.Location = new System.Drawing.Point(932, 72);
            this.addLangIdBtn.Name = "addLangIdBtn";
            this.addLangIdBtn.Size = new System.Drawing.Size(18, 19);
            this.addLangIdBtn.TabIndex = 61;
            this.addLangIdBtn.Text = "+";
            this.addLangIdBtn.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addLangIdBtn.UseCompatibleTextRendering = true;
            this.addLangIdBtn.UseVisualStyleBackColor = false;
            this.addLangIdBtn.Visible = false;
            this.addLangIdBtn.Click += new System.EventHandler(this.addLanguageIdentifier_Click);
            // 
            // langIdLabel
            // 
            this.langIdLabel.AutoSize = true;
            this.langIdLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.langIdLabel.ForeColor = System.Drawing.Color.White;
            this.langIdLabel.Location = new System.Drawing.Point(683, 66);
            this.langIdLabel.Name = "langIdLabel";
            this.langIdLabel.Size = new System.Drawing.Size(70, 28);
            this.langIdLabel.TabIndex = 60;
            this.langIdLabel.Text = "Language\r\nIdentifier";
            this.langIdLabel.Visible = false;
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
            this.languageIdTextBox.Location = new System.Drawing.Point(770, 99);
            this.languageIdTextBox.MaxLength = 32767;
            this.languageIdTextBox.Multiline = false;
            this.languageIdTextBox.Name = "languageIdTextBox";
            this.languageIdTextBox.PasswordChar = '\0';
            this.languageIdTextBox.Placeholder = true;
            this.languageIdTextBox.PlaceHolderText = "eg. php";
            this.languageIdTextBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.languageIdTextBox.ReadOnly = false;
            this.languageIdTextBox.Size = new System.Drawing.Size(159, 24);
            this.languageIdTextBox.TabIndex = 59;
            this.languageIdTextBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.languageIdTextBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.languageIdTextBox.UseSystemPasswordChar = false;
            this.languageIdTextBox.Visible = false;
            this.languageIdTextBox.WordWrap = true;
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
            this.languageIdCombo.Location = new System.Drawing.Point(770, 70);
            this.languageIdCombo.Name = "languageIdCombo";
            this.languageIdCombo.Size = new System.Drawing.Size(159, 22);
            this.languageIdCombo.TabIndex = 58;
            this.languageIdCombo.Visible = false;
            this.languageIdCombo.SelectedIndexChanged += new System.EventHandler(this.languageIdCombo_SelectedIndexChanged);
            // 
            // warnAppendCheckBox
            // 
            this.warnAppendCheckBox.AutoSize = true;
            this.warnAppendCheckBox.Checked = true;
            this.warnAppendCheckBox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.warnAppendCheckBox.Font = new System.Drawing.Font("Verdana", 14F);
            this.warnAppendCheckBox.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.warnAppendCheckBox.Location = new System.Drawing.Point(367, 148);
            this.warnAppendCheckBox.Name = "warnAppendCheckBox";
            this.warnAppendCheckBox.Size = new System.Drawing.Size(15, 14);
            this.warnAppendCheckBox.TabIndex = 57;
            this.warnAppendCheckBox.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 9F);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(249, 150);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(112, 14);
            this.label7.TabIndex = 56;
            this.label7.Text = "Warn on Append";
            // 
            // openFileBtn
            // 
            this.openFileBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.openFileBtn.FlatAppearance.BorderColor = System.Drawing.Color.Cyan;
            this.openFileBtn.FlatAppearance.BorderSize = 0;
            this.openFileBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openFileBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.openFileBtn.ForeColor = System.Drawing.Color.White;
            this.openFileBtn.Image = ((System.Drawing.Image)(resources.GetObject("openFileBtn.Image")));
            this.openFileBtn.Location = new System.Drawing.Point(935, 31);
            this.openFileBtn.Name = "openFileBtn";
            this.openFileBtn.Size = new System.Drawing.Size(17, 17);
            this.openFileBtn.TabIndex = 55;
            this.openFileBtn.UseVisualStyleBackColor = false;
            this.openFileBtn.Click += new System.EventHandler(this.openFileBtn_Click);
            // 
            // snippetFileLabel
            // 
            this.snippetFileLabel.AutoSize = true;
            this.snippetFileLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.snippetFileLabel.ForeColor = System.Drawing.Color.White;
            this.snippetFileLabel.Location = new System.Drawing.Point(682, 34);
            this.snippetFileLabel.Name = "snippetFileLabel";
            this.snippetFileLabel.Size = new System.Drawing.Size(80, 14);
            this.snippetFileLabel.TabIndex = 53;
            this.snippetFileLabel.Text = "Snippet File";
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
            this.pathTxtBox.Location = new System.Drawing.Point(768, 25);
            this.pathTxtBox.MaxLength = 32767;
            this.pathTxtBox.Multiline = false;
            this.pathTxtBox.Name = "pathTxtBox";
            this.pathTxtBox.PasswordChar = '\0';
            this.pathTxtBox.Placeholder = true;
            this.pathTxtBox.PlaceHolderText = "eg. C:/Snippet.json";
            this.pathTxtBox.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.pathTxtBox.ReadOnly = false;
            this.pathTxtBox.Size = new System.Drawing.Size(161, 24);
            this.pathTxtBox.TabIndex = 52;
            this.pathTxtBox.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.pathTxtBox.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pathTxtBox.UseSystemPasswordChar = false;
            this.pathTxtBox.WordWrap = true;
            this.pathTxtBox.MouseEnter += new System.EventHandler(this.pathTxtBox_MouseEnter);
            this.pathTxtBox.MouseLeave += new System.EventHandler(this.pathTxtBox_MouseLeave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 9F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 14);
            this.label6.TabIndex = 37;
            this.label6.Text = "Automatic Clipboard Discovery";
            // 
            // automaticDiscovery
            // 
            this.automaticDiscovery.AutoSize = true;
            this.automaticDiscovery.Font = new System.Drawing.Font("Verdana", 14F);
            this.automaticDiscovery.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.automaticDiscovery.Location = new System.Drawing.Point(218, 151);
            this.automaticDiscovery.Name = "automaticDiscovery";
            this.automaticDiscovery.Size = new System.Drawing.Size(15, 14);
            this.automaticDiscovery.TabIndex = 36;
            this.automaticDiscovery.UseVisualStyleBackColor = true;
            // 
            // escapeCharsLabel
            // 
            this.escapeCharsLabel.AutoSize = true;
            this.escapeCharsLabel.Font = new System.Drawing.Font("Verdana", 9F);
            this.escapeCharsLabel.ForeColor = System.Drawing.Color.White;
            this.escapeCharsLabel.Location = new System.Drawing.Point(15, 115);
            this.escapeCharsLabel.Name = "escapeCharsLabel";
            this.escapeCharsLabel.Size = new System.Drawing.Size(118, 14);
            this.escapeCharsLabel.TabIndex = 34;
            this.escapeCharsLabel.Text = "Escape chars ( \" )";
            // 
            // escapeChars
            // 
            this.escapeChars.AutoSize = true;
            this.escapeChars.Checked = true;
            this.escapeChars.CheckState = System.Windows.Forms.CheckState.Checked;
            this.escapeChars.Font = new System.Drawing.Font("Verdana", 14F);
            this.escapeChars.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.escapeChars.Location = new System.Drawing.Point(218, 115);
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
            this.label4.Location = new System.Drawing.Point(262, 728);
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
            this.scopeText.Location = new System.Drawing.Point(416, 71);
            this.scopeText.Name = "scopeText";
            this.scopeText.Size = new System.Drawing.Size(45, 14);
            this.scopeText.TabIndex = 31;
            this.scopeText.Text = "Scope";
            this.scopeText.Visible = false;
            // 
            // snippetScope
            // 
            this.snippetScope.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetScope.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetScope.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetScope.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetScope.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetScope.ForeColor = System.Drawing.Color.White;
            this.snippetScope.IsEnabled = true;
            this.snippetScope.Location = new System.Drawing.Point(521, 63);
            this.snippetScope.MaxLength = 32767;
            this.snippetScope.Multiline = false;
            this.snippetScope.Name = "snippetScope";
            this.snippetScope.PasswordChar = '\0';
            this.snippetScope.Placeholder = true;
            this.snippetScope.PlaceHolderText = "eg. source.php";
            this.snippetScope.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetScope.ReadOnly = false;
            this.snippetScope.Size = new System.Drawing.Size(130, 24);
            this.snippetScope.TabIndex = 29;
            this.snippetScope.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetScope.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetScope.UseSystemPasswordChar = false;
            this.snippetScope.Visible = false;
            this.snippetScope.WordWrap = true;
            this.snippetScope.TextChanged += new System.EventHandler(this.snippetScope_TextChanged_1);
            // 
            // tab
            // 
            androidColors2.ActiveTextColor = System.Drawing.Color.Cyan;
            androidColors2.InactiveTextColor = System.Drawing.Color.White;
            androidColors2.SegmentColor = System.Drawing.Color.DarkOrange;
            this.tab.ColorsAndroid = androidColors2;
            iOSColors2.ActiveTextColor = System.Drawing.Color.White;
            iOSColors2.BorderColors = new System.Drawing.Color[] {
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))))};
            iOSColors2.InactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            iOSColors2.SegmentColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(255)))));
            this.tab.ColorsIOS = iOSColors2;
            materialColors2.ActiveTextColor = System.Drawing.Color.White;
            materialColors2.InactiveTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            materialColors2.SegmentColor = System.Drawing.Color.White;
            this.tab.ColorsMaterial = materialColors2;
            this.tab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tab.FitWidth = false;
            this.tab.Font = new System.Drawing.Font("Verdana", 9F);
            this.tab.Location = new System.Drawing.Point(486, 134);
            this.tab.Name = "tab";
            this.tab.SegmentStyle = Zeroit.Framework.SnippetEditors.ZeroitHorizontalTab.Style.Android;
            this.tab.SelectedIndex = 0;
            this.tab.ShowBar = true;
            this.tab.Size = new System.Drawing.Size(463, 37);
            this.tab.TabIndex = 28;
            this.tab.TabPages = new string[] {
        "VSCode",
        "Atom",
        "Sublime",
        "Visual Studio"};
            this.tab.Tabs = "";
            this.tab.Text = "zeroitHorizontalTab1";
            this.tab.TextBox = null;
            this.tab.TabChanged += new System.EventHandler(this.tab_TabChanged);
            // 
            // extensibleOutput
            // 
            this.extensibleOutput.Border = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.extensibleOutput.Controls.Add(this.choicePanel);
            this.extensibleOutput.Controls.Add(this.outputCode);
            this.extensibleOutput.Location = new System.Drawing.Point(489, 174);
            this.extensibleOutput.Name = "extensibleOutput";
            this.extensibleOutput.Size = new System.Drawing.Size(465, 513);
            this.extensibleOutput.TabIndex = 20;
            this.extensibleOutput.MouseEnter += new System.EventHandler(this.extensibleOutput_MouseEnter);
            this.extensibleOutput.MouseLeave += new System.EventHandler(this.extensibleOutput_MouseLeave);
            // 
            // choicePanel
            // 
            this.choicePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.choicePanel.Controls.Add(this.choiceOKBtn);
            this.choicePanel.Controls.Add(this.choiceTextBox);
            this.choicePanel.ForeColor = System.Drawing.Color.White;
            this.choicePanel.Location = new System.Drawing.Point(227, 163);
            this.choicePanel.Name = "choicePanel";
            this.choicePanel.Size = new System.Drawing.Size(123, 84);
            this.choicePanel.TabIndex = 1;
            this.choicePanel.Visible = false;
            // 
            // choiceOKBtn
            // 
            this.choiceOKBtn.AllowTransparency = true;
            this.choiceOKBtn.AnimationInterval = 1;
            this.choiceOKBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.choiceOKBtn.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.choiceOKBtn.BorderWidth = 1F;
            this.choiceOKBtn.ClickLimit = 10;
            this.choiceOKBtn.ClickSpeed = 1;
            this.choiceOKBtn.Corners = 10F;
            this.choiceOKBtn.DisabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(176)))), ((int)(((byte)(178)))), ((int)(((byte)(181)))));
            this.choiceOKBtn.DoubleRipple = true;
            this.choiceOKBtn.EnabledBGColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.choiceOKBtn.Font = new System.Drawing.Font("Verdana", 8F);
            this.choiceOKBtn.ForeColor = System.Drawing.Color.White;
            this.choiceOKBtn.Image = null;
            this.choiceOKBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.choiceOKBtn.ImageSize = new System.Drawing.Size(0, 0);
            this.choiceOKBtn.Length = 50;
            this.choiceOKBtn.Location = new System.Drawing.Point(20, 52);
            this.choiceOKBtn.Mirror = false;
            this.choiceOKBtn.MirrorGradient = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.choiceOKBtn.MirrorRotation = System.Drawing.RotateFlipType.RotateNoneFlipY;
            this.choiceOKBtn.Name = "choiceOKBtn";
            this.choiceOKBtn.RippleEffectColor = System.Drawing.Color.Black;
            this.choiceOKBtn.RippleOpacity = 25;
            this.choiceOKBtn.ShowText = true;
            this.choiceOKBtn.Size = new System.Drawing.Size(81, 26);
            this.choiceOKBtn.Smoothing = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            this.choiceOKBtn.TabIndex = 74;
            this.choiceOKBtn.Text = "OK";
            this.choiceOKBtn.TextAlign = System.Drawing.StringAlignment.Center;
            this.choiceOKBtn.TextRendering = System.Drawing.Text.TextRenderingHint.AntiAlias;
            this.choiceOKBtn.Click += new System.EventHandler(this.choiceOKBtn_Click);
            // 
            // choiceTextBox
            // 
            this.choiceTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.choiceTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.choiceTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.choiceTextBox.Font = new System.Drawing.Font("Consolas", 9F);
            this.choiceTextBox.ForeColor = System.Drawing.Color.White;
            this.choiceTextBox.Location = new System.Drawing.Point(0, 0);
            this.choiceTextBox.Multiline = true;
            this.choiceTextBox.Name = "choiceTextBox";
            this.choiceTextBox.Size = new System.Drawing.Size(121, 49);
            this.choiceTextBox.TabIndex = 0;
            // 
            // outputCode
            // 
            this.outputCode.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.outputCode.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.outputCode.ContextMenuStrip = this.VSCodeOutputContextMenuStrip;
            this.outputCode.Font = new System.Drawing.Font("Consolas", 11F);
            this.outputCode.ForeColor = System.Drawing.Color.Cyan;
            this.outputCode.Location = new System.Drawing.Point(2, 3);
            this.outputCode.Multiline = true;
            this.outputCode.Name = "outputCode";
            this.outputCode.Size = new System.Drawing.Size(459, 507);
            this.outputCode.TabIndex = 0;
            this.outputCode.Text = "OUTPUT\r\n\r\nCODE \r\n\r\nDISPLAYS\r\n\r\nHERE\r\n\r\nDO\r\n\r\nNOT \r\n\r\nPASTE\r\n\r\nHERE\r\n\r\nENJOY!!!\r\n\r" +
    "\nENJOY!!!\r\n\r\nENJOY!!!\r\n\r\nENJOY!!!\r\n\r\nENJOY!!!\r\n\r\nENJOY!!!\r\n\r\nENJOY!!!";
            this.outputCode.MouseClick += new System.Windows.Forms.MouseEventHandler(this.outputCode_MouseClick);
            this.outputCode.TextChanged += new System.EventHandler(this.outputCode_TextChanged);
            this.outputCode.MouseLeave += new System.EventHandler(this.outputCode_MouseLeave);
            this.outputCode.MouseHover += new System.EventHandler(this.outputCode_MouseHover);
            this.outputCode.MouseMove += new System.Windows.Forms.MouseEventHandler(this.outputCode_MouseMove);
            // 
            // VSCodeOutputContextMenuStrip
            // 
            this.VSCodeOutputContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.VSCodeOutputContextMenuStrip.Font = new System.Drawing.Font("Verdana", 8F);
            this.VSCodeOutputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.outputCopyCtxtMenu,
            this.outputAppendCtxtMenu,
            this.Insert});
            this.VSCodeOutputContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.VSCodeOutputContextMenuStrip.Name = "contextMenuStrip1";
            this.VSCodeOutputContextMenuStrip.ShowImageMargin = false;
            this.VSCodeOutputContextMenuStrip.Size = new System.Drawing.Size(126, 70);
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
            // outputAppendCtxtMenu
            // 
            this.outputAppendCtxtMenu.ForeColor = System.Drawing.Color.White;
            this.outputAppendCtxtMenu.Name = "outputAppendCtxtMenu";
            this.outputAppendCtxtMenu.Size = new System.Drawing.Size(125, 22);
            this.outputAppendCtxtMenu.Text = "Append";
            this.outputAppendCtxtMenu.Click += new System.EventHandler(this.outputAppendCtxtMenu_Click);
            // 
            // Insert
            // 
            this.Insert.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.Insert.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TabStop,
            this.PlaceholderStripMenu,
            this.ChoiceStripMenu,
            this.VariableStripMenu});
            this.Insert.ForeColor = System.Drawing.Color.White;
            this.Insert.Name = "Insert";
            this.Insert.Size = new System.Drawing.Size(125, 22);
            this.Insert.Text = "Insert";
            // 
            // TabStop
            // 
            this.TabStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TabStop.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.TabStop.ForeColor = System.Drawing.Color.White;
            this.TabStop.Name = "TabStop";
            this.TabStop.Size = new System.Drawing.Size(140, 22);
            this.TabStop.Text = "Tab Stop";
            this.TabStop.ToolTipText = "Make the editor cursor move inside a snippet";
            this.TabStop.Click += new System.EventHandler(this.TabStop_Click);
            // 
            // PlaceholderStripMenu
            // 
            this.PlaceholderStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.PlaceholderStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.PlaceholderStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleToolStripMenuItem,
            this.nestedToolStripMenuItem});
            this.PlaceholderStripMenu.ForeColor = System.Drawing.Color.White;
            this.PlaceholderStripMenu.Name = "PlaceholderStripMenu";
            this.PlaceholderStripMenu.Size = new System.Drawing.Size(140, 22);
            this.PlaceholderStripMenu.Text = "Placeholder";
            // 
            // singleToolStripMenuItem
            // 
            this.singleToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.singleToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.singleToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.singleToolStripMenuItem.Name = "singleToolStripMenuItem";
            this.singleToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.singleToolStripMenuItem.Text = "Single";
            this.singleToolStripMenuItem.ToolTipText = "These are tabstops with values that are selected";
            this.singleToolStripMenuItem.Click += new System.EventHandler(this.singleToolStripMenuItem_Click);
            // 
            // nestedToolStripMenuItem
            // 
            this.nestedToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.nestedToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.nestedToolStripMenuItem.Name = "nestedToolStripMenuItem";
            this.nestedToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.nestedToolStripMenuItem.Text = "Nested";
            this.nestedToolStripMenuItem.ToolTipText = "These are tabstops with values that are selected";
            this.nestedToolStripMenuItem.Click += new System.EventHandler(this.nestedToolStripMenuItem_Click);
            // 
            // ChoiceStripMenu
            // 
            this.ChoiceStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.ChoiceStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ChoiceStripMenu.ForeColor = System.Drawing.Color.White;
            this.ChoiceStripMenu.Name = "ChoiceStripMenu";
            this.ChoiceStripMenu.Size = new System.Drawing.Size(140, 22);
            this.ChoiceStripMenu.Text = "Choice";
            this.ChoiceStripMenu.ToolTipText = "When the snippet is inserted and the placeholder selected, choices will prompt th" +
    "e user to pick one of the values";
            this.ChoiceStripMenu.Click += new System.EventHandler(this.ChoiceStripMenu_Click);
            // 
            // VariableStripMenu
            // 
            this.VariableStripMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.VariableStripMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.VariableStripMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.GeneralToolStripMenuItem,
            this.DateToolStripMenuItem,
            this.BlockCommentToolStripMenuItem,
            this.defineAVariableToolStripMenuItem});
            this.VariableStripMenu.ForeColor = System.Drawing.Color.White;
            this.VariableStripMenu.Name = "VariableStripMenu";
            this.VariableStripMenu.Size = new System.Drawing.Size(140, 22);
            this.VariableStripMenu.Text = "Variable";
            // 
            // GeneralToolStripMenuItem
            // 
            this.GeneralToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.GeneralToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.GeneralToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tMSELECTEDTEXTToolStripMenuItem,
            this.tMCURRENTLINEToolStripMenuItem,
            this.tMCURRENTWORDToolStripMenuItem,
            this.tMLINEINDEXToolStripMenuItem,
            this.tMLINENUMBERToolStripMenuItem,
            this.tMFILENAMEToolStripMenuItem,
            this.tMFILENAMEBASEToolStripMenuItem,
            this.tMDIRECTORYToolStripMenuItem,
            this.tMFILEPATHToolStripMenuItem,
            this.cLIPBOARDToolStripMenuItem,
            this.wORKSPACENAMEToolStripMenuItem});
            this.GeneralToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.GeneralToolStripMenuItem.Name = "GeneralToolStripMenuItem";
            this.GeneralToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.GeneralToolStripMenuItem.Text = "General";
            // 
            // tMSELECTEDTEXTToolStripMenuItem
            // 
            this.tMSELECTEDTEXTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMSELECTEDTEXTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMSELECTEDTEXTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMSELECTEDTEXTToolStripMenuItem.Name = "tMSELECTEDTEXTToolStripMenuItem";
            this.tMSELECTEDTEXTToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMSELECTEDTEXTToolStripMenuItem.Text = "TM_SELECTED_TEXT";
            this.tMSELECTEDTEXTToolStripMenuItem.ToolTipText = "The currently selected text or the empty string";
            this.tMSELECTEDTEXTToolStripMenuItem.Click += new System.EventHandler(this.tMSELECTEDTEXTToolStripMenuItem_Click);
            // 
            // tMCURRENTLINEToolStripMenuItem
            // 
            this.tMCURRENTLINEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMCURRENTLINEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMCURRENTLINEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMCURRENTLINEToolStripMenuItem.Name = "tMCURRENTLINEToolStripMenuItem";
            this.tMCURRENTLINEToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMCURRENTLINEToolStripMenuItem.Text = "TM_CURRENT_LINE";
            this.tMCURRENTLINEToolStripMenuItem.ToolTipText = "The contents of the current line";
            this.tMCURRENTLINEToolStripMenuItem.Click += new System.EventHandler(this.tMCURRENTLINEToolStripMenuItem_Click);
            // 
            // tMCURRENTWORDToolStripMenuItem
            // 
            this.tMCURRENTWORDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMCURRENTWORDToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMCURRENTWORDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMCURRENTWORDToolStripMenuItem.Name = "tMCURRENTWORDToolStripMenuItem";
            this.tMCURRENTWORDToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMCURRENTWORDToolStripMenuItem.Text = "TM_CURRENT_WORD";
            this.tMCURRENTWORDToolStripMenuItem.ToolTipText = "The contents of the word under cursor or the empty string";
            this.tMCURRENTWORDToolStripMenuItem.Click += new System.EventHandler(this.tMCURRENTWORDToolStripMenuItem_Click);
            // 
            // tMLINEINDEXToolStripMenuItem
            // 
            this.tMLINEINDEXToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMLINEINDEXToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMLINEINDEXToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMLINEINDEXToolStripMenuItem.Name = "tMLINEINDEXToolStripMenuItem";
            this.tMLINEINDEXToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMLINEINDEXToolStripMenuItem.Text = "TM_LINE_INDEX";
            this.tMLINEINDEXToolStripMenuItem.ToolTipText = "The zero-index based line number";
            this.tMLINEINDEXToolStripMenuItem.Click += new System.EventHandler(this.tMLINEINDEXToolStripMenuItem_Click);
            // 
            // tMLINENUMBERToolStripMenuItem
            // 
            this.tMLINENUMBERToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMLINENUMBERToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMLINENUMBERToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMLINENUMBERToolStripMenuItem.Name = "tMLINENUMBERToolStripMenuItem";
            this.tMLINENUMBERToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMLINENUMBERToolStripMenuItem.Text = "TM_LINE_NUMBER";
            this.tMLINENUMBERToolStripMenuItem.ToolTipText = "The one-index based line number";
            this.tMLINENUMBERToolStripMenuItem.Click += new System.EventHandler(this.tMLINENUMBERToolStripMenuItem_Click);
            // 
            // tMFILENAMEToolStripMenuItem
            // 
            this.tMFILENAMEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMFILENAMEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMFILENAMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMFILENAMEToolStripMenuItem.Name = "tMFILENAMEToolStripMenuItem";
            this.tMFILENAMEToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMFILENAMEToolStripMenuItem.Text = "TM_FILENAME";
            this.tMFILENAMEToolStripMenuItem.ToolTipText = "The filename of the current document";
            this.tMFILENAMEToolStripMenuItem.Click += new System.EventHandler(this.tMFILENAMEToolStripMenuItem_Click);
            // 
            // tMFILENAMEBASEToolStripMenuItem
            // 
            this.tMFILENAMEBASEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMFILENAMEBASEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMFILENAMEBASEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMFILENAMEBASEToolStripMenuItem.Name = "tMFILENAMEBASEToolStripMenuItem";
            this.tMFILENAMEBASEToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMFILENAMEBASEToolStripMenuItem.Text = "TM_FILENAME_BASE";
            this.tMFILENAMEBASEToolStripMenuItem.ToolTipText = "The filename of the current document without its extensions";
            this.tMFILENAMEBASEToolStripMenuItem.Click += new System.EventHandler(this.tMFILENAMEBASEToolStripMenuItem_Click);
            // 
            // tMDIRECTORYToolStripMenuItem
            // 
            this.tMDIRECTORYToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMDIRECTORYToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMDIRECTORYToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMDIRECTORYToolStripMenuItem.Name = "tMDIRECTORYToolStripMenuItem";
            this.tMDIRECTORYToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMDIRECTORYToolStripMenuItem.Text = "TM_DIRECTORY";
            this.tMDIRECTORYToolStripMenuItem.ToolTipText = "The directory of the current document";
            this.tMDIRECTORYToolStripMenuItem.Click += new System.EventHandler(this.tMDIRECTORYToolStripMenuItem_Click);
            // 
            // tMFILEPATHToolStripMenuItem
            // 
            this.tMFILEPATHToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMFILEPATHToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tMFILEPATHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMFILEPATHToolStripMenuItem.Name = "tMFILEPATHToolStripMenuItem";
            this.tMFILEPATHToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tMFILEPATHToolStripMenuItem.Text = "TM_FILEPATH";
            this.tMFILEPATHToolStripMenuItem.ToolTipText = "The full file path of the current document";
            this.tMFILEPATHToolStripMenuItem.Click += new System.EventHandler(this.tMFILEPATHToolStripMenuItem_Click);
            // 
            // cLIPBOARDToolStripMenuItem
            // 
            this.cLIPBOARDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cLIPBOARDToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cLIPBOARDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cLIPBOARDToolStripMenuItem.Name = "cLIPBOARDToolStripMenuItem";
            this.cLIPBOARDToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cLIPBOARDToolStripMenuItem.Text = "CLIPBOARD";
            this.cLIPBOARDToolStripMenuItem.ToolTipText = "The contents of your clipboard";
            this.cLIPBOARDToolStripMenuItem.Click += new System.EventHandler(this.cLIPBOARDToolStripMenuItem_Click);
            // 
            // wORKSPACENAMEToolStripMenuItem
            // 
            this.wORKSPACENAMEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.wORKSPACENAMEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.wORKSPACENAMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.wORKSPACENAMEToolStripMenuItem.Name = "wORKSPACENAMEToolStripMenuItem";
            this.wORKSPACENAMEToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.wORKSPACENAMEToolStripMenuItem.Text = "WORKSPACE_NAME";
            this.wORKSPACENAMEToolStripMenuItem.ToolTipText = "The name of the opened workspace or folder";
            this.wORKSPACENAMEToolStripMenuItem.Click += new System.EventHandler(this.wORKSPACENAMEToolStripMenuItem_Click);
            // 
            // DateToolStripMenuItem
            // 
            this.DateToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.DateToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cURRENTYEARToolStripMenuItem,
            this.cURRENTYEARSHORTToolStripMenuItem,
            this.cURRENTMONTHToolStripMenuItem,
            this.cURRENTMONTHNAMEToolStripMenuItem,
            this.cURRENTMONTHNAMESHORTToolStripMenuItem,
            this.cURRENTDATEToolStripMenuItem,
            this.cURRENTDAYNAMEToolStripMenuItem,
            this.cURRENTDAYNAMESHORTToolStripMenuItem,
            this.cURRENTHOURToolStripMenuItem,
            this.cURRENTMINUTEToolStripMenuItem,
            this.cURRENTSECONDToolStripMenuItem});
            this.DateToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.DateToolStripMenuItem.Name = "DateToolStripMenuItem";
            this.DateToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.DateToolStripMenuItem.Text = "Date";
            // 
            // cURRENTYEARToolStripMenuItem
            // 
            this.cURRENTYEARToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTYEARToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTYEARToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTYEARToolStripMenuItem.Name = "cURRENTYEARToolStripMenuItem";
            this.cURRENTYEARToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTYEARToolStripMenuItem.Text = "CURRENT_YEAR";
            this.cURRENTYEARToolStripMenuItem.ToolTipText = "The current year";
            this.cURRENTYEARToolStripMenuItem.Click += new System.EventHandler(this.cURRENTYEARToolStripMenuItem_Click);
            // 
            // cURRENTYEARSHORTToolStripMenuItem
            // 
            this.cURRENTYEARSHORTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTYEARSHORTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTYEARSHORTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTYEARSHORTToolStripMenuItem.Name = "cURRENTYEARSHORTToolStripMenuItem";
            this.cURRENTYEARSHORTToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTYEARSHORTToolStripMenuItem.Text = "CURRENT_YEAR_SHORT";
            this.cURRENTYEARSHORTToolStripMenuItem.ToolTipText = "The current year\'s last two digits";
            this.cURRENTYEARSHORTToolStripMenuItem.Click += new System.EventHandler(this.cURRENTYEARSHORTToolStripMenuItem_Click);
            // 
            // cURRENTMONTHToolStripMenuItem
            // 
            this.cURRENTMONTHToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTMONTHToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTMONTHToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTMONTHToolStripMenuItem.Name = "cURRENTMONTHToolStripMenuItem";
            this.cURRENTMONTHToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTMONTHToolStripMenuItem.Text = "CURRENT_MONTH";
            this.cURRENTMONTHToolStripMenuItem.ToolTipText = "The month as two digits (example \'02\')";
            this.cURRENTMONTHToolStripMenuItem.Click += new System.EventHandler(this.cURRENTMONTHToolStripMenuItem_Click);
            // 
            // cURRENTMONTHNAMEToolStripMenuItem
            // 
            this.cURRENTMONTHNAMEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTMONTHNAMEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTMONTHNAMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTMONTHNAMEToolStripMenuItem.Name = "cURRENTMONTHNAMEToolStripMenuItem";
            this.cURRENTMONTHNAMEToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTMONTHNAMEToolStripMenuItem.Text = "CURRENT_MONTH_NAME";
            this.cURRENTMONTHNAMEToolStripMenuItem.ToolTipText = "The full name of the month (example \'July\')";
            this.cURRENTMONTHNAMEToolStripMenuItem.Click += new System.EventHandler(this.cURRENTMONTHNAMEToolStripMenuItem_Click);
            // 
            // cURRENTMONTHNAMESHORTToolStripMenuItem
            // 
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.Name = "cURRENTMONTHNAMESHORTToolStripMenuItem";
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.Text = "CURRENT_MONTH_NAME_SHORT";
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.ToolTipText = "The short name of the month (example \'Jul\')";
            this.cURRENTMONTHNAMESHORTToolStripMenuItem.Click += new System.EventHandler(this.cURRENTMONTHNAMESHORTToolStripMenuItem_Click);
            // 
            // cURRENTDATEToolStripMenuItem
            // 
            this.cURRENTDATEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTDATEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTDATEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTDATEToolStripMenuItem.Name = "cURRENTDATEToolStripMenuItem";
            this.cURRENTDATEToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTDATEToolStripMenuItem.Text = "CURRENT_DATE";
            this.cURRENTDATEToolStripMenuItem.ToolTipText = "The day of the month";
            this.cURRENTDATEToolStripMenuItem.Click += new System.EventHandler(this.cURRENTDATEToolStripMenuItem_Click);
            // 
            // cURRENTDAYNAMEToolStripMenuItem
            // 
            this.cURRENTDAYNAMEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTDAYNAMEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTDAYNAMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTDAYNAMEToolStripMenuItem.Name = "cURRENTDAYNAMEToolStripMenuItem";
            this.cURRENTDAYNAMEToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTDAYNAMEToolStripMenuItem.Text = "CURRENT_DAY_NAME";
            this.cURRENTDAYNAMEToolStripMenuItem.ToolTipText = "The name of day (example \'Monday\')";
            this.cURRENTDAYNAMEToolStripMenuItem.Click += new System.EventHandler(this.cURRENTDAYNAMEToolStripMenuItem_Click);
            // 
            // cURRENTDAYNAMESHORTToolStripMenuItem
            // 
            this.cURRENTDAYNAMESHORTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTDAYNAMESHORTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTDAYNAMESHORTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTDAYNAMESHORTToolStripMenuItem.Name = "cURRENTDAYNAMESHORTToolStripMenuItem";
            this.cURRENTDAYNAMESHORTToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTDAYNAMESHORTToolStripMenuItem.Text = "CURRENT_DAY_NAME_SHORT";
            this.cURRENTDAYNAMESHORTToolStripMenuItem.ToolTipText = "The short name of the day (example \'Mon\')";
            this.cURRENTDAYNAMESHORTToolStripMenuItem.Click += new System.EventHandler(this.cURRENTDAYNAMESHORTToolStripMenuItem_Click);
            // 
            // cURRENTHOURToolStripMenuItem
            // 
            this.cURRENTHOURToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTHOURToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTHOURToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTHOURToolStripMenuItem.Name = "cURRENTHOURToolStripMenuItem";
            this.cURRENTHOURToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTHOURToolStripMenuItem.Text = "CURRENT_HOUR";
            this.cURRENTHOURToolStripMenuItem.ToolTipText = "The current hour in 24-hour clock format";
            this.cURRENTHOURToolStripMenuItem.Click += new System.EventHandler(this.cURRENTHOURToolStripMenuItem_Click);
            // 
            // cURRENTMINUTEToolStripMenuItem
            // 
            this.cURRENTMINUTEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTMINUTEToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTMINUTEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTMINUTEToolStripMenuItem.Name = "cURRENTMINUTEToolStripMenuItem";
            this.cURRENTMINUTEToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTMINUTEToolStripMenuItem.Text = "CURRENT_MINUTE";
            this.cURRENTMINUTEToolStripMenuItem.ToolTipText = "The current minute";
            this.cURRENTMINUTEToolStripMenuItem.Click += new System.EventHandler(this.cURRENTMINUTEToolStripMenuItem_Click);
            // 
            // cURRENTSECONDToolStripMenuItem
            // 
            this.cURRENTSECONDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cURRENTSECONDToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.cURRENTSECONDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cURRENTSECONDToolStripMenuItem.Name = "cURRENTSECONDToolStripMenuItem";
            this.cURRENTSECONDToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
            this.cURRENTSECONDToolStripMenuItem.Text = "CURRENT_SECOND";
            this.cURRENTSECONDToolStripMenuItem.ToolTipText = "The current second";
            this.cURRENTSECONDToolStripMenuItem.Click += new System.EventHandler(this.cURRENTSECONDToolStripMenuItem_Click);
            // 
            // BlockCommentToolStripMenuItem
            // 
            this.BlockCommentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.BlockCommentToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.BlockCommentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bLOCKCOMMENTSTARTToolStripMenuItem,
            this.bLOCKCOMMENTENDToolStripMenuItem,
            this.lINECOMMENTToolStripMenuItem});
            this.BlockCommentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.BlockCommentToolStripMenuItem.Name = "BlockCommentToolStripMenuItem";
            this.BlockCommentToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.BlockCommentToolStripMenuItem.Text = "Block Comment";
            // 
            // bLOCKCOMMENTSTARTToolStripMenuItem
            // 
            this.bLOCKCOMMENTSTARTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bLOCKCOMMENTSTARTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bLOCKCOMMENTSTARTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bLOCKCOMMENTSTARTToolStripMenuItem.Name = "bLOCKCOMMENTSTARTToolStripMenuItem";
            this.bLOCKCOMMENTSTARTToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.bLOCKCOMMENTSTARTToolStripMenuItem.Text = "BLOCK_COMMENT_START";
            this.bLOCKCOMMENTSTARTToolStripMenuItem.ToolTipText = "Example output: in PHP /* or in HTML <!--";
            this.bLOCKCOMMENTSTARTToolStripMenuItem.Click += new System.EventHandler(this.bLOCKCOMMENTSTARTToolStripMenuItem_Click);
            // 
            // bLOCKCOMMENTENDToolStripMenuItem
            // 
            this.bLOCKCOMMENTENDToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.bLOCKCOMMENTENDToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.bLOCKCOMMENTENDToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.bLOCKCOMMENTENDToolStripMenuItem.Name = "bLOCKCOMMENTENDToolStripMenuItem";
            this.bLOCKCOMMENTENDToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.bLOCKCOMMENTENDToolStripMenuItem.Text = "BLOCK_COMMENT_END";
            this.bLOCKCOMMENTENDToolStripMenuItem.ToolTipText = "Example output: in PHP */ or in HTML -->";
            this.bLOCKCOMMENTENDToolStripMenuItem.Click += new System.EventHandler(this.bLOCKCOMMENTENDToolStripMenuItem_Click);
            // 
            // lINECOMMENTToolStripMenuItem
            // 
            this.lINECOMMENTToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.lINECOMMENTToolStripMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.lINECOMMENTToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.lINECOMMENTToolStripMenuItem.Name = "lINECOMMENTToolStripMenuItem";
            this.lINECOMMENTToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.lINECOMMENTToolStripMenuItem.Text = "LINE_COMMENT";
            this.lINECOMMENTToolStripMenuItem.ToolTipText = "Example output: in PHP // or in HTML <!-- -->";
            this.lINECOMMENTToolStripMenuItem.Click += new System.EventHandler(this.lINECOMMENTToolStripMenuItem_Click);
            // 
            // defineAVariableToolStripMenuItem
            // 
            this.defineAVariableToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.defineAVariableToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.defineAVariableToolStripMenuItem.Name = "defineAVariableToolStripMenuItem";
            this.defineAVariableToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.defineAVariableToolStripMenuItem.Text = "Define a Variable...";
            this.defineAVariableToolStripMenuItem.Click += new System.EventHandler(this.defineAVariableToolStripMenuItem_Click);
            // 
            // extensibleInput
            // 
            this.extensibleInput.Border = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.extensibleInput.Controls.Add(this.zoomLabel);
            this.extensibleInput.Controls.Add(this.inputCode);
            this.extensibleInput.Location = new System.Drawing.Point(15, 174);
            this.extensibleInput.Name = "extensibleInput";
            this.extensibleInput.Size = new System.Drawing.Size(465, 513);
            this.extensibleInput.TabIndex = 25;
            this.extensibleInput.Text = "extensiblePanel1";
            this.extensibleInput.MouseLeave += new System.EventHandler(this.extensibleInput_MouseLeave);
            this.extensibleInput.MouseHover += new System.EventHandler(this.extensibleInput_MouseHover);
            // 
            // zoomLabel
            // 
            this.zoomLabel.AutoSize = true;
            this.zoomLabel.Font = new System.Drawing.Font("Comic Sans MS", 13F);
            this.zoomLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.zoomLabel.Location = new System.Drawing.Point(357, 7);
            this.zoomLabel.Name = "zoomLabel";
            this.zoomLabel.Size = new System.Drawing.Size(69, 24);
            this.zoomLabel.TabIndex = 1;
            this.zoomLabel.Text = "6300%";
            this.zoomLabel.Visible = false;
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
            this.inputCode.Size = new System.Drawing.Size(459, 507);
            this.inputCode.TabIndex = 0;
            this.inputCode.Text = "INPUT\n\nCODE \n\nYOU \n\nINTEND \n\nTO \n\nCONVERT\n\nHERE\n\nENJOY!!!\n\nENJOY!!!\n\nENJOY!!!\n\nEN" +
    "JOY!!!\n\nENJOY!!!\n\nENJOY!!!\n\nENJOY!!!";
            this.inputCode.Click += new System.EventHandler(this.inputCode_Click);
            this.inputCode.TextChanged += new System.EventHandler(this.inputCode_TextChanged);
            this.inputCode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.inputCode_KeyDown);
            this.inputCode.MouseEnter += new System.EventHandler(this.inputCode_MouseEnter);
            this.inputCode.MouseLeave += new System.EventHandler(this.inputCode_MouseLeave);
            // 
            // inputContextMenuStrip
            // 
            this.inputContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.inputContextMenuStrip.Font = new System.Drawing.Font("Verdana", 8F);
            this.inputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pasteInsertionToolStripMenuItem,
            this.replace,
            this.selectAll,
            this.clear,
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.inputContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.inputContextMenuStrip.Name = "contextMenuStrip1";
            this.inputContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.inputContextMenuStrip.ShowImageMargin = false;
            this.inputContextMenuStrip.Size = new System.Drawing.Size(193, 158);
            // 
            // pasteInsertionToolStripMenuItem
            // 
            this.pasteInsertionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pasteInsertionToolStripMenuItem.Name = "pasteInsertionToolStripMenuItem";
            this.pasteInsertionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.pasteInsertionToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pasteInsertionToolStripMenuItem.Text = "Paste ";
            this.pasteInsertionToolStripMenuItem.Click += new System.EventHandler(this.pasteInsertionToolStripMenuItem_Click);
            // 
            // replace
            // 
            this.replace.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.replace.Font = new System.Drawing.Font("Verdana", 8F);
            this.replace.ForeColor = System.Drawing.Color.White;
            this.replace.Name = "replace";
            this.replace.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
            this.replace.Size = new System.Drawing.Size(192, 22);
            this.replace.Text = "Replace All";
            this.replace.Click += new System.EventHandler(this.paste_Click);
            // 
            // selectAll
            // 
            this.selectAll.ForeColor = System.Drawing.Color.White;
            this.selectAll.Name = "selectAll";
            this.selectAll.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAll.Size = new System.Drawing.Size(192, 22);
            this.selectAll.Text = "Select All";
            this.selectAll.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // clear
            // 
            this.clear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.clear.Font = new System.Drawing.Font("Verdana", 8F);
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.Name = "clear";
            this.clear.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
            this.clear.Size = new System.Drawing.Size(192, 22);
            this.clear.Text = "Clear";
            this.clear.ToolTipText = "Clears the text area";
            this.clear.Click += new System.EventHandler(this.clear_Click);
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.undoToolStripMenuItem.Text = "Undo";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.undoToolStripMenuItem_Click);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.redoToolStripMenuItem.Text = "Redo";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.redoToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.zoomToolStripMenuItem.Text = "Zoom";
            this.zoomToolStripMenuItem.Click += new System.EventHandler(this.zoomToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(416, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 14);
            this.label3.TabIndex = 24;
            this.label3.Text = "Snippet Prefix";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 9F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(12, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 14);
            this.label2.TabIndex = 23;
            this.label2.Text = "Snippet Description";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 9F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 14);
            this.label1.TabIndex = 22;
            this.label1.Text = "Snippet Name";
            // 
            // snippetPrefix
            // 
            this.snippetPrefix.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetPrefix.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetPrefix.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetPrefix.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetPrefix.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetPrefix.ForeColor = System.Drawing.Color.White;
            this.snippetPrefix.IsEnabled = true;
            this.snippetPrefix.Location = new System.Drawing.Point(521, 27);
            this.snippetPrefix.MaxLength = 32767;
            this.snippetPrefix.Multiline = false;
            this.snippetPrefix.Name = "snippetPrefix";
            this.snippetPrefix.PasswordChar = '\0';
            this.snippetPrefix.Placeholder = true;
            this.snippetPrefix.PlaceHolderText = "eg. php-connect";
            this.snippetPrefix.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetPrefix.ReadOnly = false;
            this.snippetPrefix.Size = new System.Drawing.Size(130, 24);
            this.snippetPrefix.TabIndex = 21;
            this.snippetPrefix.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetPrefix.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetPrefix.UseSystemPasswordChar = false;
            this.snippetPrefix.WordWrap = true;
            this.snippetPrefix.TextChanged += new System.EventHandler(this.snippetPrefix_TextChanged);
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
            this.snippetDescription.Location = new System.Drawing.Point(182, 63);
            this.snippetDescription.MaxLength = 32767;
            this.snippetDescription.Multiline = false;
            this.snippetDescription.Name = "snippetDescription";
            this.snippetDescription.PasswordChar = '\0';
            this.snippetDescription.Placeholder = true;
            this.snippetDescription.PlaceHolderText = "eg. This is a php connection";
            this.snippetDescription.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetDescription.ReadOnly = false;
            this.snippetDescription.Size = new System.Drawing.Size(199, 24);
            this.snippetDescription.TabIndex = 20;
            this.snippetDescription.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetDescription.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetDescription.UseSystemPasswordChar = false;
            this.snippetDescription.WordWrap = true;
            this.snippetDescription.TextChanged += new System.EventHandler(this.snippetDescription_TextChanged);
            // 
            // snippetName
            // 
            this.snippetName.DisabledStringColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(187)))), ((int)(((byte)(189)))));
            this.snippetName.DisabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(236)))), ((int)(((byte)(238)))));
            this.snippetName.EnabledUnFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(219)))), ((int)(((byte)(219)))));
            this.snippetName.FocusedColor = System.Drawing.Color.Cyan;
            this.snippetName.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.snippetName.ForeColor = System.Drawing.Color.White;
            this.snippetName.IsEnabled = true;
            this.snippetName.Location = new System.Drawing.Point(182, 27);
            this.snippetName.MaxLength = 32767;
            this.snippetName.Multiline = false;
            this.snippetName.Name = "snippetName";
            this.snippetName.PasswordChar = '\0';
            this.snippetName.Placeholder = true;
            this.snippetName.PlaceHolderText = "eg. PHP Database Connect";
            this.snippetName.PlaceHolderTextColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(153)))), ((int)(((byte)(153)))));
            this.snippetName.ReadOnly = false;
            this.snippetName.Size = new System.Drawing.Size(199, 24);
            this.snippetName.TabIndex = 19;
            this.snippetName.TextAlignment = System.Windows.Forms.HorizontalAlignment.Left;
            this.snippetName.TextBackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.snippetName.UseSystemPasswordChar = false;
            this.snippetName.WordWrap = true;
            this.snippetName.TextChanged += new System.EventHandler(this.snippetName_TextChanged);
            // 
            // openFile
            // 
            this.openFile.FileName = "openFileDialog1";
            // 
            // error
            // 
            this.error.BlinkRate = 500;
            this.error.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.AlwaysBlink;
            this.error.ContainerControl = this;
            this.error.Icon = ((System.Drawing.Icon)(resources.GetObject("error.Icon")));
            // 
            // AtomOutputContextMenuStrip
            // 
            this.AtomOutputContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.AtomOutputContextMenuStrip.Font = new System.Drawing.Font("Verdana", 8F);
            this.AtomOutputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripMenuItem3});
            this.AtomOutputContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.AtomOutputContextMenuStrip.Name = "contextMenuStrip1";
            this.AtomOutputContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.AtomOutputContextMenuStrip.ShowImageMargin = false;
            this.AtomOutputContextMenuStrip.Size = new System.Drawing.Size(138, 48);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem2.Font = new System.Drawing.Font("Verdana", 8F);
            this.toolStripMenuItem2.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem2.Text = "Copy";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.toolStripMenuItem3.Size = new System.Drawing.Size(137, 22);
            this.toolStripMenuItem3.Text = "Append";
            // 
            // SublimeOutputContextMenuStrip
            // 
            this.SublimeOutputContextMenuStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.SublimeOutputContextMenuStrip.Font = new System.Drawing.Font("Verdana", 8F);
            this.SublimeOutputContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem4});
            this.SublimeOutputContextMenuStrip.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.SublimeOutputContextMenuStrip.Name = "contextMenuStrip1";
            this.SublimeOutputContextMenuStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.SublimeOutputContextMenuStrip.ShowImageMargin = false;
            this.SublimeOutputContextMenuStrip.Size = new System.Drawing.Size(126, 48);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripMenuItem1.Font = new System.Drawing.Font("Verdana", 8F);
            this.toolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.toolStripMenuItem1.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem1.Text = "Copy";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.placeholderToolStripMenuItem,
            this.cDATAToolStripMenuItem,
            this.commentToolStripMenuItem,
            this.loremIpsumToolStripMenuItem,
            this.longTagToolStripMenuItem,
            this.shortTagToolStripMenuItem,
            this.xMLProcessingInstructionToolStripMenuItem,
            this.usrbindevToolStripMenuItem,
            this.envrionmentVariablesToolStripMenuItem,
            this.substitutionToolStripMenuItem});
            this.toolStripMenuItem4.ForeColor = System.Drawing.Color.White;
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(125, 22);
            this.toolStripMenuItem4.Text = "Insert";
            // 
            // placeholderToolStripMenuItem
            // 
            this.placeholderToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.placeholderToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.placeholderToolStripMenuItem.Name = "placeholderToolStripMenuItem";
            this.placeholderToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.placeholderToolStripMenuItem.Text = "Placeholder";
            this.placeholderToolStripMenuItem.Click += new System.EventHandler(this.placeholderToolStripMenuItem_Click);
            // 
            // cDATAToolStripMenuItem
            // 
            this.cDATAToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.cDATAToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.cDATAToolStripMenuItem.Name = "cDATAToolStripMenuItem";
            this.cDATAToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.cDATAToolStripMenuItem.Text = "CDATA";
            this.cDATAToolStripMenuItem.Click += new System.EventHandler(this.cDATAToolStripMenuItem_Click);
            // 
            // commentToolStripMenuItem
            // 
            this.commentToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.commentToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.commentToolStripMenuItem.Name = "commentToolStripMenuItem";
            this.commentToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.commentToolStripMenuItem.Text = "Comment";
            this.commentToolStripMenuItem.Click += new System.EventHandler(this.commentToolStripMenuItem_Click);
            // 
            // loremIpsumToolStripMenuItem
            // 
            this.loremIpsumToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.loremIpsumToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.loremIpsumToolStripMenuItem.Name = "loremIpsumToolStripMenuItem";
            this.loremIpsumToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.loremIpsumToolStripMenuItem.Text = "Lorem Ipsum";
            this.loremIpsumToolStripMenuItem.Click += new System.EventHandler(this.loremIpsumToolStripMenuItem_Click);
            // 
            // longTagToolStripMenuItem
            // 
            this.longTagToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.longTagToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.longTagToolStripMenuItem.Name = "longTagToolStripMenuItem";
            this.longTagToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.longTagToolStripMenuItem.Text = "Long Tag";
            this.longTagToolStripMenuItem.Click += new System.EventHandler(this.longTagToolStripMenuItem_Click);
            // 
            // shortTagToolStripMenuItem
            // 
            this.shortTagToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.shortTagToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.shortTagToolStripMenuItem.Name = "shortTagToolStripMenuItem";
            this.shortTagToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.shortTagToolStripMenuItem.Text = "Short Tag";
            this.shortTagToolStripMenuItem.Click += new System.EventHandler(this.shortTagToolStripMenuItem_Click);
            // 
            // xMLProcessingInstructionToolStripMenuItem
            // 
            this.xMLProcessingInstructionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.xMLProcessingInstructionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.xMLProcessingInstructionToolStripMenuItem.Name = "xMLProcessingInstructionToolStripMenuItem";
            this.xMLProcessingInstructionToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.xMLProcessingInstructionToolStripMenuItem.Text = "XML Processing Instruction";
            this.xMLProcessingInstructionToolStripMenuItem.Click += new System.EventHandler(this.xMLProcessingInstructionToolStripMenuItem_Click);
            // 
            // usrbindevToolStripMenuItem
            // 
            this.usrbindevToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.usrbindevToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.usrbindevToolStripMenuItem.Name = "usrbindevToolStripMenuItem";
            this.usrbindevToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.usrbindevToolStripMenuItem.Text = "#!/usr/bin/dev";
            this.usrbindevToolStripMenuItem.Click += new System.EventHandler(this.usrbindevToolStripMenuItem_Click);
            // 
            // envrionmentVariablesToolStripMenuItem
            // 
            this.envrionmentVariablesToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.envrionmentVariablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pARAMPARAMnToolStripMenuItem,
            this.sELCTIONToolStripMenuItem,
            this.tMCURRENTLINEToolStripMenuItem1,
            this.tMCURRENTWORDToolStripMenuItem1,
            this.tMDIRECTORYToolStripMenuItem1,
            this.tMFILENAMEToolStripMenuItem1,
            this.tMFILEPATHToolStripMenuItem1,
            this.tMFULLNAMEToolStripMenuItem,
            this.tMLINEINDEXToolStripMenuItem1,
            this.tMLINENUMBERToolStripMenuItem1,
            this.tMSELECTEDTEXTToolStripMenuItem1,
            this.tMSCOPEToolStripMenuItem,
            this.tMSOFTTABSToolStripMenuItem,
            this.tMTABSIZEToolStripMenuItem});
            this.envrionmentVariablesToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.envrionmentVariablesToolStripMenuItem.Name = "envrionmentVariablesToolStripMenuItem";
            this.envrionmentVariablesToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.envrionmentVariablesToolStripMenuItem.Text = "Envrionment Variables";
            // 
            // pARAMPARAMnToolStripMenuItem
            // 
            this.pARAMPARAMnToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pARAMPARAMnToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.pARAMPARAMnToolStripMenuItem.Name = "pARAMPARAMnToolStripMenuItem";
            this.pARAMPARAMnToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.pARAMPARAMnToolStripMenuItem.Text = "$PARAM..$PARAMn";
            this.pARAMPARAMnToolStripMenuItem.Click += new System.EventHandler(this.pARAMPARAMnToolStripMenuItem_Click);
            // 
            // sELCTIONToolStripMenuItem
            // 
            this.sELCTIONToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.sELCTIONToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.sELCTIONToolStripMenuItem.Name = "sELCTIONToolStripMenuItem";
            this.sELCTIONToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.sELCTIONToolStripMenuItem.Text = "$SELCTION";
            this.sELCTIONToolStripMenuItem.Click += new System.EventHandler(this.sELCTIONToolStripMenuItem_Click);
            // 
            // tMCURRENTLINEToolStripMenuItem1
            // 
            this.tMCURRENTLINEToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMCURRENTLINEToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMCURRENTLINEToolStripMenuItem1.Name = "tMCURRENTLINEToolStripMenuItem1";
            this.tMCURRENTLINEToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMCURRENTLINEToolStripMenuItem1.Text = "$TM_CURRENT_LINE";
            this.tMCURRENTLINEToolStripMenuItem1.Click += new System.EventHandler(this.tMCURRENTLINEToolStripMenuItem1_Click);
            // 
            // tMCURRENTWORDToolStripMenuItem1
            // 
            this.tMCURRENTWORDToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMCURRENTWORDToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMCURRENTWORDToolStripMenuItem1.Name = "tMCURRENTWORDToolStripMenuItem1";
            this.tMCURRENTWORDToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMCURRENTWORDToolStripMenuItem1.Text = "$TM_CURRENT_WORD";
            this.tMCURRENTWORDToolStripMenuItem1.Click += new System.EventHandler(this.tMCURRENTWORDToolStripMenuItem1_Click);
            // 
            // tMDIRECTORYToolStripMenuItem1
            // 
            this.tMDIRECTORYToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMDIRECTORYToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMDIRECTORYToolStripMenuItem1.Name = "tMDIRECTORYToolStripMenuItem1";
            this.tMDIRECTORYToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMDIRECTORYToolStripMenuItem1.Text = "$TM_DIRECTORY";
            this.tMDIRECTORYToolStripMenuItem1.Click += new System.EventHandler(this.tMDIRECTORYToolStripMenuItem1_Click);
            // 
            // tMFILENAMEToolStripMenuItem1
            // 
            this.tMFILENAMEToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMFILENAMEToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMFILENAMEToolStripMenuItem1.Name = "tMFILENAMEToolStripMenuItem1";
            this.tMFILENAMEToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMFILENAMEToolStripMenuItem1.Text = "$TM_FILENAME";
            this.tMFILENAMEToolStripMenuItem1.Click += new System.EventHandler(this.tMFILENAMEToolStripMenuItem1_Click);
            // 
            // tMFILEPATHToolStripMenuItem1
            // 
            this.tMFILEPATHToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMFILEPATHToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMFILEPATHToolStripMenuItem1.Name = "tMFILEPATHToolStripMenuItem1";
            this.tMFILEPATHToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMFILEPATHToolStripMenuItem1.Text = "$TM_FILEPATH";
            this.tMFILEPATHToolStripMenuItem1.Click += new System.EventHandler(this.tMFILEPATHToolStripMenuItem1_Click);
            // 
            // tMFULLNAMEToolStripMenuItem
            // 
            this.tMFULLNAMEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMFULLNAMEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMFULLNAMEToolStripMenuItem.Name = "tMFULLNAMEToolStripMenuItem";
            this.tMFULLNAMEToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tMFULLNAMEToolStripMenuItem.Text = "$TM_FULLNAME";
            this.tMFULLNAMEToolStripMenuItem.Click += new System.EventHandler(this.tMFULLNAMEToolStripMenuItem_Click);
            // 
            // tMLINEINDEXToolStripMenuItem1
            // 
            this.tMLINEINDEXToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMLINEINDEXToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMLINEINDEXToolStripMenuItem1.Name = "tMLINEINDEXToolStripMenuItem1";
            this.tMLINEINDEXToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMLINEINDEXToolStripMenuItem1.Text = "$TM_LINE_INDEX";
            this.tMLINEINDEXToolStripMenuItem1.Click += new System.EventHandler(this.tMLINEINDEXToolStripMenuItem1_Click);
            // 
            // tMLINENUMBERToolStripMenuItem1
            // 
            this.tMLINENUMBERToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMLINENUMBERToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMLINENUMBERToolStripMenuItem1.Name = "tMLINENUMBERToolStripMenuItem1";
            this.tMLINENUMBERToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMLINENUMBERToolStripMenuItem1.Text = "$TM_LINE_NUMBER";
            this.tMLINENUMBERToolStripMenuItem1.Click += new System.EventHandler(this.tMLINENUMBERToolStripMenuItem1_Click);
            // 
            // tMSELECTEDTEXTToolStripMenuItem1
            // 
            this.tMSELECTEDTEXTToolStripMenuItem1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMSELECTEDTEXTToolStripMenuItem1.ForeColor = System.Drawing.Color.White;
            this.tMSELECTEDTEXTToolStripMenuItem1.Name = "tMSELECTEDTEXTToolStripMenuItem1";
            this.tMSELECTEDTEXTToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.tMSELECTEDTEXTToolStripMenuItem1.Text = "$TM_SELECTED_TEXT";
            this.tMSELECTEDTEXTToolStripMenuItem1.Click += new System.EventHandler(this.tMSELECTEDTEXTToolStripMenuItem1_Click);
            // 
            // tMSCOPEToolStripMenuItem
            // 
            this.tMSCOPEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMSCOPEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMSCOPEToolStripMenuItem.Name = "tMSCOPEToolStripMenuItem";
            this.tMSCOPEToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tMSCOPEToolStripMenuItem.Text = "$TM_SCOPE";
            this.tMSCOPEToolStripMenuItem.Click += new System.EventHandler(this.tMSCOPEToolStripMenuItem_Click);
            // 
            // tMSOFTTABSToolStripMenuItem
            // 
            this.tMSOFTTABSToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMSOFTTABSToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMSOFTTABSToolStripMenuItem.Name = "tMSOFTTABSToolStripMenuItem";
            this.tMSOFTTABSToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tMSOFTTABSToolStripMenuItem.Text = "$TM_SOFT_TABS";
            this.tMSOFTTABSToolStripMenuItem.Click += new System.EventHandler(this.tMSOFTTABSToolStripMenuItem_Click);
            // 
            // tMTABSIZEToolStripMenuItem
            // 
            this.tMTABSIZEToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.tMTABSIZEToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.tMTABSIZEToolStripMenuItem.Name = "tMTABSIZEToolStripMenuItem";
            this.tMTABSIZEToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.tMTABSIZEToolStripMenuItem.Text = "$TM_TAB_SIZE";
            this.tMTABSIZEToolStripMenuItem.Click += new System.EventHandler(this.tMTABSIZEToolStripMenuItem_Click);
            // 
            // substitutionToolStripMenuItem
            // 
            this.substitutionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.substitutionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.withOptionToolStripMenuItem,
            this.withoutOptionToolStripMenuItem});
            this.substitutionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.substitutionToolStripMenuItem.Name = "substitutionToolStripMenuItem";
            this.substitutionToolStripMenuItem.Size = new System.Drawing.Size(227, 22);
            this.substitutionToolStripMenuItem.Text = "Substitution";
            // 
            // withOptionToolStripMenuItem
            // 
            this.withOptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.withOptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.withOptionToolStripMenuItem.Name = "withOptionToolStripMenuItem";
            this.withOptionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.withOptionToolStripMenuItem.Text = "With Option";
            this.withOptionToolStripMenuItem.Click += new System.EventHandler(this.withOptionToolStripMenuItem_Click);
            // 
            // withoutOptionToolStripMenuItem
            // 
            this.withoutOptionToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.withoutOptionToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.withoutOptionToolStripMenuItem.Name = "withoutOptionToolStripMenuItem";
            this.withoutOptionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.withoutOptionToolStripMenuItem.Text = "Without Option";
            this.withoutOptionToolStripMenuItem.Click += new System.EventHandler(this.withoutOptionToolStripMenuItem_Click);
            // 
            // zeroitSplashScreen1
            // 
            this.zeroitSplashScreen1.AllowDragging = true;
            this.zeroitSplashScreen1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.zeroitSplashScreen1.BottomText = "Community edition";
            this.zeroitSplashScreen1.BottomTextColor = System.Drawing.Color.White;
            this.zeroitSplashScreen1.BottomTextSize = 16;
            this.zeroitSplashScreen1.EllipseCornerRadius = 10;
            this.zeroitSplashScreen1.IsEllipse = false;
            this.zeroitSplashScreen1.LoadedColor = System.Drawing.Color.DodgerBlue;
            this.zeroitSplashScreen1.ProgressBarStyle = Zeroit.Framework.SnippetEditors.Helpers.ZeroitFlatProgressBar.Style.Material;
            this.zeroitSplashScreen1.SecondsDisplayed = 3000;
            this.zeroitSplashScreen1.ShowProgressBar = true;
            this.zeroitSplashScreen1.SplashSize = new System.Drawing.Size(450, 280);
            this.zeroitSplashScreen1.TopText = "VisualStudio";
            this.zeroitSplashScreen1.TopTextColor = System.Drawing.Color.White;
            this.zeroitSplashScreen1.TopTextSize = 36;
            this.zeroitSplashScreen1.UnloadedColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            // 
            // SnippetEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(966, 750);
            this.Controls.Add(this.baseTheme2);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SnippetEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = " ";
            this.TransparencyKey = System.Drawing.Color.Fuchsia;
            this.Load += new System.EventHandler(this.SnippetEditor_Load);
            this.baseTheme2.ResumeLayout(false);
            this.baseTheme2.PerformLayout();
            this.extensibleOutput.ResumeLayout(false);
            this.extensibleOutput.PerformLayout();
            this.choicePanel.ResumeLayout(false);
            this.choicePanel.PerformLayout();
            this.VSCodeOutputContextMenuStrip.ResumeLayout(false);
            this.extensibleInput.ResumeLayout(false);
            this.extensibleInput.PerformLayout();
            this.inputContextMenuStrip.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.AtomOutputContextMenuStrip.ResumeLayout(false);
            this.SublimeOutputContextMenuStrip.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private BaseTheme baseTheme2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private ZeroitUltraTextBox snippetPrefix;
        private ZeroitUltraTextBox snippetDescription;
        private ZeroitUltraTextBox snippetName;
        private ExtensiblePanel extensibleOutput;
        private System.Windows.Forms.TextBox outputCode;
        private ExtensiblePanel extensibleInput;
        private System.Windows.Forms.RichTextBox inputCode;
        private ZeroitHorizontalTab tab;
        private System.Windows.Forms.Label scopeText;
        private ZeroitUltraTextBox snippetScope;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label escapeCharsLabel;
        private System.Windows.Forms.CheckBox escapeChars;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox automaticDiscovery;
        private System.Windows.Forms.Label snippetFileLabel;
        private ZeroitUltraTextBox pathTxtBox;
        private System.Windows.Forms.Button openFileBtn;
        private System.Windows.Forms.OpenFileDialog openFile;
        private System.Windows.Forms.CheckBox warnAppendCheckBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ContextMenuStrip inputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem replace;
        private System.Windows.Forms.ToolStripMenuItem clear;
        private System.Windows.Forms.ContextMenuStrip VSCodeOutputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem outputCopyCtxtMenu;
        private System.Windows.Forms.ToolStripMenuItem outputAppendCtxtMenu;
        private System.Windows.Forms.Label langIdLabel;
        private ZeroitUltraTextBox languageIdTextBox;
        private System.Windows.Forms.ComboBox languageIdCombo;
        private System.Windows.Forms.Button addLangIdBtn;
        private System.Windows.Forms.Label identifierLabel;
        private System.Windows.Forms.Label languageLabel;
        private ZeroitUltraTextBox languageTextBox;
        private System.Windows.Forms.CheckBox globalSnippCheckBox;
        private System.Windows.Forms.Label globalSnippLabel;
        private System.Windows.Forms.ToolStripMenuItem Insert;
        private System.Windows.Forms.ToolStripMenuItem TabStop;
        private System.Windows.Forms.ToolStripMenuItem PlaceholderStripMenu;
        private System.Windows.Forms.ToolStripMenuItem ChoiceStripMenu;
        private System.Windows.Forms.ToolStripMenuItem VariableStripMenu;
        private System.Windows.Forms.ToolStripMenuItem GeneralToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMSELECTEDTEXTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMCURRENTLINEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMCURRENTWORDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMLINEINDEXToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMLINENUMBERToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMFILENAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMFILENAMEBASEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMDIRECTORYToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMFILEPATHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cLIPBOARDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wORKSPACENAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem DateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTYEARToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTYEARSHORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTMONTHToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTMONTHNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTMONTHNAMESHORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTDATEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTDAYNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTDAYNAMESHORTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTHOURToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTMINUTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cURRENTSECONDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem BlockCommentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOCKCOMMENTSTARTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bLOCKCOMMENTENDToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lINECOMMENTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nestedToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defineAVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteInsertionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAll;
        private TransparentText minimizeBtn;
        private TransparentText closeBtn;
        private System.Windows.Forms.ToolStripMenuItem undoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.Label zoomLabel;
        private System.Windows.Forms.Button soundBtn;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lastAppendedLabel;
        private System.Windows.Forms.ErrorProvider error;
        private Helpers.Button.ZeroitLollipopClickButton resetBtn;
        private Helpers.Button.ZeroitLollipopClickButton pasteTextBtn;
        private Helpers.Button.ZeroitLollipopClickButton copyCode;
        private Helpers.Button.ZeroitLollipopClickButton appendCode;
        private System.Windows.Forms.Panel choicePanel;
        private System.Windows.Forms.TextBox choiceTextBox;
        private Helpers.Button.ZeroitLollipopClickButton choiceOKBtn;
        private System.Windows.Forms.ContextMenuStrip AtomOutputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ContextMenuStrip SublimeOutputContextMenuStrip;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem cDATAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem commentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loremIpsumToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem longTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem shortTagToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xMLProcessingInstructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usrbindevToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem placeholderToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem envrionmentVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pARAMPARAMnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sELCTIONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMCURRENTLINEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMCURRENTWORDToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMDIRECTORYToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMFILENAMEToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMFILEPATHToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMFULLNAMEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem substitutionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMLINEINDEXToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMLINENUMBERToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMSELECTEDTEXTToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tMSCOPEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMSOFTTABSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tMTABSIZEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withOptionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem withoutOptionToolStripMenuItem;
        private Components.ZeroitSplashScreen zeroitSplashScreen1;
    }
}