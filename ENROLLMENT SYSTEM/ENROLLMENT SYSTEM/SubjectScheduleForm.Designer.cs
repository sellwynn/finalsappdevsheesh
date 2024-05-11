namespace ENROLLMENT_SYSTEM
{
    partial class SubjectScheduleForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.EDPCodeTextBox = new System.Windows.Forms.TextBox();
            this.SubjectCodeTextBox = new System.Windows.Forms.TextBox();
            this.DescriptionLabel = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.StartTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ExitTimeDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.DaysTextBox = new System.Windows.Forms.TextBox();
            this.SectionTextBox = new System.Windows.Forms.TextBox();
            this.RoomTextBox = new System.Windows.Forms.TextBox();
            this.SchoolYearTextBox = new System.Windows.Forms.TextBox();
            this.AMPMComboBox = new System.Windows.Forms.ComboBox();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Ravie", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(75, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(631, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Subject Schedule Entry";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "EDP Code:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(54, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Subject Code:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(76, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Description:";
            // 
            // EDPCodeTextBox
            // 
            this.EDPCodeTextBox.Location = new System.Drawing.Point(150, 67);
            this.EDPCodeTextBox.Name = "EDPCodeTextBox";
            this.EDPCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.EDPCodeTextBox.TabIndex = 4;
            // 
            // SubjectCodeTextBox
            // 
            this.SubjectCodeTextBox.Location = new System.Drawing.Point(150, 98);
            this.SubjectCodeTextBox.Name = "SubjectCodeTextBox";
            this.SubjectCodeTextBox.Size = new System.Drawing.Size(100, 20);
            this.SubjectCodeTextBox.TabIndex = 5;
            this.SubjectCodeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SubjectCodeTextBox_KeyPress);
            // 
            // DescriptionLabel
            // 
            this.DescriptionLabel.BackColor = System.Drawing.Color.Coral;
            this.DescriptionLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DescriptionLabel.Location = new System.Drawing.Point(150, 130);
            this.DescriptionLabel.Name = "DescriptionLabel";
            this.DescriptionLabel.Size = new System.Drawing.Size(249, 26);
            this.DescriptionLabel.TabIndex = 6;

            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(64, 180);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Start Time:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Exit Time:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(88, 247);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "Days:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(76, 283);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(46, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Section:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(81, 317);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Room:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(51, 355);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 12;
            this.label11.Text = "School Year:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(383, 180);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(47, 13);
            this.label12.TabIndex = 13;
            this.label12.Text = "AM/PM:";
            // 
            // StartTimeDateTimePicker
            // 
            this.StartTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.StartTimeDateTimePicker.Location = new System.Drawing.Point(150, 173);
            this.StartTimeDateTimePicker.Name = "StartTimeDateTimePicker";
            this.StartTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StartTimeDateTimePicker.TabIndex = 14;
            // 
            // ExitTimeDateTimePicker
            // 
            this.ExitTimeDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.ExitTimeDateTimePicker.Location = new System.Drawing.Point(150, 208);
            this.ExitTimeDateTimePicker.Name = "ExitTimeDateTimePicker";
            this.ExitTimeDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.ExitTimeDateTimePicker.TabIndex = 15;
            // 
            // DaysTextBox
            // 
            this.DaysTextBox.Location = new System.Drawing.Point(150, 244);
            this.DaysTextBox.Name = "DaysTextBox";
            this.DaysTextBox.Size = new System.Drawing.Size(100, 20);
            this.DaysTextBox.TabIndex = 16;
            // 
            // SectionTextBox
            // 
            this.SectionTextBox.Location = new System.Drawing.Point(150, 280);
            this.SectionTextBox.Name = "SectionTextBox";
            this.SectionTextBox.Size = new System.Drawing.Size(100, 20);
            this.SectionTextBox.TabIndex = 17;
            // 
            // RoomTextBox
            // 
            this.RoomTextBox.Location = new System.Drawing.Point(150, 314);
            this.RoomTextBox.Name = "RoomTextBox";
            this.RoomTextBox.Size = new System.Drawing.Size(100, 20);
            this.RoomTextBox.TabIndex = 18;
            // 
            // SchoolYearTextBox
            // 
            this.SchoolYearTextBox.Location = new System.Drawing.Point(150, 352);
            this.SchoolYearTextBox.Name = "SchoolYearTextBox";
            this.SchoolYearTextBox.Size = new System.Drawing.Size(100, 20);
            this.SchoolYearTextBox.TabIndex = 19;
            // 
            // AMPMComboBox
            // 
            this.AMPMComboBox.FormattingEnabled = true;
            this.AMPMComboBox.Items.AddRange(new object[] {
            "AM",
            "PM"});
            this.AMPMComboBox.Location = new System.Drawing.Point(436, 176);
            this.AMPMComboBox.Name = "AMPMComboBox";
            this.AMPMComboBox.Size = new System.Drawing.Size(121, 21);
            this.AMPMComboBox.TabIndex = 20;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(480, 285);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 21;
            this.SaveButton.Text = "Save";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SubjectScheduleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AMPMComboBox);
            this.Controls.Add(this.SchoolYearTextBox);
            this.Controls.Add(this.RoomTextBox);
            this.Controls.Add(this.SectionTextBox);
            this.Controls.Add(this.DaysTextBox);
            this.Controls.Add(this.ExitTimeDateTimePicker);
            this.Controls.Add(this.StartTimeDateTimePicker);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.DescriptionLabel);
            this.Controls.Add(this.SubjectCodeTextBox);
            this.Controls.Add(this.EDPCodeTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SubjectScheduleForm";
            this.Text = "SubjectScheduleForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox EDPCodeTextBox;
        private System.Windows.Forms.TextBox SubjectCodeTextBox;
        private System.Windows.Forms.Label DescriptionLabel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker StartTimeDateTimePicker;
        private System.Windows.Forms.DateTimePicker ExitTimeDateTimePicker;
        private System.Windows.Forms.TextBox DaysTextBox;
        private System.Windows.Forms.TextBox SectionTextBox;
        private System.Windows.Forms.TextBox RoomTextBox;
        private System.Windows.Forms.TextBox SchoolYearTextBox;
        private System.Windows.Forms.ComboBox AMPMComboBox;
        private System.Windows.Forms.Button SaveButton;
    }
}