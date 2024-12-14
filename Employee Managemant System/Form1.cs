using Microsoft.VisualBasic;
using System.Data;
using System.Data.SqlClient;

namespace Employee_Managemant_System
{
    public partial class Form1 : Form
    {


        private int _empID;
        private string _empName;
        private string _empRole;
        private decimal _empSal;
        private string _empEmail;
        private string _empHireDate;


        //property for _empID
        public int EmployeeID
        {
            set
            {
                _empID = value;
            }
            get
            {
                return _empID;
            }
        }

        //property for _empName
        public string EmployeeName
        {
            set
            {
                _empName = value;
            }
            get
            {
                return _empName;
            }
        }

        //property for _empRole
        public string EmployeeRole
        {
            set
            {
                _empRole = value;
            }
            get
            {
                return _empRole;
            }
        }

        //property for _empSal
        public decimal EmployeeSal
        {
            set
            {
                _empSal = value;
            }
            get
            {
                return _empSal;
            }
        }

        //property for _empEmail
        public string EmployeeEmail
        {
            set
            {
                _empEmail = value;
            }
            get
            {
                return _empEmail;
            }
        }

        //property for _empHireDate
        public string EmployeeHireDate
        {
            set
            {
                _empHireDate = value;
            }
            get
            {
                return _empHireDate;
            }
        }
        public Form1()
        {
            InitializeComponent();

        }



        private void ShowError(string message, Control control)
        {
            Error.Text = message;
            Error.Location = new Point(control.Location.X, control.Location.Y + control.Height + 5); // Position the label below the control
            Error.Visible = true;
            control.Focus(); // Focus on the control for correction
        }

        private bool FormValidation()
        {
            if (!int.TryParse(empIDtxt.Text, out int parsedID) || parsedID <= 0)
            {
                ShowError("Invalid Employee ID. Please enter a valid positive number.", empIDtxt);
                return false;
            }
            else
            {
                Error.Visible = false;
                EmployeeID = parsedID;
            }

            if (string.IsNullOrWhiteSpace(empNametxt.Text))
            {
                ShowError("Invalid Employee Name. Please enter a valid employee name.", empNametxt);
                return false;
            }
            else
            {
                EmployeeName = empNametxt.Text;
                Error.Visible = false;
            }

            if (roleBox.SelectedIndex < 0)
            {
                ShowError("Invalid Employee Role. Please select a valid role.", roleBox);
                return false;
            }
            else
            {
                EmployeeRole = roleBox.SelectedItem.ToString(); // Corrected assignment to EmployeeRole
                Error.Visible = false;
            }

            if (!long.TryParse(empSaltxt.Text, out long salParse) || salParse <= 0)
            {
                ShowError("Invalid Employee Salary. Please enter a valid positive number.", empSaltxt);
                return false;
            }
            else
            {
                Error.Visible = false;
                EmployeeSal = salParse;
            }

            if (string.IsNullOrWhiteSpace(empEmailtxt.Text) || !empEmailtxt.Text.Contains("@"))
            {
                ShowError("Invalid Employee Email. Please enter a valid email, make sure it contains '@'.", empEmailtxt);
                return false;
            }
            else
            {
                EmployeeEmail = empEmailtxt.Text; // Corrected assignment to EmployeeEmail
                Error.Visible = false;
            }

            if (DateTime.TryParseExact(empHiredatetxt.Text, "dd-MM-yyyy",
      System.Globalization.CultureInfo.InvariantCulture,
      System.Globalization.DateTimeStyles.None, out DateTime hireDate))
            {
                if (hireDate > DateTime.Now)
                {
                    ShowError("Invalid Hire Date. Please enter a valid hire date.", empHiredatetxt);
                    return false;
                }
                else
                {
                    // Convert hireDate to the SQL format (yyyy-MM-dd)
                    EmployeeHireDate = hireDate.ToString("yyyy-MM-dd");
                    Error.Visible = false;
                }
            }
            else
            {
                ShowError("Invalid Hire Date format. Please enter a valid date (dd-MM-yyyy).", empHiredatetxt);
                return false;
            }


            return true;
        }

        private void CustomizeColumnHeaders()
        {
            // Set the background color of the column headers
            empDATAGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.LightBlue;

            // Set the text color of the column headers
            empDATAGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;

            // Set the font for the column headers
            empDATAGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 10, FontStyle.Bold);

