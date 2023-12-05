using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;
using Npgsql;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;
using System.Diagnostics.Eventing.Reader;

namespace _366Project
{
    public partial class Form1 : Form
    {

        private string connectionString;
        private int selectedBranch = 1;

        public Form1()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=password;Database=project366;"; ;



            populatePage();


        }

        public void populatePage()
        {
            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    int selectedIndex = branchListBox.SelectedIndex;

                    //Branch DropDown
                    string sqlQuery = "SELECT * FROM branch";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {


                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        branchListBox.DisplayMember = "location";
                        branchListBox.ValueMember = "branch_id";
                        branchListBox.DataSource = dt;
                    }

                    //initial branch population
                    sqlQuery = "SELECT * FROM branch";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        branchGridView.DataSource = dt;
                    }

                    //initial books population
                    sqlQuery = "SELECT * FROM books WHERE branch_id=1";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        booksGridView.DataSource = dt;
                    }


                    //members gridbox
                    sqlQuery = "SELECT * FROM members WHERE branch_id=1";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        membersGridView.DataSource = dt;
                    }

                    //employee gridbox
                    sqlQuery = "SELECT * FROM employee WHERE branch_id=1";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {

                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        employeeGridView.DataSource = dt;
                    }

                    //checked out gridbox
                    sqlQuery = "SELECT" +
                        " m.name AS member_name," +
                        " b.title AS book_title," +
                        " b.ISBN AS book_ISBN," +
                        " cob.late_by_date," +
                        " m.branch_id" + 
                        " FROM" +
                        " members m " +
                        "INNER JOIN " +
                        "checkedOutBooks cob ON m.member_id = cob.member_id" +
                        " INNER JOIN books b ON cob.book_id = b.book_id" +
                        " WHERE m.branch_id = 1";
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        checkedOutGridView.DataSource = dt;
                    }

                    connection.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void branchListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    selectedBranch = branchListBox.SelectedIndex+1;

                    //books gridview population
                    string sqlQuery = "SELECT * FROM books WHERE branch_id=" + selectedBranch.ToString();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        booksGridView.DataSource = dt;
                    }

                    //members gridview population
                    sqlQuery = "SELECT * FROM members WHERE branch_id=" + selectedBranch.ToString();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        membersGridView.DataSource = dt;
                    }

                    //employee gridview population
                    sqlQuery = "SELECT * FROM employee WHERE branch_id=" + selectedBranch.ToString();
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);

                        employeeGridView.DataSource = dt;
                    }

                    connection.Close();

                    //checked out books
                    sqlQuery = "SELECT" +
                        " m.name AS member_name," +
                        " b.title AS book_title," +
                        " b.ISBN AS book_ISBN," +
                        " cob.late_by_date," +
                        " m.branch_id" +
                        " FROM" +
                        " members m " +
                        "INNER JOIN " +
                        "checkedOutBooks cob ON m.member_id = cob.member_id" +
                        " INNER JOIN books b ON cob.book_id = b.book_id" +
                        " WHERE m.branch_id = " + selectedBranch;
                    using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                    {
                        DataTable dt = new DataTable();
                        adapter.Fill(dt);
                        checkedOutGridView.DataSource = dt;
                    }

                }

            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }

        }

        private void bookSearchBtn_Click(object sender, EventArgs e)
        {
            int id, isbn, maxRating, minRating;
            string title = bookTitleSearchBox.Text;
            string author = bookAuthorSearchBox.Text;
            string sqlQuery = "SELECT * FROM books WHERE branch_id="+selectedBranch;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Checking and building the SQL query based on the provided values
                    if (int.TryParse(bookIdSearchBox.Text, out id))
                    {
                        // Append condition to the query if 'id' is provided
                        sqlQuery += $" AND book_id = {id}";
                    }

                    if (!string.IsNullOrWhiteSpace(title))
                    {
                        // Append condition to the query if 'title' is provided
                        sqlQuery += $" AND title ILIKE '%{title}%'";
                    }

                    if (!string.IsNullOrWhiteSpace(author))
                    {
                        // Append condition to the query if 'author' is provided
                        sqlQuery += $" AND author ILIKE '%{author}%'";
                    }

                    if (int.TryParse(bookISBNSearchBox.Text, out isbn))
                    {
                        // Append condition to the query if 'isbn' is provided
                        sqlQuery += $" AND isbn = {isbn}";
                    }

                    if (int.TryParse(bookRatingMINSearchBox.Text, out minRating))
                    {
                        // Append condition to the query if 'minRating' is provided
                        sqlQuery += $" AND rating >= {minRating}";
                    }

                    if (int.TryParse(bookRatingMAXSearchBox.Text, out maxRating))
                    {
                        // Append condition to the query if 'maxRating' is provided
                        sqlQuery += $" AND rating <= {maxRating}";
                    }

                    try
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            booksGridView.DataSource = dt;
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
                        MessageBox.Show(sqlQuery);
                    }

                    connection.Close();

                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void bookSearchClearBtn_Click(object sender, EventArgs e)
        {
            populatePage();
        }

        private void memberSearchBtn_Click(object sender, EventArgs e)
        {
            int member_id;
            string name = memberNameSearchBox.Text;
            string address = memberAddressSearchBox.Text;
            string sqlQuery = "SELECT * FROM members WHERE branch_id=" + selectedBranch;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Checking and building the SQL query based on the provided values
                    if (int.TryParse(memberIdSearchBox.Text, out member_id))
                    {
                        // Append condition to the query if 'member_id' is provided
                        sqlQuery += $" AND member_id = {member_id}";
                    }
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        // Append condition to the query if 'name' is provided
                        sqlQuery += $" AND name ILIKE '%{name}%'";
                    }

                    if (!string.IsNullOrWhiteSpace(address))
                    {
                        // Append condition to the query if 'address' is provided
                        sqlQuery += $" AND address ILIKE '%{address}%'";
                    }

                    try
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            // Assuming booksGridView is a DataGridView
                            membersGridView.DataSource = dt;
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
                        MessageBox.Show(sqlQuery);
                    }

                    connection.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void memberClearBtn_Click(object sender, EventArgs e)
        {
            populatePage();
        }

        private void employeeSearch_Click(object sender, EventArgs e)
        {
            int empId;
            string name = empNameTextBox.Text;
            string title = empTitleSearchBox.Text;
            int supervisor_id;
            string sqlQuery = "SELECT * FROM employee WHERE branch_id=" + selectedBranch;

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Checking and building the SQL query based on the provided values
                    if (int.TryParse(empIdSearchBox.Text, out empId))
                    {
                        // Append condition to the query if 'empId' is provided
                        sqlQuery += $" AND emp_id = {empId}";
                    }
                    if (!string.IsNullOrWhiteSpace(name))
                    {
                        // Append condition to the query if 'name' is provided
                        sqlQuery += $" AND name ILIKE '%{name}%'";
                    }

                    if (!string.IsNullOrWhiteSpace(title))
                    {
                        // Append condition to the query if 'title' is provided
                        sqlQuery += $" AND title ILIKE '%{title}%'";
                    }

                    if (int.TryParse(empSupervisorSearch.Text, out supervisor_id))
                    {
                        // Append condition to the query if 'title' is provided
                        sqlQuery += $" AND supervisor = {supervisor_id}";
                    }

                    try
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(sqlQuery, connection))
                        {
                            DataTable dt = new DataTable();
                            adapter.Fill(dt);
                            employeeGridView.DataSource = dt;
                        }
                    }
                    catch (NpgsqlException ex)
                    {
                        MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
                        MessageBox.Show(sqlQuery);
                    }

                    connection.Close();
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void employeeClear_Click(object sender, EventArgs e)
        {
            populatePage();
        }



        // Function to check if a branch with the specified branchID exists
        private bool BranchExists(int branchID)

        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM branch WHERE branch_id = @branch_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@branch_id", branchID);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                    return count > 0;
                }

               
            }
        }

        //Function to check if a employee with the specified superviosr_ID exists
        private bool EmployeeExists(int supervisorID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM employee WHERE emp_id = @supervisor_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@supervisor_id", supervisorID);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                    return count > 0;
                }


            }
        }

        //Function to check if a member with the specified member_ID exists
        private bool MemberExists(int memberID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM members WHERE member_id = @member_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@member_id", memberID);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                    return count > 0;
                }


            }
        }

        //Function to check if a book with the specified book_ID exists
        private bool BookExists(int bookID)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM books WHERE book_id = @book_id";
                using (NpgsqlCommand cmd = new NpgsqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@book_id", bookID);

                    int count = Convert.ToInt32(cmd.ExecuteScalar());

                    connection.Close();

                    return count > 0;
                }


            }
        }

        //Add a Book

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string title ="";
            string author ="";
            int isbn;
            int branchID;
            int rating;
            int copies;
            Boolean avilable = false;

            //validation
            if (!string.IsNullOrWhiteSpace(txtAddTitle.Text))
            {
                title = txtAddTitle.Text;
            }
            if (!string.IsNullOrWhiteSpace(txtAddAuthor.Text))
            {
                 author = txtAddAuthor.Text;
            }
            if (int.TryParse(txtAddISBN.Text, out isbn) == true)
            {
                isbn = Convert.ToInt32(txtAddISBN.Text);
            }
            if (int.TryParse(txtAddBranchID.Text, out branchID) == true)
            {
                branchID = Convert.ToInt32(txtAddBranchID.Text);

                if (!BranchExists(branchID))
                {
                    MessageBox.Show($"Branch with ID {branchID} does not exist.");
                    return; // Exit the method if validation fails
                }
            }
            else
            {
                MessageBox.Show("Enter a valid branch ID");
                return; // Exit the method if validation fails
            }
            if (int.TryParse(txtAddRating.Text, out rating) == true)
            {
                rating = Convert.ToInt32(txtAddRating.Text);
            }
            if (int.TryParse(txtAddCopies.Text, out copies) == true)
            {
                copies = Convert.ToInt32(txtAddCopies.Text);
            }
            if (cbAddCopiesAvilable.Checked == true)
            {
                avilable = true;
            }


            string addBookQuery = "INSERT INTO books (title, author, ISBN, branch_id, rating, copies, copies_avilable) " +
                                  "VALUES (@title, @author, @ISBN, @branch_id, @rating, @copies, @copies_avilable)";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(addBookQuery, connection))
                    {
                       
                        cmd.Parameters.AddWithValue("@title", $"{title}");
                        cmd.Parameters.AddWithValue("@author", $"{author}");
                        cmd.Parameters.AddWithValue("@ISBN", isbn);
                        cmd.Parameters.AddWithValue("@branch_id", branchID);
                        cmd.Parameters.AddWithValue("@rating", rating);
                        cmd.Parameters.AddWithValue("@copies", copies);
                        cmd.Parameters.AddWithValue("@copies_avilable", avilable);

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }

        }
        
        //Delete a Book
        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            int bookId;

            //validation
            if (int.TryParse(txtDeleteBookId.Text, out bookId
                ) == true)
            {
                bookId = Convert.ToInt32(txtDeleteBookId.Text);
            }
            else
            {
                MessageBox.Show("Enter valid number");
            }

            string deleteBookQuery = "Delete from books Where book_id = @book_id";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(deleteBookQuery, connection))
                    {
                        
                        cmd.Parameters.AddWithValue("@book_id", bookId);
  

                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }

        }

        //Create a Member
        private void btnCreateMember_Click(object sender, EventArgs e)
        {
            string name ="";
            string address ="";
            int branchID;


            //validation
            if (!string.IsNullOrWhiteSpace(txtCreateMemberName.Text))
            {
                name = txtCreateMemberName.Text;
            }
            else
                MessageBox.Show("Enter valid name");

            if (!string.IsNullOrWhiteSpace(txtCreateMemberAddress.Text))
            {
                address = txtCreateMemberAddress.Text;
            }
            if (int.TryParse(txtCreateMemberBranchID.Text, out branchID) == true)
            {
                branchID = Convert.ToInt32(txtCreateMemberBranchID.Text);

                if (!BranchExists(branchID))
                {
                    MessageBox.Show($"Branch with ID {branchID} does not exist.");
                    return; // Exit the method if validation fails
                }
            }
            else
            {
                MessageBox.Show("Enter a valid branch ID");
                return; // Exit the method if validation fails
            }



            string createMemberQuery = "INSERT INTO members (name, address, member_since, branch_id) " +
                                  "VALUES (@name, @address, @member_since, @branch_id)";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(createMemberQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@name", $"{name}");
                        cmd.Parameters.AddWithValue("@address", $"{address}");
                        cmd.Parameters.AddWithValue("@member_since", DateTime.Now);
                        cmd.Parameters.AddWithValue("@branch_id", branchID);


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        //Delete a Member
        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            int memberID;

            //validation
            if (int.TryParse(txtDeleteMemberID.Text, out memberID) == true)
            {
                memberID = Convert.ToInt32(txtDeleteMemberID.Text);
            }
            else
            {
                MessageBox.Show("Enter valid number");
            }

            
            string deleteMemberQuery = "Delete from members Where member_id = @member_id";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();



                    using (NpgsqlCommand cmd = new NpgsqlCommand(deleteMemberQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@member_id", memberID);


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        //Create a Employee
        private void btnCreateEmployee_Click(object sender, EventArgs e)
        {
            decimal salary;
            string title = "";
            int supervisorID;
            int branchID;


            //validation
            if(decimal.TryParse(txtCreateEmployeeSalary.Text, out salary) == true)
            {
                salary = Convert.ToDecimal(txtCreateEmployeeSalary.Text);
            }
            if (!string.IsNullOrWhiteSpace(txtCreateEmployeeTitle.Text))
            {
                title = txtCreateEmployeeTitle.Text;
            }
            else
                MessageBox.Show("Enter valid title");
            if(int.TryParse(txtCreateEmployeeSupervisorID.Text, out supervisorID) == true)
            {
                supervisorID = Convert.ToInt32(txtCreateEmployeeSupervisorID.Text);

                if (!EmployeeExists(supervisorID))
                {
                    MessageBox.Show($"Employee with ID {supervisorID} does not exist.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter a valid Supervisor ID");
                return; // Exit the method if validation fails
            }

            if (int.TryParse(txtCreateEmployeeBranchID.Text, out branchID) == true)
            {
                branchID = Convert.ToInt32(txtCreateEmployeeBranchID.Text);

                if (!BranchExists(branchID))
                {
                    MessageBox.Show($"Branch with ID {branchID} does not exist.");
                    return; // Exit the method if validation fails
                }
            }
            else
            {
                MessageBox.Show("Enter a valid branch ID");
                return; // Exit the method if validation fails
            }




            string createMemberQuery = "INSERT INTO employee (salary, title, supervisor, branch_id) " +
                                  "VALUES (@salary, @title, @supervisorID, @branch_id)";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(createMemberQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@salary", salary);
                        cmd.Parameters.AddWithValue("@title", $"{title}");
                        cmd.Parameters.AddWithValue("@supervisorID", supervisorID);
                        cmd.Parameters.AddWithValue("@branch_id", branchID);


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        //Delete a Employee
        private void btnDeleteEmployee_Click(object sender, EventArgs e)
        {
            int employeeID;

            //validation
            if (int.TryParse(txtDeleteEmployeeID.Text, out employeeID) == true)
            {
                employeeID = Convert.ToInt32(txtDeleteEmployeeID.Text);
            }
            else
            {
                MessageBox.Show("Enter valid number");
            }


            string deleteEmployeeQuery = "Delete from employee Where emp_id = @employeeID";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();



                    using (NpgsqlCommand cmd = new NpgsqlCommand(deleteEmployeeQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@employeeID", employeeID);


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        //Create a Branch
        private void btnCreateBranch_Click(object sender, EventArgs e)
        {

            string location = "";



            //validation

            if (!string.IsNullOrWhiteSpace(txtCreateBranchLocation.Text))
            {
                location = txtCreateBranchLocation.Text;
            }
            else
                MessageBox.Show("Enter valid Location");





            string createMemberQuery = "INSERT INTO branch (location) " +
                                  "VALUES (@location)";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(createMemberQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@location", location);



                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void btnDeleteBranch_Click(object sender, EventArgs e)
        {
            int branchID;

            //validation
            if (int.TryParse(txtDelteteBranchID.Text, out branchID) == true)
            {
                branchID = Convert.ToInt32(txtDelteteBranchID.Text);

                if (!BranchExists(branchID))
                {
                    MessageBox.Show($"Branch with ID {branchID} does not exist.");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Enter valid number");
            }


            string deleteBranchQuery = "Delete from branch Where branch_id = @branchID";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();



                    using (NpgsqlCommand cmd = new NpgsqlCommand(deleteBranchQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@branchID", branchID);


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();

                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void btnCreateCheckedoutBook_Click(object sender, EventArgs e)
        {
            int memberID;
            int bookID;
            DateTime lateReturnDate;


            //validation

            if (int.TryParse(txtCreateCheckedOutBookMemberID.Text, out memberID) == true)
            {
                memberID = Convert.ToInt32(txtCreateCheckedOutBookMemberID.Text);

                if (!MemberExists(memberID))
                {
                    MessageBox.Show($"Member with ID {memberID} does not exist.");
                    return; // Exit the method if validation fails
                }
            }
            else
            {
                MessageBox.Show("Enter a valid member ID");
                return; // Exit the method if validation fails
            }

            if (int.TryParse(txtCreateCheckedOutBookID.Text, out bookID) == true)
            {
                bookID = Convert.ToInt32(txtCreateCheckedOutBookID.Text);

                if (!BookExists(bookID))
                {
                    MessageBox.Show($"Book with ID {bookID} does not exist.");
                    return; // Exit the method if validation fails
                }
            }
            else
            {
                MessageBox.Show("Enter a valid book ID");
                return; // Exit the method if validation fails
            }

            lateReturnDate = dtpLatebyDate.Value;


            string createMemberQuery = "INSERT INTO checkedOutBooks (member_id, book_id, late_by_date) " +
                                  "VALUES (@member_id, @book_id, @late_by_date)";

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    using (NpgsqlCommand cmd = new NpgsqlCommand(createMemberQuery, connection))
                    {

                        cmd.Parameters.AddWithValue("@member_id", memberID);
                        cmd.Parameters.AddWithValue("@book_id", bookID);
                        cmd.Parameters.AddWithValue("@late_by_date", lateReturnDate);
                        


                        // Execute the query
                        cmd.ExecuteNonQuery();
                        connection.Close();
                        populatePage();
                    }
                }
            }
            catch (NpgsqlException ex)
            {
                MessageBox.Show("PostgreSQL Connection Error: " + ex.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'project366DataSet.books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.project366DataSet.books);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assuming you have a connection already established
            using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
            {
                // Open the connection
                connection.Open();

                // Validate and get the integer value from memberIdInputCheckout
                if (int.TryParse(memberIdInputCheckout.Text, out int memberId))
                {
                    // Assuming dataGridView1 is your DataGridView
                    if (checkOutGridView.SelectedRows.Count > 0)
                    {
                        // Get the book_id from the first column of the selected row
                        int bookId = Convert.ToInt32(checkOutGridView.SelectedRows[0].Cells[0].Value);

                        // Check if the entered value already exists in otherTable
                        if (!DoesIdExist(connection, "otherTable", "other_id", memberId))
                        {
                            MessageBox.Show("ID doesn't exist in members. Please enter a different ID.");
                            return; // Exit the method if the ID doesn't exist
                        }

                        // Construct the SQL query using parameters for member_id, book_id, and late_by_date
                        string sqlQuery = "INSERT INTO checkedoutbooks (member_id, book_id, late_by_date) VALUES (@MemberId, @BookId, @LateByDate)";

                        using (NpgsqlCommand command = new NpgsqlCommand(sqlQuery, connection))
                        {
                            // Add parameters
                            command.Parameters.AddWithValue("@MemberId", memberId);
                            command.Parameters.AddWithValue("@BookId", bookId);
                            command.Parameters.AddWithValue("@LateByDate", DateTime.Now.AddDays(7));

                            // Execute the query
                            command.ExecuteNonQuery();
                            populatePage();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please select a row in the DataGridView before clicking the button.");
                    }
                }
                else
                {
                    // Handle the case where the entered value is not an integer
                    MessageBox.Show("Please enter a valid integer in memberIdInputCheckout.");
                }
            }
        }

        private bool DoesIdExist(NpgsqlConnection connection, string tableName, string idColumnName, int idValue)
        {
            string query = $"SELECT COUNT(*) FROM members WHERE member_id = @IdValue";

            using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@IdValue", idValue);
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        
    }


}
