using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Diagnostics.PerformanceData;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ENROLLMENT_SYSTEM
{
    public partial class EnrollmentEntry : Form
    {
        //pls kog change..
        //string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\arjay\Documents\Github\finalsappdevsheesh\PAMAYBAY.accdb";
        string connectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source = \\Server2\second semester 2023-2024\LAB802\79286_CC_APPSDEV22_1030_1230_PM_MW\79286-23222490\Desktop\FINAL FINALLY\finalsappdevsheesh-main\PAMAYBAY.accdb";
        int totalunits = 0;
        public EnrollmentEntry()
        {
            InitializeComponent();
            CenterToScreen();
        }

        private void IDNumberTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string sql = "SELECT * FROM STUDENTFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;
                string name = "";
                string course = "";
                int year = 0;

                while (thisDataReader.Read())
                {
                    if (thisDataReader["STFSTUDID"].ToString().Trim().ToUpper() == IDNumberTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        name = thisDataReader["STFSTUDLNAME"].ToString().ToUpper() + ", " + thisDataReader["STFSTUDFNAME"].ToString().ToUpper() + " " + thisDataReader["STFSTUDMNAME"].ToString().ToUpper().Substring(0, 1);
                        course = thisDataReader["STFSTUDCOURSE"].ToString().ToUpper();
                        year = Convert.ToInt16(thisDataReader["STFSTUDYEAR"]);
                        break;
                    }

                }
                if (found == false)
                    MessageBox.Show("Student ID Not Found");
                else
                {
                    NameLabel.Text = name;
                    CourseLabel.Text = course;
                    YearLabel.Text = year.ToString();
                }
            }
        }

        private void EDPCodeTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                thisConnection.Open();
                OleDbCommand thisCommand = thisConnection.CreateCommand();
                string sql = "SELECT * FROM SUBJECTSCHEDULEFILE";
                thisCommand.CommandText = sql;

                OleDbDataReader thisDataReader = thisCommand.ExecuteReader();

                bool found = false;
                int edpcode = 0;
                string subjectcode = "";
                string starttime = "";
                string endtime = "";
                string days = "";
                string room = "";
                int units = 0;

                while (thisDataReader.Read())
                {
                    if (thisDataReader["SSFEDPCODE"].ToString().Trim().ToUpper() == EDPCodeTextBox.Text.Trim().ToUpper())
                    {
                        found = true;
                        edpcode = Convert.ToInt32(thisDataReader["SSFEDPCODE"]);
                        subjectcode = thisDataReader["SSFSUBJCODE"].ToString().ToUpper();
                        starttime = thisDataReader["SSFSTARTTIME"].ToString();
                        endtime = thisDataReader["SSFENDTIME"].ToString();
                        days = thisDataReader["SSFDAYS"].ToString().ToUpper();
                        room = thisDataReader["SSFROOM"].ToString();

                        thisConnection = new OleDbConnection(connectionString);
                        thisConnection.Open();
                        thisCommand = thisConnection.CreateCommand();
                        sql = "SELECT * FROM SUBJECTFILE";
                        thisCommand.CommandText = sql;

                        thisDataReader = thisCommand.ExecuteReader();
                        while (thisDataReader.Read())
                        {
                            if (thisDataReader["SFSSUBJCODE"].ToString().Trim().ToUpper() == subjectcode.Trim().ToUpper())
                            {
                                units = Convert.ToInt16(thisDataReader["SFSSUBJUNITS"]);
                            }
                        }

                        break;
                    }

                }
                if (found == false)
                    MessageBox.Show("Subject Not Found");
                else
                {
                    SummaryDataGridView.Rows.Add();

                    int count = SummaryDataGridView.Rows.Count;

                    for(int i = 0; i < count; i++)
                    {
                        if (SummaryDataGridView.Rows[i].Cells[0].Value == null)
                        {
                            totalunits += units;
                            UnitsLabel.Text = "Units: " + totalunits;
                            SummaryDataGridView.Rows[i].Cells[0].Value = edpcode;
                            SummaryDataGridView.Rows[i].Cells[1].Value = subjectcode;
                            SummaryDataGridView.Rows[i].Cells[2].Value = starttime;
                            SummaryDataGridView.Rows[i].Cells[3].Value = endtime;
                            SummaryDataGridView.Rows[i].Cells[4].Value = days;
                            SummaryDataGridView.Rows[i].Cells[5].Value = room;
                            SummaryDataGridView.Rows[i].Cells[6].Value = units;
                            break;
                        }
                    }
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(IDNumberTextBox.Text != string.Empty)
            {
                OleDbConnection thisConnection = new OleDbConnection(connectionString);
                string Ole = "Select * From ENROLLMENTHEADERFILE";
                OleDbDataAdapter thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
                OleDbCommandBuilder thisBuilder = new OleDbCommandBuilder(thisAdapter);
                DataSet thisDataSet = new DataSet();
                thisAdapter.Fill(thisDataSet, "EnrollmentHeaderFile");

                DataRow thisRow = thisDataSet.Tables["EnrollmentHeaderFile"].NewRow();

                thisRow["ENRHFSTUDID"] = IDNumberTextBox.Text;
                thisRow["ENRHFSTUDDATEENROLL"] = DateTime.Now;
                thisRow["ENRHFSTUDSCHLYR"] = 2024;
                thisRow["ENRHFSTUDENCODER"] = "Pamaybay";
                thisRow["ENRHFSTUDTOTALUNITS"] = totalunits;
                thisRow["ENRHFSTUDSTATUS"] = "EN";

                thisDataSet.Tables["EnrollmentHeaderFile"].Rows.Add(thisRow);
                thisAdapter.Update(thisDataSet, "EnrollmentHeaderFile");

                for(int i = 0; i < SummaryDataGridView.Rows.Count - 1; i++)
                {
                    thisConnection = new OleDbConnection(connectionString);
                    Ole = "Select * From ENROLLMENTDETAILFILE";
                    thisAdapter = new OleDbDataAdapter(Ole, thisConnection);
                    thisBuilder = new OleDbCommandBuilder(thisAdapter);
                    thisDataSet = new DataSet();
                    thisAdapter.Fill(thisDataSet, "EnrollmentDetailFile");

                    thisRow = thisDataSet.Tables["EnrollmentDetailFile"].NewRow();

                    thisRow["ENRDFSTUDID"] = IDNumberTextBox.Text;
                    thisRow["ENRDFSTUDSUBJCDE"] = SummaryDataGridView.Rows[i].Cells[1].Value;
                    thisRow["ENRDFSTUDEDPCODE"] = SummaryDataGridView.Rows[i].Cells[0].Value;

                    thisDataSet.Tables["EnrollmentDetailFile"].Rows.Add(thisRow);
                    thisAdapter.Update(thisDataSet, "EnrollmentDetailFile");
                }

                MessageBox.Show("Enrolled.");
            }
            else
            {
                MessageBox.Show("ID Number is empty.");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            Menu mainMenu = new Menu();
            mainMenu.Show();
            this.Hide();
        }
    }
}
