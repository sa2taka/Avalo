using System;
using System.Windows.Forms;
using System.IO;

namespace Avalo {
    public partial class MainForm : Form {

        public MainForm() {
            InitializeComponent();
            initialize();
        }

        private void initialize() {
            originPath.Text = CaptureManager.path;
            folderNameRule.Text = CaptureManager.directoryNameRule;
            fileNameRule.Text = CaptureManager.fileNameRule;
            updateExamplePath();
        }

        private void updateExamplePath() {
            var savePath = CaptureManager.path;
            var dispPath = savePath;
            if (savePath.Equals(String.Empty)) {
                savePath = Directory.GetCurrentDirectory();
                dispPath = ".";
            }
            var saveFolder = FileNameUtils.exchangeFolderName(CaptureManager.directoryNameRule);
            var fullPath = savePath + "\\" + saveFolder;
            var dispFolder = dispPath + "\\" + saveFolder;
            fileExample.Text = dispFolder + "\\" + FileNameUtils.exchangeFileName(CaptureManager.fileNameRule, ".");
        }
       
        private void originPathButton_Click(object sender, EventArgs e) {
            var fileContent = string.Empty;
            var filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.InitialDirectory = CaptureManager.path;
                openFileDialog.Filter = "フォルダ|.";
                openFileDialog.RestoreDirectory = true;
                openFileDialog.CheckFileExists = false;
                openFileDialog.FileName = "フォルダを選択";

                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    filePath = System.IO.Path.GetDirectoryName(openFileDialog.FileName);
                }
            }

            if(!filePath.Equals(String.Empty)) {
                CaptureManager.path = filePath;
                originPath.Text = CaptureManager.path;
                updateExamplePath();
            }
        }

        private void originPath_TextChanged(object sender, EventArgs e) {
            CaptureManager.path = originPath.Text;
            updateExamplePath();
        }

        private void folderNameRule_TextChanged(object sender, EventArgs e) {
            CaptureManager.directoryNameRule = folderNameRule.Text;
            updateExamplePath();
        }

        private void fileNameRule_TextChanged(object sender, EventArgs e) {
            CaptureManager.fileNameRule = fileNameRule.Text;
            updateExamplePath();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e) {
            CaptureManager.save();
        }

    }
}
