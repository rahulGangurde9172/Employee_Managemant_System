namespace Employee_Managemant_System
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            headerpanel = new Panel();
            exitbtn = new Button();
            label1 = new Label();
            label2 = new Label();
            empIDtxt = new TextBox();
            empNametxt = new TextBox();
            label3 = new Label();
            empEmailtxt = new TextBox();
            label4 = new Label();
            roleBox = new ComboBox();
            label5 = new Label();
            empSaltxt = new TextBox();
            label6 = new Label();
            empHiredatetxt = new DateTimePicker();
            label7 = new Label();
            Addbtn = new Button();
            updatebtn = new Button();
            deletebtn = new Button();
            Error = new Label();
            empDATAGrid = new DataGridView();
            panel1 = new Panel();
            label8 = new Label();
            searchBox = new ComboBox();
            dataSearchbtn = new Button();
            label9 = new Label();
            totalemployees = new Label();
            headerpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)empDATAGrid).BeginInit();
            SuspendLayout();
            // 
            // headerpanel
            // 
            headerpanel.BackColor = Color.Crimson;
            headerpanel.Controls.Add(exitbtn);
            headerpanel.Controls.Add(label1);
            headerpanel.Dock = DockStyle.Top;
            headerpanel.Location = new Point(0, 0);
            headerpanel.Name = "headerpanel";
            headerpanel.Size = new Size(1248, 91);
            headerpanel.TabIndex = 0;
            // 
            // exitbtn
            // 
            exitbtn.BackColor = Color.Maroon;
            exitbtn.Cursor = Cursors.Hand;
            exitbtn.FlatAppearance.BorderSize = 0;
            exitbtn.FlatStyle = FlatStyle.Flat;
            exitbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            exitbtn.ForeColor = Color.White;
            exitbtn.Location = new Point(1198, 0);
            exitbtn.Name = "exitbtn";
            exitbtn.Size = new Size(50, 50);
            exitbtn.TabIndex = 16;
            exitbtn.Text = "X";
            exitbtn.UseVisualStyleBackColor = false;
            exitbtn.Click += exitbtn_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(359, 15);
            label1.Name = "label1";
            label1.Size = new Size(567, 50);
            label1.TabIndex = 1;
            label1.Text = "Employee Manegement System";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(68, 199);
            label2.Name = "label2";
            label2.Size = new Size(142, 28);
            label2.TabIndex = 1;
            label2.Text = "Employee ID :";
            // 
            // empIDtxt
            // 
            empIDtxt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            empIDtxt.Location = new Point(216, 193);
            empIDtxt.Multiline = true;
            empIDtxt.Name = "empIDtxt";
            empIDtxt.Size = new Size(174, 34);
            empIDtxt.TabIndex = 2;
            // 
            // empNametxt
            // 
            empNametxt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            empNametxt.Location = new Point(251, 253);
            empNametxt.Multiline = true;
            empNametxt.Name = "empNametxt";
            empNametxt.Size = new Size(174, 34);
            empNametxt.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(68, 259);
            label3.Name = "label3";
            label3.Size = new Size(177, 28);
            label3.TabIndex = 3;
            label3.Text = "Employee Name :";
            // 
            // empEmailtxt
            // 
            empEmailtxt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            empEmailtxt.Location = new Point(251, 451);
            empEmailtxt.Multiline = true;
            empEmailtxt.Name = "empEmailtxt";
            empEmailtxt.Size = new Size(174, 34);
            empEmailtxt.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(68, 457);
            label4.Name = "label4";
            label4.Size = new Size(173, 28);
            label4.TabIndex = 5;
            label4.Text = "Employee Email :";
            // 
            // roleBox
            // 
            roleBox.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            roleBox.FormattingEnabled = true;
            roleBox.Items.AddRange(new object[] { "HR", "Maneger", "Acountant", "Seller" });
            roleBox.Location = new Point(247, 315);
            roleBox.Name = "roleBox";
            roleBox.Size = new Size(174, 33);
            roleBox.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(68, 315);
            label5.Name = "label5";
            label5.Size = new Size(163, 28);
            label5.TabIndex = 8;
            label5.Text = "Employee Role :";
            // 
            // empSaltxt
            // 
            empSaltxt.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            empSaltxt.Location = new Point(251, 387);
            empSaltxt.Multiline = true;
            empSaltxt.Name = "empSaltxt";
            empSaltxt.Size = new Size(174, 34);
            empSaltxt.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(68, 393);
            label6.Name = "label6";
            label6.Size = new Size(180, 28);
            label6.TabIndex = 9;
            label6.Text = "Employee Salary :";
            // 
            // empHiredatetxt
            // 
            empHiredatetxt.Format = DateTimePickerFormat.Short;
            empHiredatetxt.Location = new Point(278, 511);
            empHiredatetxt.MaxDate = new DateTime(2024, 12, 13, 0, 0, 0, 0);
            empHiredatetxt.MinDate = new DateTime(2000, 1, 1, 0, 0, 0, 0);
            empHiredatetxt.Name = "empHiredatetxt";
            empHiredatetxt.Size = new Size(147, 27);
            empHiredatetxt.TabIndex = 11;
            empHiredatetxt.Value = new DateTime(2024, 12, 13, 0, 0, 0, 0);
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(72, 514);
            label7.Name = "label7";
            label7.Size = new Size(206, 28);
            label7.TabIndex = 12;
            label7.Text = "Employee HireDate :";
            // 
            // Addbtn
            // 
            Addbtn.BackColor = Color.Crimson;
            Addbtn.Cursor = Cursors.Hand;
            Addbtn.FlatAppearance.BorderSize = 0;
            Addbtn.FlatStyle = FlatStyle.Flat;
            Addbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Addbtn.ForeColor = Color.White;
            Addbtn.Location = new Point(22, 595);
            Addbtn.Name = "Addbtn";
            Addbtn.Size = new Size(138, 49);
            Addbtn.TabIndex = 13;
            Addbtn.Text = "Add";
            Addbtn.UseVisualStyleBackColor = false;
            Addbtn.Click += Addbtn_Click;
            // 
            // updatebtn
            // 
            updatebtn.BackColor = Color.Crimson;
            updatebtn.Cursor = Cursors.Hand;
            updatebtn.FlatAppearance.BorderSize = 0;
            updatebtn.FlatStyle = FlatStyle.Flat;
            updatebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            updatebtn.ForeColor = Color.White;
            updatebtn.Location = new Point(205, 595);
            updatebtn.Name = "updatebtn";
            updatebtn.Size = new Size(138, 49);
            updatebtn.TabIndex = 14;
            updatebtn.Text = "Update";
            updatebtn.UseVisualStyleBackColor = false;
            updatebtn.Click += updatebtn_Click;
            // 
            // deletebtn
            // 
            deletebtn.BackColor = Color.Crimson;
            deletebtn.Cursor = Cursors.Hand;
            deletebtn.FlatAppearance.BorderSize = 0;
            deletebtn.FlatStyle = FlatStyle.Flat;
            deletebtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            deletebtn.ForeColor = Color.White;
            deletebtn.Location = new Point(385, 595);
            deletebtn.Name = "deletebtn";
            deletebtn.Size = new Size(138, 49);
            deletebtn.TabIndex = 15;
            deletebtn.Text = "Delete";
            deletebtn.UseVisualStyleBackColor = false;
            deletebtn.Click += deletebtn_Click;
            // 
            // Error
            // 
            Error.AutoSize = true;
            Error.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point);
            Error.ForeColor = Color.Crimson;
            Error.Location = new Point(224, 228);
            Error.Name = "Error";
            Error.Size = new Size(38, 17);
            Error.TabIndex = 16;
            Error.Text = "error";
            Error.Visible = false;
            // 
            // empDATAGrid
            // 
            empDATAGrid.AllowUserToAddRows = false;
            empDATAGrid.AllowUserToDeleteRows = false;
            empDATAGrid.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.Crimson;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            empDATAGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            empDATAGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            empDATAGrid.Location = new Point(569, 172);
            empDATAGrid.Name = "empDATAGrid";
            empDATAGrid.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.Crimson;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            empDATAGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            empDATAGrid.RowHeadersWidth = 51;
            empDATAGrid.RowTemplate.Height = 29;
            empDATAGrid.Size = new Size(651, 406);
            empDATAGrid.TabIndex = 17;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Crimson;
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 736);
            panel1.Name = "panel1";
            panel1.Size = new Size(1248, 31);
            panel1.TabIndex = 18;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(581, 132);
            label8.Name = "label8";
            label8.Size = new Size(103, 25);
            label8.TabIndex = 19;
            label8.Text = "Search By ";
            // 
            // searchBox
            // 
            searchBox.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            searchBox.FormattingEnabled = true;
            searchBox.Items.AddRange(new object[] { "All Employees", "HR", "Maneger", "Acountant", "Seller" });
            searchBox.Location = new Point(690, 129);
            searchBox.Name = "searchBox";
            searchBox.Size = new Size(246, 31);
            searchBox.TabIndex = 20;
            searchBox.Text = "select";
            // 
            // dataSearchbtn
            // 
            dataSearchbtn.BackColor = Color.Crimson;
            dataSearchbtn.Cursor = Cursors.Hand;
            dataSearchbtn.FlatAppearance.BorderSize = 0;
            dataSearchbtn.FlatStyle = FlatStyle.Flat;
            dataSearchbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            dataSearchbtn.ForeColor = Color.White;
            dataSearchbtn.Location = new Point(966, 122);
            dataSearchbtn.Name = "dataSearchbtn";
            dataSearchbtn.Size = new Size(153, 40);
            dataSearchbtn.TabIndex = 21;
            dataSearchbtn.Text = "search";
            dataSearchbtn.UseVisualStyleBackColor = false;
            dataSearchbtn.Click += dataSearchbtn_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            label9.ForeColor = Color.DarkBlue;
            label9.Location = new Point(22, 122);
            label9.Name = "label9";
            label9.Size = new Size(199, 31);
            label9.TabIndex = 22;
            label9.Text = "Total Employees :";
            // 
            // totalemployees
            // 
            totalemployees.AutoSize = true;
            totalemployees.Font = new Font("Segoe UI", 16F, FontStyle.Bold, GraphicsUnit.Point);
            totalemployees.ForeColor = Color.Red;
            totalemployees.Location = new Point(216, 116);
            totalemployees.Name = "totalemployees";
            totalemployees.Size = new Size(33, 37);
            totalemployees.TabIndex = 23;
            totalemployees.Text = "0";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(1248, 767);
            Controls.Add(totalemployees);
            Controls.Add(label9);
            Controls.Add(dataSearchbtn);
            Controls.Add(searchBox);
            Controls.Add(label8);
            Controls.Add(panel1);
            Controls.Add(empDATAGrid);
            Controls.Add(Error);
            Controls.Add(deletebtn);
            Controls.Add(updatebtn);
            Controls.Add(Addbtn);
            Controls.Add(label7);
            Controls.Add(empHiredatetxt);
            Controls.Add(empSaltxt);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(roleBox);
            Controls.Add(empEmailtxt);
            Controls.Add(label4);
            Controls.Add(empNametxt);
            Controls.Add(label3);
            Controls.Add(empIDtxt);
            Controls.Add(label2);
            Controls.Add(headerpanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            headerpanel.ResumeLayout(false);
            headerpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)empDATAGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel headerpanel;
        private Label label1;
        private Label label2;
        private TextBox empIDtxt;
        private TextBox empNametxt;
        private Label label3;
        private TextBox empEmailtxt;
        private Label label4;
        private ComboBox roleBox;
        private Label label5;
        private TextBox empSaltxt;
        private Label label6;
        private DateTimePicker empHiredatetxt;
        private Label label7;
        private Button Addbtn;
        private Button updatebtn;
        private Button deletebtn;
        private Button exitbtn;
        private Label Error;
        private DataGridView empDATAGrid;
        private Panel panel1;
        private Label label8;
        private ComboBox searchBox;
        private Button dataSearchbtn;
        private Label label9;
        private Label totalemployees;
    }
}
