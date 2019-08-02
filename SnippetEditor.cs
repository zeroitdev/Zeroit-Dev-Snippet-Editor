using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Zeroit.Framework.SnippetEditors
{
    public partial class SnippetEditor : Form
    {

        #region Private Fields

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

        bool enableSound = true;

        VisualStudioEditor visualStudioEditor = new VisualStudioEditor();

        CustomMessageWarnAppend appendWarningMessage = new CustomMessageWarnAppend();

        CustomMessageWarnAppend warn = new CustomMessageWarnAppend();

        int tabStop = 0;

        string selectedText = "";

        Dictionary<string, string> lastAppendedItem = new Dictionary<string, string>();
        //Stack<string> lastAppendedItem = new Stack<string>();

        #endregion

        #region Constructor
        public SnippetEditor()
        {
            InitializeComponent();

            if (tab.SelectedIndex == 0)
            {
                openFile.InitialDirectory = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Code\User\Snippets\";

                pathTxtBox.Text = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Code\User\Snippets\";

            }

            if (globalSnippCheckBox.Checked)
            {
                langIdLabel.Visible = true;
                languageIdCombo.Visible = true;
            }

            languageIdCombo.SelectedIndex = 17;

            languageIdentifier = langIdentifiersSymbols[languageIdCombo.SelectedIndex];


        }

        #endregion
                
        #region Private Methods

        private void VisualStudioCode()
        {
            List<string> emptyList = new List<string>();
            char symbol = '"';
            char curlyOpen = '{';
            char curlyClose = '}';
            char tab = '\t';
            char arrayStartSymbol = '[';
            char arrayEndSymbol = ']';
            string newLine = "\n";

            for (int i = 0; i < inputCode.Lines.Length; i++)
            {

                #region Old Working Code
                //emptyList.Add(
                //    symbol.ToString() +
                //    inputCode.Lines[i].ToString().Replace('"'.ToString(), string.Format("{0}{1}", @"\", '"')) +
                //    symbol.ToString() + ","); 
                #endregion

                emptyList.Add(
                    "\t\t" +
                    symbol.ToString() +
                    inputCode.Lines[i].ToString().Replace(@"\", string.Format("{0}", @"\\")).
                    Replace('"'.ToString(), string.Format("{0}{1}", @"\", '"')).
                    Replace("$", string.Format("{0}", @"${0:$}")) +
                    symbol.ToString() + ",");
            }


            List<string> secondEmptyList = new List<string>();
            secondEmptyList.Add(symbol.ToString() + snippetName.Text + symbol + " : " + curlyOpen.ToString() + newLine);
            secondEmptyList.Add(tab.ToString() + symbol.ToString() + "prefix" + symbol.ToString() + " : " + symbol.ToString() + snippetPrefix.Text + symbol.ToString() + ",");

            if (globalSnippCheckBox.Checked)
            {
                secondEmptyList.Add(tab.ToString() + symbol.ToString() + "scope" + symbol.ToString() + " : " + symbol.ToString() + languageIdentifier + symbol.ToString() + ",");
            }

            secondEmptyList.Add(tab.ToString() + symbol.ToString() + "body" + symbol.ToString() + " : " + arrayStartSymbol.ToString());

            for (int i = 0; i < emptyList.Count; i++)
            {

                secondEmptyList.Add(emptyList[i].ToString());

            }

            // + symbol.ToString() + ",")
            secondEmptyList.Add("\t" + arrayEndSymbol.ToString() + "," + newLine);
            secondEmptyList.Add("\t" + symbol.ToString() + "description" + symbol.ToString() + " : " + symbol.ToString() + snippetDescription.Text.
                Replace(@"\".ToString(), string.Format("{0}", @"\\")).
                Replace('"'.ToString(), string.Format("{0}{1}", @"\", '"')).
                Replace("$", string.Format("{0}", @"${0:$}")) + symbol.ToString());
            secondEmptyList.Add("\t" + curlyClose.ToString() + "," + newLine);
            outputCode.Lines = secondEmptyList.ToArray();
        }

        private void Atom()
        {
            List<string> emptyList = new List<string>();
            char symbol = '\'';
            char curlyOpen = '{';
            char curlyClose = '}';
            char tab = '\t';
            char arrayStartSymbol = '[';
            char arrayEndSymbol = ']';
            string newLine = "\n";

            for (int i = 0; i < inputCode.Lines.Length; i++)
            {
                if (escapeChars.Checked)
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
            secondEmptyList.Add(symbol.ToString() + ".source." + languageIdentifier + symbol + " : ");
            secondEmptyList.Add("\t" + symbol.ToString() + snippetName.Text + symbol + " : ");

            if (escapeChars.Checked)
            {
                secondEmptyList.Add("\t\t" + symbol.ToString() + "prefix" + symbol.ToString() + " : " + symbol.ToString() + snippetPrefix.Text.Replace('"'.ToString(), string.Format("{0}{1}", @"\", '"')) + symbol.ToString());

            }
            else
            {
                secondEmptyList.Add("\t\t" + symbol.ToString() + "prefix" + symbol.ToString() + " : " + symbol.ToString() + snippetPrefix.Text + symbol.ToString());
                
            }

            secondEmptyList.Add("\t\t" + symbol.ToString() + "body" + symbol.ToString() + " : " + string.Format("{0}{0}{0}", '"'));

            for (int i = 0; i < emptyList.Count; i++)
            {

                secondEmptyList.Add("\t\t" + emptyList[i].ToString());

            }

            secondEmptyList.Add(string.Format("\t\t" + "{0}{0}{0}", '"'));

            outputCode.Lines = secondEmptyList.ToArray();
        }

        private void Sublime()
        {
            List<string> emptyList = new List<string>();
            char symbol = '\'';
            char curlyOpen = '{';
            char curlyClose = '}';
            char tab = '\t';
            char arrayStartSymbol = '[';
            char arrayEndSymbol = ']';
            string newLine = "\n";

            for (int i = 0; i < inputCode.Lines.Length; i++)
            {

                if (escapeChars.Checked)
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
            secondEmptyList.Add(@"<snippet>");
            secondEmptyList.Add(tab + @"<content>");
            secondEmptyList.Add(tab + @"<![CDATA[");

            for (int i = 0; i < emptyList.Count; i++)
            {

                secondEmptyList.Add("\t    " + emptyList[i].ToString());

            }

            secondEmptyList.Add(tab + @"]]>");
            secondEmptyList.Add(tab + @"</content>");
            secondEmptyList.Add(@"<tabTrigger>" + snippetPrefix.Text + @"</tabTrigger>");
            secondEmptyList.Add(@"<description>" + snippetDescription.Text + @"</description>");
            secondEmptyList.Add(@"<scope>" + snippetScope.Text + @"</scope>");
            secondEmptyList.Add(@"</snippet>" + newLine);


            outputCode.Lines = secondEmptyList.ToArray();
        }

        private void SelectProduct()
        {
            
            switch (tab.SelectedIndex)
            {
                case 0:
                    outputCode.ContextMenuStrip = VSCodeOutputContextMenuStrip;
                    escapeChars.Visible = true;
                    escapeCharsLabel.Visible = true;
                    scopeText.Visible = false;
                    snippetScope.Visible = false;
                    outputCode.Text = String.Empty;
                    VisualStudioCode();
                    copyCode.Text = "Copy VSCode Snippet";
                    appendCode.Text = "Apend to VSCode Snippet";

                    globalSnippLabel.Visible = true;
                    globalSnippCheckBox.Visible = true;

                    if (globalSnippCheckBox.Checked)
                    {
                        globalSnippLabel.Visible = true;
                        globalSnippCheckBox.Visible = true;
                        langIdLabel.Visible = true;
                        languageIdCombo.Visible = true;
                                                
                    }
                    else
                    {
                        addLangIdBtn.Visible = false;
                        langIdLabel.Visible = false;
                        languageIdCombo.Visible = false;
                        
                        identifierLabel.Visible = false;
                        languageIdTextBox.Visible = false;
                        languageLabel.Visible = false;
                        languageTextBox.Visible = false;
                    }

                    openFile.InitialDirectory = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Code\User\Snippets\";

                    pathTxtBox.Text = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Code\User\Snippets\";

                    appendCode.Visible = true;
                    copyCode.Location = new Point(542, 690);

                    
                    break;
                case 1:
                    outputCode.ContextMenuStrip = AtomOutputContextMenuStrip;
                    escapeChars.Visible = true;
                    escapeCharsLabel.Visible = true;
                    //scopeText.Visible = true;
                    //snippetScope.Visible = true;
                    outputCode.Text = String.Empty;
                    Atom();
                    copyCode.Text = "Copy Atom Snippet";
                    appendCode.Text = "Apend to Atom Snippet";

                    globalSnippLabel.Visible = false;
                    globalSnippCheckBox.Visible = false;
                    //languageLabel.Visible = false;
                    //languageTextBox.Visible = false;
                    //identifierLabel.Visible = false;
                    //languageIdTextBox.Visible = false;
                    langIdLabel.Visible = true;
                    languageIdCombo.Visible = true;

                    openFile.InitialDirectory = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) + @"\.atom\";

                    pathTxtBox.Text = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.UserProfile)) + @"\.atom\";

                    appendCode.Visible = false;

                    copyCode.Location = new Point(655, 690);

                    
                    break;
                case 2:
                    outputCode.ContextMenuStrip = SublimeOutputContextMenuStrip;
                    escapeChars.Visible = true;
                    escapeCharsLabel.Visible = true;
                    scopeText.Visible = true;
                    snippetScope.Visible = true;
                    outputCode.Text = String.Empty;
                    Sublime();
                    copyCode.Text = "Copy Sublime Snippet";
                    appendCode.Text = "Apend to Sublime Snippet";

                    globalSnippLabel.Visible = false;
                    globalSnippCheckBox.Visible = false;
                    addLangIdBtn.Visible = false;
                    languageLabel.Visible = false;
                    languageTextBox.Visible = false;
                    identifierLabel.Visible = false;
                    languageIdTextBox.Visible = false;
                    langIdLabel.Visible = false;
                    languageIdCombo.Visible = false;
                    

                    openFile.InitialDirectory = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Sublime Text 3\Packages\User\";

                    pathTxtBox.Text = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Sublime Text 3\Packages\User\";

                    appendCode.Visible = false;
                    copyCode.Location = new Point(655, 690);

                    break;
                case 3:
                    outputCode.ContextMenuStrip = SublimeOutputContextMenuStrip;
                    globalSnippLabel.Visible = false;
                    globalSnippCheckBox.Visible = false;
                    languageLabel.Visible = false;
                    languageTextBox.Visible = false;
                    identifierLabel.Visible = false;
                    languageIdTextBox.Visible = false;
                    langIdLabel.Visible = false;
                    languageIdCombo.Visible = false;

                    this.Hide();

                    if (visualStudioEditor.ShowDialog() == DialogResult.OK)
                    {
                        this.Show();
                        tab.SelectedIndex = 0;

                    }

                    appendCode.Visible = false;
                    copyCode.Location = new Point(655, 690);
                    break;
                default:
                    break;
            }
        }

        private void CopyCode()
        {
            Clipboard.SetData(DataFormats.Text, (Object)outputCode.Text);
        }

        private void PasteText()
        {
            tabStop = 0;

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

        private string PasteAtInsertion()
        {
            // Retrieves data 
            IDataObject iData = Clipboard.GetDataObject();

            string text = (String)iData.GetData(DataFormats.Text);


            // Is Data Text?
            if (iData.GetDataPresent(DataFormats.Text))
            {
                text = (String)iData.GetData(DataFormats.Text);

            }
            else
            {
                text = "Data not found";
            }

            return text;

        }

        private void ClearClipBoard()
        {
            Clipboard.Clear();
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

        private void AppendToVSCodeSnippetFile()
        {
            Rectangle screenArea = Screen.PrimaryScreen.Bounds;
            appendWarningMessage.Location = new Point((screenArea.Width / 2) - (appendWarningMessage.Width / 2), (screenArea.Height / 2) - (appendWarningMessage.Height / 2));
            appendWarningMessage.Message = "Do you want to append the text to the main snippet file ?";
            if (warnAppendCheckBox.Checked)
            {

                if (appendWarningMessage.ShowDialog() == DialogResult.OK)
                {
                    //File.AppendAllLines(pathTxtBox.Text, outputCode.Lines.ToList<string>());
                    ReadAndCreateVSCodeFile();
                }
            }
            else
            {
                //File.AppendAllLines(pathTxtBox.Text, outputCode.Lines.ToList<string>());
                ReadAndCreateVSCodeFile();
            }
        }

        private void ReadAndCreateVSCodeFile()
        {

            try
            {

                if (lastAppendedItem.Values.Contains(outputCode.Text) && lastAppendedItem.Keys.Contains(snippetName.Text))
                {
                    WarningMessage("Snippet with the same name and code exist. \n\n\t\tChoose a different name", Color.DarkOrange, "Choose Different Name", 10, 508, 145, 205, 95);

                }
                else if(lastAppendedItem.Values.Contains(outputCode.Text) && !lastAppendedItem.Keys.Contains(snippetName.Text))
                {
                    WarningMessage("Snippet with the same code exist. \n\n\t\tChoose a different name", Color.DarkOrange, "Choose Different Name");

                    CustomMessageWarnAppend warning = new CustomMessageWarnAppend();
                    warning.Header = "Append The Same Code?";
                    warning.Message = "The same snippet code exist but with a different name.";

                    if(warning.ShowDialog() == DialogResult.OK)
                    {
                        CreateAndAppendVSCodeSelectedFile();
                    }

                }
                else if(lastAppendedItem.Keys.Contains(snippetName.Text))
                {
                    WarningMessage("Snippet with the same name exist. \n\n\t\tChoose a different name", Color.DarkOrange, "Choose Different Name");
                }
                else
                {
                    CreateAndAppendVSCodeSelectedFile();

                }


            }
            catch (Exception ex)
            {

                WarningMessage("Please Select A File To Append Text", Color.DarkOrange, "Select A File");

                if(warn.DialogResult == DialogResult.OK)
                {
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {

                        pathTxtBox.Text = openFile.FileName;

                        CreateAndAppendVSCodeSelectedFile();

                    }
                }

            }


        }

        private void CreateAndAppendVSCodeSelectedFile()
        {
            //Create object of FileInfo for specified path            
            FileInfo fi = new FileInfo(pathTxtBox.Text);

            //Open file for Read\Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            //Create object of StreamReader by passing FileStream object on which it needs to operates on
            StreamReader sr = new StreamReader(fs);

            //Use ReadToEnd method to read all the content from file
            
            string fileContent = sr.ReadToEnd(); 

            //Close StreamReader object after operation
            sr.Close();
            fs.Close();

            #region Backup Before anything happens


            string fileName = Path.GetFileNameWithoutExtension(pathTxtBox.Text);
            string fileExtension = Path.GetExtension(pathTxtBox.Text);
            string newName = string.Format("{0}(Copy){1}", fileName, fileExtension);
            int nameLength = string.Format("{0}{1}", fileName, fileExtension).Length;
            string path = openFile.FileName.Substring(0, openFile.FileName.Length - nameLength);

            string sourceName = pathTxtBox.Text;
            string destinationName = path + newName;

            File.Copy(sourceName, destinationName);

            #endregion

            int changeStart = 0;
            int changeEnd = 0;

            TextBox inputCode = new TextBox();
            inputCode.Text = fileContent;
            changeStart = inputCode.Lines.Length;

            List<string> emptyList = new List<string>();

            for (int i = 0; i < inputCode.Lines.Length; i++)
            {

                emptyList.Add(inputCode.Lines[i].ToString());

            }

            emptyList.RemoveAt(emptyList.Count - 1);
            emptyList.RemoveAt(emptyList.Count - 1);
            emptyList.Add("\n");


            List<string> emptyList1 = new List<string>();

            for (int i = 0; i < emptyList.Count; i++)
            {

                emptyList1.Add(emptyList[i].ToString());

            }

            inputCode.Text = String.Empty;
            inputCode.Lines = emptyList1.ToArray();

            File.WriteAllText(pathTxtBox.Text, inputCode.Text);

            List<string> outputCodeList = outputCode.Lines.ToList<string>();

            outputCodeList.Add("}");

            File.AppendAllLines(pathTxtBox.Text, outputCodeList);

            int lengthAfterChange = 0;

            foreach (string contained in outputCodeList)
            {
                lengthAfterChange += contained.Length;
            }

            lengthAfterChange += inputCode.Text.Length;

            changeStart = emptyList.Count + 1;
            changeEnd = changeStart - 3 + outputCodeList.Count;

            PlaySuccessSound();

            WarningMessage(string.Format("Successfully Added Snippet \n\nCharacters Before Change : {0} " +
                "\n\nCharacters After Change : {1} " +
                "\n\nTotal Change : {2}" +
                string.Format("\n\nChange Occured From Line : {0} - {1}", changeStart, changeEnd), fileContent.Length, lengthAfterChange, lengthAfterChange - fileContent.Length),
                Color.FromArgb(0, 122, 204),
                "Success", 10, 508, 280, 205, 220);

            File.Delete(destinationName);

            lastAppendedItem.Add(snippetName.Text, outputCode.Text);

            lastAppendedLabel.Text = "Last Appended : " + lastAppendedItem.Keys.Last().ToString();
        }
        
        private void AppendToSublimeSnippetFile()
        {
            Rectangle screenArea = Screen.PrimaryScreen.Bounds;
            appendWarningMessage.Location = new Point((screenArea.Width / 2) - (appendWarningMessage.Width / 2), (screenArea.Height / 2) - (appendWarningMessage.Height / 2));
            appendWarningMessage.Message = "Do you want to append the text to the main snippet file ?";
            if (warnAppendCheckBox.Checked)
            {

                if (appendWarningMessage.ShowDialog() == DialogResult.OK)
                {
                    //File.AppendAllLines(pathTxtBox.Text, outputCode.Lines.ToList<string>());
                    ReadAndCreateSublimeFile();
                }
            }
            else
            {
                //File.AppendAllLines(pathTxtBox.Text, outputCode.Lines.ToList<string>());
                ReadAndCreateSublimeFile();
            }
        }

        private void ReadAndCreateSublimeFile()
        {

            try
            {

                if (lastAppendedItem.Values.Contains(outputCode.Text) && lastAppendedItem.Keys.Contains(snippetName.Text))
                {
                    WarningMessage("Snippet with the same name and code exist. \n\n\t\tChoose a different name", Color.DarkOrange, "Choose Different Name", 10, 508, 145, 205, 95);

                }
                else if (lastAppendedItem.Values.Contains(outputCode.Text) && !lastAppendedItem.Keys.Contains(snippetName.Text))
                {
                    WarningMessage("Snippet with the same code exist. \n\n\t\tChoose a different name", Color.DarkOrange, "Choose Different Name");

                    CustomMessageWarnAppend warning = new CustomMessageWarnAppend();
                    warning.Header = "Append The Same Code?";
                    warning.Message = "The same snippet code exist but with a different name.";

                    if (warning.ShowDialog() == DialogResult.OK)
                    {
                        CreateAndAppendSublimeSelectedFile();
                    }

                }
                else if (lastAppendedItem.Keys.Contains(snippetName.Text))
                {
                    WarningMessage("Snippet with the same name exist. \n\n\t\tChoose a different name", Color.DarkOrange, "Choose Different Name");
                }
                else
                {
                    CreateAndAppendSublimeSelectedFile();

                }


            }
            catch (Exception)
            {

                WarningMessage("Please Select A File To Append Text", Color.DarkOrange, "Select A File");

                if (warn.DialogResult == DialogResult.OK)
                {
                    if (openFile.ShowDialog() == DialogResult.OK)
                    {

                        pathTxtBox.Text = openFile.FileName;

                        CreateAndAppendSublimeSelectedFile();

                    }
                }

            }


        }

        private void CreateAndAppendSublimeSelectedFile()
        {
            //Create object of FileInfo for specified path            
            FileInfo fi = new FileInfo(pathTxtBox.Text);

            //Open file for Read\Write
            FileStream fs = fi.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

            //Create object of StreamReader by passing FileStream object on which it needs to operates on
            StreamReader sr = new StreamReader(fs);

            //Use ReadToEnd method to read all the content from file

            string fileContent = sr.ReadToEnd();

            //Close StreamReader object after operation
            sr.Close();
            fs.Close();

            #region Backup Before anything happens


            string fileName = Path.GetFileNameWithoutExtension(pathTxtBox.Text);
            string fileExtension = Path.GetExtension(pathTxtBox.Text);
            string newName = string.Format("{0}(Copy){1}", fileName, fileExtension);
            int nameLength = string.Format("{0}{1}", fileName, fileExtension).Length;
            string path = openFile.FileName.Substring(0, openFile.FileName.Length - nameLength);

            string sourceName = pathTxtBox.Text;
            string destinationName = path + newName;

            File.Copy(sourceName, destinationName);

            #endregion

            int changeStart = 0;
            int changeEnd = 0;

            TextBox inputCode = new TextBox();
            inputCode.Text = fileContent;
            changeStart = inputCode.Lines.Length;

            List<string> emptyList = new List<string>();

            for (int i = 0; i < inputCode.Lines.Length; i++)
            {

                emptyList.Add(inputCode.Lines[i].ToString());

            }

            //emptyList.RemoveAt(emptyList.Count - 1);
            //emptyList.RemoveAt(emptyList.Count - 1);
            emptyList.Add("\n");


            List<string> emptyList1 = new List<string>();

            for (int i = 0; i < emptyList.Count; i++)
            {

                emptyList1.Add(emptyList[i].ToString());

            }

            inputCode.Text = String.Empty;
            inputCode.Lines = emptyList1.ToArray();

            File.WriteAllText(pathTxtBox.Text, inputCode.Text);

            List<string> outputCodeList = outputCode.Lines.ToList<string>();

            //outputCodeList.Add("}");

            File.AppendAllLines(pathTxtBox.Text, outputCodeList);

            int lengthAfterChange = 0;

            foreach (string contained in outputCodeList)
            {
                lengthAfterChange += contained.Length;
            }

            lengthAfterChange += inputCode.Text.Length;

            changeStart = emptyList.Count + 1;
            changeEnd = changeStart - 3 + outputCodeList.Count;

            PlaySuccessSound();

            WarningMessage(string.Format("Successfully Added Snippet \n\nCharacters Before Change : {0} " +
                "\n\nCharacters After Change : {1} " +
                "\n\nTotal Change : {2}" +
                string.Format("\n\nChange Occured From Line : {0} - {1}", changeStart, changeEnd), fileContent.Length, lengthAfterChange, lengthAfterChange - fileContent.Length),
                Color.FromArgb(0, 122, 204),
                "Success", 10, 508, 280, 205, 220);

            File.Delete(destinationName);

            lastAppendedItem.Add(snippetName.Text, outputCode.Text);

            lastAppendedLabel.Text = "Last Appended : " + lastAppendedItem.Keys.Last().ToString();
        }

        private void PlaySuccessSound()
        {
            SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.Success);

            if (enableSound)
            {
                soundPlayer.Play();
            }


        }

        private void SelectAllText()
        {
            // Determine if any text is selected in the TextBox control.
            if (inputCode.SelectionLength == 0)
                // Select all text in the text box.
                inputCode.SelectAll();

            // Copy the contents of the control to the Clipboard.
            //inputCode.Copy();
        }

        private void SelectAndReplace()
        {
            // Determine if any text is selected in the TextBox control.
            if (outputCode.SelectionLength == 0)
            {
                // Select text in the text box.
                outputCode.Select();

                // After this call, the data (string) is placed on the clipboard and tagged
                // with a data format of "Text".
                Clipboard.SetData(DataFormats.Text, (Object)outputCode.SelectedText);

            }

            //outputCode.Copy();
            
        }

        private void SelectAndCopyAllText()
        {
            // Determine if any text is selected in the TextBox control.
            if (inputCode.SelectionLength == 0)
                // Select all text in the text box.
                inputCode.SelectAll();

            // Copy the contents of the control to the Clipboard.
            //inputCode.Copy();
        }

        private void SetErrorNotification()
        {
            error.SetError(snippetName, "Please provide a name");
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
                    SelectProduct();
                    break;
                default:
                    languageIdentifier = langIdentifiersSymbols[languageIdCombo.SelectedIndex];
                    addLangIdBtn.Visible = false;
                    identifierLabel.Visible = false;
                    languageIdTextBox.Visible = false;
                    languageLabel.Visible = false;
                    languageTextBox.Visible = false;
                    SelectProduct();
                    break;
            }
        }


        #endregion

        #region Events and Overrides
        private void inputCode_TextChanged(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void tab_TabChanged(object sender, EventArgs e)
        {
            SelectProduct();
                      
            
        }

        private void snippetName_TextChanged(object sender, EventArgs e)
        {
            SelectProduct();

            if (snippetName.Text != String.Empty)
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
            SelectProduct();
        }

        private void snippetPrefix_TextChanged(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void escapeChars_CheckedChanged(object sender, EventArgs e)
        {
            SelectProduct();
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

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void copyCode_Click(object sender, EventArgs e)
        {
            automaticDiscovery.Checked = false;
            CopyCode();
        }

        private void snippetScope_TextChanged(object sender, EventArgs e)
        {
            SelectProduct();
        }
        
        private void pasteTextBtn_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void baseTheme2_MouseEnter(object sender, EventArgs e)
        {
            if (automaticDiscovery.Checked)
            {
                PasteText();
            }
        }

        private void pasteTextBtn_MouseHover(object sender, EventArgs e)
        {
            pasteTextBtn.BorderColor = Color.Cyan;
        }

        private void pasteTextBtn_MouseLeave(object sender, EventArgs e)
        {
            pasteTextBtn.BorderColor = Color.FromArgb(20,20,20);
        }

        private void copyCode_MouseHover(object sender, EventArgs e)
        {
            copyCode.BorderColor = Color.Cyan;
        }

        private void copyCode_MouseLeave(object sender, EventArgs e)
        {
            copyCode.BorderColor = Color.FromArgb(20,20,20);
        }
        
        private void appendCode_Click(object sender, EventArgs e)
        {

            switch (tab.SelectedIndex)
            {
                case 0:
                    
                    if (snippetName.Text == String.Empty)
                    {
                        SetErrorNotification();

                        WarningMessage("Enter Snippet Name to Proceed", Color.DarkOrange);
                    }
                    else
                    {
                        error.Clear();

                        if (globalSnippCheckBox.Checked)
                        {
                            try
                            {
                                if (openFile.SafeFileName.Substring(openFile.SafeFileName.IndexOf(".")) != ".code-snippets")
                                {
                                    WarningMessage("Global Snippets should have an extension of .code-snippets", Color.DarkOrange);
                                }
                                else
                                {
                                    try
                                    {
                                        //File.AppendAllLines(pathTxtBox.Text, outputCode.Lines.ToList<string>());
                                        //WarningMessage("Successfully Appended Text", Color.DarkOrange, "Success");

                                        ReadAndCreateVSCodeFile();


                                    }
                                    catch (Exception exception)
                                    {

                                        WarningMessage(exception.Message, Color.DarkOrange, "Warning");
                                    }

                                }
                            }
                            catch (Exception exception)
                            {
                                WarningMessage("Please select a Global snippet file with .code-snippet extension or uncheck\n" +
                                                "the Global Snippet checkbox", Color.DarkOrange, "Warning!!!", 8);

                            }


                        }
                        else
                        {
                            AppendToVSCodeSnippetFile();
                        }
                    }
                    
                    break;

                case 1:
                    
                    break;

                case 2:
                    
                    if (snippetName.Text == String.Empty)
                    {
                        SetErrorNotification();
                    }
                    else
                    {
                        error.Clear();

                        if (globalSnippCheckBox.Checked)
                        {
                            try
                            {
                                if (openFile.SafeFileName.Substring(openFile.SafeFileName.IndexOf(".")) != ".code-snippets")
                                {
                                    WarningMessage("Global Snippets should have an extension of .code-snippets", Color.DarkOrange);
                                }
                                else
                                {
                                    try
                                    {
                                        //File.AppendAllLines(pathTxtBox.Text, outputCode.Lines.ToList<string>());
                                        //WarningMessage("Successfully Appended Text", Color.DarkOrange, "Success");

                                        ReadAndCreateSublimeFile();


                                    }
                                    catch (Exception exception)
                                    {

                                        WarningMessage(exception.Message, Color.DarkOrange, "Warning");
                                    }

                                }
                            }
                            catch (Exception exception)
                            {
                                WarningMessage("Please select a Global snippet file with .code-snippet extension or uncheck\n" +
                                                "the Global Snippet checkbox", Color.DarkOrange, "Warning!!!", 8);

                            }


                        }
                        else
                        {
                            AppendToSublimeSnippetFile();
                        }
                    }

                    break;
                case 3:
                    
                    break;

                default:
                    break;
            }
            

        }

        private void openFileBtn_Click(object sender, EventArgs e)
        {
            if (openFile.ShowDialog() == DialogResult.OK)
            {

                pathTxtBox.Text = openFile.FileName;

            }
            
            
        }

        private void copy_Click(object sender, EventArgs e)
        {

        }

        private void outputCopyCtxtMenu_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)outputCode.Text);
        }

        private void paste_Click(object sender, EventArgs e)
        {
            PasteText();
        }

        private void clear_Click(object sender, EventArgs e)
        {
            inputCode.Text = String.Empty;
        }

        private void outputAppendCtxtMenu_Click(object sender, EventArgs e)
        {
            AppendToVSCodeSnippetFile();
        }
        
        private void languageIdCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedIdentifier();

        }

        
        private void addLanguageIdentifier_Click(object sender, EventArgs e)
        {
            languageIdCombo.Items.Add(languageTextBox.Text);
            langIdentifiersSymbols.Add(languageIdTextBox.Text);

            addLangIdBtn.Visible = false;
            identifierLabel.Visible = false;
            languageIdTextBox.Visible = false;
            languageLabel.Visible = false;
            languageTextBox.Visible = false;
        }

        private void globalSnippCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (globalSnippCheckBox.Checked)
            {
                langIdLabel.Visible = true;
                languageIdCombo.Visible = true;
            }
            else
            {
                langIdLabel.Visible = false;
                languageIdCombo.Visible = false;
            }

            SelectProduct();

        }

        private void snippetScope_TextChanged_1(object sender, EventArgs e)
        {
            SelectProduct();
        }

        private void languageTextBox_TextChanged(object sender, EventArgs e)
        {
            SelectProduct();
        }
        
        private void TabStop_Click(object sender, EventArgs e)
        {

            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                tabStop++;

                outputCode.Paste(string.Format("${0}", tabStop));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);
                              
                
            }                       

        }

        private void singleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //${1:foo}

                tabStop++;

                //SelectAndReplace();

                // Determine if any text is selected in the TextBox control.
                if (outputCode.SelectionLength == 0)
                {
                    // Select text in the text box.
                    outputCode.Select();


                }

                // After this call, the data (string) is placed on the clipboard and tagged
                // with a data format of "Text".
                Clipboard.SetData(DataFormats.Text, (Object)outputCode.SelectedText);


                // Retrieves data 
                IDataObject iData = Clipboard.GetDataObject();

                selectedText = (String)iData.GetData(DataFormats.Text);

                outputCode.Paste(@"${" + tabStop + ":" + selectedText + "}");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }

            
        }

        private void nestedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //${1:another ${2:placeholder}}

                tabStop++;
                outputCode.Paste(string.Format("${" + tabStop + ":another ${" + (tabStop += 1)
                                + ":" + "placeholder}"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void ChoiceStripMenu_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //${1|one,two,three|}

                tabStop++;

                // Determine if any text is selected in the TextBox control.
                if (outputCode.SelectionLength == 0)
                {
                    // Select text in the text box.
                    outputCode.Select();


                }

                // After this call, the data (string) is placed on the clipboard and tagged
                // with a data format of "Text".
                Clipboard.SetData(DataFormats.Text, (Object)outputCode.SelectedText);


                // Retrieves data 
                IDataObject iData = Clipboard.GetDataObject();

                selectedText = (String)iData.GetData(DataFormats.Text);

                choiceTextBox.Text = selectedText;

                choicePanel.Visible = true;

                //outputCode.Paste(@"${" + tabStop + @"|"+ choices + "|"+"}");


            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void defineAVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //${name:default}
                outputCode.Paste(@"${name:default}");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMSELECTEDTEXTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste(string.Format(@"$TM_SELECTED_TEXT"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMCURRENTLINEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste(string.Format(@"$TM_CURRENT_LINE"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMCURRENTWORDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_CURRENT_WORD
                outputCode.Paste(string.Format(@"$TM_CURRENT_WORD"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMLINEINDEXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_LINE_INDEX
                outputCode.Paste(string.Format(@"$TM_LINE_INDEX"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMLINENUMBERToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_LINE_NUMBER
                outputCode.Paste(string.Format(@"$TM_LINE_NUMBER"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMFILENAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_FILENAME
                outputCode.Paste(string.Format(@"$TM_FILENAME"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMFILENAMEBASEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_FILENAME_BASE
                outputCode.Paste(string.Format(@"$TM_FILENAME_BASE"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMDIRECTORYToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_DIRECTORY
                outputCode.Paste(string.Format(@"$TM_DIRECTORY"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMFILEPATHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //TM_FILEPATH
                outputCode.Paste(string.Format(@"$TM_FILEPATH"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cLIPBOARDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CLIPBOARD
                outputCode.Paste(string.Format(@"$CLIPBOARD"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void wORKSPACENAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //WORKSPACE_NAME
                outputCode.Paste(string.Format(@"$WORKSPACE_NAME"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTYEARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_YEAR
                outputCode.Paste(string.Format(@"$CURRENT_YEAR"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTYEARSHORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_YEAR_SHORT
                outputCode.Paste(string.Format(@"$CURRENT_YEAR_SHORT"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTMONTHToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_MONTH 
                outputCode.Paste(string.Format(@"$CURRENT_MONTH"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTMONTHNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_MONTH_NAME 
                outputCode.Paste(string.Format(@"$CURRENT_MONTH_NAME"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTMONTHNAMESHORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_MONTH_NAME_SHORT 
                outputCode.Paste(string.Format(@"$CURRENT_MONTH_NAME_SHORT"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTDATEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_DATE 
                outputCode.Paste(string.Format(@"$CURRENT_DATE"));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTDAYNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_DAY_NAME
                outputCode.Paste(string.Format(@"$CURRENT_DAY_NAME"));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTDAYNAMESHORTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_DAY_NAME_SHORT
                outputCode.Paste(string.Format(@"$CURRENT_DAY_NAME_SHORT"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTHOURToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_HOUR 
                outputCode.Paste(string.Format(@"$CURRENT_HOUR"));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTMINUTEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_MINUTE 
                outputCode.Paste(string.Format(@"$CURRENT_MINUTE"));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cURRENTSECONDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //CURRENT_SECOND 
                outputCode.Paste(string.Format(@"$CURRENT_SECOND"));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void bLOCKCOMMENTSTARTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //BLOCK_COMMENT_START 
                outputCode.Paste(string.Format(@"$BLOCK_COMMENT_START"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void bLOCKCOMMENTENDToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //BLOCK_COMMENT_END 
                outputCode.Paste(string.Format(@"$BLOCK_COMMENT_END"));
            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void lINECOMMENTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //LINE_COMMENT 
                outputCode.Paste(string.Format(@"$LINE_COMMENT"));

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Clipboard.SetData(DataFormats.Text, (Object)outputCode.Text);
        }

        private void outputSaveCtxtMenu_Click(object sender, EventArgs e)
        {
            AppendToVSCodeSnippetFile();
        }

        private void pasteInsertionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputCode.Paste();
            //inputCode.Paste(PasteAtInsertion());
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectAllText();
        }

        private void inputCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.A)
            {
                if (sender != null)
                    ((TextBox)sender).SelectAll();
            }
        }

        private void minimizeBtn_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void minimizeBtn_MouseHover(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.FromArgb(100, 0, 0, 0);
        }

        private void minimizeBtn_MouseLeave(object sender, EventArgs e)
        {
            minimizeBtn.BackColor = Color.Transparent;
        }

        private void closeBtn_MouseHover(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Red;
        }

        private void closeBtn_MouseLeave(object sender, EventArgs e)
        {
            closeBtn.BackColor = Color.Transparent;

        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputCode.Undo();
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            inputCode.Redo();
        }

        private void inputCode_Click(object sender, EventArgs e)
        {
            Knob1Remove();
            zoomLabel.Visible = false;
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

        private void resetBtn_MouseEnter(object sender, EventArgs e)
        {
            resetBtn.BorderColor = Color.Cyan;
        }

        private void resetBtn_MouseLeave(object sender, EventArgs e)
        {
            resetBtn.BorderColor = Color.FromArgb(20, 20, 20);
        }

        private void resetBtn_Click(object sender, EventArgs e)
        {

            Rectangle screenArea = Screen.PrimaryScreen.Bounds;
            appendWarningMessage.Location = new Point((screenArea.Width / 2) - (appendWarningMessage.Width / 2), (screenArea.Height / 2) - (appendWarningMessage.Height / 2));

            appendWarningMessage.Message = "Do you to reset the application ?";

            if (appendWarningMessage.ShowDialog() == DialogResult.OK)
            {

                snippetName.Text = String.Empty;
                snippetDescription.Text = String.Empty;
                snippetPrefix.Text = String.Empty;
                snippetScope.Text = String.Empty;
                languageTextBox.Text = String.Empty;
                escapeChars.Checked = true;
                warnAppendCheckBox.Checked = true;
                globalSnippCheckBox.Checked = false;
                automaticDiscovery.Checked = false;

                pathTxtBox.Text = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Code\User\Snippets\";

                openFile.InitialDirectory = string.Format(@"{0}", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)) + @"\Code\User\Snippets\";

                languageIdCombo.SelectedIndex = 17;

                languageIdentifier = langIdentifiersSymbols[languageIdCombo.SelectedIndex];

                inputCode.Text = "Place code here";

            }


        }

        private void outputCode_TextChanged(object sender, EventArgs e)
        {
            if (outputCode.Lines.Length > 27)
            {
                outputCode.ScrollBars = ScrollBars.Vertical;
            }
            else
            {
                outputCode.ScrollBars = ScrollBars.None;
            }

            if (snippetName.Text != String.Empty)
            {
                error.Clear();
            }
            else
            {
                SetErrorNotification();
            }
        }

        private void pathTxtBox_MouseEnter(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pathTxtBox, pathTxtBox.Text);
            toolTip1.Show(pathTxtBox.Text, pathTxtBox);

        }

        private void pathTxtBox_MouseLeave(object sender, EventArgs e)
        {
            toolTip1.Hide(pathTxtBox);
            toolTip1.RemoveAll();
        }

        private void appendCode_MouseLeave(object sender, EventArgs e)
        {
            appendCode.BorderColor = Color.FromArgb(20, 20, 20);
        }

        private void appendCode_MouseHover(object sender, EventArgs e)
        {
            appendCode.BorderColor = Color.Cyan;
        }

        private void outputCode_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void outputCode_MouseClick(object sender, MouseEventArgs e)
        {
            choicePanel.Location = new Point(e.X + 10, e.Y + 10);
        }

        private void choiceOKBtn_Click(object sender, EventArgs e)
        {
            choicePanel.Visible = false;
            string choices = choiceTextBox.Text.Replace("\n", ",");
            outputCode.Paste(@"${" + tabStop + @"|" + choices + "|" + "}");
        }


        #endregion

        #region Knob Activities

        /// <summary>
        /// The knob1
        /// </summary>
        private ZeroitLBKnob knob1 = new ZeroitLBKnob();

        /// <summary>
        /// The knob1 animator
        /// </summary>
        private ZeroitAnimator knob1Animator = new ZeroitAnimator();

        private void zoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Knob1Created();
            Knob1AnimatorCreated();

            this.knob1.BringToFront();
            knob1Animator.Activate();
        }

        /// <summary>
        /// Knob1s the created.
        /// </summary>
        private void Knob1Created()
        {
            this.knob1.BackColor = System.Drawing.Color.Transparent;
            this.knob1.DrawRatio = 0.59F;
            this.knob1.IndicatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.knob1.IndicatorOffset = 10F;
            this.knob1.KnobColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(120)))), ((int)(((byte)(120)))));
            this.knob1.Location = new System.Drawing.Point(158, 172);
            this.knob1.MaxValue = 63;
            this.knob1.MinValue = 0.101f;
            this.knob1.ScaleColor = Color.Gray;
            this.knob1.Size = new System.Drawing.Size(118, 121);
            this.knob1.StepValue = 0.01f;
            this.knob1.Style = ZeroitLBKnob.KnobStyle.Circular;
            this.knob1.Value = inputCode.ZoomFactor;
            this.knob1.Visible = true;


            extensibleInput.Controls.Add(knob1);
            knob1.KnobChangeValue += Knob1_KnobChangeValue;
            knob1.MouseDown += changeKnob_MouseDown;
            knob1.MouseUp += changeKnob_MouseUp;
        }
        /// <summary>
        /// Knob1s the remove.
        /// </summary>
        private void Knob1Remove()
        {
            knob1.Visible = false;
            baseTheme2.Controls.Remove(knob1);
        }

        /// <summary>
        /// Handles the KnobChangeValue event of the Knob1 control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="ZeroitLBKnobEventArgs"/> instance containing the event data.</param>
        private void Knob1_KnobChangeValue(object sender, ZeroitLBKnobEventArgs e)
        {
            inputCode.ZoomFactor = knob1.Value;
            zoomLabel.Visible = true;
            zoomLabel.Text = string.Format("{0}%", Convert.ToInt32(knob1.Value * 100));
        }

        private void changeKnob_MouseDown(object sender, MouseEventArgs e)
        {
            knob1.ScaleColor = Color.Cyan;
        }

        private void changeKnob_MouseUp(object sender, MouseEventArgs e)
        {
            knob1.ScaleColor = Color.Gray;
        }

        /// <summary>
        /// Knob1s the animator created.
        /// </summary>
        private void Knob1AnimatorCreated()
        {
            knob1Animator.Target = knob1;
            knob1Animator.AnimationType = AnimationType.Mosaic;
            knob1Animator.TargetHeight = 121;
            knob1Animator.TargetWidth = 118;
            knob1Animator.Interval = 10;
            knob1Animator.MaxAnimationTime = 1500;
            knob1Animator.TimeStep = 0.02f;
        }




        #endregion

        private void placeholderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                //${1:foo}

                tabStop++;

                //SelectAndReplace();

                // Determine if any text is selected in the TextBox control.
                if (outputCode.SelectionLength == 0)
                {
                    // Select text in the text box.
                    outputCode.Select();


                }

                // After this call, the data (string) is placed on the clipboard and tagged
                // with a data format of "Text".
                Clipboard.SetData(DataFormats.Text, (Object)outputCode.SelectedText);


                // Retrieves data 
                IDataObject iData = Clipboard.GetDataObject();

                selectedText = (String)iData.GetData(DataFormats.Text);

                outputCode.Paste(@"${" + tabStop + ":" + selectedText + "}");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void cDATAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
 
                outputCode.Paste(@"<![CDATA[]]>");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void commentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste(@"<!--  -->");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void loremIpsumToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod /n" +
                                 "tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, /n" +
                                 "quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo /n" +
                                 "consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse /n" +
                                 "cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non /n" +
                                 "proident, sunt in culpa qui officia deserunt mollit anim id est laborum.");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void longTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
 
                outputCode.Paste(@"<name></name>");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void shortTagToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste(@"<name />");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void xMLProcessingInstructionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste("<?xml version=\"1.0\" encoding=\"UTF - 8\"?>");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void usrbindevToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste(@"#!/usr/bin/env");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        
        private void withOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste(@"$var_name/regex/format_string/options");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void withoutOptionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste(@"$var_name/regex/format_string/");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void pARAMPARAMnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
         
                outputCode.Paste(@"$PARAM" + tabStop);

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void sELCTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$SELECTION");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMCURRENTLINEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_CURRENT_LINE");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMCURRENTWORDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_CURRENT_WORD");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMDIRECTORYToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_DIRECTORY");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMFILENAMEToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_FILENAME");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMFILEPATHToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_FILEPATH");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMFULLNAMEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_FULLNAME");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMLINEINDEXToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_LINE_INDEX");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMLINENUMBERToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_LINE_NUMBER");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMSELECTEDTEXTToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_SELECTED_TEXT");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMSCOPEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_SCOPE");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMSOFTTABSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();

                outputCode.Paste("$TM_SOFT_TABS");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        private void tMTABSIZEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (snippetName.Text != String.Empty)
            {
                error.Clear();
                
                outputCode.Paste("$TM_TAB_SIZE");

            }
            else
            {
                SetErrorNotification();

                WarningMessage("Enter Snippet Name", Color.DarkOrange);


            }
        }

        SplashScreenForm splash = new SplashScreenForm();

        private void SnippetEditor_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            splash.Form = this;
            splash.BringToFront();
            splash.Show();
            this.SendToBack();
            
        }

        
    }
}
