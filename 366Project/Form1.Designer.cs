﻿namespace _366Project
{
    partial class Form1
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.booksTab = new System.Windows.Forms.TabPage();
            this.searchContainer = new System.Windows.Forms.GroupBox();
            this.bookSearchClearBtn = new System.Windows.Forms.Button();
            this.bookSearchBtn = new System.Windows.Forms.Button();
            this.bookRatingMAXSearchBox = new System.Windows.Forms.TextBox();
            this.bookRatingMINSearchBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.bookISBNSearchBox = new System.Windows.Forms.TextBox();
            this.bookTitleSearchBox = new System.Windows.Forms.TextBox();
            this.bookAuthorSearchBox = new System.Windows.Forms.TextBox();
            this.bookIdSearchBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.membersTab = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.memberClearBtn = new System.Windows.Forms.Button();
            this.memberSearchBtn = new System.Windows.Forms.Button();
            this.memberNameSearchBox = new System.Windows.Forms.TextBox();
            this.memberAddressSearchBox = new System.Windows.Forms.TextBox();
            this.memberIdSearchBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.membersGridView = new System.Windows.Forms.DataGridView();
            this.employeeTab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.employeeClear = new System.Windows.Forms.Button();
            this.employeeSearch = new System.Windows.Forms.Button();
            this.empTitleSearchBox = new System.Windows.Forms.TextBox();
            this.empSupervisorSearch = new System.Windows.Forms.TextBox();
            this.empIdSearchBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.employeeGridView = new System.Windows.Forms.DataGridView();
            this.checkedOutTab = new System.Windows.Forms.TabPage();
            this.checkedOutGridView = new System.Windows.Forms.DataGridView();
            this.adminTab = new System.Windows.Forms.TabPage();
            this.checkoutTab = new System.Windows.Forms.TabPage();
            this.branchListBox = new System.Windows.Forms.ListBox();
            this.AddContainer = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.txtAddTitle = new System.Windows.Forms.TextBox();
            this.txtAddAuthor = new System.Windows.Forms.TextBox();
            this.txtAddISBN = new System.Windows.Forms.TextBox();
            this.txtAddBranchID = new System.Windows.Forms.TextBox();
            this.txtAddRating = new System.Windows.Forms.TextBox();
            this.txtAddCopies = new System.Windows.Forms.TextBox();
            this.cbAddCopiesAvilable = new System.Windows.Forms.CheckBox();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.gpDeleteBook = new System.Windows.Forms.GroupBox();
            this.label21 = new System.Windows.Forms.Label();
            this.txtDeleteBookId = new System.Windows.Forms.TextBox();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label22 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.btnCreateMember = new System.Windows.Forms.Button();
            this.txtCreateMemberName = new System.Windows.Forms.TextBox();
            this.txtCreateMemberAddress = new System.Windows.Forms.TextBox();
            this.txtCreateMemberBranchID = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtDeleteMemberID = new System.Windows.Forms.TextBox();
            this.btnDeleteMember = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.booksTab.SuspendLayout();
            this.searchContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.membersTab.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).BeginInit();
            this.employeeTab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).BeginInit();
            this.checkedOutTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutGridView)).BeginInit();
            this.AddContainer.SuspendLayout();
            this.gpDeleteBook.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.booksTab);
            this.tabControl.Controls.Add(this.membersTab);
            this.tabControl.Controls.Add(this.employeeTab);
            this.tabControl.Controls.Add(this.checkedOutTab);
            this.tabControl.Controls.Add(this.adminTab);
            this.tabControl.Controls.Add(this.checkoutTab);
            this.tabControl.Location = new System.Drawing.Point(12, 41);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(901, 609);
            this.tabControl.TabIndex = 1;
            // 
            // booksTab
            // 
            this.booksTab.Controls.Add(this.gpDeleteBook);
            this.booksTab.Controls.Add(this.AddContainer);
            this.booksTab.Controls.Add(this.searchContainer);
            this.booksTab.Controls.Add(this.booksGridView);
            this.booksTab.Location = new System.Drawing.Point(4, 22);
            this.booksTab.Name = "booksTab";
            this.booksTab.Padding = new System.Windows.Forms.Padding(3);
            this.booksTab.Size = new System.Drawing.Size(893, 583);
            this.booksTab.TabIndex = 0;
            this.booksTab.Text = "Books";
            this.booksTab.UseVisualStyleBackColor = true;
            // 
            // searchContainer
            // 
            this.searchContainer.Controls.Add(this.bookSearchClearBtn);
            this.searchContainer.Controls.Add(this.bookSearchBtn);
            this.searchContainer.Controls.Add(this.bookRatingMAXSearchBox);
            this.searchContainer.Controls.Add(this.bookRatingMINSearchBox);
            this.searchContainer.Controls.Add(this.label6);
            this.searchContainer.Controls.Add(this.bookISBNSearchBox);
            this.searchContainer.Controls.Add(this.bookTitleSearchBox);
            this.searchContainer.Controls.Add(this.bookAuthorSearchBox);
            this.searchContainer.Controls.Add(this.bookIdSearchBox);
            this.searchContainer.Controls.Add(this.label5);
            this.searchContainer.Controls.Add(this.label4);
            this.searchContainer.Controls.Add(this.label3);
            this.searchContainer.Controls.Add(this.label2);
            this.searchContainer.Controls.Add(this.label1);
            this.searchContainer.Location = new System.Drawing.Point(19, 218);
            this.searchContainer.Name = "searchContainer";
            this.searchContainer.Size = new System.Drawing.Size(220, 201);
            this.searchContainer.TabIndex = 1;
            this.searchContainer.TabStop = false;
            this.searchContainer.Text = "Search";
            // 
            // bookSearchClearBtn
            // 
            this.bookSearchClearBtn.Location = new System.Drawing.Point(110, 164);
            this.bookSearchClearBtn.Name = "bookSearchClearBtn";
            this.bookSearchClearBtn.Size = new System.Drawing.Size(88, 23);
            this.bookSearchClearBtn.TabIndex = 11;
            this.bookSearchClearBtn.Text = "Clear";
            this.bookSearchClearBtn.UseVisualStyleBackColor = true;
            this.bookSearchClearBtn.Click += new System.EventHandler(this.bookSearchClearBtn_Click);
            // 
            // bookSearchBtn
            // 
            this.bookSearchBtn.Location = new System.Drawing.Point(9, 164);
            this.bookSearchBtn.Name = "bookSearchBtn";
            this.bookSearchBtn.Size = new System.Drawing.Size(88, 23);
            this.bookSearchBtn.TabIndex = 11;
            this.bookSearchBtn.Text = "Search";
            this.bookSearchBtn.UseVisualStyleBackColor = true;
            this.bookSearchBtn.Click += new System.EventHandler(this.bookSearchBtn_Click);
            // 
            // bookRatingMAXSearchBox
            // 
            this.bookRatingMAXSearchBox.Location = new System.Drawing.Point(149, 129);
            this.bookRatingMAXSearchBox.Name = "bookRatingMAXSearchBox";
            this.bookRatingMAXSearchBox.Size = new System.Drawing.Size(49, 20);
            this.bookRatingMAXSearchBox.TabIndex = 10;
            // 
            // bookRatingMINSearchBox
            // 
            this.bookRatingMINSearchBox.Location = new System.Drawing.Point(50, 129);
            this.bookRatingMINSearchBox.Name = "bookRatingMINSearchBox";
            this.bookRatingMINSearchBox.Size = new System.Drawing.Size(47, 20);
            this.bookRatingMINSearchBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(103, 132);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = " < Id < ";
            // 
            // bookISBNSearchBox
            // 
            this.bookISBNSearchBox.Location = new System.Drawing.Point(44, 99);
            this.bookISBNSearchBox.Name = "bookISBNSearchBox";
            this.bookISBNSearchBox.Size = new System.Drawing.Size(154, 20);
            this.bookISBNSearchBox.TabIndex = 8;
            // 
            // bookTitleSearchBox
            // 
            this.bookTitleSearchBox.Location = new System.Drawing.Point(44, 42);
            this.bookTitleSearchBox.Name = "bookTitleSearchBox";
            this.bookTitleSearchBox.Size = new System.Drawing.Size(154, 20);
            this.bookTitleSearchBox.TabIndex = 7;
            // 
            // bookAuthorSearchBox
            // 
            this.bookAuthorSearchBox.Location = new System.Drawing.Point(44, 71);
            this.bookAuthorSearchBox.Name = "bookAuthorSearchBox";
            this.bookAuthorSearchBox.Size = new System.Drawing.Size(154, 20);
            this.bookAuthorSearchBox.TabIndex = 7;
            // 
            // bookIdSearchBox
            // 
            this.bookIdSearchBox.Location = new System.Drawing.Point(51, 13);
            this.bookIdSearchBox.Name = "bookIdSearchBox";
            this.bookIdSearchBox.Size = new System.Drawing.Size(69, 20);
            this.bookIdSearchBox.TabIndex = 5;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Rating";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ISBN";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Title";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book Id";
            // 
            // booksGridView
            // 
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Location = new System.Drawing.Point(19, 6);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.Size = new System.Drawing.Size(844, 205);
            this.booksGridView.TabIndex = 0;
            // 
            // membersTab
            // 
            this.membersTab.Controls.Add(this.groupBox4);
            this.membersTab.Controls.Add(this.groupBox3);
            this.membersTab.Controls.Add(this.groupBox1);
            this.membersTab.Controls.Add(this.membersGridView);
            this.membersTab.Location = new System.Drawing.Point(4, 22);
            this.membersTab.Name = "membersTab";
            this.membersTab.Padding = new System.Windows.Forms.Padding(3);
            this.membersTab.Size = new System.Drawing.Size(893, 583);
            this.membersTab.TabIndex = 1;
            this.membersTab.Text = "Members";
            this.membersTab.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.memberClearBtn);
            this.groupBox1.Controls.Add(this.memberSearchBtn);
            this.groupBox1.Controls.Add(this.memberNameSearchBox);
            this.groupBox1.Controls.Add(this.memberAddressSearchBox);
            this.groupBox1.Controls.Add(this.memberIdSearchBox);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Location = new System.Drawing.Point(22, 227);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 136);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
            // 
            // memberClearBtn
            // 
            this.memberClearBtn.Location = new System.Drawing.Point(132, 97);
            this.memberClearBtn.Name = "memberClearBtn";
            this.memberClearBtn.Size = new System.Drawing.Size(88, 23);
            this.memberClearBtn.TabIndex = 11;
            this.memberClearBtn.Text = "Clear";
            this.memberClearBtn.UseVisualStyleBackColor = true;
            this.memberClearBtn.Click += new System.EventHandler(this.memberClearBtn_Click);
            // 
            // memberSearchBtn
            // 
            this.memberSearchBtn.Location = new System.Drawing.Point(31, 97);
            this.memberSearchBtn.Name = "memberSearchBtn";
            this.memberSearchBtn.Size = new System.Drawing.Size(88, 23);
            this.memberSearchBtn.TabIndex = 11;
            this.memberSearchBtn.Text = "Search";
            this.memberSearchBtn.UseVisualStyleBackColor = true;
            this.memberSearchBtn.Click += new System.EventHandler(this.memberSearchBtn_Click);
            // 
            // memberNameSearchBox
            // 
            this.memberNameSearchBox.Location = new System.Drawing.Point(69, 42);
            this.memberNameSearchBox.Name = "memberNameSearchBox";
            this.memberNameSearchBox.Size = new System.Drawing.Size(154, 20);
            this.memberNameSearchBox.TabIndex = 7;
            // 
            // memberAddressSearchBox
            // 
            this.memberAddressSearchBox.Location = new System.Drawing.Point(69, 71);
            this.memberAddressSearchBox.Name = "memberAddressSearchBox";
            this.memberAddressSearchBox.Size = new System.Drawing.Size(154, 20);
            this.memberAddressSearchBox.TabIndex = 7;
            // 
            // memberIdSearchBox
            // 
            this.memberIdSearchBox.Location = new System.Drawing.Point(69, 13);
            this.memberIdSearchBox.Name = "memberIdSearchBox";
            this.memberIdSearchBox.Size = new System.Drawing.Size(98, 20);
            this.memberIdSearchBox.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 74);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(45, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Address";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 45);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(35, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Name";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Member Id";
            // 
            // membersGridView
            // 
            this.membersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.membersGridView.Location = new System.Drawing.Point(22, 15);
            this.membersGridView.Name = "membersGridView";
            this.membersGridView.Size = new System.Drawing.Size(844, 205);
            this.membersGridView.TabIndex = 2;
            // 
            // employeeTab
            // 
            this.employeeTab.Controls.Add(this.groupBox2);
            this.employeeTab.Controls.Add(this.employeeGridView);
            this.employeeTab.Location = new System.Drawing.Point(4, 22);
            this.employeeTab.Name = "employeeTab";
            this.employeeTab.Padding = new System.Windows.Forms.Padding(3);
            this.employeeTab.Size = new System.Drawing.Size(893, 583);
            this.employeeTab.TabIndex = 2;
            this.employeeTab.Text = "Employees";
            this.employeeTab.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.empNameTextBox);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.employeeClear);
            this.groupBox2.Controls.Add(this.employeeSearch);
            this.groupBox2.Controls.Add(this.empTitleSearchBox);
            this.groupBox2.Controls.Add(this.empSupervisorSearch);
            this.groupBox2.Controls.Add(this.empIdSearchBox);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(22, 226);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(241, 163);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Search";
            // 
            // empNameTextBox
            // 
            this.empNameTextBox.Location = new System.Drawing.Point(77, 42);
            this.empNameTextBox.Name = "empNameTextBox";
            this.empNameTextBox.Size = new System.Drawing.Size(146, 20);
            this.empNameTextBox.TabIndex = 13;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(36, 42);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 12;
            this.label13.Text = "Name";
            // 
            // employeeClear
            // 
            this.employeeClear.Location = new System.Drawing.Point(128, 120);
            this.employeeClear.Name = "employeeClear";
            this.employeeClear.Size = new System.Drawing.Size(88, 23);
            this.employeeClear.TabIndex = 11;
            this.employeeClear.Text = "Clear";
            this.employeeClear.UseVisualStyleBackColor = true;
            this.employeeClear.Click += new System.EventHandler(this.employeeClear_Click);
            // 
            // employeeSearch
            // 
            this.employeeSearch.Location = new System.Drawing.Point(27, 120);
            this.employeeSearch.Name = "employeeSearch";
            this.employeeSearch.Size = new System.Drawing.Size(88, 23);
            this.employeeSearch.TabIndex = 11;
            this.employeeSearch.Text = "Search";
            this.employeeSearch.UseVisualStyleBackColor = true;
            this.employeeSearch.Click += new System.EventHandler(this.employeeSearch_Click);
            // 
            // empTitleSearchBox
            // 
            this.empTitleSearchBox.Location = new System.Drawing.Point(77, 68);
            this.empTitleSearchBox.Name = "empTitleSearchBox";
            this.empTitleSearchBox.Size = new System.Drawing.Size(146, 20);
            this.empTitleSearchBox.TabIndex = 7;
            // 
            // empSupervisorSearch
            // 
            this.empSupervisorSearch.Location = new System.Drawing.Point(77, 94);
            this.empSupervisorSearch.Name = "empSupervisorSearch";
            this.empSupervisorSearch.Size = new System.Drawing.Size(146, 20);
            this.empSupervisorSearch.TabIndex = 7;
            // 
            // empIdSearchBox
            // 
            this.empIdSearchBox.Location = new System.Drawing.Point(77, 13);
            this.empIdSearchBox.Name = "empIdSearchBox";
            this.empIdSearchBox.Size = new System.Drawing.Size(98, 20);
            this.empIdSearchBox.TabIndex = 5;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "Supervisor";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(44, 71);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Title";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 16);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Employee Id";
            // 
            // employeeGridView
            // 
            this.employeeGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.employeeGridView.Location = new System.Drawing.Point(22, 15);
            this.employeeGridView.Name = "employeeGridView";
            this.employeeGridView.Size = new System.Drawing.Size(844, 205);
            this.employeeGridView.TabIndex = 4;
            // 
            // checkedOutTab
            // 
            this.checkedOutTab.Controls.Add(this.checkedOutGridView);
            this.checkedOutTab.Location = new System.Drawing.Point(4, 22);
            this.checkedOutTab.Name = "checkedOutTab";
            this.checkedOutTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkedOutTab.Size = new System.Drawing.Size(893, 583);
            this.checkedOutTab.TabIndex = 3;
            this.checkedOutTab.Text = "Checked Out";
            this.checkedOutTab.UseVisualStyleBackColor = true;
            // 
            // checkedOutGridView
            // 
            this.checkedOutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkedOutGridView.Location = new System.Drawing.Point(13, 6);
            this.checkedOutGridView.Name = "checkedOutGridView";
            this.checkedOutGridView.Size = new System.Drawing.Size(512, 544);
            this.checkedOutGridView.TabIndex = 0;
            // 
            // adminTab
            // 
            this.adminTab.Location = new System.Drawing.Point(4, 22);
            this.adminTab.Name = "adminTab";
            this.adminTab.Padding = new System.Windows.Forms.Padding(3);
            this.adminTab.Size = new System.Drawing.Size(893, 583);
            this.adminTab.TabIndex = 4;
            this.adminTab.Text = "Admin";
            this.adminTab.UseVisualStyleBackColor = true;
            // 
            // checkoutTab
            // 
            this.checkoutTab.Location = new System.Drawing.Point(4, 22);
            this.checkoutTab.Name = "checkoutTab";
            this.checkoutTab.Padding = new System.Windows.Forms.Padding(3);
            this.checkoutTab.Size = new System.Drawing.Size(893, 583);
            this.checkoutTab.TabIndex = 5;
            this.checkoutTab.Text = "Check Out";
            this.checkoutTab.UseVisualStyleBackColor = true;
            // 
            // branchListBox
            // 
            this.branchListBox.FormattingEnabled = true;
            this.branchListBox.Location = new System.Drawing.Point(29, 5);
            this.branchListBox.Name = "branchListBox";
            this.branchListBox.Size = new System.Drawing.Size(136, 30);
            this.branchListBox.TabIndex = 2;
            this.branchListBox.SelectedIndexChanged += new System.EventHandler(this.branchListBox_SelectedIndexChanged);
            // 
            // AddContainer
            // 
            this.AddContainer.Controls.Add(this.btnAddBook);
            this.AddContainer.Controls.Add(this.cbAddCopiesAvilable);
            this.AddContainer.Controls.Add(this.txtAddCopies);
            this.AddContainer.Controls.Add(this.txtAddRating);
            this.AddContainer.Controls.Add(this.txtAddBranchID);
            this.AddContainer.Controls.Add(this.txtAddISBN);
            this.AddContainer.Controls.Add(this.txtAddAuthor);
            this.AddContainer.Controls.Add(this.txtAddTitle);
            this.AddContainer.Controls.Add(this.label20);
            this.AddContainer.Controls.Add(this.label19);
            this.AddContainer.Controls.Add(this.label18);
            this.AddContainer.Controls.Add(this.label17);
            this.AddContainer.Controls.Add(this.label16);
            this.AddContainer.Controls.Add(this.label15);
            this.AddContainer.Controls.Add(this.label14);
            this.AddContainer.Location = new System.Drawing.Point(271, 218);
            this.AddContainer.Name = "AddContainer";
            this.AddContainer.Size = new System.Drawing.Size(228, 252);
            this.AddContainer.TabIndex = 2;
            this.AddContainer.TabStop = false;
            this.AddContainer.Text = "Create";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(7, 19);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(27, 13);
            this.label14.TabIndex = 0;
            this.label14.Text = "Title";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(7, 42);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(38, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Author";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(7, 71);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(32, 13);
            this.label16.TabIndex = 2;
            this.label16.Text = "ISBN";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(7, 99);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 13);
            this.label17.TabIndex = 3;
            this.label17.Text = "branch";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(7, 129);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 4;
            this.label18.Text = "Rating";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(7, 164);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(39, 13);
            this.label19.TabIndex = 5;
            this.label19.Text = "Copies";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(10, 193);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(80, 13);
            this.label20.TabIndex = 6;
            this.label20.Text = "copies_avilable";
            // 
            // txtAddTitle
            // 
            this.txtAddTitle.Location = new System.Drawing.Point(86, 19);
            this.txtAddTitle.Name = "txtAddTitle";
            this.txtAddTitle.Size = new System.Drawing.Size(100, 20);
            this.txtAddTitle.TabIndex = 7;
            // 
            // txtAddAuthor
            // 
            this.txtAddAuthor.Location = new System.Drawing.Point(86, 46);
            this.txtAddAuthor.Name = "txtAddAuthor";
            this.txtAddAuthor.Size = new System.Drawing.Size(100, 20);
            this.txtAddAuthor.TabIndex = 8;
            // 
            // txtAddISBN
            // 
            this.txtAddISBN.Location = new System.Drawing.Point(86, 70);
            this.txtAddISBN.Name = "txtAddISBN";
            this.txtAddISBN.Size = new System.Drawing.Size(100, 20);
            this.txtAddISBN.TabIndex = 9;
            // 
            // txtAddBranchID
            // 
            this.txtAddBranchID.Location = new System.Drawing.Point(86, 102);
            this.txtAddBranchID.Name = "txtAddBranchID";
            this.txtAddBranchID.Size = new System.Drawing.Size(100, 20);
            this.txtAddBranchID.TabIndex = 10;
            // 
            // txtAddRating
            // 
            this.txtAddRating.Location = new System.Drawing.Point(86, 128);
            this.txtAddRating.Name = "txtAddRating";
            this.txtAddRating.Size = new System.Drawing.Size(100, 20);
            this.txtAddRating.TabIndex = 11;
            // 
            // txtAddCopies
            // 
            this.txtAddCopies.Location = new System.Drawing.Point(86, 164);
            this.txtAddCopies.Name = "txtAddCopies";
            this.txtAddCopies.Size = new System.Drawing.Size(100, 20);
            this.txtAddCopies.TabIndex = 12;
            // 
            // cbAddCopiesAvilable
            // 
            this.cbAddCopiesAvilable.AutoSize = true;
            this.cbAddCopiesAvilable.Location = new System.Drawing.Point(97, 193);
            this.cbAddCopiesAvilable.Name = "cbAddCopiesAvilable";
            this.cbAddCopiesAvilable.Size = new System.Drawing.Size(15, 14);
            this.cbAddCopiesAvilable.TabIndex = 13;
            this.cbAddCopiesAvilable.UseVisualStyleBackColor = true;
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(13, 220);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(198, 23);
            this.btnAddBook.TabIndex = 14;
            this.btnAddBook.Text = "Create a Book";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // gpDeleteBook
            // 
            this.gpDeleteBook.Controls.Add(this.btnDeleteBook);
            this.gpDeleteBook.Controls.Add(this.txtDeleteBookId);
            this.gpDeleteBook.Controls.Add(this.label21);
            this.gpDeleteBook.Location = new System.Drawing.Point(533, 218);
            this.gpDeleteBook.Name = "gpDeleteBook";
            this.gpDeleteBook.Size = new System.Drawing.Size(200, 115);
            this.gpDeleteBook.TabIndex = 3;
            this.gpDeleteBook.TabStop = false;
            this.gpDeleteBook.Text = "Delete";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(20, 41);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(46, 13);
            this.label21.TabIndex = 0;
            this.label21.Text = "Book ID";
            // 
            // txtDeleteBookId
            // 
            this.txtDeleteBookId.Location = new System.Drawing.Point(82, 41);
            this.txtDeleteBookId.Name = "txtDeleteBookId";
            this.txtDeleteBookId.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteBookId.TabIndex = 1;
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(23, 74);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(159, 23);
            this.btnDeleteBook.TabIndex = 2;
            this.btnDeleteBook.Text = "Delte a Book";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtCreateMemberBranchID);
            this.groupBox3.Controls.Add(this.txtCreateMemberAddress);
            this.groupBox3.Controls.Add(this.txtCreateMemberName);
            this.groupBox3.Controls.Add(this.btnCreateMember);
            this.groupBox3.Controls.Add(this.label24);
            this.groupBox3.Controls.Add(this.label23);
            this.groupBox3.Controls.Add(this.label22);
            this.groupBox3.Location = new System.Drawing.Point(290, 227);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(200, 136);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Create";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(7, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(35, 13);
            this.label22.TabIndex = 0;
            this.label22.Text = "Name";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(7, 45);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(45, 13);
            this.label23.TabIndex = 1;
            this.label23.Text = "Address";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(7, 71);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(55, 13);
            this.label24.TabIndex = 2;
            this.label24.Text = "Branch ID";
            // 
            // btnCreateMember
            // 
            this.btnCreateMember.Location = new System.Drawing.Point(10, 96);
            this.btnCreateMember.Name = "btnCreateMember";
            this.btnCreateMember.Size = new System.Drawing.Size(184, 23);
            this.btnCreateMember.TabIndex = 3;
            this.btnCreateMember.Text = "Create a Member";
            this.btnCreateMember.UseVisualStyleBackColor = true;
            this.btnCreateMember.Click += new System.EventHandler(this.btnCreateMember_Click);
            // 
            // txtCreateMemberName
            // 
            this.txtCreateMemberName.Location = new System.Drawing.Point(83, 20);
            this.txtCreateMemberName.Name = "txtCreateMemberName";
            this.txtCreateMemberName.Size = new System.Drawing.Size(100, 20);
            this.txtCreateMemberName.TabIndex = 4;
            // 
            // txtCreateMemberAddress
            // 
            this.txtCreateMemberAddress.Location = new System.Drawing.Point(83, 44);
            this.txtCreateMemberAddress.Name = "txtCreateMemberAddress";
            this.txtCreateMemberAddress.Size = new System.Drawing.Size(100, 20);
            this.txtCreateMemberAddress.TabIndex = 5;
            // 
            // txtCreateMemberBranchID
            // 
            this.txtCreateMemberBranchID.Location = new System.Drawing.Point(83, 70);
            this.txtCreateMemberBranchID.Name = "txtCreateMemberBranchID";
            this.txtCreateMemberBranchID.Size = new System.Drawing.Size(100, 20);
            this.txtCreateMemberBranchID.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnDeleteMember);
            this.groupBox4.Controls.Add(this.txtDeleteMemberID);
            this.groupBox4.Controls.Add(this.label25);
            this.groupBox4.Location = new System.Drawing.Point(515, 227);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete";
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(17, 26);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(59, 13);
            this.label25.TabIndex = 0;
            this.label25.Text = "Member ID";
            // 
            // txtDeleteMemberID
            // 
            this.txtDeleteMemberID.Location = new System.Drawing.Point(82, 23);
            this.txtDeleteMemberID.Name = "txtDeleteMemberID";
            this.txtDeleteMemberID.Size = new System.Drawing.Size(100, 20);
            this.txtDeleteMemberID.TabIndex = 1;
            // 
            // btnDeleteMember
            // 
            this.btnDeleteMember.Location = new System.Drawing.Point(33, 60);
            this.btnDeleteMember.Name = "btnDeleteMember";
            this.btnDeleteMember.Size = new System.Drawing.Size(139, 23);
            this.btnDeleteMember.TabIndex = 2;
            this.btnDeleteMember.Text = "Delete";
            this.btnDeleteMember.UseVisualStyleBackColor = true;
            this.btnDeleteMember.Click += new System.EventHandler(this.btnDeleteMember_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 662);
            this.Controls.Add(this.branchListBox);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabControl.ResumeLayout(false);
            this.booksTab.ResumeLayout(false);
            this.searchContainer.ResumeLayout(false);
            this.searchContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.membersTab.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.membersGridView)).EndInit();
            this.employeeTab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.employeeGridView)).EndInit();
            this.checkedOutTab.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkedOutGridView)).EndInit();
            this.AddContainer.ResumeLayout(false);
            this.AddContainer.PerformLayout();
            this.gpDeleteBook.ResumeLayout(false);
            this.gpDeleteBook.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage booksTab;
        private System.Windows.Forms.TabPage membersTab;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.ListBox branchListBox;
        private System.Windows.Forms.TabPage employeeTab;
        private System.Windows.Forms.TabPage checkedOutTab;
        private System.Windows.Forms.TabPage adminTab;
        private System.Windows.Forms.TabPage checkoutTab;
        private System.Windows.Forms.GroupBox searchContainer;
        private System.Windows.Forms.TextBox bookRatingMAXSearchBox;
        private System.Windows.Forms.TextBox bookRatingMINSearchBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox bookISBNSearchBox;
        private System.Windows.Forms.TextBox bookAuthorSearchBox;
        private System.Windows.Forms.TextBox bookIdSearchBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bookSearchClearBtn;
        private System.Windows.Forms.Button bookSearchBtn;
        private System.Windows.Forms.TextBox bookTitleSearchBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button memberClearBtn;
        private System.Windows.Forms.Button memberSearchBtn;
        private System.Windows.Forms.TextBox memberNameSearchBox;
        private System.Windows.Forms.TextBox memberAddressSearchBox;
        private System.Windows.Forms.TextBox memberIdSearchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView membersGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button employeeClear;
        private System.Windows.Forms.Button employeeSearch;
        private System.Windows.Forms.TextBox empTitleSearchBox;
        private System.Windows.Forms.TextBox empSupervisorSearch;
        private System.Windows.Forms.TextBox empIdSearchBox;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView employeeGridView;
        private System.Windows.Forms.TextBox empNameTextBox;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView checkedOutGridView;
        private System.Windows.Forms.GroupBox AddContainer;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.CheckBox cbAddCopiesAvilable;
        private System.Windows.Forms.TextBox txtAddCopies;
        private System.Windows.Forms.TextBox txtAddRating;
        private System.Windows.Forms.TextBox txtAddBranchID;
        private System.Windows.Forms.TextBox txtAddISBN;
        private System.Windows.Forms.TextBox txtAddAuthor;
        private System.Windows.Forms.TextBox txtAddTitle;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox gpDeleteBook;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.TextBox txtDeleteBookId;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnCreateMember;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtCreateMemberBranchID;
        private System.Windows.Forms.TextBox txtCreateMemberAddress;
        private System.Windows.Forms.TextBox txtCreateMemberName;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnDeleteMember;
        private System.Windows.Forms.TextBox txtDeleteMemberID;
        private System.Windows.Forms.Label label25;
    }
}

