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

namespace _366Project
{
    public partial class Form1 : Form
    {

        private string connectionString;
        private int selectedBranch = 1;

        public Form1()
        {
            InitializeComponent();
            connectionString = "Server=localhost;Port=5432;User Id=postgres;Password=0655;Database=Library;"; ;



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
    }
}
