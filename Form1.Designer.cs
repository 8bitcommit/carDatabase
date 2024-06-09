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
            Rental.SuspendLayout();
            Car.SuspendLayout();
            tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)vehicleList).BeginInit();
            SuspendLayout();
            // 
            // Reports
            // 
            Reports.BackColor = SystemColors.GradientInactiveCaption;
            Reports.Location = new Point(4, 24);
            Reports.Margin = new Padding(3, 2, 3, 2);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3, 2, 3, 2);
            Reports.Size = new Size(777, 407);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
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
            Rental.Size = new Size(777, 407);
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
            Car.Size = new Size(777, 407);
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
            tabControl1.Size = new Size(785, 435);
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
            vehicleList.Location = new Point(17, 455);
            vehicleList.Name = "vehicleList";
            vehicleList.ReadOnly = true;
            vehicleList.Size = new Size(782, 305);
            vehicleList.TabIndex = 12;
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
    }
}
