using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FileCount
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
           
        }

        private void fileExtensionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            string selectedExtensionState = fileExtensionComboBox.SelectedItem.ToString();
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            fileExtensionComboBox.Items.Add("exe");
            fileExtensionComboBox.Items.Add("txt");
            fileExtensionComboBox.Items.Add("doc");
            fileExtensionComboBox.Items.Add("docx");
            fileExtensionComboBox.Items.Add("pdf");
            fileExtensionComboBox.Items.Add("zip");
            fileExtensionComboBox.Items.Add("rar");
            fileExtensionComboBox.Items.Add("jpg");        
        }

        public void ChooseFolder()
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                filePathRichTextBox.Text = folderBrowserDialog1.SelectedPath;
            }
        }
        

        static string[] SearchDirectory(string patch)
        {
            string[] ResultSearch = Directory.GetDirectories(patch);           
            return ResultSearch;            
        }


        static string[] SearchFile(string patch, string pattern)
        {
            string[] ResultSearch = Directory.GetFiles(patch, pattern, SearchOption.AllDirectories);           
            return ResultSearch;
        }


        private void findFileButton_Click(object sender, EventArgs e)
        {                 
            string PatchProfile = filePathRichTextBox.Text.ToString();
            string[] S = SearchDirectory(PatchProfile);
            
            string ListPatch ="";
            foreach (string folderPatch in S)
            {
                 ListPatch += folderPatch + "\n";
                try
                {
                    string[] F = SearchFile(folderPatch, "*."+fileExtensionComboBox.SelectedItem.ToString());
                    foreach (string FF in F)
                    {
                        listBox1.Items.Add(FF.ToString());
                        int count = F.Length;
                      filesFoundRichTextBox.Text = count.ToString();
                    }
                }
                catch
                {
                }
            }
            
        }
      

        private void opentPathButton_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedItem.ToString();
        }
    }
}
