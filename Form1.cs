using Microsoft.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace project291
{
    public partial class Form1 : Form
    {
        public SqlConnection myConnection;
        public SqlCommand myCommand;
        public SqlDataReader myReader;
        private bool fillMissingFields = false;

        public Form1()
        {
            InitializeComponent();
            string connectionString = "Server = LAPTOP-ITDAE565\\SQLEXPRESS; Database = Project_group3; Trusted_Connection = yes; TrustServerCertificate=true;";

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
            string title = "Confirm Reservation";
            string message = "Do you wish to confirm this reservation?\n\n"+ vehType.Text +" Vehicle\nPick-up at " + pBranch.Text + " \nDate: " + PickUpPicker.Text + "\nReturn: " + DropOffPicker.Text + "\nTotal days: " + (DropOffPicker.Value - PickUpPicker.Value).Days.ToString() + " days";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.OK)
            {
                // total will be calculated price from Database
                double total = 100.00;

                Price.Text = total.ToString("C2");//display price in dollar format
                Price.Visible = true;
            }
        }

        private void AddBranchButton_Click(object sender, EventArgs e)
        {
            pBranch.Items.Add("London");
        }

        private void DifferentLocationCheckBox_CheckedChanged(object sender, EventArgs e)
        {

            if (DifferentLocationCheckBox.Checked)
            {
                rBranch.Visible = true;
                ReturnComboBox.Visible = true;
            }
            else
            {
                rBranch.Visible = false;
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
                AddCar();
            }
            else if (ModifyRadioButton.Checked)
            {
                ModifyCar();
            }
            else if (DeleteRadioButton.Checked)
            {
                DeleteCar();
            }
            else if (SearchRadioButton.Checked)
            {
                SearchCar();
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
            if (carInput.VIN.Length != 17)
            {
                ShowError("Vin is not 17 long");
                return false;
            }

            if (carInput.Kilometers != "")
            {
                if (long.TryParse(carInput.Kilometers, out var kms))
                {
                    if (kms < 0 || kms > 10000000)
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

            if (ValidateDataForModify(carInput))
            {
                UpdateDatabaseForModify(carInput);
            }
        }

        private void UpdateDatabaseForModify(CarInput carInput)
        {
            try
            {
                var updates = new List<string>();

                if (carInput.LicensePlate != "")
                {
                    updates.Add($"LicensePlate='{carInput.LicensePlate}'");
                }

                if (carInput.Kilometers != "")
                {
                    updates.Add($"Kilometers={carInput.Kilometers}");
                }

                if (carInput.Make != "")
                {
                    updates.Add($"Make='{carInput.Make}'");
                }

                if (carInput.Model != "")
                {
                    updates.Add($"Model='{carInput.Model}'");
                }

                if (carInput.Colour != "")
                {
                    updates.Add($"Colour='{carInput.Colour}'");
                }

                if (carInput.VehicleType != "")
                {
                    updates.Add($"vType='{carInput.VehicleType}'");
                }


                var updateString = "";

                for (int i = 0; i < updates.Count; i++)
                {
                    if (i == 0)
                    {
                        updateString += updates[i];
                    }
                    if (i > 0)
                    {
                        updateString += ", " + updates[i];
                    }

                }

                if (updates.Count == 0)
                {
                    ShowSuccess("No updates to perform");
                    return;
                }

                myCommand.CommandText = $"UPDATE Vehicle SET {updateString} WHERE VIN = '{carInput.VIN}';";
                MessageBox.Show(myCommand.CommandText);

                var rowsUpdated = myCommand.ExecuteNonQuery();
                if (rowsUpdated > 0)
                {
                    ShowSuccess("Success");
                }
                else
                {
                    ShowError("Car with that VIN not found");
                }
            }
            catch (Exception e2)
            {
                ShowError("Error: " + e2.ToString());
            }
        }

        private void DeleteCar()
        {
            var carInput = GetCarFromUI();

            try
            {
                if (carInput.VIN.Length == 17)
                {
                    myCommand.CommandText = $"delete from Vehicle where VIN='{carInput.VIN}'";
                    myCommand.ExecuteNonQuery();

                    MessageBox.Show(myCommand.CommandText);
                    ShowSuccess("Success");
                }
                else ShowError("VIN must be 17 characters long");
            }

            catch (Exception e3)
            {
                MessageBox.Show(e3.ToString(), "Error");
            }
        }



        private void AddCar()
        {
            var carInput = GetCarFromUI();

            try
            {
                // Validate VIN
                if (carInput.VIN.Length != 17)
                {
                    ShowError("VIN must be 17 characters long");
                    return;
                }

                // Check if the VIN already exists
                myCommand.CommandText = $"SELECT * FROM Vehicle WHERE VIN = '{carInput.VIN}'";

                using (var myReader = myCommand.ExecuteReader())
                {
                    if (myReader.Read())
                    {
                        // VIN already exists, check for missing fields
                        var missingFields = new List<string>();

                        if (myReader["LicensePlate"] == DBNull.Value)
                            missingFields.Add("License Plate");
                        if (myReader["Kilometers"] == DBNull.Value)
                            missingFields.Add("Kilometers");
                        if (myReader["Make"] == DBNull.Value)
                            missingFields.Add("Make");
                        if (myReader["Model"] == DBNull.Value)
                            missingFields.Add("Model");
                        if (myReader["Colour"] == DBNull.Value)
                            missingFields.Add("Colour");
                        if (myReader["vType"] == DBNull.Value)
                            missingFields.Add("Vehicle Type");

                        if (missingFields.Count > 0 && !fillMissingFields)
                        {
                            // Prompt user to fill missing fields
                            DialogResult dialogResult = MessageBox.Show("VIN already exists. Do you want to fill in the missing fields?", "VIN Exists", MessageBoxButtons.YesNo);
                            if (dialogResult == DialogResult.Yes)
                            {
                                // Populate form with existing data
                                VINTextBox.Text = myReader["VIN"].ToString();
                                LicensePlateTextBox.Text = myReader["LicensePlate"] != DBNull.Value ? myReader["LicensePlate"].ToString() : "";
                                KilometersTextBox.Text = myReader["Kilometers"] != DBNull.Value ? myReader["Kilometers"].ToString() : "";
                                MakeTextBox.Text = myReader["Make"] != DBNull.Value ? myReader["Make"].ToString() : "";
                                ModelTextBox.Text = myReader["Model"] != DBNull.Value ? myReader["Model"].ToString() : "";
                                ColourTextBox.Text = myReader["Colour"] != DBNull.Value ? myReader["Colour"].ToString() : "";
                                VehicleTypeComboBox.Text = myReader["vType"] != DBNull.Value ? myReader["vType"].ToString() : "";


                                fillMissingFields = true;
                                myReader.Close();
                                return;
                            }

                        }
                        else if (fillMissingFields)
                        {

                            myReader.Close();
                            InsertOrUpdateCar(carInput, true);
                            ClearForm();
                            return;

                        }
                        else
                        {
                            // VIN exists with no missing info
                            ShowSuccess("VIN already exists and has no missing information.");

                            return;
                        }
                    }

                }

                // VIN doesn't exist, proceed with inserting new car
                InsertOrUpdateCar(carInput, false);
            }
            catch (Exception e)
            {
                ShowError("Error: " + e.Message);
            }

        }

        private void InsertOrUpdateCar(CarInput carInput, bool update)
        {
            try
            {
                // Construct SQL command based on whether to update or insert
                string sqlCommand;

                if (update)
                {
                    // Update the existing record with NULL values for empty fields
                    sqlCommand = $"UPDATE Vehicle SET " +
                                 $"LicensePlate = {(string.IsNullOrEmpty(carInput.LicensePlate) ? "NULL" : $"'{carInput.LicensePlate}'")}, " +
                                 $"Kilometers = {(string.IsNullOrEmpty(carInput.Kilometers) ? "0" : $"{carInput.Kilometers}")}, " +
                                 $"Make = {(string.IsNullOrEmpty(carInput.Make) ? "NULL" : $"'{carInput.Make}'")}, " +
                                 $"Model = {(string.IsNullOrEmpty(carInput.Model) ? "NULL" : $"'{carInput.Model}'")}, " +
                                 $"Colour = {(string.IsNullOrEmpty(carInput.Colour) ? "NULL" : $"'{carInput.Colour}'")}, " +
                                 $"vType = {(string.IsNullOrEmpty(carInput.VehicleType) ? "NULL" : $"'{carInput.VehicleType}'")} " +
                                 $"WHERE VIN = '{carInput.VIN}'";
                }
                else
                {
                    // Insert the new car with NULL values for empty fields
                    sqlCommand = $"INSERT INTO Vehicle (VIN, LicensePlate, Kilometers, Make, Model, Colour, vType) " +
                                 $"VALUES ('{carInput.VIN}', " +
                                 $"{(string.IsNullOrEmpty(carInput.LicensePlate) ? "NULL" : $"'{carInput.LicensePlate}'")}, " +
                                 $"{(string.IsNullOrEmpty(carInput.Kilometers) ? "0" : $"{carInput.Kilometers}")}, " +
                                 $"{(string.IsNullOrEmpty(carInput.Make) ? "NULL" : $"'{carInput.Make}'")}, " +
                                 $"{(string.IsNullOrEmpty(carInput.Model) ? "NULL" : $"'{carInput.Model}'")}, " +
                                 $"{(string.IsNullOrEmpty(carInput.Colour) ? "NULL" : $"'{carInput.Colour}'")}, " +
                                 $"{(string.IsNullOrEmpty(carInput.VehicleType) ? "NULL" : $"'{carInput.VehicleType}'")})";
                }
                // Construct the display message
                string displayMessage = sqlCommand;

                // Show the display message in a message box
                MessageBox.Show(displayMessage);

                // Execute SQL command
                myCommand.CommandText = sqlCommand;
                myCommand.ExecuteNonQuery();


                // Show success message
                ShowSuccess(update ? "Car information updated successfully." : "Car added successfully.");
                fillMissingFields = false;
                ClearForm();
            }
            catch (Exception e)
            {
                ShowError("Error: " + e.Message);
            }
        }

        private void ClearForm()
        {
            // Clear all form fields
            VINTextBox.Text = "";
            LicensePlateTextBox.Text = "";
            KilometersTextBox.Text = "";
            MakeTextBox.Text = "";
            ModelTextBox.Text = "";
            ColourTextBox.Text = "";
            VehicleTypeComboBox.SelectedIndex = -1; // Reset combo box selection
        }


        private void SearchCar()
        {
            var carInput = GetCarFromUI();

            try
            {
                var search = new List<string>();

                if (carInput.LicensePlate != "")
                {
                    search.Add($"LicensePlate='{carInput.LicensePlate}'");
                }

                if (carInput.Kilometers != "")
                {
                    search.Add($"Kilometers={carInput.Kilometers}");
                }

                if (carInput.Make != "")
                {
                    search.Add($"Make='{carInput.Make}'");
                }

                if (carInput.Model != "")
                {
                    search.Add($"Model='{carInput.Model}'");
                }

                if (carInput.Colour != "")
                {
                    search.Add($"Colour='{carInput.Colour}'");
                }

                if (carInput.VehicleType != "")
                {
                    search.Add($"vType='{carInput.VehicleType}'");
                }


                var searchString = "";

                for (int i = 0; i < search.Count; i++)
                {
                    if (i == 0)
                    {
                        searchString += "WHERE " + search[i];
                    }
                    if (i > 0)
                    {
                        searchString += " AND " + search[i];
                    }

                }

                myCommand.CommandText = $"SELECT * FROM Vehicle {searchString};";
                MessageBox.Show(myCommand.CommandText);

                myReader = myCommand.ExecuteReader();

                vehicleList.Rows.Clear();
                while (myReader.Read())
                {
                    vehicleList.Rows.Add(myReader["VIN"].ToString(),
                                         myReader["LicensePlate"].ToString(),
                                         myReader["Kilometers"].ToString(),
                                         myReader["Make"].ToString(),
                                         myReader["Model"].ToString(),
                                         myReader["Colour"].ToString(),
                                         myReader["vType"].ToString());
                }



                myReader.Close();
            }
            catch (Exception e)
            {
                ShowError("Error: " + e.Message);
            }

        }

        private void Reports_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Price_Click(object sender, EventArgs e)
        {

        }
    }

}

