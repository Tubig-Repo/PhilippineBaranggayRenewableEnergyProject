namespace PhilippineBaranggayRenewableEnergyProject
{
    partial class Dashboard
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtBrgyName = new TextBox();
            txtMunicipality = new TextBox();
            txtProvince = new TextBox();
            btn_create = new Button();
            btn_view = new Button();
            btn_update = new Button();
            btn_deleteBrgy = new Button();
            txtRegion = new TextBox();
            label5 = new Label();
            dataGridViewBrgy = new DataGridView();
            textProject = new TextBox();
            projectName = new Label();
            energyType = new Label();
            textEnergy = new TextBox();
            label1 = new Label();
            label6 = new Label();
            textCapacity = new TextBox();
            projectStatus = new Label();
            textStatus = new TextBox();
            fundingSource = new Label();
            textGmail = new TextBox();
            gmail = new Label();
            textLastName = new TextBox();
            lastName = new Label();
            textFirstName = new TextBox();
            firstName = new Label();
            sourceName = new Label();
            textSource = new TextBox();
            Barangay = new Label();
            dataGridViewProjects = new DataGridView();
            dataGridViewFundingSource = new DataGridView();
            fundingAmount = new Label();
            textFunding = new TextBox();
            cmbBrgyID = new ComboBox();
            label7 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            btn_deleteProject = new Button();
            btn_deleteFunding = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrgy).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFundingSource).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 87);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 1;
            label2.Text = "Baranggay Name:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 164);
            label3.Name = "label3";
            label3.Size = new Size(76, 15);
            label3.TabIndex = 2;
            label3.Text = "Municipality:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 124);
            label4.Name = "label4";
            label4.Size = new Size(56, 15);
            label4.TabIndex = 3;
            label4.Text = "Province:";
            // 
            // txtBrgyName
            // 
            txtBrgyName.Location = new Point(119, 87);
            txtBrgyName.Name = "txtBrgyName";
            txtBrgyName.Size = new Size(295, 23);
            txtBrgyName.TabIndex = 5;
            // 
            // txtMunicipality
            // 
            txtMunicipality.Location = new Point(119, 161);
            txtMunicipality.Name = "txtMunicipality";
            txtMunicipality.Size = new Size(295, 23);
            txtMunicipality.TabIndex = 6;
            // 
            // txtProvince
            // 
            txtProvince.Location = new Point(119, 124);
            txtProvince.Name = "txtProvince";
            txtProvince.Size = new Size(295, 23);
            txtProvince.TabIndex = 7;
            // 
            // btn_create
            // 
            btn_create.Location = new Point(8, 240);
            btn_create.Name = "btn_create";
            btn_create.Size = new Size(100, 40);
            btn_create.TabIndex = 8;
            btn_create.Text = "Create/Insert";
            btn_create.UseVisualStyleBackColor = true;
            btn_create.Click += btn_create_Click;
            // 
            // btn_view
            // 
            btn_view.Location = new Point(119, 532);
            btn_view.Name = "btn_view";
            btn_view.Size = new Size(100, 40);
            btn_view.TabIndex = 9;
            btn_view.Text = "Retrieve/View";
            btn_view.UseVisualStyleBackColor = true;
            btn_view.Click += btn_view_Click_1;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(225, 532);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(100, 40);
            btn_update.TabIndex = 10;
            btn_update.Text = "Update";
            btn_update.UseVisualStyleBackColor = true;
            btn_update.Click += btn_update_Click;
            // 
            // btn_deleteBrgy
            // 
            btn_deleteBrgy.Location = new Point(331, 240);
            btn_deleteBrgy.Name = "btn_deleteBrgy";
            btn_deleteBrgy.Size = new Size(100, 40);
            btn_deleteBrgy.TabIndex = 11;
            btn_deleteBrgy.Text = "Delete";
            btn_deleteBrgy.UseVisualStyleBackColor = true;
            btn_deleteBrgy.Click += btn_delete_Click;
            // 
            // txtRegion
            // 
            txtRegion.Location = new Point(119, 198);
            txtRegion.Name = "txtRegion";
            txtRegion.Size = new Size(295, 23);
            txtRegion.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(13, 206);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 14;
            label5.Text = "Region:";
            // 
            // dataGridViewBrgy
            // 
            dataGridViewBrgy.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewBrgy.Location = new Point(576, 59);
            dataGridViewBrgy.Name = "dataGridViewBrgy";
            dataGridViewBrgy.RowTemplate.Height = 25;
            dataGridViewBrgy.Size = new Size(559, 185);
            dataGridViewBrgy.TabIndex = 15;
            // 
            // textProject
            // 
            textProject.Location = new Point(118, 324);
            textProject.Name = "textProject";
            textProject.Size = new Size(294, 23);
            textProject.TabIndex = 16;
            // 
            // projectName
            // 
            projectName.AutoSize = true;
            projectName.Location = new Point(12, 332);
            projectName.Name = "projectName";
            projectName.Size = new Size(79, 15);
            projectName.TabIndex = 17;
            projectName.Text = "Project Name";
            projectName.Click += label1_Click;
            // 
            // energyType
            // 
            energyType.AutoSize = true;
            energyType.Location = new Point(13, 376);
            energyType.Name = "energyType";
            energyType.Size = new Size(70, 15);
            energyType.TabIndex = 18;
            energyType.Text = "Energy Type";
            // 
            // textEnergy
            // 
            textEnergy.Location = new Point(118, 368);
            textEnergy.Name = "textEnergy";
            textEnergy.Size = new Size(294, 23);
            textEnergy.TabIndex = 19;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(8, 283);
            label1.Name = "label1";
            label1.Size = new Size(80, 30);
            label1.TabIndex = 20;
            label1.Text = "Project";
            label1.Click += label1_Click_1;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 416);
            label6.Name = "label6";
            label6.Size = new Size(53, 15);
            label6.TabIndex = 21;
            label6.Text = "Capacity";
            // 
            // textCapacity
            // 
            textCapacity.Location = new Point(118, 413);
            textCapacity.Name = "textCapacity";
            textCapacity.Size = new Size(294, 23);
            textCapacity.TabIndex = 22;
            // 
            // projectStatus
            // 
            projectStatus.AutoSize = true;
            projectStatus.Location = new Point(12, 459);
            projectStatus.Name = "projectStatus";
            projectStatus.Size = new Size(79, 15);
            projectStatus.TabIndex = 23;
            projectStatus.Text = "Project Status";
            // 
            // textStatus
            // 
            textStatus.Location = new Point(118, 451);
            textStatus.Name = "textStatus";
            textStatus.Size = new Size(294, 23);
            textStatus.TabIndex = 24;
            // 
            // fundingSource
            // 
            fundingSource.AutoSize = true;
            fundingSource.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            fundingSource.Location = new Point(9, 592);
            fundingSource.Name = "fundingSource";
            fundingSource.Size = new Size(162, 30);
            fundingSource.TabIndex = 25;
            fundingSource.Text = "Funding Source";
            // 
            // textGmail
            // 
            textGmail.Location = new Point(118, 770);
            textGmail.Name = "textGmail";
            textGmail.Size = new Size(294, 23);
            textGmail.TabIndex = 33;
            // 
            // gmail
            // 
            gmail.AutoSize = true;
            gmail.Location = new Point(12, 778);
            gmail.Name = "gmail";
            gmail.Size = new Size(38, 15);
            gmail.TabIndex = 32;
            gmail.Text = "Gmail";
            // 
            // textLastName
            // 
            textLastName.Location = new Point(118, 732);
            textLastName.Name = "textLastName";
            textLastName.Size = new Size(294, 23);
            textLastName.TabIndex = 31;
            // 
            // lastName
            // 
            lastName.AutoSize = true;
            lastName.Location = new Point(13, 735);
            lastName.Name = "lastName";
            lastName.Size = new Size(63, 15);
            lastName.TabIndex = 30;
            lastName.Text = "Last Name";
            // 
            // textFirstName
            // 
            textFirstName.Location = new Point(118, 687);
            textFirstName.Name = "textFirstName";
            textFirstName.Size = new Size(294, 23);
            textFirstName.TabIndex = 29;
            // 
            // firstName
            // 
            firstName.AutoSize = true;
            firstName.Location = new Point(13, 695);
            firstName.Name = "firstName";
            firstName.Size = new Size(64, 15);
            firstName.TabIndex = 28;
            firstName.Text = "First Name";
            // 
            // sourceName
            // 
            sourceName.AutoSize = true;
            sourceName.Location = new Point(12, 651);
            sourceName.Name = "sourceName";
            sourceName.Size = new Size(78, 15);
            sourceName.TabIndex = 27;
            sourceName.Text = "Source Name";
            // 
            // textSource
            // 
            textSource.Location = new Point(118, 643);
            textSource.Name = "textSource";
            textSource.Size = new Size(294, 23);
            textSource.TabIndex = 26;
            // 
            // Barangay
            // 
            Barangay.AutoSize = true;
            Barangay.Font = new Font("Segoe UI Semibold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Barangay.Location = new Point(10, 40);
            Barangay.Name = "Barangay";
            Barangay.Size = new Size(103, 30);
            Barangay.TabIndex = 34;
            Barangay.Text = "Barangay";
            // 
            // dataGridViewProjects
            // 
            dataGridViewProjects.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProjects.Location = new Point(576, 324);
            dataGridViewProjects.Name = "dataGridViewProjects";
            dataGridViewProjects.RowTemplate.Height = 25;
            dataGridViewProjects.Size = new Size(559, 200);
            dataGridViewProjects.TabIndex = 35;
            // 
            // dataGridViewFundingSource
            // 
            dataGridViewFundingSource.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFundingSource.Location = new Point(576, 627);
            dataGridViewFundingSource.Name = "dataGridViewFundingSource";
            dataGridViewFundingSource.RowTemplate.Height = 25;
            dataGridViewFundingSource.Size = new Size(559, 236);
            dataGridViewFundingSource.TabIndex = 36;
            // 
            // fundingAmount
            // 
            fundingAmount.AutoSize = true;
            fundingAmount.Location = new Point(12, 816);
            fundingAmount.Name = "fundingAmount";
            fundingAmount.Size = new Size(101, 15);
            fundingAmount.TabIndex = 41;
            fundingAmount.Text = "Funding  Amount";
            fundingAmount.Click += fundingAmount_Click;
            // 
            // textFunding
            // 
            textFunding.Location = new Point(119, 813);
            textFunding.Name = "textFunding";
            textFunding.Size = new Size(294, 23);
            textFunding.TabIndex = 40;
            // 
            // cmbBrgyID
            // 
            cmbBrgyID.FormattingEnabled = true;
            cmbBrgyID.Location = new Point(117, 495);
            cmbBrgyID.Name = "cmbBrgyID";
            cmbBrgyID.Size = new Size(295, 23);
            cmbBrgyID.TabIndex = 42;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(13, 498);
            label7.Name = "label7";
            label7.Size = new Size(70, 15);
            label7.TabIndex = 43;
            label7.Text = "Barangay ID";
            // 
            // button1
            // 
            button1.Location = new Point(10, 532);
            button1.Name = "button1";
            button1.Size = new Size(100, 40);
            button1.TabIndex = 44;
            button1.Text = "Create/Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // button2
            // 
            button2.Location = new Point(114, 240);
            button2.Name = "button2";
            button2.Size = new Size(100, 40);
            button2.TabIndex = 45;
            button2.Text = "Retrieve/View";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click_1;
            // 
            // button3
            // 
            button3.Location = new Point(220, 240);
            button3.Name = "button3";
            button3.Size = new Size(100, 40);
            button3.TabIndex = 46;
            button3.Text = "Update";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // btn_deleteProject
            // 
            btn_deleteProject.Location = new Point(331, 532);
            btn_deleteProject.Name = "btn_deleteProject";
            btn_deleteProject.Size = new Size(100, 40);
            btn_deleteProject.TabIndex = 47;
            btn_deleteProject.Text = "Delete";
            btn_deleteProject.UseVisualStyleBackColor = true;
            btn_deleteProject.Click += btn_deleteProject_Click_1;
            // 
            // btn_deleteFunding
            // 
            btn_deleteFunding.Location = new Point(332, 855);
            btn_deleteFunding.Name = "btn_deleteFunding";
            btn_deleteFunding.Size = new Size(100, 40);
            btn_deleteFunding.TabIndex = 51;
            btn_deleteFunding.Text = "Delete";
            btn_deleteFunding.UseVisualStyleBackColor = true;
            btn_deleteFunding.Click += btn_deleteFunding_Click_1;
            // 
            // button6
            // 
            button6.Location = new Point(11, 855);
            button6.Name = "button6";
            button6.Size = new Size(100, 40);
            button6.TabIndex = 50;
            button6.Text = "Create/Insert";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(226, 855);
            button7.Name = "button7";
            button7.Size = new Size(100, 40);
            button7.TabIndex = 49;
            button7.Text = "Update";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click_2;
            // 
            // button8
            // 
            button8.Location = new Point(120, 855);
            button8.Name = "button8";
            button8.Size = new Size(100, 40);
            button8.TabIndex = 48;
            button8.Text = "Retrieve/View";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click_3;
            // 
            // Dashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1210, 1041);
            Controls.Add(btn_deleteFunding);
            Controls.Add(button6);
            Controls.Add(button7);
            Controls.Add(button8);
            Controls.Add(btn_deleteProject);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label7);
            Controls.Add(cmbBrgyID);
            Controls.Add(fundingAmount);
            Controls.Add(textFunding);
            Controls.Add(dataGridViewFundingSource);
            Controls.Add(dataGridViewProjects);
            Controls.Add(Barangay);
            Controls.Add(textGmail);
            Controls.Add(gmail);
            Controls.Add(textLastName);
            Controls.Add(lastName);
            Controls.Add(textFirstName);
            Controls.Add(firstName);
            Controls.Add(sourceName);
            Controls.Add(textSource);
            Controls.Add(fundingSource);
            Controls.Add(textStatus);
            Controls.Add(projectStatus);
            Controls.Add(textCapacity);
            Controls.Add(label6);
            Controls.Add(label1);
            Controls.Add(textEnergy);
            Controls.Add(energyType);
            Controls.Add(projectName);
            Controls.Add(textProject);
            Controls.Add(dataGridViewBrgy);
            Controls.Add(label5);
            Controls.Add(txtRegion);
            Controls.Add(btn_deleteBrgy);
            Controls.Add(btn_update);
            Controls.Add(btn_view);
            Controls.Add(btn_create);
            Controls.Add(txtProvince);
            Controls.Add(txtMunicipality);
            Controls.Add(txtBrgyName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Dashboard";
            Text = "Philippine Barangay Energy Renewal Management System (Database)";
            Load += Dashboard_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewBrgy).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProjects).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFundingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label projectName;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtbrgyID;
        private TextBox txtBrgyName;
        private TextBox txtMunicipality;
        private TextBox txtProvince;
        private Button btn_create;
        private Button btn_view;
        private Button btn_update;
        private Button btn_deleteBrgy;
        private TextBox txtRegion;
        private Label label5;
        private Label label6;
        private Label projectStatus;
        private TextBox txtStatusID;
        private TextBox txtStatusn;
        private TextBox txtCapacity;
        private TextBox txtProjectName;
        private TextBox txtProjectID;
        private TextBox txtEnergyType;
        private TextBox txtFundingID;
        private TextBox txtSourceName;
        private TextBox txtLastName;
        private TextBox txtBeneficiaryID;
        private TextBox txtGmail;
        private TextBox txtFirstName;
        private TextBox txtAmount;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private DataGridView dataGridViewBrgy;
        private TextBox textProject;
        private Label energyType;
        private TextBox textEnergy;
        private Label label1;
        private TextBox textCapacity;
        private TextBox textStatus;
        private Label fundingSource;
        private TextBox textGmail;
        private Label gmail;
        private TextBox textLastName;
        private Label lastName;
        private TextBox textFirstName;
        private Label firstName;
        private Label sourceName;
        private TextBox textSource;
        private Label Barangay;
        private DataGridView dataGridViewProjects;
        private DataGridView dataGridViewFundingSource;
        private Label fundingAmount;
        private TextBox textFunding;
        private ComboBox cmbBrgyID;
        private Label label7;
        private Button button1;
        private Button button2;
        private Button button3;
        private Button btn_deleteProject;
        private Button btn_deleteFunding;
        private Button button6;
        private Button button7;
        private Button button8;
    }
}