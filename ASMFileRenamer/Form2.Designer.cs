
namespace ASMFileRenamer
{
    partial class Form2
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
            this.dgvASMRenamed = new System.Windows.Forms.DataGridView();
            this.Enable = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.OriginalName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NewName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnOpenAsmXMLFile = new System.Windows.Forms.Button();
            this.btnSaveRenamingFile = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCurrentFile = new System.Windows.Forms.Label();
            this.tboxSearchBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClearNew = new System.Windows.Forms.Button();
            this.btnLoadASMFile = new System.Windows.Forms.Button();
            this.btnSaveRenamedASM = new System.Windows.Forms.Button();
            this.btnOpenLabelFile = new System.Windows.Forms.Button();
            this.cboxReverseColumns = new System.Windows.Forms.CheckBox();
            this.cboxIgnoreLabelStrings = new System.Windows.Forms.CheckBox();
            this.cboxIgnoreTblStrings = new System.Windows.Forms.CheckBox();
            this.cboxOnlyProcessLabe = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblProgress = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvASMRenamed)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvASMRenamed
            // 
            this.dgvASMRenamed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvASMRenamed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Enable,
            this.OriginalName,
            this.NewName});
            this.dgvASMRenamed.Location = new System.Drawing.Point(12, 75);
            this.dgvASMRenamed.Name = "dgvASMRenamed";
            this.dgvASMRenamed.Size = new System.Drawing.Size(713, 393);
            this.dgvASMRenamed.TabIndex = 0;
            // 
            // Enable
            // 
            this.Enable.HeaderText = "Enable";
            this.Enable.Name = "Enable";
            this.Enable.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Enable.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Enable.Width = 50;
            // 
            // OriginalName
            // 
            this.OriginalName.HeaderText = "OriginalName";
            this.OriginalName.Name = "OriginalName";
            this.OriginalName.Width = 200;
            // 
            // NewName
            // 
            this.NewName.HeaderText = "NewName";
            this.NewName.Name = "NewName";
            this.NewName.Width = 400;
            // 
            // btnOpenAsmXMLFile
            // 
            this.btnOpenAsmXMLFile.Location = new System.Drawing.Point(593, 476);
            this.btnOpenAsmXMLFile.Name = "btnOpenAsmXMLFile";
            this.btnOpenAsmXMLFile.Size = new System.Drawing.Size(132, 23);
            this.btnOpenAsmXMLFile.TabIndex = 1;
            this.btnOpenAsmXMLFile.Text = "Open XML Renaming File";
            this.btnOpenAsmXMLFile.UseVisualStyleBackColor = true;
            this.btnOpenAsmXMLFile.Click += new System.EventHandler(this.btnOpenAsmXMLFile_Click);
            // 
            // btnSaveRenamingFile
            // 
            this.btnSaveRenamingFile.Location = new System.Drawing.Point(593, 505);
            this.btnSaveRenamingFile.Name = "btnSaveRenamingFile";
            this.btnSaveRenamingFile.Size = new System.Drawing.Size(132, 23);
            this.btnSaveRenamingFile.TabIndex = 2;
            this.btnSaveRenamingFile.Text = "Save XML";
            this.btnSaveRenamingFile.UseVisualStyleBackColor = true;
            this.btnSaveRenamingFile.Click += new System.EventHandler(this.btnSaveRenamingFile_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Current File:";
            // 
            // labelCurrentFile
            // 
            this.labelCurrentFile.AutoSize = true;
            this.labelCurrentFile.Location = new System.Drawing.Point(122, 9);
            this.labelCurrentFile.Name = "labelCurrentFile";
            this.labelCurrentFile.Size = new System.Drawing.Size(0, 13);
            this.labelCurrentFile.TabIndex = 4;
            // 
            // tboxSearchBox
            // 
            this.tboxSearchBox.Location = new System.Drawing.Point(120, 39);
            this.tboxSearchBox.Name = "tboxSearchBox";
            this.tboxSearchBox.Size = new System.Drawing.Size(288, 20);
            this.tboxSearchBox.TabIndex = 5;
            this.tboxSearchBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tboxSearchBox_KeyUp);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(49, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Search:";
            // 
            // btnClearNew
            // 
            this.btnClearNew.Location = new System.Drawing.Point(650, 32);
            this.btnClearNew.Name = "btnClearNew";
            this.btnClearNew.Size = new System.Drawing.Size(75, 23);
            this.btnClearNew.TabIndex = 7;
            this.btnClearNew.Text = "Clear \\ New";
            this.btnClearNew.UseVisualStyleBackColor = true;
            this.btnClearNew.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnLoadASMFile
            // 
            this.btnLoadASMFile.Location = new System.Drawing.Point(593, 556);
            this.btnLoadASMFile.Name = "btnLoadASMFile";
            this.btnLoadASMFile.Size = new System.Drawing.Size(132, 23);
            this.btnLoadASMFile.TabIndex = 8;
            this.btnLoadASMFile.Text = "Load ASM File";
            this.btnLoadASMFile.UseVisualStyleBackColor = true;
            this.btnLoadASMFile.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSaveRenamedASM
            // 
            this.btnSaveRenamedASM.Location = new System.Drawing.Point(593, 584);
            this.btnSaveRenamedASM.Name = "btnSaveRenamedASM";
            this.btnSaveRenamedASM.Size = new System.Drawing.Size(132, 23);
            this.btnSaveRenamedASM.TabIndex = 9;
            this.btnSaveRenamedASM.Text = "Save Renamed ASM";
            this.btnSaveRenamedASM.UseVisualStyleBackColor = true;
            this.btnSaveRenamedASM.Click += new System.EventHandler(this.btnSaveRenamedASM_Click);
            // 
            // btnOpenLabelFile
            // 
            this.btnOpenLabelFile.Location = new System.Drawing.Point(8, 16);
            this.btnOpenLabelFile.Name = "btnOpenLabelFile";
            this.btnOpenLabelFile.Size = new System.Drawing.Size(137, 23);
            this.btnOpenLabelFile.TabIndex = 10;
            this.btnOpenLabelFile.Text = "Import asm662 label file";
            this.btnOpenLabelFile.UseVisualStyleBackColor = true;
            this.btnOpenLabelFile.Click += new System.EventHandler(this.btnOpenLabelFile_Click);
            // 
            // cboxReverseColumns
            // 
            this.cboxReverseColumns.AutoSize = true;
            this.cboxReverseColumns.Location = new System.Drawing.Point(8, 45);
            this.cboxReverseColumns.Name = "cboxReverseColumns";
            this.cboxReverseColumns.Size = new System.Drawing.Size(158, 17);
            this.cboxReverseColumns.TabIndex = 11;
            this.cboxReverseColumns.Text = "Reverse columns upon load";
            this.cboxReverseColumns.UseVisualStyleBackColor = true;
            this.cboxReverseColumns.CheckedChanged += new System.EventHandler(this.cboxReverseColumns_CheckedChanged);
            // 
            // cboxIgnoreLabelStrings
            // 
            this.cboxIgnoreLabelStrings.AutoSize = true;
            this.cboxIgnoreLabelStrings.Location = new System.Drawing.Point(172, 18);
            this.cboxIgnoreLabelStrings.Name = "cboxIgnoreLabelStrings";
            this.cboxIgnoreLabelStrings.Size = new System.Drawing.Size(227, 17);
            this.cboxIgnoreLabelStrings.TabIndex = 12;
            this.cboxIgnoreLabelStrings.Text = "Ignore \"labe\" NewName Strings upon load";
            this.cboxIgnoreLabelStrings.UseVisualStyleBackColor = true;
            // 
            // cboxIgnoreTblStrings
            // 
            this.cboxIgnoreTblStrings.AutoSize = true;
            this.cboxIgnoreTblStrings.Location = new System.Drawing.Point(172, 41);
            this.cboxIgnoreTblStrings.Name = "cboxIgnoreTblStrings";
            this.cboxIgnoreTblStrings.Size = new System.Drawing.Size(224, 17);
            this.cboxIgnoreTblStrings.TabIndex = 13;
            this.cboxIgnoreTblStrings.Text = "Ignore \"tbl_\" NewName Strings upon load";
            this.cboxIgnoreTblStrings.UseVisualStyleBackColor = true;
            // 
            // cboxOnlyProcessLabe
            // 
            this.cboxOnlyProcessLabe.AutoSize = true;
            this.cboxOnlyProcessLabe.Location = new System.Drawing.Point(172, 64);
            this.cboxOnlyProcessLabe.Name = "cboxOnlyProcessLabe";
            this.cboxOnlyProcessLabe.Size = new System.Drawing.Size(260, 17);
            this.cboxOnlyProcessLabe.TabIndex = 14;
            this.cboxOnlyProcessLabe.Text = "Only Process \"labe\" and \"tbl_\" NewName Strings";
            this.cboxOnlyProcessLabe.UseVisualStyleBackColor = true;
            this.cboxOnlyProcessLabe.CheckedChanged += new System.EventHandler(this.cboxOnlyProcessLabe_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(166, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "(Use when updating source ASM)";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(125, 568);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(288, 23);
            this.progressBar1.TabIndex = 16;
            // 
            // lblProgress
            // 
            this.lblProgress.AutoSize = true;
            this.lblProgress.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgress.Location = new System.Drawing.Point(47, 571);
            this.lblProgress.Name = "lblProgress";
            this.lblProgress.Size = new System.Drawing.Size(66, 16);
            this.lblProgress.TabIndex = 17;
            this.lblProgress.Text = "Progress:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cboxOnlyProcessLabe);
            this.groupBox1.Controls.Add(this.cboxIgnoreTblStrings);
            this.groupBox1.Controls.Add(this.cboxIgnoreLabelStrings);
            this.groupBox1.Controls.Add(this.cboxReverseColumns);
            this.groupBox1.Controls.Add(this.btnOpenLabelFile);
            this.groupBox1.Location = new System.Drawing.Point(12, 476);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(476, 83);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Import Labels";
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblProgress);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnSaveRenamedASM);
            this.Controls.Add(this.btnLoadASMFile);
            this.Controls.Add(this.btnClearNew);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tboxSearchBox);
            this.Controls.Add(this.labelCurrentFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSaveRenamingFile);
            this.Controls.Add(this.btnOpenAsmXMLFile);
            this.Controls.Add(this.dgvASMRenamed);
            this.Name = "Form2";
            this.Text = "ASM File Renamer v1.3";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvASMRenamed)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvASMRenamed;
        private System.Windows.Forms.Button btnOpenAsmXMLFile;
        private System.Windows.Forms.Button btnSaveRenamingFile;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCurrentFile;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Enable;
        private System.Windows.Forms.DataGridViewTextBoxColumn OriginalName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NewName;
        private System.Windows.Forms.TextBox tboxSearchBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnClearNew;
        private System.Windows.Forms.Button btnLoadASMFile;
        private System.Windows.Forms.Button btnSaveRenamedASM;
        private System.Windows.Forms.Button btnOpenLabelFile;
        private System.Windows.Forms.CheckBox cboxReverseColumns;
        private System.Windows.Forms.CheckBox cboxIgnoreLabelStrings;
        private System.Windows.Forms.CheckBox cboxIgnoreTblStrings;
        private System.Windows.Forms.CheckBox cboxOnlyProcessLabe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblProgress;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}