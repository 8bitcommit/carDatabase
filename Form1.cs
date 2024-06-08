using Microsoft.Data.SqlClient;

namespace LAB6291
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server = Bubbles; Database = Project_group3; Trusted_Connection = yes; TrustServerCertificate=true;";

            var myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
                this.Close();
            }
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {
            string mes = "Reservation from " + BranchComboBox.Text + " branch \nFrom Date: " + PickUpPicker.Text + " To Date: " + DropOffPicker.Text + "\nFor:" + (DropOffPicker.Value - PickUpPicker.Value).Days.ToString() + " days is Confirmed";
            MessageBox.Show(mes);
        }

        private void AddBranchButton_Click(object sender, EventArgs e)
        {
            BranchComboBox.Items.Add("London");
        }

        private void DifferentLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (DifferentLocationCheckBox.Checked)
            {
                ReturnBranchLabel.Visible = true;
                ReturnComboBox.Visible = true;
            }
            else
            {
                ReturnBranchLabel.Visible = false;
                ReturnComboBox.Visible = false;
            }
        }
    }
}

