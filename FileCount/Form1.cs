using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
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

        private static List<string> filesList = new List<string>();

        private static List<string> DirSech (string currentDirectory, string extension)
        {
            try
            {
                string checkDir = currentDirectory;
                
                foreach (string directory in Directory.GetDirectories(currentDirectory))
                {
                    if (checkDir.Equals(currentDirectory))
                    {
                        foreach (string file in Directory.GetFiles(currentDirectory, "*." + extension))
                        {
                            string currentExtension = Path.GetExtension(file);
                            if (currentExtension != null && (currentExtension.Equals("." + extension)))
                            {
                                filesList.Add(file);
                            }
                            checkDir = "";
                            break;
                        }
                    }
                    foreach (string file in Directory.GetFiles(directory, "*." + extension))
                    {
                        string currentExtension = Path.GetExtension(file);
                        if (currentExtension != null && (currentExtension.Equals("." + extension)))
                        {
                            filesList.Add(file);
                        }
                    }

                    DirSech(directory, extension);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return filesList;
        }


        private void potok1() => filesFoundRichTextBox.Invoke((MethodInvoker)delegate
        {
            filesFoundRichTextBox.Text = filesList.Count.ToString();
            Thread.Sleep(100);
        });


        private void potok2() => listBox1.Invoke((MethodInvoker)delegate
        {
            DirSech(filePathRichTextBox.Text.ToString(), fileExtensionComboBox.SelectedItem.ToString());
            foreach (string file in filesList)
            {


                listBox1.Items.Add(file.ToString());
            }
            Thread.Sleep(100);

        });


        private void findFileButton_Click(object sender, EventArgs e)
        {
            Thread foundThread = new Thread(potok2);
            foundThread.Start();
            Thread countThread = new Thread(potok1);
            countThread.Start();
            
        }

      
        private void opentPathButton_Click(object sender, EventArgs e)
        {
            ChooseFolder();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            listBox1.SelectedItem.ToString();
        }


        private void clearLiasBoxButton_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            filePathRichTextBox.Text = "";
            filesFoundRichTextBox.Text = "";
        }
    }
}
