using Microsoft.Data.SqlClient;

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
            string connectionString = "Server = DESKTOP-5REHQJV; Database = Project_group3; Trusted_Connection = yes; TrustServerCertificate=true;";

            var myConnection = new SqlConnection(connectionString); // Timeout in seconds

            try
            {
                myConnection.Open(); // Open connection
                myCommand = new SqlCommand();
                myCommand.Connection = myConnection; // Link the command stream to the connection

                myCommand.CommandText = $"SELECT * FROM branch";
                using var myReader = myCommand.ExecuteReader();

                while (myReader.Read())
                {
                    var branch = new Branch()
                    {
                        Name = ((string)myReader["BranchName"]).Trim(),
                        Id = (int)myReader["BranchID"]
                    };

                    PickupComboBox.Items.Add(branch);
                    ReturnComboBox.Items.Add(branch);
                }

                PickupComboBox.SelectedIndex = 0;
                ReturnComboBox.SelectedIndex = 0;
                RentalVehicleTypeComboBox.SelectedIndex = 0;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error");
                this.Close();
            }
        }

        private void ReserveButton_Click(object sender, EventArgs e)
        {

            // Get rental input from UI
            var rentalInput = GetRentalInfoFromUI();

            // Validate pickup and return dates
            if (rentalInput.PickupDate >= rentalInput.DropOffDate)
            {
                ShowRentalError("Pickup date must be before return date.");
                return;
            }
            try
            {
                var availability = CheckRentalAvailability(rentalInput);
                var displayTotalCost = $"${availability.TotalCost:0.00}";

                ShowTotalCost(availability.TotalCost);

                var pickupLocation = PickupComboBox.Text;

                var title = "Confirm Reservation";
                var message = $"Do you wish to confirm this reservation?\n\nType: {rentalInput.VehicleType}\nPick-up location: {rentalInput.PickUpLocation} \nPick-up date: {rentalInput.PickupDate.ToString("MMM d, yyyy")}\nReturn location: {rentalInput.ReturnLocation}\nReturn date: {rentalInput.DropOffDate.ToString("MMM d, yyyy")}\nTotal days: {availability.Days}\nPrice: {displayTotalCost}";
                var buttons = MessageBoxButtons.OKCancel;
                var result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.OK)
                {
                    ReserveRental(rentalInput, availability.TotalCost, availability.VIN);
                }
                else
                {
                    OrderTotalLabel.Hide();
                    PriceLabel.Hide();
                }

                ShowRentalSuccess("Success");
            }
            catch (Exception ex)
            {
                ShowRentalError(ex.Message);
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

            //resize columns automatically
            for (int x = 0; x < vehicleList.ColumnCount; x++)
            {
                vehicleList.Columns[x].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }


        }

        private RentalInput GetRentalInfoFromUI()
        {
            var rentalInput = new RentalInput()
            {
                PickUpLocation = (Branch)PickupComboBox.SelectedItem!,
                ReturnLocation = (Branch)ReturnComboBox.SelectedItem!,
                PickupDate = PickUpPicker.Value,
                DropOffDate = DropOffPicker.Value,
                VehicleType = RentalVehicleTypeComboBox.Text.Trim(),
            };

            if (!DifferentLocationCheckBox.Checked)
            {
                rentalInput.ReturnLocation = rentalInput.PickUpLocation;
            }

            return rentalInput;
        }

        //rental page

        public static decimal CalculateRentalCost(int rentalDays, decimal costPerDay, decimal costPerWeek, decimal costPerMonth)
        {
            // Calculate the number of months, weeks, and remaining days
            int months = rentalDays / 30;
            int remainingDaysAfterMonths = rentalDays % 30;
            int weeks = remainingDaysAfterMonths / 7;
            int days = remainingDaysAfterMonths % 7;

            // Calculate the total cost
            decimal totalCost = (months * costPerMonth) + (weeks * costPerWeek) + (days * costPerDay);

            return totalCost;
        }

        private RentalAvailability CheckRentalAvailability(RentalInput rentalInput)
        {
            try
            {
                var pickupDate = rentalInput.PickupDate.ToString("yyyy-MM-dd");
                var dropoffDate = rentalInput.DropOffDate.ToString("yyyy-MM-dd");

                myCommand.CommandText = $"""
                                         SELECT * 
                                         FROM Vehicle v
                                         JOIN VehicleType vt ON v.vType = vt.vType
                                         WHERE v.vType = '{rentalInput.VehicleType}' 
                                         AND NOT EXISTS (
                                            SELECT 1
                                         	FROM Rental r
                                         	WHERE v.VIN = r.VIN
                                         	AND (r.DateRented <= '{dropoffDate}' AND r.DateReturned >= '{pickupDate}')
                                         )
                                         """;

                MessageBox.Show(myCommand.CommandText);


                myReader = myCommand.ExecuteReader();

                if (!myReader.Read())
                {
                    throw new Exception($"No available {rentalInput.VehicleType} vehicles for that date range");
                }
                var rentalDuration = DropOffPicker.Value - PickUpPicker.Value;
                var rentalDays = (int)rentalDuration.TotalDays + 1;

                var costPerDay = (decimal)myReader["CostPerDay"];
                var costPerWeek = (decimal)myReader["CostPerWeek"];
                var costPerMonth = (decimal)myReader["CostPerMonth"];
                var VIN = (string)myReader["VIN"];

                // need to actually calculate the price
                //get num of days rented

                myReader.Close();

                var totalCost = CalculateRentalCost(rentalDays, costPerDay, costPerWeek, costPerMonth);

                return new RentalAvailability()
                {
                    Available = true,
                    TotalCost = totalCost,
                    Days = rentalDays,
                    VIN = VIN
                };
            }
            catch
            {
                throw;
            }
            finally
            {
                if (!myReader.IsClosed)
                {
                    myReader.Close();
                }
            }
        }

        private void ReserveRental(RentalInput rentalInput, decimal totalCost, string VIN)
        {

            // Insert the new rental transaction with NULL values for empty fields
            var sqlCommand = $"INSERT INTO Rental (DateRented, DateReturned, TotalPrice, VIN, RentedFrom, ReturnedTo) VALUES ('{rentalInput.PickupDate:yyyy-MM-dd}', '{rentalInput.DropOffDate:yyyy-MM-dd}', {totalCost:0.00}, '{VIN}',{rentalInput.PickUpLocation.Id}, {rentalInput.ReturnLocation.Id});";

            // Construct the display message
            string displayMessage = sqlCommand;

            // Show the display message in a message box
            MessageBox.Show(displayMessage);

            // Execute SQL command
            myCommand.CommandText = sqlCommand;

            var rowsUpdated = myCommand.ExecuteNonQuery();
            if (rowsUpdated == 0)
            {
                throw new Exception("Failed to add reservation to database");
            }
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
            else if (Q6_radio.Checked)
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
                // Query : select * from Vehicle where vType in (select vehicle.vType from Vehicle inner join Rental on Vehicle.VIN = Rental.VIN where (select Month(DateRented) as month) = '{month}' group by vehicle.vType having count(*) > {rentAmt})

                myCommand.CommandText = $"select * from Vehicle where vType in " +
                                        $"(select vType from Vehicle inner join Rental on Vehicle.VIN = Rental.VIN where " +
                                        $"(select Month(DateRented) as month) = '{month}' " +
                                        $"group by vType having count(*) > {rentAmt})" + 
                                        $"and VIN in (select VIN from Rental where (select Month(DateRented) as month) = '06')";
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
            try
            {
                int kilos = Int32.Parse(RepKilos.Text.Trim());
                string branch = Pop_branch.Text.Trim();
                branch = branch.Replace("'", "\''");

                myCommand.CommandText = $"Select BranchID from Branch where BranchName = '{branch}'";
                
                myReader = myCommand.ExecuteReader();
                myReader.Read();
                string branchID = myReader["BranchID"].ToString();
                myReader.Close();

                // Query : select * from Vehicle where VIN in(select VIN from Rental where ReturnedTo = '5000' group by VIN having count(*) = (select max(amt) from (select VIN, count(*) as amt from Rental group by VIN) Rental))

                myCommand.CommandText = $"select * from Vehicle where VIN in " +
                            $"(select VIN from Rental where ReturnedTo = '{branchID}' " +
                            $"group by VIN having count(*) = " +
                            $"(select max(amt) from (select VIN, count(*) as amt from Rental where ReturnedTo = '{branchID}' group by VIN) Rental))" +
                            $"and Kilometers < {kilos}";

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
            catch (Exception e6)
            {
                MessageBox.Show(e6.ToString(), "Error");
            }
        }

        private void Query3()
        {
            int month = Q3_combo1.SelectedIndex + 1;
            int year = 2024 - Q3_combo2.SelectedIndex;
            // Query : select * from Vehicle except (select * from Vehicle where VIN in (select VIN from Rental where Month(DateRented) = '{month}' and Year(DateRented) = '{year}')
            try
            {
                myCommand.CommandText = $"select * from Vehicle except " +
                            $"(select * from Vehicle where VIN in " +
                            $"(select VIN from Rental where Month(DateRented) = '{month}' and Year(DateRented) = '{year}'))";

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
            catch (Exception e7)
            {
                MessageBox.Show(e7.ToString(), "Error");
            }
        }

        private void Query4()
        {
            //SELECT b.BranchID, b.BranchName, COUNT(*) AS RentalCount
            //FROM Branch b
            //JOIN Rental r ON r.RentedFrom = b.BranchID
            //WHERE YEAR(r.DateRented) = 2024 AND MONTH(r.DateRented) = 6
            //GROUP BY b.BranchID, b.BranchName;

            try
            {
                int month = Q4_combo.SelectedIndex + 1;
                int year = 2024 - Q4_combo2.SelectedIndex;

                myCommand.CommandText = $"SELECT TOP 1 b.BranchID, b.BranchName, COUNT(*) AS RentalCount " +
                                        $"FROM Branch b JOIN Rental r ON r.RentedFrom = b.BranchID " +
                                        $"WHERE YEAR(r.DateRented) = {year} AND MONTH(r.DateRented) = {month} " +
                                        $"GROUP BY b.BranchID, b.BranchName " +
                                        $"ORDER BY RentalCount DESC;";
                MessageBox.Show(myCommand.CommandText);

                myReader = myCommand.ExecuteReader();

                vehicleList.Rows.Clear();
                vehicleList.Columns.Clear();
                vehicleList.Columns.Add("Branch ID", "Branch ID");
                vehicleList.Columns.Add("Branch Name", "Branch Name");
                vehicleList.Columns.Add("Rental Count", "Rental Count");

                //resize columns automatically
                for (int x = 0; x < vehicleList.ColumnCount; x++)
                {
                    vehicleList.Columns[x].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }



                while (myReader.Read())
                {
                    vehicleList.Rows.Add(myReader["BranchID"].ToString(),
                                         myReader["BranchName"].ToString(),
                                         myReader["RentalCount"].ToString());
                }

                myReader.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }


        }
        private void Query5()
        {
            //SELECT b.BranchID, b.BranchName, AVG(DATEDIFF(DAY, DateRented, DateReturned)) AS AvgRentalLength
            //FROM Branch b
            //JOIN Rental r on r.RentedFrom = b.BranchID
            //WHERE YEAR(r.DateRented) = 2024 AND MONTH(r.DateRented) = 6
            //GROUP BY b.BranchID, b.BranchName;

            try
            {
                int month = Q5_combo.SelectedIndex + 1;
                int year = 2024 - Q5_combo2.SelectedIndex;

                myCommand.CommandText = $"SELECT b.BranchID, b.BranchName, AVG(DATEDIFF(DAY, DateRented, DateReturned)) AS AvgRentalLength " +
                                        $"FROM Branch b JOIN Rental r on r.RentedFrom = b.BranchID " +
                                        $"WHERE YEAR(r.DateRented) = {year} AND MONTH(r.DateRented) = {month} " +
                                        $"GROUP BY b.BranchID, b.BranchName " +
                                        $"ORDER BY AvgRentalLength DESC;";


                MessageBox.Show(myCommand.CommandText);

                myReader = myCommand.ExecuteReader();

                vehicleList.Rows.Clear();
                vehicleList.Columns.Clear();
                vehicleList.Columns.Add("Branch ID", "Branch ID");
                vehicleList.Columns.Add("Branch Name", "Branch Name");
                vehicleList.Columns.Add("AvgRentalLength", "Average Rental Legnth in Days");

                //resize columns automatically
                for (int x = 0; x < vehicleList.ColumnCount; x++)
                {
                    vehicleList.Columns[x].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }



                while (myReader.Read())
                {
                    vehicleList.Rows.Add(myReader["BranchID"].ToString(),
                                         myReader["BranchName"].ToString(),
                                         myReader["AvgRentalLength"].ToString());
                }

                myReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }


        }
        private void Query6()
        {
            /*
            WITH ReturnedToDifferentBranch AS(
                SELECT r.VIN, r.RentedFrom AS PickUpBranch, r.ReturnedTo AS ReturnBranch, v.vType
                FROM Rental r
                JOIN Vehicle v ON r.VIN = v.VIN
                WHERE r.RentedFrom<> r.ReturnedTo
            )
            SELECT TOP 1 vType, COUNT(*) AS ReturnCount
            FROM ReturnedToDifferentBranch
            GROUP BY vType
            ORDER BY ReturnCount DESC;
            */

            try
            {

                myCommand.CommandText = $"WITH ReturnedToDifferentBranch AS( " +
                                            $"SELECT r.VIN, r.RentedFrom AS PickUpBranch, r.ReturnedTo AS ReturnBranch, v.vType " +
                                            $"FROM Rental r JOIN Vehicle v ON r.VIN = v.VIN " +
                                            $"WHERE r.RentedFrom<> r.ReturnedTo" +
                                        $") " +
                                        $"SELECT TOP 1 vType, COUNT(*) AS ReturnCount " +
                                        $"FROM ReturnedToDifferentBranch " +
                                        $"GROUP BY vType ORDER BY ReturnCount DESC;";


                MessageBox.Show(myCommand.CommandText);

                myReader = myCommand.ExecuteReader();

                vehicleList.Rows.Clear();
                vehicleList.Columns.Clear();
                vehicleList.Columns.Add("vType", "Vehicle Type");
                vehicleList.Columns.Add("ReturnCount", "Number of Returns to different locations");

                //resize columns automatically
                for (int x = 0; x < vehicleList.ColumnCount; x++)
                {
                    vehicleList.Columns[x].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }



                while (myReader.Read())
                {
                    vehicleList.Rows.Add(myReader["vType"].ToString(),
                                         myReader["ReturnCount"].ToString());
                }

                myReader.Close();

            }
            catch (Exception e)
            {
                MessageBox.Show(e.ToString(), "Error");
            }


        }

        private void ShowTotalCost(decimal totalCost)
        {
            OrderTotalLabel.Show();
            PriceLabel.ForeColor = Color.Green;
            PriceLabel.Text = $"${totalCost:0.00}";
            PriceLabel.Show();

        }
        private void ShowRentalError(string message)
        {
            RentalNotificationLabel.ForeColor = Color.Red;
            RentalNotificationLabel.Text = message;
            RentalNotificationLabel.Show();

            HideRentalNotificationTimer.Stop();
            HideRentalNotificationTimer.Start();
        }

        private void ShowRentalSuccess(string message)
        {
            RentalNotificationLabel.ForeColor = Color.Green;
            RentalNotificationLabel.Text = message;
            RentalNotificationLabel.Show();

            HideRentalNotificationTimer.Stop();
            HideRentalNotificationTimer.Start();
        }
    }

}

