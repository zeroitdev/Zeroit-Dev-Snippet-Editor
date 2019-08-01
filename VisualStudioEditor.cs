using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using System.Media;

namespace Zeroit.Framework.SnippetEditors
{
    public partial class VisualStudioEditor : Form
    {

        List<string> langIdentifiersSymbols = new List<string>()
        {
            "",
            "abap",
            "bat",
            "bibtex",
            "clojure",
            "coffeescript",
            "c",
            "cpp",
            "csharp",
            "css",
            "diff",
            "dockerfile",
            "fsharp",
            "git-commit", // and git-rebase
            "go",
            "groovy",
            "handlebars",
            "html",
            "ini",
            "java",
            "javascript",
            "javascriptreact",
            "json",
            "jsonc",
            "latex",
            "less",
            "lua",
            "makefile",
            "markdown",
            "objective-c",
            "objective-cpp",
            "perl", // and perl6
            "php",
            "powershell",
            "jade",
            "python",
            "r",
            "razor",
            "ruby",
            "rust",
            "scss",
            "sass",
            "shaderlab",
            "shellscript",
            "sql",
            "swift",
            "typescript",
            "typescriptreact",
            "tex",
            "vb",
            "xml",
            "xsl",
            "yaml"
        };

        string languageIdentifier = String.Empty;

        CustomMessageBox customMessageBox = new CustomMessageBox();

        CustomMessageWarnAppend warn = new CustomMessageWarnAppend();

        bool enableSound = true;

        public VisualStudioEditor()
        {
            InitializeComponent();
                        
            openFile.InitialDirectory = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            pathTxtBox.Text = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments));

            languageIdCombo.SelectedIndex = 8;

            languageIdentifier = langIdentifiersSymbols[languageIdCombo.SelectedIndex];

