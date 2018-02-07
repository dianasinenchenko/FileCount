using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            fileExtensionComboBox.SelectedIndexChanged += fileExtensionComboBox_SelectedIndexChanged;
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
            fileExtensionComboBox.Items.Add("ppt");
          
        }
    }
}
