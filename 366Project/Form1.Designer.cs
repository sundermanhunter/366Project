namespace _366Project
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
            this.adminTab = new System.Windows.Forms.TabPage();
            this.checkoutTab = new System.Windows.Forms.TabPage();
            this.branchListBox = new System.Windows.Forms.ListBox();
            this.empNameTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.checkedOutGridView = new System.Windows.Forms.DataGridView();
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
            // checkedOutGridView
            // 
            this.checkedOutGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.checkedOutGridView.Location = new System.Drawing.Point(13, 6);
            this.checkedOutGridView.Name = "checkedOutGridView";
            this.checkedOutGridView.Size = new System.Drawing.Size(512, 544);
            this.checkedOutGridView.TabIndex = 0;
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
    }
}

