using System.Data;
using System.Data.SqlClient;

namespace PhilippineBaranggayRenewableEnergyProject
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            int selectedBrgyID = Convert.ToInt32(cmbBrgyID.SelectedItem);
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Insert into tbl_Baranggay
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO tbl_Barangay (BrgyName, Municipality, Province, Region) VALUES (@BrgyName, @Municipality, @Province, @Region)", connection))
                    {
                        cmd.Parameters.AddWithValue("@BrgyName", txtBrgyName.Text);
                        cmd.Parameters.AddWithValue("@Municipality", txtMunicipality.Text);
                        cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                        cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                        cmd.ExecuteNonQuery();
                    }

                    LoadDataIntoDataGridView();

                    MessageBox.Show("Saved Successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // This event can be used to handle changes in the text box, if needed
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // This event can be used to handle clicks on the label, if needed
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            LoadDataIntoDataGridView();
            LoadBarangayID();
        }

        private void LoadDataIntoDataGridView()
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to select data from tbl_Barangay
                    string queryBrgyTable = "SELECT Brgy_ID, BrgyName, Municipality, Province, Region FROM tbl_Barangay";

                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryBrgyTable, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridViewBrgy.DataSource = dataTable;
                    }

                    string queryProject = "SELECT ProjectID, ProjectName, EnergyType, Capacity,Brgy_ID FROM tbl_projects";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryProject, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridViewProjects.DataSource = dataTable;
                    }

                    string queryFunding = "SELECT FundingID, SourceName, FirstName, LastName, Gmail,FundingAmount FROM tbl_FundingSource";
                    using (SqlDataAdapter adapter = new SqlDataAdapter(queryFunding, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Bind the DataTable to the DataGridView
                        dataGridViewFundingSource.DataSource = dataTable;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }
        }

        private void LoadBarangayID()
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Query to select Brgy_ID values from tbl_Barangay
                    string query = "SELECT Brgy_ID FROM tbl_Barangay";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear existing items in ComboBox
                            cmbBrgyID.Items.Clear();

                            // Loop through the data and add Brgy_ID values to ComboBox
                            while (reader.Read())
                            {
                                cmbBrgyID.Items.Add(reader["Brgy_ID"].ToString());
                            }
                        }
                    }

                    // Optionally, select the first item by default
                    if (cmbBrgyID.Items.Count > 0)
                    {
                        cmbBrgyID.SelectedIndex = 0;
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

        }
        //Updating Barangay Data
        private void UpdateBarangay(int brgyID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE tbl_Barangay SET BrgyName = @BrgyName, Municipality = @Municipality, Province = @Province, Region = @Region WHERE Brgy_ID = @Brgy_ID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@BrgyName", txtBrgyName.Text);
                        cmd.Parameters.AddWithValue("@Municipality", txtMunicipality.Text);
                        cmd.Parameters.AddWithValue("@Province", txtProvince.Text);
                        cmd.Parameters.AddWithValue("@Region", txtRegion.Text);
                        cmd.Parameters.AddWithValue("@Brgy_ID", brgyID);  // Ensure the correct parameter name
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Barangay updated successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        //Updating Projects Data
        private void UpdateProject(int projectID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            int selectedBrgyID = Convert.ToInt32(cmbBrgyID.SelectedItem);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE tbl_projects SET ProjectName = @ProjectName, EnergyType = @EnergyType, Capacity = @Capacity, ProjectStatus = @ProjectStatus, Brgy_ID = @Brgy_ID WHERE ProjectID = @ProjectID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProjectName", textProject.Text);
                        cmd.Parameters.AddWithValue("@EnergyType", textEnergy.Text);
                        cmd.Parameters.AddWithValue("@Capacity", textCapacity.Text);
                        cmd.Parameters.AddWithValue("@ProjectStatus", textStatus.Text);
                        cmd.Parameters.AddWithValue("@Brgy_ID", selectedBrgyID);
                        cmd.Parameters.AddWithValue("@ProjectID", projectID);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Project updated successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        //Update funding

        private void UpdateFundingSource(int fundID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "UPDATE tbl_FundingSource SET SourceName = @SourceName, FirstName = @FirstName, LastName = @LastName, Gmail = @Gmail, FundingAmount = @FundingAmount WHERE FundingID = @FundingID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SourceName", textSource.Text);
                        cmd.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", textLastName.Text);
                        cmd.Parameters.AddWithValue("@Gmail", textGmail.Text);
                        cmd.Parameters.AddWithValue("@FundingAmount", textFunding.Text);
                        cmd.Parameters.AddWithValue("@FundingID", fundID);

                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Funding Source updated successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void FetchDataForSelectedBrgy(int brgyID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tbl_Barangay WHERE Brgy_ID = @Brgy_ID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@Brgy_ID", brgyID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtBrgyName.Text = reader["BrgyName"].ToString();
                            txtMunicipality.Text = reader["Municipality"].ToString();
                            txtProvince.Text = reader["Province"].ToString();
                            txtRegion.Text = reader["Region"].ToString();
                        }
                    }
                }
            }
        }
        private void FetchDataForSelectedProject(int projectID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tbl_projects WHERE ProjectID = @ProjectID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@ProjectID", projectID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textProject.Text = reader["ProjectName"].ToString();
                            textEnergy.Text = reader["EnergyType"].ToString();
                            textCapacity.Text = reader["Capacity"].ToString();
                            textStatus.Text = reader["ProjectStatus"].ToString();
                            int brgyID = Convert.ToInt32(reader["Brgy_ID"]);
                            cmbBrgyID.SelectedValue = brgyID;
                        }
                    }
                }
            }
        }

        private void FetchDataForSelectedFunding(int fundID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT * FROM tbl_FundingSource WHERE FundingID = @FundingID";
                using (SqlCommand cmd = new SqlCommand(query, connection))
                {
                    cmd.Parameters.AddWithValue("@FundingID", fundID);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            textSource.Text = reader["SourceName"].ToString();
                            textFirstName.Text = reader["FirstName"].ToString();
                            textLastName.Text = reader["LastName"].ToString();
                            textGmail.Text = reader["Gmail"].ToString();
                            textFunding.Text = reader["FundingAmount"].ToString();
                        }
                    }
                }
            }

        }

        private void DeleteBarangay(int brgyID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tbl_Barangay WHERE Brgy_ID = @Brgy_ID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Brgy_ID", brgyID);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Barangay deleted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DeleteProject(int projectID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tbl_projects WHERE ProjectID = @ProjectID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProjectID", projectID);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Project deleted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void DeleteFundingSource(int fundID)
        {
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string query = "DELETE FROM tbl_FundingSource WHERE FundingID = @FundingID";
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@FundingID", fundID);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Funding Source deleted successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void fundingAmount_Click(object sender, EventArgs e)
        {

        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridViewBrgy.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewBrgy.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedBrgyID = Convert.ToInt32(selectedRow.Cells["Brgy_ID"].Value);

                // Delete the selected row from the database
                DeleteBarangay(selectedBrgyID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {





        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbl_projects (ProjectName, EnergyType, Capacity, ProjectStatus, Brgy_ID) VALUES (@ProjectName, @EnergyType, @Capacity, @ProjectStatus, @Brgy_ID)";
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            int selectedBrgyID = Convert.ToInt32(cmbBrgyID.SelectedItem);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@ProjectName", textProject.Text);
                        cmd.Parameters.AddWithValue("@EnergyType", textEnergy.Text);
                        cmd.Parameters.AddWithValue("@Capacity", textCapacity.Text);
                        cmd.Parameters.AddWithValue("@ProjectStatus", textStatus.Text);
                        cmd.Parameters.AddWithValue("@Brgy_ID", selectedBrgyID);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Saved Successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }
        }
        //Inserting Values to Table
        private void button6_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO tbl_fundingSource (SourceName, FirstName, LastName, Gmail,FundingAmount ) VALUES (@SourceName, @FirstName, @LastName, @Gmail, @FundingAmount)";
            string connectionString = "Data Source=DESKTOP-RH92DIM\\SQLEXPRESS;Initial Catalog=JOYDB;Integrated Security=True;TrustServerCertificate=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@SourceName", textSource.Text);
                        cmd.Parameters.AddWithValue("@FirstName", textFirstName.Text);
                        cmd.Parameters.AddWithValue("@LastName", textLastName.Text);
                        cmd.Parameters.AddWithValue("@Gmail", gmail.Text);
                        cmd.Parameters.AddWithValue("@FundingAmount", textFunding.Text);
                        cmd.ExecuteNonQuery();
                    }
                    LoadDataIntoDataGridView();
                    MessageBox.Show("Saved Successfully");
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    connection.Close();
                }


            }
        }



        private void btn_view_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click_1(object sender, EventArgs e)
        {

        }
        //Update Button
        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridViewBrgy.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewBrgy.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedBrgyID = Convert.ToInt32(selectedRow.Cells["Brgy_ID"].Value);

                // Update the barangay details in the database
                UpdateBarangay(selectedBrgyID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewBrgy.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewBrgy.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedBrgyID = Convert.ToInt32(selectedRow.Cells["Brgy_ID"].Value);

                // Fetch detailed information based on the selectedBrgyID
                FetchDataForSelectedBrgy(selectedBrgyID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }

        private void btn_update_Click(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewProjects.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedProjectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value);

                // Update the project details in the database
                UpdateProject(selectedProjectID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }

        }
        // Retrieve Project
        private void btn_view_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewProjects.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedProjectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value);
                // Fetch detailed information based on the selectedProjectID
                FetchDataForSelectedProject(selectedProjectID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }
        //Update Button
        private void button7_Click(object sender, EventArgs e)
        {

        }
        //Retriving Funding data
        private void button8_Click_2(object sender, EventArgs e)
        {

        }

        private void button8_Click_3(object sender, EventArgs e)
        {
            if (dataGridViewFundingSource.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewFundingSource.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int fundingID = Convert.ToInt32(selectedRow.Cells["FundingID"].Value);
                // Fetch detailed information based on the selectedProjectID
                FetchDataForSelectedFunding(fundingID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }
        //Updating Funding Button 
        private void button7_Click_1(object sender, EventArgs e)
        {

        }

        private void button7_Click_2(object sender, EventArgs e)
        {
            if (dataGridViewFundingSource.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewFundingSource.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedFundID = Convert.ToInt32(selectedRow.Cells["FundingID"].Value);

                // Update the funding source details in the database
                UpdateFundingSource(selectedFundID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }

        private void btn_deleteProject_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteProject_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewProjects.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewProjects.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedProjectID = Convert.ToInt32(selectedRow.Cells["ProjectID"].Value);

                // Delete the selected row from the database
                DeleteProject(selectedProjectID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }
        }

        private void btn_deleteFunding_Click(object sender, EventArgs e)
        {

        }

        private void btn_deleteFunding_Click_1(object sender, EventArgs e)
        {
            if (dataGridViewFundingSource.SelectedRows.Count > 0)
            {
                // Get the selected row
                DataGridViewRow selectedRow = dataGridViewFundingSource.SelectedRows[0];

                // Retrieve the primary key or unique identifier from the selected row
                int selectedFundID = Convert.ToInt32(selectedRow.Cells["FundingID"].Value);

                // Delete the selected row from the database
                DeleteFundingSource(selectedFundID);
            }
            else
            {
                MessageBox.Show("Please select a row in the DataGridView first.");
            }

        }
    }
}