            folderBrowser.RootFolder = Environment.SpecialFolder.MyComputer;
                        
        }

        
        private void WarningMessage(string Message, Color OKBtnColor, string Header = "Warning!!!", int MessageFont = 10, int Width = 508, int Height = 145, int ButtonLocationX = 205, int ButtonLocationY = 87)
        {
            Rectangle screenArea = Screen.PrimaryScreen.Bounds;

            warn.Location = new Point((screenArea.Width / 2) - (warn.Width / 2), (screenArea.Height / 2) - (warn.Height / 2));
            warn.Size = new Size(Width, Height);

            warn.saveSnippetBtn.Text = "OK";
            warn.saveSnippetBtn.Location = new Point(ButtonLocationX, ButtonLocationY);
            warn.saveSnippetBtn.BackColor = OKBtnColor;

            warn.cancelBtn.Visible = false;
            warn.cancelBtn.Text = "Cancel";



            warn.Message = Message;
            warn.messageLabel.Font = new Font("Verdana", MessageFont);
            warn.Header = Header;

            if (warn.ShowDialog() == DialogResult.OK)
            {

            }
        }

        private void PlaySuccessSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Success);

            if (enableSound)
            {
                soundPlayer.Play();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void inputCode_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();
        }

        

        private void VisualStudio()
        {
            List<string> emptyList = new List<string>();
            
            string newLine = "\n";

            for (int i = 0; i < inputCode.Lines.Length; i++)
            {

                if(escapeChars.Checked)
                {
                    emptyList.Add(
                    inputCode.Lines[i].ToString().Replace('"'.ToString(), string.Format("{0}{1}", @"\", '"')));

                }
                else
                {
                    emptyList.Add(inputCode.Lines[i].ToString());

                }


            }
                       
            List<string> secondEmptyList = new List<string>();
            secondEmptyList.Add("<?xml version=\"1.0\" encoding=\"utf-8\"?>");
            secondEmptyList.Add("<CodeSnippets xmlns=\"http://schemas.microsoft.com/VisualStudio/2005/CodeSnippet\" >");
            secondEmptyList.Add("\t" + "<CodeSnippet Format=\"1.0.0\">");
            secondEmptyList.Add("\t " + "<Header>");
            secondEmptyList.Add("\t  " + "<Title>" + snippetTitle.Text +"</Title>");
            secondEmptyList.Add("\t  " + "<Author>" + snippetAuthor.Text + "</Author>");
            secondEmptyList.Add("\t  " + "<Description>" + snippetDescription.Text + "</Description>");
            secondEmptyList.Add("\t  " + "<Shortcut>" + snippetShortcut.Text + "</Shortcut>");
            secondEmptyList.Add("\t " + "</Header>");
            
            secondEmptyList.Add("\t " + "<Snippet>");
            secondEmptyList.Add("\t  " + string.Format("<Code Language=\"{0}\">",/*snippetLanguage.Text*/ languageIdentifier));
            secondEmptyList.Add("\t   " + "<![CDATA[");

            for (int i = 0; i < emptyList.Count; i++)
            {

                secondEmptyList.Add("\t    " + emptyList[i].ToString());

            }

            secondEmptyList.Add("\t   " + "]]>");
            secondEmptyList.Add("\t  " + "</Code>");
            
            secondEmptyList.Add("\t  " + "<References>");

            #region Old but useful code
            //for(int i=0; i < assemblyCombo.Items.Count; i++)
            //{
            //    secondEmptyList.Add("\t   " + "<Reference>" + newLine);
            //    secondEmptyList.Add("\t    " + string.Format("<Assembly>{0}</Assembly>", assemblyCombo.Items[i].ToString()) + newLine);
            //    secondEmptyList.Add("\t   " + "</Reference>" + newLine);

            //} 
            #endregion

            foreach (string contained in assemblyCombo.Items)
            {
                secondEmptyList.Add("\t   " + "<Reference>");
                secondEmptyList.Add("\t    " + string.Format("<Assembly>{0}</Assembly>", contained));
                secondEmptyList.Add("\t   " + "</Reference>");

            }

            secondEmptyList.Add("\t  " + "</References>");

            secondEmptyList.Add("\t  " + "<Imports>");

            #region Old but useful code
            //for (int i = 0; i < assemblyCombo.Items.Count; i++)
            //{
            //    secondEmptyList.Add("\t   " + "<Import>" + newLine);
            //    secondEmptyList.Add("\t    " + string.Format("<Namespace>{0}</Namespace>", namespaceCombo.Items[i].ToString()) + newLine);
            //    secondEmptyList.Add("\t   " + "</Import>" + newLine);

            //} 
            #endregion

            foreach(string contained in namespaceCombo.Items)
            {
                secondEmptyList.Add("\t   " + "<Import>");
                secondEmptyList.Add("\t    " + string.Format("<Namespace>{0}</Namespace>", contained));
                secondEmptyList.Add("\t   " + "</Import>");

            }


            secondEmptyList.Add("\t  " + "</Imports>");

            secondEmptyList.Add("\t " + "</Snippet>");
            secondEmptyList.Add("\t" + "</CodeSnippet>");
            secondEmptyList.Add("</CodeSnippets>" + newLine);
                        
            outputCode.Lines = secondEmptyList.ToArray();
        }
                
        private void ConvertCode()
        {
            
            outputCode.Text = String.Empty;
            VisualStudio();
            
        }

        
        private void snippetName_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();

            if (snippetTitle.Text !=String.Empty)
            {
                error.Clear();
            }
            else
            {
                SetErrorNotification();
            }
            
        }

        private void snippetDescription_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();
        }

        private void snippetPrefix_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();
        }

        private void escapeChars_CheckedChanged(object sender, EventArgs e)
        {
            ConvertCode();
        }

        private void extensibleInput_MouseHover(object sender, EventArgs e)
        {
            extensibleInput.Border = Color.FromArgb(150, 142, 245);
        }

        private void extensibleInput_MouseLeave(object sender, EventArgs e)
        {
            extensibleInput.Border = Color.FromArgb(50, 128, 128, 128);
        }

        private void inputCode_MouseEnter(object sender, EventArgs e)
        {
            extensibleInput.Border = Color.FromArgb(150, 142, 245);
        }

        private void inputCode_MouseLeave(object sender, EventArgs e)
        {
            extensibleInput.Border = Color.FromArgb(50, 128, 128, 128);
        }

        private void outputCode_MouseHover(object sender, EventArgs e)
        {
            extensibleOutput.Border = Color.Cyan;
        }

        private void outputCode_MouseLeave(object sender, EventArgs e)
        {
            extensibleOutput.Border = Color.FromArgb(50, 128, 128, 128);
        }

        private void extensibleOutput_MouseEnter(object sender, EventArgs e)
        {
            extensibleOutput.Border = Color.Cyan;
        }

        private void extensibleOutput_MouseLeave(object sender, EventArgs e)
        {
            extensibleOutput.Border = Color.FromArgb(50, 128, 128, 128);
        }

        private void VisualStudioEditor_Load(object sender, EventArgs e)
        {
            animator.Activate();
            
        }

        private void snippetAuthor_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();

            
        }

        private void snippetShortcut_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();
        }

        private void snippetLanguage_TextChanged(object sender, EventArgs e)
        {
            ConvertCode();
        }

        private void assemblyAdd_Click(object sender, EventArgs e)
        {
            if(snippetAssembly.Text != String.Empty)
            {
                assemblyCombo.Items.Add(snippetAssembly.Text);
                assemblyCombo.SelectedIndex = assemblyCombo.Items.IndexOf(snippetAssembly.Text);
                ConvertCode();
            }
            
        }

        private void assemblyDelete_Click(object sender, EventArgs e)
        {
            assemblyCombo.Items.Remove(snippetAssembly.Text);
            Random rand = new Random();
            string empty = String.Empty;

            if (assemblyCombo.Items.Count > 0)
            {
                assemblyCombo.SelectedIndex = rand.Next(0, assemblyCombo.Items.Count);

            }
            else
            {
                assemblyCombo.Text = empty;
                snippetAssembly.Text = empty;
            }

            ConvertCode();
        }

        private void namespaceAdd_Click(object sender, EventArgs e)
        {
            if(snippetNamespace.Text !=String.Empty)
            {
                namespaceCombo.Items.Add(snippetNamespace.Text);
                namespaceCombo.SelectedIndex = namespaceCombo.Items.IndexOf(snippetNamespace.Text);
                ConvertCode();
            }
            
        }

        private void namespaceDelete_Click(object sender, EventArgs e)
        {
            namespaceCombo.Items.Remove(snippetNamespace.Text);
            Random rand = new Random();
            string empty = String.Empty;

            if (namespaceCombo.Items.Count > 0)
            {
                namespaceCombo.SelectedIndex = rand.Next(0, namespaceCombo.Items.Count);

            }
            else
            {
                namespaceCombo.Text = empty;
                snippetNamespace.Text = empty;
            }

            ConvertCode();
        }

        private void copyCode_Click(object sender, EventArgs e)
        {
            automaticDiscovery.Checked = false;
            CopyCode();
        }

        private void pasteText_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void CopyCode()
        {
            Clipboard.SetData(DataFormats.Text, (Object)outputCode.Text);
        }

        private void PasteText()
        {
            // Retrieves data 
            IDataObject iData = Clipboard.GetDataObject();

            // Is Data Text?
            if (iData.GetDataPresent(DataFormats.Text))
            {
                inputCode.Text = (String)iData.GetData(DataFormats.Text);
            }
            else
            {
                MessageBox.Show("Data not found");
            }
                        
        }

        private void ClearClipBoard()
        {
            Clipboard.Clear();
        }

        private void theme_MouseEnter(object sender, EventArgs e)
        {
            if (automaticDiscovery.Checked)
            {
                PasteText();
            }
        }

        
        private void btn_MouseHover(object sender, EventArgs e)
        {

        }

        private void btn_MouseLeave(object sender, EventArgs e)
        {

        }

        private void assemblyAdd_MouseHover(object sender, EventArgs e)
        {
            assemblyAdd.FlatAppearance.BorderSize = 1;
        }

        private void assemblyAdd_MouseLeave(object sender, EventArgs e)
        {
            assemblyAdd.FlatAppearance.BorderSize = 0;
        }

        private void assemblyDelete_MouseHover(object sender, EventArgs e)
        {
            assemblyDelete.FlatAppearance.BorderSize = 1;
        }

        private void assemblyDelete_MouseLeave(object sender, EventArgs e)
        {
            assemblyDelete.FlatAppearance.BorderSize = 0;
        }

        private void namespaceAdd_MouseHover(object sender, EventArgs e)
        {
            namespaceAdd.FlatAppearance.BorderSize = 1;
        }

        private void namespaceAdd_MouseLeave(object sender, EventArgs e)
        {
            namespaceAdd.FlatAppearance.BorderSize = 0;
        }

        private void namespaceDelete_MouseHover(object sender, EventArgs e)
        {
            namespaceDelete.FlatAppearance.BorderSize = 1;
        }

        private void namespaceDelete_MouseLeave(object sender, EventArgs e)
        {
            namespaceDelete.FlatAppearance.BorderSize = 0;
        }

        private void pasteText_MouseHover(object sender, EventArgs e)
        {
            pasteText.BorderColor = Color.Cyan;
        }

        private void pasteText_MouseLeave(object sender, EventArgs e)
        {
            pasteText.BorderColor = Color.FromArgb(20,20,20);
        }

        private void copyCode_MouseHover(object sender, EventArgs e)
        {
            copyCode.BorderColor = Color.Cyan;
        }

        private void copyCode_MouseLeave(object sender, EventArgs e)
        {
            copyCode.BorderColor = Color.FromArgb(20,20,20);
        }

        private void saveSnippetBtn_MouseHover(object sender, EventArgs e)
        {
            saveSnippetBtn.BorderColor = Color.Cyan;
        }

        private void saveSnippetBtn_MouseLeave(object sender, EventArgs e)
        {
            saveSnippetBtn.BorderColor = Color.FromArgb(20, 20, 20);
        }

        private void saveSnippetBtn_Click(object sender, EventArgs e)
        {
            SaveSnippet();

        }

        private void SaveSnippet()
        {
            if(snippetTitle.Text !=String.Empty)
            {
                if (File.Exists(string.Format(@"{0}\{1}.snippet", pathTxtBox.Text, snippetTitle.Text)))
                {
                    if (customMessageBox.ShowDialog() == DialogResult.OK)
                    {
                        switch (customMessageBox.WriteMethod)
                        {
                            case CustomMessageBox.Operation.Append:
                                File.AppendAllLines(string.Format(@"{0}\{1}.snippet", pathTxtBox.Text, snippetTitle.Text), outputCode.Lines.ToList<string>());
                                PlaySuccessSound();
                                WarningMessage("Successfully Appended File", Color.FromArgb(0, 122, 204));
                                break;
                            case CustomMessageBox.Operation.Overwrite:
                                File.WriteAllText(string.Format(@"{0}\{1}.snippet", pathTxtBox.Text, snippetTitle.Text), outputCode.Text);
                                PlaySuccessSound();
                                WarningMessage("Overwrite was successful", Color.FromArgb(0, 122, 204));
                                break;
                            default:
                                break;
                        }
                    }
                }
                else
                {
                    File.AppendAllLines(string.Format(@"{0}\{1}.snippet", pathTxtBox.Text, snippetTitle.Text), outputCode.Lines.ToList<string>());
                    PlaySuccessSound();
                    WarningMessage("Successfully Created File", Color.FromArgb(0, 122, 204));
                }
            }
            else
            {
                theme.ActiveControl = snippetTitle;
                SetErrorNotification();

                WarningMessage("Enter Snippet Title", Color.DarkOrange);

            }
        }

        private void SetErrorNotification()
        {
            error.SetError(snippetTitle, "Please provide a value");
        }

        private void paste_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputCode.Text = String.Empty;
        }

        private void outputCopyCtxtMenu_Click(object sender, EventArgs e)
        {
            CopyCode();
        }

        private void outputSaveCtxtMenu_Click(object sender, EventArgs e)
        {
            SaveSnippet();
        }

        
        private void openFileBtn_Click(object sender, EventArgs e)
        {
            //if (openFile.ShowDialog() == DialogResult.OK)
            //{
                
            //    pathTxtBox.Text = openFile.FileName;

            //}

            if(folderBrowser.ShowDialog() == DialogResult.OK)
            {
                pathTxtBox.Text = folderBrowser.SelectedPath;
            }

        }

        private void languageIdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIdentifier();
        }

        private void SelectedIdentifier()
        {
            switch (languageIdCombo.SelectedIndex)
            {
                case 0:
                    addLangIdBtn.Visible = true;
                    identifierLabel.Visible = true;
                    languageIdTextBox.Visible = true;
                    languageLabel.Visible = true;
                    languageTextBox.Visible = true;
                    ConvertCode();
                    break;
                default:
                    languageIdentifier = langIdentifiersSymbols[languageIdCombo.SelectedIndex];
                    addLangIdBtn.Visible = false;
                    identifierLabel.Visible = false;
                    languageIdTextBox.Visible = false;
                    languageLabel.Visible = false;
                    languageTextBox.Visible = false;
                    ConvertCode();
                    break;
            }
        }

        private void addLangIdBtn_Click(object sender, EventArgs e)
        {
            languageIdCombo.Items.Add(languageTextBox.Text);
            langIdentifiersSymbols.Add(languageIdTextBox.Text);

            addLangIdBtn.Visible = false;
            identifierLabel.Visible = false;
            languageIdTextBox.Visible = false;
            languageLabel.Visible = false;
            languageTextBox.Visible = false;
        }

        private void soundBtn_Click(object sender, EventArgs e)
        {
            enableSound = !enableSound;

            if (enableSound)
            {
                soundBtn.Image = Properties.Resources.sound_24px;
                toolTip1.SetToolTip(soundBtn, "Sound Enabled");
            }
            else
            {
                soundBtn.Image = Properties.Resources.no_sound_24px;
                toolTip1.SetToolTip(soundBtn, "Sound Disabled");
            }
        }
    }
}
