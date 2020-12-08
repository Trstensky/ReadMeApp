using ReadMeLib.Readers;
using System;
using System.IO;
using System.Windows.Forms;

namespace ReadMe {
    /// <summary>
    /// Aplication functionality
    /// Reading txt, xml and json files as a plain text or an encrypted text with security roles admin, user and guest
    /// </summary>
    public partial class FormReadMe:Form {
        public FormReadMe() {
            InitializeComponent();
        }

        /// <summary>
        /// Implements logic for select files, loading files and handling strings from files
        /// After handling the output string is loaded to richtext box
        /// </summary>
        private void ButtonOpenFile_Click(object sender, EventArgs e) {
            // Set up initial directory
            var initialDirectory = Path.GetFullPath(Path.Combine(Application.StartupPath, @"../../FileSample"));

            // Set up file filter
            var filter = "";
            if(RadioButtonTxt.Checked) {
                filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            } else if(RadioButtonXml.Checked) {
                filter = "xml files (*.xml)|*.xml|All files (*.*)|*.*";
            } else if(RadioButtonJson.Checked) {
                filter = "json files (*.json)|*.json|All files (*.*)|*.*";
            }

            // Open dialog window
            var filePath = OpenFileDialog(initialDirectory, filter);
            if(filePath != null) {
                var result = "";
                if(RadioButtonTxt.Checked) {
                    // Handling all operation with txt files
                    result = ReadTxt(filePath);
                } else if(RadioButtonXml.Checked) {
                    // Handling all operation with xml files
                    result = ReadXml(filePath);
                } else if(RadioButtonJson.Checked) {
                    // Handling all operation with json files
                    result = ReadJson(filePath);
                }

                // Set up result text to output richtext box
                RichTextBoxOutput.Text = result;
            }
        }

        /// <summary>
        /// Handling all operations with txt files
        /// </summary>
        /// <param name="filePath">Complete path to text file with file name</param>
        /// <returns>Result string after all operations</returns>
        private string ReadTxt(string filePath) {
            // Read string from txt file
            var fileReader = new FileReader(filePath);
            fileReader.ReadTxt();
            var result = fileReader.GetResult();
            if(RadioButtonEncrypted.Checked) {
                // Read encrypted string from txt file
                var encryptedReader = new EncryptedReader(result);
                encryptedReader.ReadTxt();
                result = encryptedReader.GetResult();
            }
            if(RadioButtonAdmin.Checked) {
                // Read string from txt file as role admin 
                var adminReader = new AdminReader(result);
                adminReader.ReadTxt();
                result = adminReader.GetResult();
            } else if(RadioButtonUser.Checked) {
                // Read string from txt file as role user 
                var userReader = new UserReader(result);
                userReader.ReadTxt();
                result = userReader.GetResult();
            } else if(RadioButtonGuest.Checked) {
                // Read string from txt file as role guest 
                var guestReader = new GuestReader(result);
                guestReader.ReadTxt();
                result = guestReader.GetResult();
            }
            // Result string after all operations
            return result;
        }

        /// <summary>
        /// Handling all operations with xml files
        /// </summary>
        /// <param name="filePath">Complete path to text file with file name</param>
        /// <returns>Result string after all operations</returns>
        private string ReadXml(string filePath) {
            // Read string from xml file
            var fileReader = new FileReader(filePath);
            fileReader.ReadXml();
            var result = fileReader.GetResult();
            if(RadioButtonEncrypted.Checked) {
                // Read encrypted string from xml file
                var encryptedReader = new EncryptedReader(result);
                encryptedReader.ReadXml();
                result = encryptedReader.GetResult();
            }
            if(RadioButtonAdmin.Checked) {
                // Read string from xml file as role admin 
                var adminReader = new AdminReader(result);
                adminReader.ReadXml();
                result = adminReader.GetResult();
            } else if(RadioButtonUser.Checked) {
                // Read string from xml file as role user 
                var userReader = new UserReader(result);
                userReader.ReadXml();
                result = userReader.GetResult();
            } else if(RadioButtonGuest.Checked) {
                // Read string from xml file as role guest 
                var guestReader = new GuestReader(result);
                guestReader.ReadXml();
                result = guestReader.GetResult();
            }
            // Result string after all operations
            return result;
        }

        /// <summary>
        /// Handling all operations with json files
        /// </summary>
        /// <param name="filePath">Complete path to text file with file name</param>
        /// <returns>Result string after all operations</returns>
        private string ReadJson(string filePath) {
            // Read string from json file
            var fileReader = new FileReader(filePath);
            fileReader.ReadJson();
            var result = fileReader.GetResult();
            if(RadioButtonEncrypted.Checked) {
                // Read encrypted string from json file
                var encryptedReader = new EncryptedReader(result);
                encryptedReader.ReadJson();
                result = encryptedReader.GetResult();
            }
            if(RadioButtonAdmin.Checked) {
                // Read string from json file as role admin 
                var adminReader = new AdminReader(result);
                adminReader.ReadJson();
                result = adminReader.GetResult();
            } else if(RadioButtonUser.Checked) {
                // Read string from json file as role user 
                var userReader = new UserReader(result);
                userReader.ReadJson();
                result = userReader.GetResult();
            } else if(RadioButtonGuest.Checked) {
                // Read string from json file as role guest 
                var guestReader = new GuestReader(result);
                guestReader.ReadJson();
                result = guestReader.GetResult();
            }
            // Result string after all operations
            return result;
        }

        /// <summary>
        /// Open file dialog
        /// </summary>
        /// <param name="initialDirectory">Set up initial directory</param>
        /// <param name="filter">Set up file filter</param>
        /// <returns>Complete path to text file with file name</returns>
        private string OpenFileDialog(string initialDirectory, string filter) {
            using(OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = initialDirectory;
                openFileDialog.Filter = filter;

                if(openFileDialog.ShowDialog() == DialogResult.OK) {
                    // return file path
                    return openFileDialog.FileName;
                }
            }
            return null;
        }
    }
}