            // Optionally, you can set the alignment of the text in the header cells
            empDATAGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        }
        private void Addbtn_Click(object sender, EventArgs e)
        {
            if (FormValidation())
            {
                string connection = "Data Source=RAHUL;Initial Catalog=EMPLOYEE_MANAGEMENT_DB;Integrated Security=True;";

                using (SqlConnection conn = new SqlConnection(connection))
                {
                    try
                    {
                        conn.Open();
                        string IDexist = "SELECT COUNT(*) FROM employee_tbl WHERE empID = @id";
                        SqlCommand idExistCMD = new SqlCommand(IDexist, conn);
                        idExistCMD.Parameters.AddWithValue("@id", EmployeeID);

                        int isExist = (int)idExistCMD.ExecuteScalar();

                        if (isExist > 0)
                        {
                            MessageBox.Show("ID already Exist.Please enter unique employee ID ", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else
                        {
                            string insertQuery = "INSERT INTO employee_tbl VALUES(@id, @name, @role, @sal, @email, @date)";
                            SqlCommand insertCMD = new SqlCommand(insertQuery, conn);

                            insertCMD.Parameters.AddWithValue("@id", EmployeeID);
                            insertCMD.Parameters.AddWithValue("@name", EmployeeName);
                            insertCMD.Parameters.AddWithValue("@role", EmployeeRole);
                            insertCMD.Parameters.AddWithValue("@sal", EmployeeSal);
                            insertCMD.Parameters.AddWithValue("@email", EmployeeEmail);
                            insertCMD.Parameters.AddWithValue("@date", EmployeeHireDate);

                            int isInsert = insertCMD.ExecuteNonQuery();

                            if (isInsert > 0)
                            {
                                MessageBox.Show("Employee Insert Successful", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                empIDtxt.Text = "";
                                empNametxt.Text = "";
                                roleBox.Text = "";
                                empSaltxt.Text = "";
                                empEmailtxt.Text = "";
                                empHiredatetxt.Text = "";
                                totalEmployee(); 
                            }
                            else
                            {
                                MessageBox.Show("Employee Not Insert Successful", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }




                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        conn.Close();
                    }
                }
            }
            DisplayEmployee();
        }

        private void DisplayEmployee()
        {

            string connection = "Data Source=RAHUL;Initial Catalog=EMPLOYEE_MANAGEMENT_DB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string employeDisplay = "SELECT * FROM employee_tbl";
                    SqlDataAdapter da = new SqlDataAdapter(employeDisplay, conn);

                    DataSet dataSet = new DataSet();
                    da.Fill(dataSet);

                    empDATAGrid.DataSource = dataSet.Tables[0];

                    // Customizing columns
                    empDATAGrid.Columns["empID"].HeaderText = "Employee ID";
                    empDATAGrid.Columns["empName"].HeaderText = "Employee Name";
                    empDATAGrid.Columns["empHireDate"].HeaderText = "Hire Date";
                    empDATAGrid.Columns["empSal"].HeaderText = "Salary";
                    empDATAGrid.Columns["empEmail"].HeaderText = "Email";

                    // Set column widths
                    empDATAGrid.Columns["empID"].Width = 100;
                    empDATAGrid.Columns["empName"].Width = 100;
                    empDATAGrid.Columns["empSal"].Width = 100;
                    empDATAGrid.Columns["EmpRole"].Width = 80;
                    empDATAGrid.Columns["empEmail"].Width = 110;
                    empDATAGrid.Columns["empHireDate"].Width = 100;



                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }

        }

        private void DisplaySelectedData(string selectedDATA)
        {
            string connection = "Data Source=RAHUL;Initial Catalog=EMPLOYEE_MANAGEMENT_DB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string employeDisplay = "SELECT * FROM employee_tbl WHERE emprole = @role";
                    SqlDataAdapter da = new SqlDataAdapter(employeDisplay, conn);
                    da.SelectCommand.Parameters.AddWithValue("@role", selectedDATA);
                    DataSet dataSet = new DataSet();
                    da.Fill(dataSet);

                    if (dataSet.Tables[0].Rows.Count > 0)
                    {
                        
                        empDATAGrid.DataSource = dataSet.Tables[0];

                        // Customizing columns
                        empDATAGrid.Columns["empID"].HeaderText = "Employee ID";
                        empDATAGrid.Columns["empName"].HeaderText = "Employee Name";
                        empDATAGrid.Columns["empHireDate"].HeaderText = "Hire Date";
                        empDATAGrid.Columns["empSal"].HeaderText = "Salary";
                        empDATAGrid.Columns["empEmail"].HeaderText = "Email";

                        // Set column widths
                        empDATAGrid.Columns["empID"].Width = 100;
                        empDATAGrid.Columns["empName"].Width = 100;
                        empDATAGrid.Columns["empSal"].Width = 100;
                        empDATAGrid.Columns["EmpRole"].Width = 80;
                        empDATAGrid.Columns["empEmail"].Width = 110;
                        empDATAGrid.Columns["empHireDate"].Width = 100;
                    }
                    else
                    {
                    
                        MessageBox.Show("No records found for the selected role.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        empDATAGrid.DataSource = null;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CustomizeColumnHeaders();
            DisplayEmployee();
            totalEmployee();
        }

        private void updatebtn_Click(object sender, EventArgs e)
        {
            if (!FormValidation())
                return;

            string connection = "Data Source=RAHUL;Initial Catalog=EMPLOYEE_MANAGEMENT_DB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();

                    string checkQuery = "SELECT COUNT(*) FROM employee_tbl WHERE empID = @id";
                    SqlCommand checkCmd = new SqlCommand(checkQuery, conn);
                    checkCmd.Parameters.AddWithValue("@id", EmployeeID);

                    int exists = (int)checkCmd.ExecuteScalar();
                    if (exists == 0)
                    {
                        MessageBox.Show("Employee ID does not exist. Update cannot proceed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string updateQuery = @"UPDATE employee_tbl 
                                   SET empName = @name, 
                                       emprole = @role, 
                                       empSal = @sal, 
                                       empEmail = @email, 
                                       empHireDate = @date 
                                   WHERE empID = @id";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, conn);
                    updateCmd.Parameters.AddWithValue("@id", EmployeeID);
                    updateCmd.Parameters.AddWithValue("@name", EmployeeName);
                    updateCmd.Parameters.AddWithValue("@role", EmployeeRole);
                    updateCmd.Parameters.AddWithValue("@sal", EmployeeSal);
                    updateCmd.Parameters.AddWithValue("@email", EmployeeEmail);
                    updateCmd.Parameters.AddWithValue("@date", EmployeeHireDate);

                    int rowsAffected = updateCmd.ExecuteNonQuery();

                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Employee details updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DisplayEmployee();
                        totalEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Failed to update employee details. No rows were affected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn.Close();
                }
            }
        }

        private void deletebtn_Click(object sender, EventArgs e)
        {
            string id = empIDtxt.Text;
            string connection = "Data Source=RAHUL;Initial Catalog=EMPLOYEE_MANAGEMENT_DB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string isExist = "SELECT COUNT(*) FROM employee_tbl WHERE empID = @id";
                    SqlCommand isExistCMD = new SqlCommand(isExist,conn);
                    isExistCMD.Parameters.AddWithValue("@id", id);
                    int exist = (int)isExistCMD.ExecuteScalar();

                    if (exist==0)
                    {
                        MessageBox.Show("Employee can not Existe.Please Check the Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    string deleteEmployee = "DELETE FROM employee_tbl WHERE empID = @id;";
                    SqlCommand deleteCMD = new SqlCommand(deleteEmployee, conn);
                    deleteCMD.Parameters.AddWithValue("@id", id);

                    int isdelete = deleteCMD.ExecuteNonQuery();
                    if (isdelete>0)
                    {
                        MessageBox.Show("Employee Delete Successful.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        empIDtxt.Text = "";
                        DisplayEmployee();
                        totalEmployee();
                    }
                    else
                    {
                        MessageBox.Show("Employee can Delete.Please Check the Employee ID", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }




                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                     conn.Close ();
                }
            }
        }

        private void totalEmployee()
        {
            string connection = "Data Source=RAHUL;Initial Catalog=EMPLOYEE_MANAGEMENT_DB;Integrated Security=True;";
            using (SqlConnection conn = new SqlConnection(connection))
            {
                try
                {
                    conn.Open();
                    string totalemp = "SELECT COUNT(*) FROM employee_tbl ";
                    SqlCommand isExistCMD = new SqlCommand(totalemp, conn);
                    int total = (int)isExistCMD.ExecuteScalar();
                    if (total > 0)
                    {
                        totalemployees.Text = $"{total}";
                    }
                    else
                    {
                        totalemployees.Visible = false;
                    }
                }
                catch (Exception ex) { }
                finally
                {
                    conn.Close ();
                }
                }
               
        }
        private void dataSearchbtn_Click(object sender, EventArgs e)
        {
            string selectedData = searchBox.Text;

            if (selectedData.Equals("All Employees"))
            {
                DisplayEmployee();
            }
            else if (selectedData.Equals("HR"))
            {
                DisplaySelectedData(selectedData);
            }
            else if (selectedData.Equals("Maneger"))
            {
                DisplaySelectedData(selectedData);
            }
            else if (selectedData.Equals("Acountant"))
            {
                DisplaySelectedData(selectedData);
            }
            else if (selectedData.Equals("Seller"))
            {
                DisplaySelectedData(selectedData);
            }
            else
            {
                MessageBox.Show("Data not found", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
