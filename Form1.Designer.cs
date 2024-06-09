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
            dateTimePicker2 = new DateTimePicker();
            label8 = new Label();
            label7 = new Label();
            comboBox5 = new ComboBox();
            label3 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            KiloSelection = new TextBox();
            comboBox4 = new ComboBox();
            label4 = new Label();
            comboBox3 = new ComboBox();
            comboBox2 = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            ReportsVehicleModel = new ComboBox();
            ReportsModelLabel = new Label();
            ReportsVehicleType = new ComboBox();
            label1 = new Label();
            Rental = new TabPage();
            DifferentLocationCheckBox = new CheckBox();
            ReturnComboBox = new ComboBox();
            ReturnBranchLabel = new Label();
            AddBranchButton = new Button();
            ReserveButton = new Button();
            DropOffPicker = new DateTimePicker();
            DropOffDateLabel = new Label();
            BranchComboBox = new ComboBox();
            PickUpBranchLabel = new Label();
            PickUpPicker = new DateTimePicker();
            PickUpDateLabel = new Label();
            Car = new TabPage();
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
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            label9 = new Label();
            button1 = new Button();
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
            Reports.Controls.Add(button1);
            Reports.Controls.Add(label9);
            Reports.Controls.Add(radioButton3);
            Reports.Controls.Add(radioButton4);
            Reports.Controls.Add(dateTimePicker2);
            Reports.Controls.Add(label8);
            Reports.Controls.Add(label7);
            Reports.Controls.Add(comboBox5);
            Reports.Controls.Add(label3);
            Reports.Controls.Add(comboBox1);
            Reports.Controls.Add(label2);
            Reports.Controls.Add(dateTimePicker1);
            Reports.Controls.Add(KiloSelection);
            Reports.Controls.Add(comboBox4);
            Reports.Controls.Add(label4);
            Reports.Controls.Add(comboBox3);
            Reports.Controls.Add(comboBox2);
            Reports.Controls.Add(label5);
            Reports.Controls.Add(label6);
            Reports.Controls.Add(ReportsVehicleModel);
            Reports.Controls.Add(ReportsModelLabel);
            Reports.Controls.Add(ReportsVehicleType);
            Reports.Controls.Add(label1);
            Reports.Location = new Point(4, 24);
            Reports.Margin = new Padding(3, 2, 3, 2);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3, 2, 3, 2);
            Reports.Size = new Size(740, 444);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(445, 308);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(200, 23);
            dateTimePicker2.TabIndex = 43;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(393, 306);
            label8.Name = "label8";
            label8.Size = new Size(46, 25);
            label8.TabIndex = 42;
            label8.Text = "and";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(20, 306);
            label7.Name = "label7";
            label7.Size = new Size(161, 25);
            label7.TabIndex = 41;
            label7.Text = "Rented between:";
            // 
            // comboBox5
            // 
            comboBox5.FormattingEnabled = true;
            comboBox5.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            comboBox5.Location = new Point(210, 265);
            comboBox5.Margin = new Padding(3, 2, 3, 2);
            comboBox5.Name = "comboBox5";
            comboBox5.Size = new Size(133, 23);
            comboBox5.TabIndex = 40;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(20, 263);
            label3.Name = "label3";
            label3.Size = new Size(124, 25);
            label3.TabIndex = 39;
            label3.Text = "Returned to:";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            comboBox1.Location = new Point(210, 226);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(133, 23);
            comboBox1.TabIndex = 38;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(20, 224);
            label2.Name = "label2";
            label2.Size = new Size(157, 25);
            label2.TabIndex = 37;
            label2.Text = "Picked-up from:";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(187, 308);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(200, 23);
            dateTimePicker1.TabIndex = 36;
            // 
            // KiloSelection
            // 
            KiloSelection.Location = new Point(349, 111);
            KiloSelection.Margin = new Padding(3, 2, 3, 2);
            KiloSelection.Name = "KiloSelection";
            KiloSelection.Size = new Size(134, 23);
            KiloSelection.TabIndex = 35;
            // 
            // comboBox4
            // 
            comboBox4.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            comboBox4.FormattingEnabled = true;
            comboBox4.Location = new Point(210, 188);
            comboBox4.Margin = new Padding(3, 2, 3, 2);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(133, 23);
            comboBox4.TabIndex = 34;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(20, 183);
            label4.Name = "label4";
            label4.Size = new Size(73, 25);
            label4.TabIndex = 33;
            label4.Text = "Colour";
            // 
            // comboBox3
            // 
            comboBox3.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(210, 150);
            comboBox3.Margin = new Padding(3, 2, 3, 2);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(133, 23);
            comboBox3.TabIndex = 21;
            // 
            // comboBox2
            // 
            comboBox2.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "greater than", "less than" });
            comboBox2.Location = new Point(210, 111);
            comboBox2.Margin = new Padding(3, 2, 3, 2);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(133, 23);
            comboBox2.TabIndex = 21;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(20, 145);
            label5.Name = "label5";
            label5.Size = new Size(66, 25);
            label5.TabIndex = 20;
            label5.Text = "Make:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(20, 106);
            label6.Name = "label6";
            label6.Size = new Size(106, 25);
            label6.TabIndex = 20;
            label6.Text = "Kilometers";
            // 
            // ReportsVehicleModel
            // 
            ReportsVehicleModel.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            ReportsVehicleModel.FormattingEnabled = true;
            ReportsVehicleModel.Location = new Point(210, 70);
            ReportsVehicleModel.Margin = new Padding(3, 2, 3, 2);
            ReportsVehicleModel.Name = "ReportsVehicleModel";
            ReportsVehicleModel.Size = new Size(133, 23);
            ReportsVehicleModel.TabIndex = 19;
            // 
            // ReportsModelLabel
            // 
            ReportsModelLabel.AutoSize = true;
            ReportsModelLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            ReportsModelLabel.Location = new Point(20, 65);
            ReportsModelLabel.Name = "ReportsModelLabel";
            ReportsModelLabel.Size = new Size(74, 25);
            ReportsModelLabel.TabIndex = 18;
            ReportsModelLabel.Text = "Model:";
            // 
            // ReportsVehicleType
            // 
            ReportsVehicleType.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            ReportsVehicleType.FormattingEnabled = true;
            ReportsVehicleType.Items.AddRange(new object[] { "", "Sports", "Truck", "SUV", "Sedan", "Electric" });
            ReportsVehicleType.Location = new Point(210, 29);
            ReportsVehicleType.Margin = new Padding(3, 2, 3, 2);
            ReportsVehicleType.Name = "ReportsVehicleType";
            ReportsVehicleType.Size = new Size(133, 23);
            ReportsVehicleType.TabIndex = 17;
            ReportsVehicleType.SelectedIndexChanged += ReportsVehicleType_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(20, 24);
            label1.Name = "label1";
            label1.Size = new Size(123, 25);
            label1.TabIndex = 16;
            label1.Text = "Vehicle type:";
            // 
            // Rental
            // 
            Rental.BackColor = SystemColors.GradientInactiveCaption;
            Rental.Controls.Add(DifferentLocationCheckBox);
            Rental.Controls.Add(ReturnComboBox);
            Rental.Controls.Add(ReturnBranchLabel);
            Rental.Controls.Add(AddBranchButton);
            Rental.Controls.Add(ReserveButton);
            Rental.Controls.Add(DropOffPicker);
            Rental.Controls.Add(DropOffDateLabel);
            Rental.Controls.Add(BranchComboBox);
            Rental.Controls.Add(PickUpBranchLabel);
            Rental.Controls.Add(PickUpPicker);
            Rental.Controls.Add(PickUpDateLabel);
            Rental.Location = new Point(4, 24);
            Rental.Margin = new Padding(3, 2, 3, 2);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3, 2, 3, 2);
            Rental.Size = new Size(740, 444);
            Rental.TabIndex = 1;
            Rental.Text = "Rental";
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
            ReturnComboBox.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            ReturnComboBox.Location = new Point(207, 148);
            ReturnComboBox.Margin = new Padding(3, 2, 3, 2);
            ReturnComboBox.Name = "ReturnComboBox";
            ReturnComboBox.Size = new Size(133, 23);
            ReturnComboBox.TabIndex = 13;
            ReturnComboBox.Visible = false;
            // 
            // ReturnBranchLabel
            // 
            ReturnBranchLabel.AutoSize = true;
            ReturnBranchLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReturnBranchLabel.Location = new Point(59, 143);
            ReturnBranchLabel.Name = "ReturnBranchLabel";
            ReturnBranchLabel.Size = new Size(78, 25);
            ReturnBranchLabel.TabIndex = 12;
            ReturnBranchLabel.Text = "Return:";
            ReturnBranchLabel.Visible = false;
            // 
            // AddBranchButton
            // 
            AddBranchButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AddBranchButton.Location = new Point(240, 376);
            AddBranchButton.Margin = new Padding(3, 2, 3, 2);
            AddBranchButton.Name = "AddBranchButton";
            AddBranchButton.Size = new Size(154, 40);
            AddBranchButton.TabIndex = 10;
            AddBranchButton.Text = "Add Branch";
            AddBranchButton.UseVisualStyleBackColor = true;
            AddBranchButton.Click += AddBranchButton_Click;
            // 
            // ReserveButton
            // 
            ReserveButton.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ReserveButton.Location = new Point(46, 374);
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
            DropOffPicker.Location = new Point(261, 276);
            DropOffPicker.Margin = new Padding(3, 2, 3, 2);
            DropOffPicker.Name = "DropOffPicker";
            DropOffPicker.Size = new Size(219, 23);
            DropOffPicker.TabIndex = 8;
            // 
            // DropOffDateLabel
            // 
            DropOffDateLabel.AutoSize = true;
            DropOffDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DropOffDateLabel.Location = new Point(46, 276);
            DropOffDateLabel.Name = "DropOffDateLabel";
            DropOffDateLabel.Size = new Size(191, 25);
            DropOffDateLabel.TabIndex = 7;
            DropOffDateLabel.Text = "Enter drop-off date:";
            // 
            // BranchComboBox
            // 
            BranchComboBox.FormattingEnabled = true;
            BranchComboBox.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            BranchComboBox.Location = new Point(203, 49);
            BranchComboBox.Margin = new Padding(3, 2, 3, 2);
            BranchComboBox.Name = "BranchComboBox";
            BranchComboBox.Size = new Size(133, 23);
            BranchComboBox.TabIndex = 5;
            // 
            // PickUpBranchLabel
            // 
            PickUpBranchLabel.AutoSize = true;
            PickUpBranchLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PickUpBranchLabel.Location = new Point(54, 44);
            PickUpBranchLabel.Name = "PickUpBranchLabel";
            PickUpBranchLabel.Size = new Size(85, 25);
            PickUpBranchLabel.TabIndex = 4;
            PickUpBranchLabel.Text = "Pick-up:";
            // 
            // PickUpPicker
            // 
            PickUpPicker.Location = new Point(261, 220);
            PickUpPicker.Margin = new Padding(3, 2, 3, 2);
            PickUpPicker.Name = "PickUpPicker";
            PickUpPicker.Size = new Size(219, 23);
            PickUpPicker.TabIndex = 2;
            // 
            // PickUpDateLabel
            // 
            PickUpDateLabel.AutoSize = true;
            PickUpDateLabel.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PickUpDateLabel.Location = new Point(46, 220);
            PickUpDateLabel.Name = "PickUpDateLabel";
            PickUpDateLabel.Size = new Size(181, 25);
            PickUpDateLabel.TabIndex = 0;
            PickUpDateLabel.Text = "Enter pick-up date:";
            // 
            // Car
            // 
            Car.AccessibleRole = AccessibleRole.Caret;
            Car.BackColor = SystemColors.GradientInactiveCaption;
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
            Car.Size = new Size(740, 444);
            Car.TabIndex = 2;
            Car.Text = "Car";
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
            ColourTextBox.Location = new Point(192, 210);
            ColourTextBox.Margin = new Padding(3, 2, 3, 2);
            ColourTextBox.MaxLength = 20;
            ColourTextBox.Name = "ColourTextBox";
            ColourTextBox.Size = new Size(133, 23);
            ColourTextBox.TabIndex = 22;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(191, 172);
            ModelTextBox.Margin = new Padding(3, 2, 3, 2);
            ModelTextBox.MaxLength = 20;
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(134, 23);
            ModelTextBox.TabIndex = 13;
            // 
            // MakeTextBox
            // 
            MakeTextBox.Location = new Point(191, 137);
            MakeTextBox.Margin = new Padding(3, 2, 3, 2);
            MakeTextBox.MaxLength = 20;
            MakeTextBox.Name = "MakeTextBox";
            MakeTextBox.Size = new Size(134, 23);
            MakeTextBox.TabIndex = 11;
            // 
            // KilometersTextBox
            // 
            KilometersTextBox.Location = new Point(191, 98);
            KilometersTextBox.Margin = new Padding(3, 2, 3, 2);
            KilometersTextBox.MaxLength = 9;
            KilometersTextBox.Name = "KilometersTextBox";
            KilometersTextBox.Size = new Size(134, 23);
            KilometersTextBox.TabIndex = 9;
            // 
            // VINTextBox
            // 
            VINTextBox.Location = new Point(191, 22);
            VINTextBox.Margin = new Padding(3, 2, 3, 2);
            VINTextBox.Name = "VINTextBox";
            VINTextBox.Size = new Size(134, 23);
            VINTextBox.TabIndex = 8;
            // 
            // LicensePlateTextBox
            // 
            LicensePlateTextBox.Location = new Point(191, 60);
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
            ModifyRadioButton.CheckedChanged += ModifyRadioButton_CheckedChanged;
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
            AddRadioButton.CheckedChanged += AddRadioButton_CheckedChanged;
            // 
            // VehicleTypeComboBox
            // 
            VehicleTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            VehicleTypeComboBox.FormattingEnabled = true;
            VehicleTypeComboBox.Items.AddRange(new object[] { "", "Sports", "Truck", "SUV", "Sedan", "Electric" });
            VehicleTypeComboBox.Location = new Point(192, 248);
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
            tabControl1.Size = new Size(748, 472);
            tabControl1.TabIndex = 11;
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
            vehicleList.Location = new Point(17, 492);
            vehicleList.Name = "vehicleList";
            vehicleList.ReadOnly = true;
            vehicleList.Size = new Size(744, 274);
            vehicleList.TabIndex = 12;
            // 
            // VIN
            // 
            VIN.HeaderText = "VIN";
            VIN.Name = "VIN";
            VIN.ReadOnly = true;
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
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(276, 359);
            radioButton3.Margin = new Padding(3, 2, 3, 2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(50, 19);
            radioButton3.TabIndex = 45;
            radioButton3.Text = "Total";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Checked = true;
            radioButton4.Location = new Point(189, 359);
            radioButton4.Margin = new Padding(3, 2, 3, 2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(43, 19);
            radioButton4.TabIndex = 44;
            radioButton4.TabStop = true;
            radioButton4.Text = "List";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label9.Location = new Point(20, 353);
            label9.Name = "label9";
            label9.Size = new Size(108, 25);
            label9.TabIndex = 48;
            label9.Text = "Select one:";
            // 
            // button1
            // 
            button1.Location = new Point(20, 399);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(82, 22);
            button1.TabIndex = 49;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(772, 771);
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
        private TabPage tabPage3;
        private TabPage Reports;
        private TabPage Rental;
        private ComboBox ReturnComboBox;
        private Label ReturnBranchLabel;
        private Button AddBranchButton;
        private Button ReserveButton;
        private DateTimePicker DropOffPicker;
        private Label DropOffDateLabel;
        private ComboBox BranchComboBox;
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
        private ComboBox ReportsVehicleType;
        private Label label1;
        private ComboBox ReportsVehicleModel;
        private Label ReportsModelLabel;
        private ComboBox comboBox4;
        private Label label4;
        private ComboBox comboBox3;
        private ComboBox comboBox2;
        private Label label5;
        private Label label6;
        private TextBox KiloSelection;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private Label label2;
        private ComboBox comboBox5;
        private Label label3;
        private DateTimePicker dateTimePicker2;
        private Label label8;
        private Label label7;
        private Label label9;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;
    }
}
