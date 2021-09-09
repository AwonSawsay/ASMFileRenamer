using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace ASMFileRenamer
{
       
    
    public partial class Form2 : Form
    {

        public Form2()
        {
            
            InitializeComponent();
            cboxIgnoreLabelStrings.Checked = true;
            cboxIgnoreTblStrings.Checked = true;
            cboxOnlyProcessLabe.Checked = false;
            cboxReverseColumns.Checked = false;
            progressBar1.Visible = false;
            lblProgress.Visible = false;
            

        }
//        string OpenedXMLFile;
        DataSet dataset1 = new DataSet();
        DataView dv = new DataView();
        bool FirstRun = true;
        string XMLPath;

        private void MakeDataSet()
        {
            dataset1.ReadXml(XMLPath);
            dgvASMRenamed.AutoGenerateColumns = false;
            if (cboxReverseColumns.Checked)
            {
                dgvASMRenamed.Columns[0].DataPropertyName = "Enable";
                dgvASMRenamed.Columns[2].DataPropertyName = "OriginalName";
                dgvASMRenamed.Columns[1].DataPropertyName = "NewName";
            }
            else
            {
                dgvASMRenamed.Columns[0].DataPropertyName = "Enable";
                dgvASMRenamed.Columns[1].DataPropertyName = "OriginalName";
                dgvASMRenamed.Columns[2].DataPropertyName = "NewName";
            }

            dv.Table = dataset1.Tables[0];
            dgvASMRenamed.DataSource = dv;
        }
        OpenFileDialog OPENAsmRenamingFile = new OpenFileDialog();
        private void ClearDataSetAndTable()
        {
            dgvASMRenamed.DataSource = null;
            dgvASMRenamed.Rows.Clear();
            tboxSearchBox.Text = "";
            dv.RowFilter = null;
            if (dv.Table != null)
            {
                dv.Table.Clear();
                this.dgvASMRenamed.DataSource = null;
                dgvASMRenamed.Rows.Clear();
            }
        }
        
        private void btnOpenAsmXMLFile_Click(object sender, EventArgs e)
        {
           
            OPENAsmRenamingFile.Filter = "XML Files | *.xml";
            if (OPENAsmRenamingFile.ShowDialog() == DialogResult.OK)
            {
                XMLPath = OPENAsmRenamingFile.FileName;
                ClearDataSetAndTable();

                //OpenedXMLFile = OPENAsmRenamingFile.FileName;

                try
                {
                    labelCurrentFile.Text = OPENAsmRenamingFile.FileName;
                    MakeDataSet();
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
        }


        DataTable DT = new DataTable();
        private DataTable GetDataTableFromDGV(DataGridView dgv)
        {

            int j = 0;
            foreach(DataGridViewColumn col in dgv.Columns)
            {
                if (col.Visible)
                {
                    string headerText = dgv.Columns[j].HeaderText;
                    headerText = System.Text.RegularExpressions.Regex.Replace(headerText, "[-/, ]", "_");
                    if (FirstRun)
                    {
                        DataColumn column = new DataColumn(headerText);
                        DT.Columns.Add(column);
                    }

                    j++;
                }
            }

            object[] cellValues = new object[dgv.Columns.Count];
            foreach(DataGridViewRow row in dgv.Rows)
            {
                for(int i = 0; i < row.Cells.Count; i++)
                {
                    cellValues[i] = row.Cells[i].Value;
                }
                DT.Rows.Add(cellValues);
            }
            FirstRun = false;
            return DT;
        }

        SaveFileDialog SaveAsmRenamingFile = new SaveFileDialog();
        DataSet DS = new DataSet();
        private void btnSaveRenamingFile_Click(object sender, EventArgs e)
        {
                SaveAsmRenamingFile.Filter = "XML Files | *.xml";
                if (SaveAsmRenamingFile.ShowDialog() == DialogResult.OK)
                {
                labelCurrentFile.Text = SaveAsmRenamingFile.FileName;
                //OpenedXMLFile = SaveAsmRenamingFile.FileName;
                XMLPath = SaveAsmRenamingFile.FileName;
                tboxSearchBox.Text = "";
                dv.RowFilter = null;
                DT.Clear();
                DT = GetDataTableFromDGV(dgvASMRenamed);
                if (DS.Tables.CanRemove(DT))
                {
                    DS.Tables.Remove(DT);
                }
                DS.Clear();
                DS.Tables.Add(DT);
                
               
                              
                // Create the FileStream to write with.
                System.IO.FileStream stream = new System.IO.FileStream
                    //(OpenedXMLFile, System.IO.FileMode.Create);
                    (XMLPath, System.IO.FileMode.Create);

                // Create an XmlTextWriter with the fileStream.
                System.Xml.XmlTextWriter xmlWriter =
                    new System.Xml.XmlTextWriter(stream,
                    System.Text.Encoding.Unicode);

                // Write to the file with the WriteXml method.
                DS.WriteXml(xmlWriter);
                xmlWriter.Close();

                }
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void tboxSearchBox_KeyUp(object sender, KeyEventArgs e)
        {
            dv.RowFilter = "OriginalName Like '%" + tboxSearchBox.Text + "%' OR NewName Like '%" + tboxSearchBox.Text + "%'";
            this.dgvASMRenamed.DataSource = dv;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dv.Table != null)
            {
                dv.Table.Clear();
                this.dgvASMRenamed.DataSource = null;
                dgvASMRenamed.Rows.Clear();
            }
            labelCurrentFile.Text = "";
            //OpenedXMLFile = null;
            XMLPath = null;
            tboxSearchBox.Text = "";
            dv.RowFilter = null;
            DT.Clear();
            DT = GetDataTableFromDGV(dgvASMRenamed);
            if (DS.Tables.CanRemove(DT))
            {
                DS.Tables.Remove(DT);
            }
            DS.Clear();
            DS.Tables.Add(DT);
        }
        
        
        OpenFileDialog OPENAsmDialog = new OpenFileDialog();
        string CurrentASMPath;
        string ASMSimpleName;
        bool ASMOpened = false;
        private void button2_Click(object sender, EventArgs e)
        {
            OPENAsmDialog.Filter = "ASM Files | *.asm";
            if (OPENAsmDialog.ShowDialog() == DialogResult.OK)
            {
                CurrentASMPath = OPENAsmDialog.FileName;
                LoadASMFileIntoStringArray();
                ASMSimpleName = OPENAsmDialog.SafeFileName;
                ASMOpened = true;
            }
        }

        string[] ASMFileArray;
        string[] RenamedASMFileArray;
        private void LoadASMFileIntoStringArray()
        {
            ASMFileArray = System.IO.File.ReadAllLines(CurrentASMPath);
        }

        //StreamWriter objStreamWriter;
        private void btnSaveRenamedASM_Click(object sender, EventArgs e)
        {
           
            
            
            if (ASMOpened)
            {
                try
                {
                    progressBar1.Visible = true;
                    lblProgress.Visible = true;
                    lblProgress.Refresh();

                    RenamedASMFileArray = System.IO.File.ReadAllLines(CurrentASMPath);
                    ASMFileArray = System.IO.File.ReadAllLines(CurrentASMPath);
                    ReadXMLFileIntoDataset();
                   // MessageBox.Show("The renamed file will be saved as RENAMED_" + ASMSimpleName);
                    RenameUsingValuesFromXML(ASMFileArray, RenamedASMFileArray);
                  
                    string RenamedAsmName = System.IO.Path.GetDirectoryName(CurrentASMPath) + "\\" + "RENAMED_" + ASMSimpleName;
                    using (StreamWriter outputfile = new StreamWriter(RenamedAsmName))
                    {
                        foreach (string line in RenamedASMFileArray)
                        
                            outputfile.WriteLine(line);
                            
                        

                    }
                    
                    MessageBox.Show("File saved as RENAMED_" + ASMSimpleName);

                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message);
                }
            }
            else
            {
                MessageBox.Show("Open an ASM file that you would like to rename first.");
            }
            progressBar1.Visible = false;
            lblProgress.Visible = false;

        }
        private void ReadXMLFileIntoDataset()
        {
            try
            {
                dataset1.Clear();
                // dataset1.ReadXml(OPENAsmRenamingFile.FileName);
                dataset1.ReadXml(XMLPath);
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }
        private void RenameUsingValuesFromXML(string[] OrigArray, string[] NewArray, bool RestoreToOriginalValue = false)
        {
            
            progressBar1.Minimum = 1;
            //progressBar1.Maximum = dataset1.Tables[0].Rows.Count * 2;
            progressBar1.Value = 1;
            progressBar1.Step = 1;
            progressBar1.Maximum = OrigArray.Length;

            for (int index = 0; index < OrigArray.Length; index++)
            {
               
                foreach (DataTable table in dataset1.Tables)
                {
                    foreach (DataRow dr in table.Rows)
                    {
                       

                        if (Convert.ToString(dr[0]) == "True")
                        //if (Convert.ToBoolean(dr[0]))
                        {
                            string searchString = Convert.ToString(dr[2]);
                            
                            if (OrigArray[index].Contains(searchString) )
                            {
                                NewArray[index] = CaseSenstiveReplace(NewArray[index], searchString, Convert.ToString(dr[1]));
                            }
                               
                            
                        }
                      

                    }
                }
                progressBar1.PerformStep();
            }


        }
        public string CaseSenstiveReplace(string originalString, string oldValue, string newValue)
        {
            if (oldValue != "")
            {
                return originalString.Replace(oldValue, newValue);
            }
            else
            {
                return originalString;
            }
        }
        OpenFileDialog OPENLabelFile = new OpenFileDialog();
        string OpenedTXTFile;
        string[] OpenTXTFileArray;
        string[] ModifiedTxtArray;
        string XMLHeader = "<NewDataSet>";
        string XMLFooter = "</NewDataSet>";
        string XMLStringPart1 = "<Table1><Enable>True</Enable><OriginalName>";
        string XMLStringPart2 = "</OriginalName><NewName>";
        string XMLStringPart3 = "</NewName></Table1>";
        string TrimmedString;
        String XMLLabelOutput;
        String XMLTblOutput;
        List<string> XMLStringArray = new List<string>();
        bool SkipThisString;
        string strNewNameStringPrefix;




        private void btnOpenLabelFile_Click(object sender, EventArgs e)
        {

           
                OPENLabelFile.Filter = "TXT Files | *.txt";
                if (OPENLabelFile.ShowDialog() == DialogResult.OK)
                {


                OpenedTXTFile = OPENLabelFile.FileName;
                OpenTXTFileArray = System.IO.File.ReadAllLines(OpenedTXTFile);
                int i = 0;
                foreach (string s in OpenTXTFileArray)
                {
                    //Remove whitespace from string
                    string strNoWhitespace = new string(s.ToCharArray()
                    .Where(c => !Char.IsWhiteSpace(c))
                    .ToArray());
                    OpenTXTFileArray[i] = strNoWhitespace;
                   
                    //Remove char after // 
                int index = 0;
                index = OpenTXTFileArray[i].IndexOf("//");
                    if(index >= 0)
                    {
                        TrimmedString = OpenTXTFileArray[i].Substring(0, index);
                    }
                else
                    {
                        TrimmedString = OpenTXTFileArray[i];
                    }

                    string[] SplitArray = TrimmedString.Split('=');
                   
                    if (SplitArray.Length >1 && SplitArray[1].Length > 5)
                    {
                        string strHexAddress = SplitArray[1].Substring(2, 4);
                        if (SplitArray[0].Length > 4)
                        {
                            strNewNameStringPrefix = SplitArray[0].Substring(0, 4);
                        }
                        
                        strNewNameStringPrefix = strNewNameStringPrefix.ToLower();
                        SkipThisString = false;
                        if(strNewNameStringPrefix == "labe" && cboxIgnoreLabelStrings.Checked)
                        {
                           SkipThisString = true;
                        }
                        if (strNewNameStringPrefix == "tbl_" && cboxIgnoreTblStrings.Checked)
                        {
                            SkipThisString = true;
                        }
                        if (cboxOnlyProcessLabe.Checked)
                        {
                            if(strNewNameStringPrefix == "labe" || strNewNameStringPrefix == "tbl_")
                            {
                                SkipThisString = false;
                            }
                            else
                            {
                                SkipThisString = true;
                            }
                            
                        }

                        SplitArray[1] = strHexAddress.ToLower();
                    }
                    
                    try
                    {
                        XMLLabelOutput = "";
                        XMLTblOutput = "";
                        if (cboxOnlyProcessLabe.Checked)
                        {
                            if(strNewNameStringPrefix == "labe")
                            {
                                XMLLabelOutput = XMLStringPart1 + "label_" + SplitArray[1] + XMLStringPart2 + SplitArray[0] + XMLStringPart3;
                            }
                            if(strNewNameStringPrefix == "tbl_")
                            {
                                XMLTblOutput = XMLStringPart1 + "tbl_" + SplitArray[1] + XMLStringPart2 + SplitArray[0] + XMLStringPart3;
                            }
                        }
                        else
                        {
                            XMLLabelOutput = XMLStringPart1 + "label_" + SplitArray[1] + XMLStringPart2 + SplitArray[0] + XMLStringPart3;
                            if (strNewNameStringPrefix != "labe")
                            {
                                XMLTblOutput = XMLStringPart1 + "tbl_" + SplitArray[1] + XMLStringPart2 + SplitArray[0] + XMLStringPart3;
                            }
                        }
                        
                        
                    }
                    catch
                    {

                    }
                    if(i == 0)
                    {
                        XMLStringArray.Clear();
                        XMLStringArray.Add(XMLHeader);
                    }
                    if(i == OpenTXTFileArray.Length - 3)
                    {
                        XMLStringArray.Add(XMLFooter);
                        break;
                    }
                    else
                    {

                        if(XMLLabelOutput != null && SkipThisString != true)
                        {
                            XMLStringArray.Add(XMLLabelOutput);
                        }
                       if(XMLTblOutput != null && SkipThisString != true)
                        {
                            XMLStringArray.Add(XMLTblOutput);
                        }
                       
                    }

    


                i++;
                }

                XMLPath = System.IO.Path.GetDirectoryName(OpenedTXTFile) + "\\" + "tempxml.xml";
                using (StreamWriter outputfile = new StreamWriter(XMLPath))
                {
                    foreach (string line in XMLStringArray)
                        outputfile.WriteLine(line);
                }



                try
                    {
                    labelCurrentFile.Text = XMLPath;
                    ClearDataSetAndTable();
                        
                    MakeDataSet();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show(error.Message);
                    }
                }
            
        }

        private void cboxOnlyProcessLabe_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxOnlyProcessLabe.Checked)
            {
                cboxIgnoreLabelStrings.Checked = false;
                cboxIgnoreTblStrings.Checked = false;
            }
        }

        private void cboxReverseColumns_CheckedChanged(object sender, EventArgs e)
        {
            if (cboxReverseColumns.Checked)
            {
                cboxIgnoreTblStrings.Checked = false;
                cboxIgnoreLabelStrings.Checked = false;
                cboxOnlyProcessLabe.Checked = true;
            }
            else
            {
                cboxIgnoreTblStrings.Checked = true;
                cboxIgnoreLabelStrings.Checked = true;
                cboxOnlyProcessLabe.Checked = false;
            }
            
        }
    }
}
