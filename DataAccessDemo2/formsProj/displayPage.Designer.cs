namespace FindAJob
{
    partial class displayPage
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
            this.companyTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableTabs = new System.Windows.Forms.TabControl();
            this.companyTab = new System.Windows.Forms.TabPage();
            this.nameDisplay = new System.Windows.Forms.Label();
            this.companyDropDown = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.schoolTab = new System.Windows.Forms.TabPage();
            this.label23 = new System.Windows.Forms.Label();
            this.schoolDropDown = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.schoolTable = new System.Windows.Forms.TableLayoutPanel();
            this.candidatesTab = new System.Windows.Forms.TabPage();
            this.label24 = new System.Windows.Forms.Label();
            this.candidateDropDown = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.candidateTable = new System.Windows.Forms.TableLayoutPanel();
            this.salaryTab = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.salaryDropDown = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.salaryTable = new System.Windows.Forms.TableLayoutPanel();
            this.tableTabs.SuspendLayout();
            this.companyTab.SuspendLayout();
            this.schoolTab.SuspendLayout();
            this.candidatesTab.SuspendLayout();
            this.salaryTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // companyTable
            // 
            this.companyTable.AutoScroll = true;
            this.companyTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.companyTable.BackColor = System.Drawing.Color.White;
            this.companyTable.ColumnCount = 5;
            this.companyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.companyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.companyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.companyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.companyTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.companyTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyTable.Location = new System.Drawing.Point(165, 35);
            this.companyTable.Name = "companyTable";
            this.companyTable.RowCount = 1;
            this.companyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.companyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.companyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.companyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.companyTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.companyTable.Size = new System.Drawing.Size(707, 323);
            this.companyTable.TabIndex = 0;
            // 
            // tableTabs
            // 
            this.tableTabs.Controls.Add(this.companyTab);
            this.tableTabs.Controls.Add(this.schoolTab);
            this.tableTabs.Controls.Add(this.candidatesTab);
            this.tableTabs.Controls.Add(this.salaryTab);
            this.tableTabs.Location = new System.Drawing.Point(12, 12);
            this.tableTabs.Name = "tableTabs";
            this.tableTabs.SelectedIndex = 0;
            this.tableTabs.Size = new System.Drawing.Size(922, 404);
            this.tableTabs.TabIndex = 1;
            // 
            // companyTab
            // 
            this.companyTab.BackColor = System.Drawing.SystemColors.Control;
            this.companyTab.Controls.Add(this.nameDisplay);
            this.companyTab.Controls.Add(this.companyDropDown);
            this.companyTab.Controls.Add(this.label11);
            this.companyTab.Controls.Add(this.label5);
            this.companyTab.Controls.Add(this.label4);
            this.companyTab.Controls.Add(this.label3);
            this.companyTab.Controls.Add(this.label2);
            this.companyTab.Controls.Add(this.label1);
            this.companyTab.Controls.Add(this.companyTable);
            this.companyTab.Location = new System.Drawing.Point(4, 25);
            this.companyTab.Name = "companyTab";
            this.companyTab.Padding = new System.Windows.Forms.Padding(3);
            this.companyTab.Size = new System.Drawing.Size(914, 375);
            this.companyTab.TabIndex = 0;
            this.companyTab.Text = "By Company";
            // 
            // nameDisplay
            // 
            this.nameDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameDisplay.Location = new System.Drawing.Point(6, 12);
            this.nameDisplay.Name = "nameDisplay";
            this.nameDisplay.Size = new System.Drawing.Size(131, 54);
            this.nameDisplay.TabIndex = 15;
            this.nameDisplay.Text = "You Must Create A Profile to Apply to a Job";
            // 
            // companyDropDown
            // 
            this.companyDropDown.DropDownWidth = 150;
            this.companyDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.companyDropDown.FormattingEnabled = true;
            this.companyDropDown.Location = new System.Drawing.Point(9, 120);
            this.companyDropDown.Name = "companyDropDown";
            this.companyDropDown.Size = new System.Drawing.Size(121, 26);
            this.companyDropDown.TabIndex = 7;
            this.companyDropDown.SelectedIndexChanged += new System.EventHandler(this.companyChangeClick);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(6, 83);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(131, 18);
            this.label11.TabIndex = 6;
            this.label11.Text = "Filter by Company:";
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(801, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 23);
            this.label5.TabIndex = 5;
            this.label5.Text = "Apply";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(642, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(160, 23);
            this.label4.TabIndex = 4;
            this.label4.Text = "Application Due Date";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(483, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(160, 23);
            this.label3.TabIndex = 3;
            this.label3.Text = "Majors Accepted";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Job Type";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(165, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Job Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolTab
            // 
            this.schoolTab.BackColor = System.Drawing.SystemColors.Control;
            this.schoolTab.Controls.Add(this.label23);
            this.schoolTab.Controls.Add(this.schoolDropDown);
            this.schoolTab.Controls.Add(this.label12);
            this.schoolTab.Controls.Add(this.label7);
            this.schoolTab.Controls.Add(this.label8);
            this.schoolTab.Controls.Add(this.label9);
            this.schoolTab.Controls.Add(this.label10);
            this.schoolTab.Controls.Add(this.schoolTable);
            this.schoolTab.Location = new System.Drawing.Point(4, 25);
            this.schoolTab.Name = "schoolTab";
            this.schoolTab.Padding = new System.Windows.Forms.Padding(3);
            this.schoolTab.Size = new System.Drawing.Size(914, 375);
            this.schoolTab.TabIndex = 1;
            this.schoolTab.Text = "Popular Schools";
            // 
            // label23
            // 
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.Location = new System.Drawing.Point(17, 17);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(131, 54);
            this.label23.TabIndex = 14;
            this.label23.Text = "Where are your peers applying?";
            // 
            // schoolDropDown
            // 
            this.schoolDropDown.DropDownWidth = 150;
            this.schoolDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolDropDown.FormattingEnabled = true;
            this.schoolDropDown.Location = new System.Drawing.Point(20, 125);
            this.schoolDropDown.Name = "schoolDropDown";
            this.schoolDropDown.Size = new System.Drawing.Size(121, 26);
            this.schoolDropDown.TabIndex = 13;
            this.schoolDropDown.SelectedIndexChanged += new System.EventHandler(this.schoolChangeClick);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(17, 95);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(131, 18);
            this.label12.TabIndex = 12;
            this.label12.Text = "Filter by Company:";
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.White;
            this.label7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(705, 12);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 23);
            this.label7.TabIndex = 10;
            this.label7.Text = "Number of Applicants";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(529, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "Type of School";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(353, 12);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(177, 23);
            this.label9.TabIndex = 8;
            this.label9.Text = "School Mascot";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(177, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(177, 23);
            this.label10.TabIndex = 7;
            this.label10.Text = "School Name";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // schoolTable
            // 
            this.schoolTable.AutoScroll = true;
            this.schoolTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.schoolTable.BackColor = System.Drawing.Color.White;
            this.schoolTable.ColumnCount = 4;
            this.schoolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schoolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schoolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schoolTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.schoolTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolTable.Location = new System.Drawing.Point(177, 35);
            this.schoolTable.Name = "schoolTable";
            this.schoolTable.RowCount = 1;
            this.schoolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.schoolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.schoolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.schoolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.schoolTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.schoolTable.Size = new System.Drawing.Size(707, 323);
            this.schoolTable.TabIndex = 6;
            // 
            // candidatesTab
            // 
            this.candidatesTab.BackColor = System.Drawing.SystemColors.Control;
            this.candidatesTab.Controls.Add(this.label24);
            this.candidatesTab.Controls.Add(this.candidateDropDown);
            this.candidatesTab.Controls.Add(this.label6);
            this.candidatesTab.Controls.Add(this.label13);
            this.candidatesTab.Controls.Add(this.label14);
            this.candidatesTab.Controls.Add(this.label15);
            this.candidatesTab.Controls.Add(this.label16);
            this.candidatesTab.Controls.Add(this.label17);
            this.candidatesTab.Controls.Add(this.candidateTable);
            this.candidatesTab.Location = new System.Drawing.Point(4, 25);
            this.candidatesTab.Name = "candidatesTab";
            this.candidatesTab.Padding = new System.Windows.Forms.Padding(3);
            this.candidatesTab.Size = new System.Drawing.Size(914, 375);
            this.candidatesTab.TabIndex = 2;
            this.candidatesTab.Text = "Best Candidates";
            // 
            // label24
            // 
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(24, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(131, 54);
            this.label24.TabIndex = 16;
            this.label24.Text = "Based off GPA and Major, find the best fit for the job.";
            // 
            // candidateDropDown
            // 
            this.candidateDropDown.DropDownWidth = 150;
            this.candidateDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateDropDown.FormattingEnabled = true;
            this.candidateDropDown.Location = new System.Drawing.Point(27, 137);
            this.candidateDropDown.Name = "candidateDropDown";
            this.candidateDropDown.Size = new System.Drawing.Size(121, 26);
            this.candidateDropDown.TabIndex = 15;
            this.candidateDropDown.SelectedIndexChanged += new System.EventHandler(this.candidateChangeClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(24, 107);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(131, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "Filter by Company:";
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.White;
            this.label13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(730, 14);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(160, 23);
            this.label13.TabIndex = 13;
            this.label13.Text = "Last Name";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(571, 14);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(160, 23);
            this.label14.TabIndex = 12;
            this.label14.Text = "First Name";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(501, 14);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(71, 23);
            this.label15.TabIndex = 11;
            this.label15.Text = "GPA";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(342, 14);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(160, 23);
            this.label16.TabIndex = 10;
            this.label16.Text = "Major";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.BackColor = System.Drawing.Color.White;
            this.label17.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(183, 14);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(160, 23);
            this.label17.TabIndex = 9;
            this.label17.Text = "Job Title";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // candidateTable
            // 
            this.candidateTable.AutoScroll = true;
            this.candidateTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.candidateTable.BackColor = System.Drawing.Color.White;
            this.candidateTable.ColumnCount = 5;
            this.candidateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.candidateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.candidateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.candidateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.candidateTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.5F));
            this.candidateTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateTable.Location = new System.Drawing.Point(183, 37);
            this.candidateTable.Name = "candidateTable";
            this.candidateTable.RowCount = 1;
            this.candidateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.candidateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.candidateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.candidateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.candidateTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.candidateTable.Size = new System.Drawing.Size(707, 323);
            this.candidateTable.TabIndex = 8;
            // 
            // salaryTab
            // 
            this.salaryTab.BackColor = System.Drawing.SystemColors.Control;
            this.salaryTab.Controls.Add(this.label25);
            this.salaryTab.Controls.Add(this.salaryDropDown);
            this.salaryTab.Controls.Add(this.label18);
            this.salaryTab.Controls.Add(this.label19);
            this.salaryTab.Controls.Add(this.label20);
            this.salaryTab.Controls.Add(this.label21);
            this.salaryTab.Controls.Add(this.label22);
            this.salaryTab.Controls.Add(this.salaryTable);
            this.salaryTab.Location = new System.Drawing.Point(4, 25);
            this.salaryTab.Name = "salaryTab";
            this.salaryTab.Padding = new System.Windows.Forms.Padding(3);
            this.salaryTab.Size = new System.Drawing.Size(914, 375);
            this.salaryTab.TabIndex = 3;
            this.salaryTab.Text = "Best Salaries";
            // 
            // label25
            // 
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(23, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(131, 75);
            this.label25.TabIndex = 21;
            this.label25.Text = "Find what company is paying your major the most!";
            // 
            // salaryDropDown
            // 
            this.salaryDropDown.DropDownWidth = 150;
            this.salaryDropDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryDropDown.FormattingEnabled = true;
            this.salaryDropDown.Location = new System.Drawing.Point(26, 145);
            this.salaryDropDown.Name = "salaryDropDown";
            this.salaryDropDown.Size = new System.Drawing.Size(121, 26);
            this.salaryDropDown.TabIndex = 20;
            this.salaryDropDown.SelectedIndexChanged += new System.EventHandler(this.salaryChangeClick);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(23, 113);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(105, 18);
            this.label18.TabIndex = 19;
            this.label18.Text = "Filter by Major:";
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.White;
            this.label19.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(711, 14);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(180, 23);
            this.label19.TabIndex = 18;
            this.label19.Text = "GPA Requirement";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.White;
            this.label20.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(535, 14);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(177, 23);
            this.label20.TabIndex = 17;
            this.label20.Text = "Position Title";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.White;
            this.label21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(359, 14);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(177, 23);
            this.label21.TabIndex = 16;
            this.label21.Text = "Average Salary";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.White;
            this.label22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(183, 14);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(177, 23);
            this.label22.TabIndex = 15;
            this.label22.Text = "Company Name";
            this.label22.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // salaryTable
            // 
            this.salaryTable.AutoScroll = true;
            this.salaryTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.salaryTable.BackColor = System.Drawing.Color.White;
            this.salaryTable.ColumnCount = 4;
            this.salaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.salaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.salaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.salaryTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.salaryTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salaryTable.Location = new System.Drawing.Point(183, 37);
            this.salaryTable.Name = "salaryTable";
            this.salaryTable.RowCount = 1;
            this.salaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.salaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.salaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.salaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.salaryTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 323F));
            this.salaryTable.Size = new System.Drawing.Size(707, 323);
            this.salaryTable.TabIndex = 14;
            // 
            // displayPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(946, 453);
            this.Controls.Add(this.tableTabs);
            this.Name = "displayPage";
            this.Text = "Find A Job";
            this.tableTabs.ResumeLayout(false);
            this.companyTab.ResumeLayout(false);
            this.companyTab.PerformLayout();
            this.schoolTab.ResumeLayout(false);
            this.schoolTab.PerformLayout();
            this.candidatesTab.ResumeLayout(false);
            this.candidatesTab.PerformLayout();
            this.salaryTab.ResumeLayout(false);
            this.salaryTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel companyTable;
        private System.Windows.Forms.TabControl tableTabs;
        private System.Windows.Forms.TabPage companyTab;
        private System.Windows.Forms.TabPage schoolTab;
        private System.Windows.Forms.TabPage candidatesTab;
        private System.Windows.Forms.TabPage salaryTab;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox companyDropDown;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox schoolDropDown;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TableLayoutPanel schoolTable;
        private System.Windows.Forms.ComboBox candidateDropDown;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TableLayoutPanel candidateTable;
        private System.Windows.Forms.ComboBox salaryDropDown;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TableLayoutPanel salaryTable;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label nameDisplay;
    }
}