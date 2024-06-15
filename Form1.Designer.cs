namespace project291
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            Reports = new TabPage();
            Q3_combo2 = new ComboBox();
            Q4_combo2 = new ComboBox();
            Q5_combo2 = new ComboBox();
            RepKilos = new ComboBox();
            timespermonth = new ComboBox();
            label2 = new Label();
            button1 = new Button();
            label10 = new Label();
            Q5_combo = new ComboBox();
            label9 = new Label();
            Q4_combo = new ComboBox();
            label8 = new Label();
            Q3_combo1 = new ComboBox();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            month1 = new ComboBox();
            label1 = new Label();
            Pop_branch = new ComboBox();
            Q6_radio = new RadioButton();
            Q5_radio = new RadioButton();
            Q4_radio = new RadioButton();
            Q3_radio = new RadioButton();
            Q2_radio = new RadioButton();
            Q1_radio = new RadioButton();
            Rental = new TabPage();
            RentalNotificationLabel = new Label();
            PriceLabel = new Label();
            OrderTotalLabel = new Label();
            RentalVehicleTypeComboBox = new ComboBox();
            label11 = new Label();
            DifferentLocationCheckBox = new CheckBox();
            ReturnComboBox = new ComboBox();
            rBranch = new Label();
            ReserveButton = new Button();
            DropOffPicker = new DateTimePicker();
            DropOffDateLabel = new Label();
            PickupComboBox = new ComboBox();
            PickUpBranchLabel = new Label();
            PickUpPicker = new DateTimePicker();
            PickUpDateLabel = new Label();
            Car = new TabPage();
            vinComboBox = new ComboBox();
            kiloComboBox = new ComboBox();
            DeleteRadioButton = new RadioButton();
            ColourTextBox = new TextBox();
            ModelTextBox = new TextBox();
            MakeTextBox = new TextBox();
            KilometersTextBox = new TextBox();
            VINTextBox = new TextBox();
            LicensePlateTextBox = new TextBox();
            ColourLabel = new Label();
            SelectOneLabel = new Label();
            SubmitButton = new Button();
            SearchRadioButton = new RadioButton();
            ModifyRadioButton = new RadioButton();
            AddRadioButton = new RadioButton();
            VehicleTypeComboBox = new ComboBox();
            VehicleTypeLabel = new Label();
            ModelLabel = new Label();
            MakeLabel = new Label();
            KilometersLabel = new Label();
            LicensePlateLabel = new Label();
            VINLabel = new Label();
            NotificationLabel = new Label();
            tabControl1 = new TabControl();
            HideNotificationTimer = new System.Windows.Forms.Timer(components);
            vehicleList = new DataGridView();
            VIN = new DataGridViewTextBoxColumn();
            LicensePlate = new DataGridViewTextBoxColumn();
            Kilometers = new DataGridViewTextBoxColumn();
            Make = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Colour = new DataGridViewTextBoxColumn();
            vType = new DataGridViewTextBoxColumn();
            HideRentalNotificationTimer = new System.Windows.Forms.Timer(components);
            Reports.SuspendLayout();
            Rental.SuspendLayout();
            Car.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehicleList).BeginInit();
            SuspendLayout();
            // 
            // Reports
            // 
            Reports.BackColor = SystemColors.GradientInactiveCaption;
            Reports.Controls.Add(Q3_combo2);
            Reports.Controls.Add(Q4_combo2);
            Reports.Controls.Add(Q5_combo2);
            Reports.Controls.Add(RepKilos);
            Reports.Controls.Add(timespermonth);
            Reports.Controls.Add(label2);
            Reports.Controls.Add(button1);
            Reports.Controls.Add(label10);
            Reports.Controls.Add(Q5_combo);
            Reports.Controls.Add(label9);
            Reports.Controls.Add(Q4_combo);
            Reports.Controls.Add(label8);
            Reports.Controls.Add(Q3_combo1);
            Reports.Controls.Add(label7);
            Reports.Controls.Add(label6);
            Reports.Controls.Add(label5);
            Reports.Controls.Add(label4);
            Reports.Controls.Add(label3);
            Reports.Controls.Add(month1);
            Reports.Controls.Add(label1);
            Reports.Controls.Add(Pop_branch);
            Reports.Controls.Add(Q6_radio);
            Reports.Controls.Add(Q5_radio);
            Reports.Controls.Add(Q4_radio);
            Reports.Controls.Add(Q3_radio);
            Reports.Controls.Add(Q2_radio);
            Reports.Controls.Add(Q1_radio);
            Reports.Location = new Point(4, 24);
            Reports.Margin = new Padding(3, 2, 3, 2);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3, 2, 3, 2);
            Reports.Size = new Size(777, 407);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            // 
            // Q3_combo2
            // 
            Q3_combo2.FormattingEnabled = true;
            Q3_combo2.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020" });
            Q3_combo2.Location = new Point(404, 107);
            Q3_combo2.Name = "Q3_combo2";
            Q3_combo2.Size = new Size(121, 23);
            Q3_combo2.TabIndex = 38;
            Q3_combo2.Text = "Year";
            // 
            // Q4_combo2
            // 
            Q4_combo2.FormattingEnabled = true;
            Q4_combo2.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020" });
            Q4_combo2.Location = new Point(475, 152);
            Q4_combo2.Name = "Q4_combo2";
            Q4_combo2.Size = new Size(121, 23);
            Q4_combo2.TabIndex = 37;
            Q4_combo2.Text = "Year";
            // 
            // Q5_combo2
            // 
            Q5_combo2.FormattingEnabled = true;
            Q5_combo2.Items.AddRange(new object[] { "2024", "2023", "2022", "2021", "2020" });
            Q5_combo2.Location = new Point(360, 197);
            Q5_combo2.Name = "Q5_combo2";
            Q5_combo2.Size = new Size(60, 23);
            Q5_combo2.TabIndex = 36;
            Q5_combo2.Text = "Year";
            // 
            // RepKilos
            // 
            RepKilos.FormattingEnabled = true;
            RepKilos.Items.AddRange(new object[] { "10000", "20000", "30000", "50000", "100000" });
            RepKilos.Location = new Point(570, 64);
            RepKilos.Name = "RepKilos";
            RepKilos.Size = new Size(93, 23);
            RepKilos.TabIndex = 35;
            RepKilos.Text = "Choose KMs";
            // 
            // timespermonth
            // 
            timespermonth.FormattingEnabled = true;
            timespermonth.Items.AddRange(new object[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10" });
            timespermonth.Location = new Point(391, 24);
            timespermonth.Name = "timespermonth";
            timespermonth.Size = new Size(37, 23);
            timespermonth.TabIndex = 34;
            timespermonth.Text = "#";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(426, 199);
            label2.Name = "label2";
            label2.Size = new Size(67, 15);
            label2.TabIndex = 33;
            label2.Text = "per branch.";
            // 
            // button1
            // 
            button1.Location = new Point(11, 291);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(82, 22);
            button1.TabIndex = 32;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(105, 242);
            label10.Name = "label10";
            label10.Size = new Size(364, 15);
            label10.TabIndex = 31;
            label10.Text = "Vehicle type most often returned to a different branch than pick-up.";
            // 
            // Q5_combo
            // 
            Q5_combo.FormattingEnabled = true;
            Q5_combo.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            Q5_combo.Location = new Point(247, 196);
            Q5_combo.Name = "Q5_combo";
            Q5_combo.Size = new Size(91, 23);
            Q5_combo.TabIndex = 30;
            Q5_combo.Text = "Month";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(105, 199);
            label9.Name = "label9";
            label9.Size = new Size(136, 15);
            label9.TabIndex = 29;
            label9.Text = "Average rental length in ";
            // 
            // Q4_combo
            // 
            Q4_combo.FormattingEnabled = true;
            Q4_combo.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            Q4_combo.Location = new Point(348, 152);
            Q4_combo.Name = "Q4_combo";
            Q4_combo.Size = new Size(121, 23);
            Q4_combo.TabIndex = 28;
            Q4_combo.Text = "Month";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(105, 155);
            label8.Name = "label8";
            label8.Size = new Size(216, 15);
            label8.TabIndex = 27;
            label8.Text = "Branch that rented the most vehicles in ";
            // 
            // Q3_combo1
            // 
            Q3_combo1.FormattingEnabled = true;
            Q3_combo1.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            Q3_combo1.Location = new Point(277, 106);
            Q3_combo1.Name = "Q3_combo1";
            Q3_combo1.Size = new Size(121, 23);
            Q3_combo1.TabIndex = 26;
            Q3_combo1.Text = "Month";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(105, 109);
            label7.Name = "label7";
            label7.Size = new Size(166, 15);
            label7.TabIndex = 25;
            label7.Text = "Vehicles that went unrented in";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(686, 67);
            label6.Name = "label6";
            label6.Size = new Size(65, 15);
            label6.TabIndex = 23;
            label6.Text = "kilometers.";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(472, 67);
            label5.Name = "label5";
            label5.Size = new Size(79, 15);
            label5.TabIndex = 21;
            label5.Text = "with less than";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(105, 67);
            label4.Name = "label4";
            label4.Size = new Size(180, 15);
            label4.TabIndex = 20;
            label4.Text = "Most popular vehicle returned to";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(454, 27);
            label3.Name = "label3";
            label3.Size = new Size(49, 15);
            label3.TabIndex = 19;
            label3.Text = "times in";
            // 
            // month1
            // 
            month1.FormattingEnabled = true;
            month1.Items.AddRange(new object[] { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" });
            month1.Location = new Point(526, 21);
            month1.Name = "month1";
            month1.Size = new Size(121, 23);
            month1.TabIndex = 17;
            month1.Text = "Month";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(105, 27);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.Yes;
            label1.Size = new Size(256, 15);
            label1.TabIndex = 9;
            label1.Text = "Vehicles where Vehicle type is rented more than";
            // 
            // Pop_branch
            // 
            Pop_branch.FormattingEnabled = true;
            Pop_branch.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            Pop_branch.Location = new Point(304, 64);
            Pop_branch.Margin = new Padding(3, 2, 3, 2);
            Pop_branch.Name = "Pop_branch";
            Pop_branch.Size = new Size(144, 23);
            Pop_branch.TabIndex = 7;
            Pop_branch.Text = "Branch";
            // 
            // Q6_radio
            // 
            Q6_radio.AutoSize = true;
            Q6_radio.Location = new Point(11, 240);
            Q6_radio.Name = "Q6_radio";
            Q6_radio.Size = new Size(56, 19);
            Q6_radio.TabIndex = 5;
            Q6_radio.Text = "Select";
            Q6_radio.UseVisualStyleBackColor = true;
            // 
            // Q5_radio
            // 
            Q5_radio.AutoSize = true;
            Q5_radio.Location = new Point(11, 197);
            Q5_radio.Name = "Q5_radio";
            Q5_radio.Size = new Size(56, 19);
            Q5_radio.TabIndex = 4;
            Q5_radio.Text = "Select";
            Q5_radio.UseVisualStyleBackColor = true;
            // 
            // Q4_radio
            // 
            Q4_radio.AutoSize = true;
            Q4_radio.Location = new Point(11, 153);
            Q4_radio.Name = "Q4_radio";
            Q4_radio.Size = new Size(56, 19);
            Q4_radio.TabIndex = 3;
            Q4_radio.Text = "Select";
            Q4_radio.UseVisualStyleBackColor = true;
            // 
            // Q3_radio
            // 
            Q3_radio.AutoSize = true;
            Q3_radio.Location = new Point(11, 107);
            Q3_radio.Name = "Q3_radio";
            Q3_radio.Size = new Size(56, 19);
            Q3_radio.TabIndex = 2;
            Q3_radio.Text = "Select";
            Q3_radio.UseVisualStyleBackColor = true;
            // 
            // Q2_radio
            // 
            Q2_radio.AutoSize = true;
            Q2_radio.Location = new Point(11, 65);
            Q2_radio.Name = "Q2_radio";
            Q2_radio.Size = new Size(56, 19);
            Q2_radio.TabIndex = 1;
            Q2_radio.Text = "Select";
            Q2_radio.UseVisualStyleBackColor = true;
            // 
            // Q1_radio
            // 
            Q1_radio.AutoSize = true;
            Q1_radio.Checked = true;
            Q1_radio.Location = new Point(11, 25);
            Q1_radio.Name = "Q1_radio";
            Q1_radio.Size = new Size(56, 19);
            Q1_radio.TabIndex = 0;
            Q1_radio.TabStop = true;
            Q1_radio.Text = "Select";
            Q1_radio.UseVisualStyleBackColor = true;
            // 
            // Rental
            // 
            Rental.BackColor = SystemColors.GradientInactiveCaption;
            Rental.Controls.Add(RentalNotificationLabel);
            Rental.Controls.Add(PriceLabel);
            Rental.Controls.Add(OrderTotalLabel);
            Rental.Controls.Add(RentalVehicleTypeComboBox);
            Rental.Controls.Add(label11);
            Rental.Controls.Add(DifferentLocationCheckBox);
            Rental.Controls.Add(ReturnComboBox);
            Rental.Controls.Add(rBranch);
            Rental.Controls.Add(ReserveButton);
            Rental.Controls.Add(DropOffPicker);
            Rental.Controls.Add(DropOffDateLabel);
            Rental.Controls.Add(PickupComboBox);
            Rental.Controls.Add(PickUpBranchLabel);
            Rental.Controls.Add(PickUpPicker);
            Rental.Controls.Add(PickUpDateLabel);
            Rental.Location = new Point(4, 24);
            Rental.Margin = new Padding(3, 2, 3, 2);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3, 2, 3, 2);
            Rental.Size = new Size(777, 407);
            Rental.TabIndex = 1;
            Rental.Text = "Rental";
            // 
            // RentalNotificationLabel
            // 
            RentalNotificationLabel.AutoSize = true;
            RentalNotificationLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RentalNotificationLabel.Location = new Point(216, 364);
            RentalNotificationLabel.Name = "RentalNotificationLabel";
            RentalNotificationLabel.Size = new Size(85, 19);
            RentalNotificationLabel.TabIndex = 26;
            RentalNotificationLabel.Text = "Notification";
            RentalNotificationLabel.Visible = false;
            // 
            // PriceLabel
            // 
            PriceLabel.AutoSize = true;
            PriceLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PriceLabel.Location = new Point(643, 49);
            PriceLabel.Name = "PriceLabel";
            PriceLabel.Size = new Size(66, 25);
            PriceLabel.TabIndex = 20;
            PriceLabel.Text = "$ 0.00";
            PriceLabel.Visible = false;
            // 
            // OrderTotalLabel
            // 
            OrderTotalLabel.AutoSize = true;
            OrderTotalLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            OrderTotalLabel.Location = new Point(520, 49);
            OrderTotalLabel.Name = "OrderTotalLabel";
            OrderTotalLabel.Size = new Size(117, 25);
            OrderTotalLabel.TabIndex = 18;
            OrderTotalLabel.Text = "Order Total:";
            OrderTotalLabel.Visible = false;
            // 
            // RentalVehicleTypeComboBox
            // 
            RentalVehicleTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            RentalVehicleTypeComboBox.FormattingEnabled = true;
            RentalVehicleTypeComboBox.Items.AddRange(new object[] { "Sports", "Truck", "SUV", "Sedan", "Electric" });
            RentalVehicleTypeComboBox.Location = new Point(216, 303);
            RentalVehicleTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            RentalVehicleTypeComboBox.Name = "RentalVehicleTypeComboBox";
            RentalVehicleTypeComboBox.Size = new Size(133, 23);
            RentalVehicleTypeComboBox.TabIndex = 17;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label11.Location = new Point(59, 300);
            label11.Name = "label11";
            label11.Size = new Size(123, 25);
            label11.TabIndex = 16;
            label11.Text = "Vehicle type:";
            // 
            // DifferentLocationCheckBox
            // 
            DifferentLocationCheckBox.AutoSize = true;
            DifferentLocationCheckBox.Location = new Point(59, 93);
            DifferentLocationCheckBox.Name = "DifferentLocationCheckBox";
            DifferentLocationCheckBox.Size = new Size(169, 19);
            DifferentLocationCheckBox.TabIndex = 14;
            DifferentLocationCheckBox.Text = "Return to different location";
            DifferentLocationCheckBox.UseVisualStyleBackColor = true;
            DifferentLocationCheckBox.CheckedChanged += DifferentLocationCheckBox_CheckedChanged;
            // 
            // ReturnComboBox
            // 
            ReturnComboBox.FormattingEnabled = true;
            ReturnComboBox.Location = new Point(207, 142);
            ReturnComboBox.Margin = new Padding(3, 2, 3, 2);
            ReturnComboBox.Name = "ReturnComboBox";
            ReturnComboBox.Size = new Size(133, 23);
            ReturnComboBox.TabIndex = 13;
            ReturnComboBox.Visible = false;
            // 
            // rBranch
            // 
            rBranch.AutoSize = true;
            rBranch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rBranch.Location = new Point(59, 137);
            rBranch.Name = "rBranch";
            rBranch.Size = new Size(78, 25);
            rBranch.TabIndex = 12;
            rBranch.Text = "Return:";
            rBranch.Visible = false;
            // 
            // ReserveButton
            // 
            ReserveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReserveButton.Location = new Point(59, 348);
            ReserveButton.Margin = new Padding(3, 2, 3, 2);
            ReserveButton.Name = "ReserveButton";
            ReserveButton.Size = new Size(132, 44);
            ReserveButton.TabIndex = 9;
            ReserveButton.Text = "Reserve";
            ReserveButton.UseVisualStyleBackColor = true;
            ReserveButton.Click += ReserveButton_Click;
            // 
            // DropOffPicker
            // 
            DropOffPicker.Location = new Point(274, 248);
            DropOffPicker.Margin = new Padding(3, 2, 3, 2);
            DropOffPicker.Name = "DropOffPicker";
            DropOffPicker.Size = new Size(219, 23);
            DropOffPicker.TabIndex = 8;
            // 
            // DropOffDateLabel
            // 
            DropOffDateLabel.AutoSize = true;
            DropOffDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DropOffDateLabel.Location = new Point(59, 248);
            DropOffDateLabel.Name = "DropOffDateLabel";
            DropOffDateLabel.Size = new Size(191, 25);
            DropOffDateLabel.TabIndex = 7;
            DropOffDateLabel.Text = "Enter drop-off date:";
            // 
            // PickupComboBox
            // 
            PickupComboBox.FormattingEnabled = true;
            PickupComboBox.Location = new Point(208, 54);
            PickupComboBox.Margin = new Padding(3, 2, 3, 2);
            PickupComboBox.Name = "PickupComboBox";
            PickupComboBox.Size = new Size(133, 23);
            PickupComboBox.TabIndex = 5;
            // 
            // PickUpBranchLabel
            // 
            PickUpBranchLabel.AutoSize = true;
            PickUpBranchLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PickUpBranchLabel.Location = new Point(59, 49);
            PickUpBranchLabel.Name = "PickUpBranchLabel";
            PickUpBranchLabel.Size = new Size(85, 25);
            PickUpBranchLabel.TabIndex = 4;
            PickUpBranchLabel.Text = "Pick-up:";
            // 
            // PickUpPicker
            // 
            PickUpPicker.Location = new Point(274, 192);
            PickUpPicker.Margin = new Padding(3, 2, 3, 2);
            PickUpPicker.Name = "PickUpPicker";
            PickUpPicker.Size = new Size(219, 23);
            PickUpPicker.TabIndex = 2;
            // 
            // PickUpDateLabel
            // 
            PickUpDateLabel.AutoSize = true;
            PickUpDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PickUpDateLabel.Location = new Point(59, 192);
            PickUpDateLabel.Name = "PickUpDateLabel";
            PickUpDateLabel.Size = new Size(181, 25);
            PickUpDateLabel.TabIndex = 0;
            PickUpDateLabel.Text = "Enter pick-up date:";
            // 
            // Car
            // 
            Car.AccessibleRole = AccessibleRole.Caret;
            Car.BackColor = SystemColors.GradientInactiveCaption;
            Car.Controls.Add(vinComboBox);
            Car.Controls.Add(kiloComboBox);
            Car.Controls.Add(DeleteRadioButton);
            Car.Controls.Add(ColourTextBox);
            Car.Controls.Add(ModelTextBox);
            Car.Controls.Add(MakeTextBox);
            Car.Controls.Add(KilometersTextBox);
            Car.Controls.Add(VINTextBox);
            Car.Controls.Add(LicensePlateTextBox);
            Car.Controls.Add(ColourLabel);
            Car.Controls.Add(SelectOneLabel);
            Car.Controls.Add(SubmitButton);
            Car.Controls.Add(SearchRadioButton);
            Car.Controls.Add(ModifyRadioButton);
            Car.Controls.Add(AddRadioButton);
            Car.Controls.Add(VehicleTypeComboBox);
            Car.Controls.Add(VehicleTypeLabel);
            Car.Controls.Add(ModelLabel);
            Car.Controls.Add(MakeLabel);
            Car.Controls.Add(KilometersLabel);
            Car.Controls.Add(LicensePlateLabel);
            Car.Controls.Add(VINLabel);
            Car.Controls.Add(NotificationLabel);
            Car.Location = new Point(4, 24);
            Car.Margin = new Padding(3, 2, 3, 2);
            Car.Name = "Car";
            Car.Size = new Size(777, 407);
            Car.TabIndex = 2;
            Car.Text = "Car";
            // 
            // vinComboBox
            // 
            vinComboBox.FormattingEnabled = true;
            vinComboBox.Items.AddRange(new object[] { "is", "contains" });
            vinComboBox.Location = new Point(109, 22);
            vinComboBox.Name = "vinComboBox";
            vinComboBox.Size = new Size(95, 23);
            vinComboBox.TabIndex = 27;
            vinComboBox.Visible = false;
            // 
            // kiloComboBox
            // 
            kiloComboBox.FormattingEnabled = true;
            kiloComboBox.Items.AddRange(new object[] { "<", ">", "=" });
            kiloComboBox.Location = new Point(156, 96);
            kiloComboBox.Name = "kiloComboBox";
            kiloComboBox.Size = new Size(48, 23);
            kiloComboBox.TabIndex = 26;
            kiloComboBox.Visible = false;
            // 
            // DeleteRadioButton
            // 
            DeleteRadioButton.AutoSize = true;
            DeleteRadioButton.Location = new Point(386, 310);
            DeleteRadioButton.Margin = new Padding(3, 2, 3, 2);
            DeleteRadioButton.Name = "DeleteRadioButton";
            DeleteRadioButton.Size = new Size(58, 19);
            DeleteRadioButton.TabIndex = 23;
            DeleteRadioButton.Text = "Delete";
            DeleteRadioButton.UseVisualStyleBackColor = true;
            // 
            // ColourTextBox
            // 
            ColourTextBox.Location = new Point(210, 209);
            ColourTextBox.Margin = new Padding(3, 2, 3, 2);
            ColourTextBox.MaxLength = 20;
            ColourTextBox.Name = "ColourTextBox";
            ColourTextBox.Size = new Size(133, 23);
            ColourTextBox.TabIndex = 22;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(210, 174);
            ModelTextBox.Margin = new Padding(3, 2, 3, 2);
            ModelTextBox.MaxLength = 20;
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(134, 23);
            ModelTextBox.TabIndex = 13;
            // 
            // MakeTextBox
            // 
            MakeTextBox.Location = new Point(210, 136);
            MakeTextBox.Margin = new Padding(3, 2, 3, 2);
            MakeTextBox.MaxLength = 20;
            MakeTextBox.Name = "MakeTextBox";
            MakeTextBox.Size = new Size(134, 23);
            MakeTextBox.TabIndex = 11;
            // 
            // KilometersTextBox
            // 
            KilometersTextBox.Location = new Point(210, 96);
            KilometersTextBox.Margin = new Padding(3, 2, 3, 2);
            KilometersTextBox.MaxLength = 9;
            KilometersTextBox.Name = "KilometersTextBox";
            KilometersTextBox.Size = new Size(134, 23);
            KilometersTextBox.TabIndex = 9;
            // 
            // VINTextBox
            // 
            VINTextBox.Location = new Point(210, 22);
            VINTextBox.Margin = new Padding(3, 2, 3, 2);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.Size = new Size(134, 23);
            VINTextBox.TabIndex = 8;
            // 
            // LicensePlateTextBox
            // 
            LicensePlateTextBox.Location = new Point(210, 58);
            LicensePlateTextBox.Margin = new Padding(3, 2, 3, 2);
            LicensePlateTextBox.MaxLength = 10;
            LicensePlateTextBox.Name = "LicensePlateTextBox";
            LicensePlateTextBox.Size = new Size(134, 23);
            LicensePlateTextBox.TabIndex = 7;
            // 
            // ColourLabel
            // 
            ColourLabel.AutoSize = true;
            ColourLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ColourLabel.Location = new Point(36, 207);
            ColourLabel.Name = "ColourLabel";
            ColourLabel.Size = new Size(79, 25);
            ColourLabel.TabIndex = 21;
            ColourLabel.Text = "Colour:";
            // 
            // SelectOneLabel
            // 
            SelectOneLabel.AutoSize = true;
            SelectOneLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            SelectOneLabel.Location = new Point(35, 305);
            SelectOneLabel.Name = "SelectOneLabel";
            SelectOneLabel.Size = new Size(108, 25);
            SelectOneLabel.TabIndex = 20;
            SelectOneLabel.Text = "Select one:";
            // 
            // SubmitButton
            // 
            SubmitButton.Location = new Point(36, 369);
            SubmitButton.Margin = new Padding(3, 2, 3, 2);
            SubmitButton.Name = "SubmitButton";
            SubmitButton.RightToLeft = RightToLeft.Yes;
            SubmitButton.Size = new Size(82, 22);
            SubmitButton.TabIndex = 19;
            SubmitButton.Text = "Submit";
            SubmitButton.UseVisualStyleBackColor = true;
            SubmitButton.Click += SubmitButton_Click;
            // 
            // SearchRadioButton
            // 
            SearchRadioButton.AutoSize = true;
            SearchRadioButton.Location = new Point(480, 310);
            SearchRadioButton.Margin = new Padding(3, 2, 3, 2);
            SearchRadioButton.Name = "SearchRadioButton";
            SearchRadioButton.Size = new Size(60, 19);
            SearchRadioButton.TabIndex = 18;
            SearchRadioButton.Text = "Search";
            SearchRadioButton.UseVisualStyleBackColor = true;
            SearchRadioButton.CheckedChanged += SearchRadioButton_CheckedChanged;
            // 
            // ModifyRadioButton
            // 
            ModifyRadioButton.AutoSize = true;
            ModifyRadioButton.Location = new Point(281, 310);
            ModifyRadioButton.Margin = new Padding(3, 2, 3, 2);
            ModifyRadioButton.Name = "ModifyRadioButton";
            ModifyRadioButton.Size = new Size(63, 19);
            ModifyRadioButton.TabIndex = 17;
            ModifyRadioButton.Text = "Modify";
            ModifyRadioButton.UseVisualStyleBackColor = true;
            // 
            // AddRadioButton
            // 
            AddRadioButton.AutoSize = true;
            AddRadioButton.Checked = true;
            AddRadioButton.Location = new Point(194, 310);
            AddRadioButton.Margin = new Padding(3, 2, 3, 2);
            AddRadioButton.Name = "AddRadioButton";
            AddRadioButton.Size = new Size(47, 19);
            AddRadioButton.TabIndex = 16;
            AddRadioButton.TabStop = true;
            AddRadioButton.Text = "Add";
            AddRadioButton.UseVisualStyleBackColor = true;
            // 
            // VehicleTypeComboBox
            // 
            VehicleTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            VehicleTypeComboBox.FormattingEnabled = true;
            VehicleTypeComboBox.Items.AddRange(new object[] { "", "Sports", "Truck", "SUV", "Sedan", "Electric" });
            VehicleTypeComboBox.Location = new Point(210, 247);
            VehicleTypeComboBox.Margin = new Padding(3, 2, 3, 2);
            VehicleTypeComboBox.Name = "VehicleTypeComboBox";
            VehicleTypeComboBox.Size = new Size(133, 23);
            VehicleTypeComboBox.TabIndex = 15;
            // 
            // VehicleTypeLabel
            // 
            VehicleTypeLabel.AutoSize = true;
            VehicleTypeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            VehicleTypeLabel.Location = new Point(35, 245);
            VehicleTypeLabel.Name = "VehicleTypeLabel";
            VehicleTypeLabel.Size = new Size(123, 25);
            VehicleTypeLabel.TabIndex = 14;
            VehicleTypeLabel.Text = "Vehicle type:";
            // 
            // ModelLabel
            // 
            ModelLabel.AutoSize = true;
            ModelLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ModelLabel.Location = new Point(35, 169);
            ModelLabel.Name = "ModelLabel";
            ModelLabel.Size = new Size(74, 25);
            ModelLabel.TabIndex = 12;
            ModelLabel.Text = "Model:";
            // 
            // MakeLabel
            // 
            MakeLabel.AutoSize = true;
            MakeLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            MakeLabel.Location = new Point(35, 134);
            MakeLabel.Name = "MakeLabel";
            MakeLabel.Size = new Size(66, 25);
            MakeLabel.TabIndex = 10;
            MakeLabel.Text = "Make:";
            // 
            // KilometersLabel
            // 
            KilometersLabel.AutoSize = true;
            KilometersLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            KilometersLabel.Location = new Point(35, 94);
            KilometersLabel.Name = "KilometersLabel";
            KilometersLabel.Size = new Size(111, 25);
            KilometersLabel.TabIndex = 2;
            KilometersLabel.Text = "Kilometers:";
            // 
            // LicensePlateLabel
            // 
            LicensePlateLabel.AutoSize = true;
            LicensePlateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            LicensePlateLabel.Location = new Point(35, 56);
            LicensePlateLabel.Name = "LicensePlateLabel";
            LicensePlateLabel.Size = new Size(130, 25);
            LicensePlateLabel.TabIndex = 1;
            LicensePlateLabel.Text = "License Plate:";
            // 
            // VINLabel
            // 
            VINLabel.AutoSize = true;
            VINLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            VINLabel.Location = new Point(35, 22);
            VINLabel.Name = "VINLabel";
            VINLabel.Size = new Size(51, 25);
            VINLabel.TabIndex = 0;
            VINLabel.Text = "VIN:";
            // 
            // NotificationLabel
            // 
            NotificationLabel.AutoSize = true;
            NotificationLabel.Font = new Font("Segoe UI Semibold", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NotificationLabel.Location = new Point(183, 369);
            NotificationLabel.Name = "NotificationLabel";
            NotificationLabel.Size = new Size(85, 19);
            NotificationLabel.TabIndex = 25;
            NotificationLabel.Text = "Notification";
            NotificationLabel.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Car);
            tabControl1.Controls.Add(Rental);
            tabControl1.Controls.Add(Reports);
            tabControl1.Location = new Point(13, 13);
            tabControl1.Margin = new Padding(4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(785, 435);
            tabControl1.TabIndex = 1;
            // 
            // HideNotificationTimer
            // 
            HideNotificationTimer.Interval = 5000;
            HideNotificationTimer.Tick += HideNotificationTimer_Tick;
            // 
            // vehicleList
            // 
            vehicleList.AllowUserToAddRows = false;
            vehicleList.AllowUserToDeleteRows = false;
            vehicleList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            vehicleList.Columns.AddRange(new DataGridViewColumn[] { VIN, LicensePlate, Kilometers, Make, Model, Colour, vType });
            vehicleList.Location = new Point(17, 455);
            vehicleList.Name = "vehicleList";
            vehicleList.ReadOnly = true;
            vehicleList.Size = new Size(782, 305);
            vehicleList.TabIndex = 0;
            // 
            // VIN
            // 
            VIN.HeaderText = "VIN";
            VIN.Name = "VIN";
            VIN.ReadOnly = true;
            VIN.Width = 135;
            // 
            // LicensePlate
            // 
            LicensePlate.HeaderText = "License Plate";
            LicensePlate.Name = "LicensePlate";
            LicensePlate.ReadOnly = true;
            // 
            // Kilometers
            // 
            Kilometers.HeaderText = "Kilometers";
            Kilometers.Name = "Kilometers";
            Kilometers.ReadOnly = true;
            // 
            // Make
            // 
            Make.HeaderText = "Make";
            Make.Name = "Make";
            Make.ReadOnly = true;
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.Name = "Model";
            Model.ReadOnly = true;
            // 
            // Colour
            // 
            Colour.HeaderText = "Colour";
            Colour.Name = "Colour";
            Colour.ReadOnly = true;
            // 
            // vType
            // 
            vType.HeaderText = "Vehicle Type";
            vType.Name = "vType";
            vType.ReadOnly = true;
            // 
            // HideRentalNotificationTimer
            // 
            HideRentalNotificationTimer.Interval = 5000;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(811, 771);
            Controls.Add(vehicleList);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Reservation";
            Reports.ResumeLayout(false);
            Reports.PerformLayout();
            Rental.ResumeLayout(false);
            Rental.PerformLayout();
            Car.ResumeLayout(false);
            Car.PerformLayout();
            tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)vehicleList).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TabPage Reports;
        private TabPage Rental;
        private ComboBox ReturnComboBox;
        private Label rBranch;
        private Button ReserveButton;
        private DateTimePicker DropOffPicker;
        private Label DropOffDateLabel;
        private ComboBox PickupComboBox;
        private Label PickUpBranchLabel;
        private DateTimePicker PickUpPicker;
        private Label PickUpDateLabel;
        private TabPage Car;
        private RadioButton DeleteRadioButton;
        private TextBox ColourTextBox;
        private TextBox ModelTextBox;
        private TextBox MakeTextBox;
        private TextBox KilometersTextBox;
        private TextBox VINTextBox;
        private TextBox LicensePlateTextBox;
        private Label ColourLabel;
        private Label SelectOneLabel;
        private Button SubmitButton;
        private RadioButton SearchRadioButton;
        private RadioButton ModifyRadioButton;
        private RadioButton AddRadioButton;
        private ComboBox VehicleTypeComboBox;
        private Label VehicleTypeLabel;
        private Label ModelLabel;
        private Label MakeLabel;
        private Label KilometersLabel;
        private Label LicensePlateLabel;
        private Label VINLabel;
        private TabControl tabControl1;
        private CheckBox DifferentLocationCheckBox;
        private Label NotificationLabel;
        private System.Windows.Forms.Timer HideNotificationTimer;
        private DataGridView vehicleList;
        private DataGridViewTextBoxColumn VIN;
        private DataGridViewTextBoxColumn LicensePlate;
        private DataGridViewTextBoxColumn Kilometers;
        private DataGridViewTextBoxColumn Make;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Colour;
        private DataGridViewTextBoxColumn vType;
        private RadioButton Q1_radio;
        private RadioButton Q6_radio;
        private RadioButton Q5_radio;
        private RadioButton Q4_radio;
        private RadioButton Q3_radio;
        private RadioButton Q2_radio;
        private Label label1;
        private ComboBox Pop_branch;
        private ComboBox month1;
        private Label label4;
        private Label label3;
        private Label label6;
        private Label label5;
        private ComboBox Q3_combo1;
        private Label label7;
        private ComboBox Q4_combo;
        private Label label8;
        private Label label10;
        private ComboBox Q5_combo;
        private Label label9;
        private Button button1;
        private Label label2;
        private ComboBox RentalVehicleTypeComboBox;
        private Label label11;
        private Label OrderTotalLabel;
        private Label PriceLabel;
        private ComboBox timespermonth;
        private ComboBox RepKilos;
        private ComboBox kiloComboBox;
        private ComboBox vinComboBox;
        private ComboBox Q5_combo2;
        private ComboBox Q4_combo2;
        private Label RentalNotificationLabel;
        private System.Windows.Forms.Timer HideRentalNotificationTimer;
        private ComboBox Q3_combo2;
    }
}
