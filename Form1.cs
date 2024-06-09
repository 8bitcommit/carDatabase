using Microsoft.Data.SqlClient;

namespace project291
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

        private void ShowError(string message)
        {
            NotificationLabel.ForeColor = Color.Red;
            NotificationLabel.Text = message;
            NotificationLabel.Show();

            HideNotificationTimer.Stop();
            HideNotificationTimer.Start();
        }

        private void ShowSuccess(string message)
        {
            NotificationLabel.ForeColor = Color.Green;
            NotificationLabel.Text = message;
            NotificationLabel.Show();

            HideNotificationTimer.Stop();
            HideNotificationTimer.Start();
        }

        private void HideNotificationTimer_Tick(object sender, EventArgs e)
        {
            NotificationLabel.Hide();
            HideNotificationTimer.Stop();
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (AddRadioButton.Checked)
            {

            }
            else if (ModifyRadioButton.Checked)
            {
                ModifyCar();
            }
            else if (DeleteRadioButton.Checked)
            {

            }
            else if (SearchRadioButton.Checked)
            {

            }
        }

        private CarInput GetCarFromUI()
        {
            return new CarInput()
            {
                VIN = VINTextBox.Text.Trim(),
                LicensePlate = LicensePlateTextBox.Text.Trim(),
                Kilometers = KilometersTextBox.Text.Trim(),
                Make = MakeTextBox.Text.Trim(),
                Model = ModelTextBox.Text.Trim(),
                Colour = ColourTextBox.Text.Trim(),
                VehicleType = VehicleTypeComboBox.Text.Trim(),
            };
        }

        private bool ValidateDataForModify(CarInput carInput)
        {
            if(carInput.VIN.Length != 17)
            {
                ShowError("Vin is not 17 long");
                return false;
            }

            if(carInput.Kilometers != "")
            {
                if(long.TryParse(carInput.Kilometers, out var kms))
                {
                    if(kms < 0 || kms > 10000000)
                    {
                        ShowError("Kilometers must be between 0 and 10 million");
                        return false;
                    }
                }
                else
                {
                    ShowError("Kilometers must be a number");
                    return false;
                }
            }
           

               return true;
        }

        private void ModifyCar()
        {
            var carInput = GetCarFromUI();

            if(ValidateDataForModify(carInput))
            {
                ShowSuccess("Success");
            }

            //do dangerous operation knowing it's correct
        }
    }
}

