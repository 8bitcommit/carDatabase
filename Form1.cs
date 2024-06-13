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
            string connectionString = "Server = VBOX; Database = Project_group3; Trusted_Connection = yes; TrustServerCertificate=true;";

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
            try
            {
                var rentalInput = GetRentalInfoFromUI();
                var availability = CheckRentalAvailability(rentalInput);

                var displayPrice = $"${availability.Cost.ToString("#.00")}";
                var title = "Confirm Reservation";
                var message = $"Do you wish to confirm this reservation?\n\n{vehType.Text}Vehicle\nPick-up location: {pBranch.Text} \nDate: {PickUpPicker.Text}\nReturn location: {ReturnComboBox.Text}\nReturn Date: {DropOffPicker.Text}\nTotal days: {(DropOffPicker.Value - PickUpPicker.Value).Days} days\nPrice: {displayPrice}";
                var buttons = MessageBoxButtons.OKCancel;
                var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    ReserveRental(rentalInput);
                    // total will be calculated price from Database

                    Price.Text = displayPrice;//display price in dollar format
                    Price.Show();
                }
                else
                {
                    Price.Hide();
                }
            }
            catch (Exception ex)
            {
                ShowError(ex.ToString());
            }
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

                if (carInput.VIN != "")
                {
                    if (vinComboBox.SelectedIndex == 0)
                    {
                        search.Add($"VIN='{carInput.VIN}'");
                    }
                    else if (vinComboBox.SelectedIndex == 1)
                    {
                        search.Add($"VIN like '%{carInput.VIN}%'");
                    }

                }

                if (carInput.LicensePlate != "")
                {
                    search.Add($"LicensePlate='{carInput.LicensePlate}'");
                }

                if (carInput.Kilometers != "")
                {
                    if (kiloComboBox.SelectedIndex == 0)
                    {
                        search.Add($"Kilometers<{carInput.Kilometers}");
                    }
                    else if (kiloComboBox.SelectedIndex == 1)
                    {
                        search.Add($"Kilometers>{carInput.Kilometers}");
                    }
                    else
                    {
                        search.Add($"Kilometers={carInput.Kilometers}");
                    }
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

                vehicle_table_columns();

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

        private void vehicle_table_columns()
        {
            vehicleList.Columns.Clear();
            vehicleList.Columns.Add("VIN", "VIN");
            vehicleList.Columns.Add("LicensePlate", "License Plate");
            vehicleList.Columns.Add("Kilometers", "Kilometers");
            vehicleList.Columns.Add("Make", "Make");
            vehicleList.Columns.Add("Model", "Model");
            vehicleList.Columns.Add("Colour", "Colour");
            vehicleList.Columns.Add("vType", "Vehicle Type");

            vehicleList.Columns[0].Width = 135;
        }

        private RentalInput GetRentalInfoFromUI()
        {
            return new RentalInput()
            {
                PickUpLocation = pBranch.Text.Trim(),
                ReturnLocation = ReturnComboBox.Text.Trim(),
                PickupDate = PickUpPicker.Value.ToString("yyyy-MM-dd"),
                DropOffDate = DropOffPicker.Value.ToString("yyyy-MM-dd"),
                VehicleType = vehType.Text.Trim(),
            };
        }

        //rental page

        private RentalAvailability CheckRentalAvailability(RentalInput rentalInput)
        {
            //myCommand.CommandText = $"SELECT * From Vehicle WHERE vType = '{rentalInput.VehicleType}';";
            // WHERE THERE ARE NO RENTALS WHERE VIN = EACHVIN AND DATE RENTED DOES NOT OVERLAP WITH TARGET DATE RANGE
            try
            {
                myCommand.CommandText = $"SELECT * FROM VehicleType WHERE vType = 'Sedan';";

                myReader = myCommand.ExecuteReader();

                if (!myReader.Read())
                {
                    throw new Exception("No price found in database for vehicle");
                }

                var costPerDay = (decimal)myReader["CostPerDay"];
                var costPerWeek = (decimal)myReader["CostPerWeek"];
                var costPerMonth = (decimal)myReader["CostPerMonth"];

                // need to actually calculate the price

                myReader.Close();

                MessageBox.Show(myCommand.CommandText);

                return new RentalAvailability()
                {
                    Available = true,
                    Cost = 0
                };

            }
            finally
            {
                if (!myReader.IsClosed)
                {
                    myReader.Close();
                }
            }
        }

        private void ReserveRental(RentalInput rentalInput)
        {

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

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void SearchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (SearchRadioButton.Checked)
            {
                kiloComboBox.Visible = true;
                kiloComboBox.SelectedIndex = 0;
                vinComboBox.Visible = true;
                vinComboBox.SelectedIndex = 0;
            }
            else
            {
                kiloComboBox.Visible = false;
                vinComboBox.Visible = false;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Q1_radio.Checked)
            {
                Query1();
            }
            else if (Q2_radio.Checked)
            {
                Query2();
            }
            else if (Q3_radio.Checked)
            {
                Query3();
            }
            else if (Q4_radio.Checked)
            {
                Query4();
            }
            else if (Q5_radio.Checked)
            {
                Query5();
            }
            else if (Q5_radio.Checked)
            {
                Query6();
            }
        }

        private void Query1()
        {
            try
            {
                Dictionary<string, string> months = new Dictionary<string, string>
            {
                {"January", "01" },
                {"February", "02" },
                {"March", "03" },
                {"April", "04" },
                {"May", "05" },
                {"June", "06" },
                {"July", "07" },
                {"August", "08" },
                {"September", "09" },
                {"October", "10" },
                {"November", "11" },
                {"December", "12" }
            };

                string month = months[month1.Text.Trim()];
                int rentAmt = Int32.Parse(timespermonth.Text.Trim());
                // Query : select VIN from Vehicle where vType in (select vType from Vehicle where VIN in (select VIN from Rental where (select Month(DateRented) as month) = '05') group by vType having count(*) = 1)

                myCommand.CommandText = $"select * from Vehicle where vType in " +
                                        $"(select vType from Vehicle where VIN in " +
                                        $"(select VIN from Rental where (select Month(DateRented) as resMonth) = '{month}') " +
                                        $"group by vType having count(*) > {rentAmt})";
                MessageBox.Show(myCommand.CommandText);

                myReader = myCommand.ExecuteReader();

                vehicleList.Rows.Clear();
                vehicle_table_columns();

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

            catch (Exception e5)
            {
                MessageBox.Show(e5.ToString(), "Error");
            }
        }

        private void Query2()
        {

        }

        private void Query3()
        {

        }

        private void Query4()
        {
            // Ben's code here
            // Branch that rented the most vehicles in Q4_combo Q4_combo2

            int month = Q4_combo.SelectedIndex + 1;
            int year = 2024 - Q4_combo2.SelectedIndex;

            myCommand.CommandText = $"SELECT b.BranchID, b.BranchName, COUNT(*) AS RentalCount " +
                                    $"FROM Branch b JOIN Rental r ON r.RentedFrom = b.BranchID " +
                                    $"WHERE YEAR(r.DateRented) = {year} AND MONTH(r.DateRented) = {month} " +
                                    $"GROUP BY b.BranchID, b.BranchName;";
            MessageBox.Show(myCommand.CommandText);

            myReader = myCommand.ExecuteReader();


            vehicleList.Columns.Clear();
            vehicleList.Columns.Add("Branch ID", "Branch ID");
            vehicleList.Columns.Add("Branch Name", "Branch Name");
            vehicleList.Columns.Add("Rental Count", "Rental Count");
            vehicleList.Columns[1].Width = 135;

            vehicleList.Rows.Clear();

            while (myReader.Read())
            {
                vehicleList.Rows.Add(myReader["BranchID"].ToString(),
                                     myReader["BranchName"].ToString(),
                                     myReader["RentalCount"].ToString());
            }

            myReader.Close();
        }
        private void Query5()
        {
            // Ben's code here
            // Vehicle type most often returned to a different branch than pick-up.
        }
        private void Query6()
        {

        }
    }

}

