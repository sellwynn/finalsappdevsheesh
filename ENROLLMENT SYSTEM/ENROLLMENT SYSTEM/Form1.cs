using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENROLLMENT_SYSTEM
{
    public partial class Form1 : Form
    {
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=\\Server2\second semester 2023-2024\LAB802\79286_CC_APPSDEV22_1030_1230_PM_MW\79286-23222490\Desktop\FINAL\PAMAYBAY.accdb";
        public Form1()
        {
            InitializeComponent();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            OleDbConnection thisConnection = new OleDbConnection(connectionString);
            string Ole = "Select * From SUBJECTFILE";
            OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
            OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
            DataSet thisDataSet = new DataSet();
            thisAdapter.Fill(thisDataSet, "SubjectFile");

            DataRow thisRow = thisDataSet.Tables["SubjectFile"].NewRow ();
            thisRow["SFSSUBJCODE"] = SubjectCodeTextBox.Text;
            thisRow["SFSSUBJDESC"] = DescriptionTextBox.Text;
            thisRow["SFSSUBJUNITS"] = UnitsTextBox.Text;
            thisRow["SFSSUBJREGOFRNG"] = OfferingComboBox.Text.Substring(0, 1);
            thisRow["SFSSUBJCATEGORY"] = CategoryComboBox.Text.Substring(0, 3);
            thisRow["SFSSUBJSTATUS"] = "AC";
            thisRow["SFSSUBJCOURSECODE"] = CourseCodeComboBox.Text.Substring(0, 1);
            thisRow["SFSSUBJCURRCODE"] =CurriculumYearTextBox.Text;

            thisDataSet.Tables["SubjectFile"].Rows.Add (thisRow);
            thisAdapter.Update(thisDataSet, "SubjectFile");

            MessageBox.Show("Recorded");

        }

        private void SubjectCodeRequisiteTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand ();
                string sql = "SELECT * FROM SUBJECTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;
                string subjectCode = "";
                string description = "";
                string units = "";

                while (thisDataReader.Read()) 
                {
                    //MessageBox.Show(thisDataReader["SFSSUBJCODE"].ToString());
                    if (thisDataReader["SFSSUBJCODE"].ToString().Trim().ToUpper() == SubjectCodeRequisiteTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        subjectCode = thisDataReader["SFSSUBJCODE"].ToString();
                        description = thisDataReader["SFSSUBJDESC"].ToString();
                        units = thisDataReader["SFSSUBJUNITS"].ToString ();
                        break;
                    
                    }
                    
                }if (found == false)
                    MessageBox.Show("Subject Code Not Found");
                else 
                {
                    SubjectDataGridView.Rows[0].Cells[0].Value = subjectCode;
                    SubjectDataGridView.Rows[0].Cells[1].Value = description;
                    SubjectDataGridView.Rows[0].Cells[2].Value = units;

                }

            }
        }


    }
}
