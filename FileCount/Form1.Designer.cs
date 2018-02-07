﻿namespace FileCount
{
    partial class MainWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.filePathRichTextBox = new System.Windows.Forms.RichTextBox();
            this.fileExtensionComboBox = new System.Windows.Forms.ComboBox();
            this.opentPathButton = new System.Windows.Forms.Button();
            this.findFileButton = new System.Windows.Forms.Button();
            this.stopButton = new System.Windows.Forms.Button();
            this.allFilesListBox = new System.Windows.Forms.ListBox();
            this.filesFoundRichTextBox = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.resultPanel = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.mainPanel.SuspendLayout();
            this.resultPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "enter path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(357, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = " file extension ";
            // 
            // filePathRichTextBox
            // 
            this.filePathRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filePathRichTextBox.Location = new System.Drawing.Point(16, 44);
            this.filePathRichTextBox.Name = "filePathRichTextBox";
            this.filePathRichTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedHorizontal;
            this.filePathRichTextBox.Size = new System.Drawing.Size(342, 32);
            this.filePathRichTextBox.TabIndex = 2;
            this.filePathRichTextBox.Text = "";
            // 
            // fileExtensionComboBox
            // 
            this.fileExtensionComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fileExtensionComboBox.FormattingEnabled = true;
            this.fileExtensionComboBox.Location = new System.Drawing.Point(361, 44);
            this.fileExtensionComboBox.Name = "fileExtensionComboBox";
            this.fileExtensionComboBox.Size = new System.Drawing.Size(121, 32);
            this.fileExtensionComboBox.TabIndex = 3;
            this.fileExtensionComboBox.SelectedIndexChanged += new System.EventHandler(this.fileExtensionComboBox_SelectedIndexChanged);
            // 
            // opentPathButton
            // 
            this.opentPathButton.Location = new System.Drawing.Point(222, 234);
            this.opentPathButton.Name = "opentPathButton";
            this.opentPathButton.Size = new System.Drawing.Size(75, 23);
            this.opentPathButton.TabIndex = 4;
            this.opentPathButton.Text = "Open";
            this.opentPathButton.UseVisualStyleBackColor = true;
            this.opentPathButton.Click += new System.EventHandler(this.opentPathButton_Click);
            // 
            // findFileButton
            // 
            this.findFileButton.Location = new System.Drawing.Point(314, 234);
            this.findFileButton.Name = "findFileButton";
            this.findFileButton.Size = new System.Drawing.Size(75, 23);
            this.findFileButton.TabIndex = 5;
            this.findFileButton.Text = "Find";
            this.findFileButton.UseVisualStyleBackColor = true;
            this.findFileButton.Click += new System.EventHandler(this.findFileButton_Click);
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(404, 234);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 23);
            this.stopButton.TabIndex = 6;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            // 
            // allFilesListBox
            // 
            this.allFilesListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allFilesListBox.FormattingEnabled = true;
            this.allFilesListBox.ItemHeight = 24;
            this.allFilesListBox.Location = new System.Drawing.Point(19, 40);
            this.allFilesListBox.Name = "allFilesListBox";
            this.allFilesListBox.Size = new System.Drawing.Size(339, 220);
            this.allFilesListBox.TabIndex = 7;
            // 
            // filesFoundRichTextBox
            // 
            this.filesFoundRichTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.filesFoundRichTextBox.Location = new System.Drawing.Point(368, 40);
            this.filesFoundRichTextBox.Name = "filesFoundRichTextBox";
            this.filesFoundRichTextBox.Size = new System.Drawing.Size(100, 36);
            this.filesFoundRichTextBox.TabIndex = 8;
            this.filesFoundRichTextBox.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(364, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = " files found";
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.filePathRichTextBox);
            this.mainPanel.Controls.Add(this.label1);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.fileExtensionComboBox);
            this.mainPanel.Controls.Add(this.stopButton);
            this.mainPanel.Controls.Add(this.opentPathButton);
            this.mainPanel.Controls.Add(this.findFileButton);
            this.mainPanel.Location = new System.Drawing.Point(12, 12);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(500, 260);
            this.mainPanel.TabIndex = 10;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // resultPanel
            // 
            this.resultPanel.Controls.Add(this.label4);
            this.resultPanel.Controls.Add(this.allFilesListBox);
            this.resultPanel.Controls.Add(this.filesFoundRichTextBox);
            this.resultPanel.Controls.Add(this.label3);
            this.resultPanel.Location = new System.Drawing.Point(530, 12);
            this.resultPanel.Name = "resultPanel";
            this.resultPanel.Size = new System.Drawing.Size(499, 268);
            this.resultPanel.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(15, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = " files list";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 285);
            this.Controls.Add(this.resultPanel);
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.ShowIcon = false;
            this.Text = "FileCount";
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.resultPanel.ResumeLayout(false);
            this.resultPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox filePathRichTextBox;
        private System.Windows.Forms.ComboBox fileExtensionComboBox;
        private System.Windows.Forms.Button opentPathButton;
        private System.Windows.Forms.Button findFileButton;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.ListBox allFilesListBox;
        private System.Windows.Forms.RichTextBox filesFoundRichTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel resultPanel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

