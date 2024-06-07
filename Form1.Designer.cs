namespace LAB6291
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
            mult = new RadioButton();
            add = new RadioButton();
            sub = new RadioButton();
            Car = new TabPage();
            Delete = new RadioButton();
            textBox6 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            Search = new RadioButton();
            Modify = new RadioButton();
            radioButton1 = new RadioButton();
            comboBox1 = new ComboBox();
            label4 = new Label();
            textBox5 = new TextBox();
            label8 = new Label();
            textBox4 = new TextBox();
            label7 = new Label();
            textBox3 = new TextBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label6 = new Label();
            label5 = new Label();
            VIN = new Label();
            Rental = new TabPage();
            ReturnBox = new ComboBox();
            locationReturn = new Label();
            diff = new RadioButton();
            addBranch = new Button();
            Reserve = new Button();
            dateR = new DateTimePicker();
            enterD = new Label();
            branch = new ComboBox();
            locationtext = new Label();
            DateP = new DateTimePicker();
            enterp = new Label();
            tabControl1 = new TabControl();
            Reports = new TabPage();
            Car.SuspendLayout();
            Rental.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // mult
            // 
            mult.AutoSize = true;
            mult.Location = new Point(170, 4);
            mult.Name = "mult";
            mult.Size = new Size(84, 24);
            mult.TabIndex = 10;
            mult.TabStop = true;
            mult.Text = "Multiply";
            mult.UseVisualStyleBackColor = true;
            mult.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // add
            // 
            add.AutoSize = true;
            add.Location = new Point(15, 4);
            add.Name = "add";
            add.Size = new Size(58, 24);
            add.TabIndex = 8;
            add.TabStop = true;
            add.Text = "Add";
            add.UseVisualStyleBackColor = true;
            add.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // sub
            // 
            sub.AutoSize = true;
            sub.Location = new Point(79, 4);
            sub.Name = "sub";
            sub.Size = new Size(85, 24);
            sub.TabIndex = 9;
            sub.TabStop = true;
            sub.Text = "Subtract";
            sub.UseVisualStyleBackColor = true;
            // 
            // Car
            // 
            Car.AccessibleRole = AccessibleRole.Caret;
            Car.BackColor = SystemColors.GradientInactiveCaption;
            Car.Controls.Add(Delete);
            Car.Controls.Add(textBox6);
            Car.Controls.Add(label2);
            Car.Controls.Add(label1);
            Car.Controls.Add(button1);
            Car.Controls.Add(Search);
            Car.Controls.Add(Modify);
            Car.Controls.Add(radioButton1);
            Car.Controls.Add(comboBox1);
            Car.Controls.Add(label4);
            Car.Controls.Add(textBox5);
            Car.Controls.Add(label8);
            Car.Controls.Add(textBox4);
            Car.Controls.Add(label7);
            Car.Controls.Add(textBox3);
            Car.Controls.Add(textBox2);
            Car.Controls.Add(textBox1);
            Car.Controls.Add(label6);
            Car.Controls.Add(label5);
            Car.Controls.Add(VIN);
            Car.Location = new Point(4, 29);
            Car.Name = "Car";
            Car.Size = new Size(758, 596);
            Car.TabIndex = 2;
            Car.Text = "Car";
            // 
            // Delete
            // 
            Delete.AutoSize = true;
            Delete.Location = new Point(441, 414);
            Delete.Name = "Delete";
            Delete.Size = new Size(74, 24);
            Delete.TabIndex = 23;
            Delete.TabStop = true;
            Delete.Text = "Delete";
            Delete.UseVisualStyleBackColor = true;
            Delete.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(219, 280);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(151, 27);
            textBox6.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label2.Location = new Point(41, 276);
            label2.Name = "label2";
            label2.Size = new Size(93, 31);
            label2.TabIndex = 21;
            label2.Text = "Colour:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label1.Location = new Point(40, 407);
            label1.Name = "label1";
            label1.Size = new Size(130, 31);
            label1.TabIndex = 20;
            label1.Text = "Select one:";
            // 
            // button1
            // 
            button1.Location = new Point(41, 492);
            button1.Name = "button1";
            button1.RightToLeft = RightToLeft.Yes;
            button1.Size = new Size(94, 29);
            button1.TabIndex = 19;
            button1.Text = "Submit";
            button1.UseVisualStyleBackColor = true;
            // 
            // Search
            // 
            Search.AutoSize = true;
            Search.Location = new Point(549, 414);
            Search.Name = "Search";
            Search.Size = new Size(74, 24);
            Search.TabIndex = 18;
            Search.TabStop = true;
            Search.Text = "Search";
            Search.UseVisualStyleBackColor = true;
            // 
            // Modify
            // 
            Modify.AutoSize = true;
            Modify.Location = new Point(336, 414);
            Modify.Name = "Modify";
            Modify.Size = new Size(77, 24);
            Modify.TabIndex = 17;
            Modify.TabStop = true;
            Modify.Text = "Modify";
            Modify.UseVisualStyleBackColor = true;
            Modify.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(222, 414);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(58, 24);
            radioButton1.TabIndex = 16;
            radioButton1.TabStop = true;
            radioButton1.Text = "Add";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteCustomSource.AddRange(new string[] { "Compact", "Sedan", "SUV", "Mini-Van", "Truck" });
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            comboBox1.Location = new Point(219, 330);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(151, 28);
            comboBox1.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label4.Location = new Point(40, 327);
            label4.Name = "label4";
            label4.Size = new Size(150, 31);
            label4.TabIndex = 14;
            label4.Text = "Vehicle type:";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(218, 229);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(152, 27);
            textBox5.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label8.Location = new Point(40, 225);
            label8.Name = "label8";
            label8.Size = new Size(89, 31);
            label8.TabIndex = 12;
            label8.Text = "Model:";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(218, 183);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(152, 27);
            textBox4.TabIndex = 11;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label7.Location = new Point(40, 179);
            label7.Name = "label7";
            label7.Size = new Size(79, 31);
            label7.TabIndex = 10;
            label7.Text = "Make:";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(218, 130);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(152, 27);
            textBox3.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(218, 29);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(152, 27);
            textBox2.TabIndex = 8;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(218, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(152, 27);
            textBox1.TabIndex = 7;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label6.Location = new Point(40, 126);
            label6.Name = "label6";
            label6.Size = new Size(136, 31);
            label6.TabIndex = 2;
            label6.Text = "Kilometers:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            label5.Location = new Point(40, 74);
            label5.Name = "label5";
            label5.Size = new Size(158, 31);
            label5.TabIndex = 1;
            label5.Text = "License Plate:";
            // 
            // VIN
            // 
            VIN.AutoSize = true;
            VIN.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold);
            VIN.Location = new Point(40, 29);
            VIN.Name = "VIN";
            VIN.Size = new Size(60, 31);
            VIN.TabIndex = 0;
            VIN.Text = "VIN:";
            VIN.Click += label4_Click_3;
            // 
            // Rental
            // 
            Rental.BackColor = SystemColors.GradientInactiveCaption;
            Rental.Controls.Add(ReturnBox);
            Rental.Controls.Add(locationReturn);
            Rental.Controls.Add(diff);
            Rental.Controls.Add(addBranch);
            Rental.Controls.Add(Reserve);
            Rental.Controls.Add(dateR);
            Rental.Controls.Add(enterD);
            Rental.Controls.Add(branch);
            Rental.Controls.Add(locationtext);
            Rental.Controls.Add(DateP);
            Rental.Controls.Add(enterp);
            Rental.Location = new Point(4, 29);
            Rental.Name = "Rental";
            Rental.Padding = new Padding(3);
            Rental.Size = new Size(758, 596);
            Rental.TabIndex = 1;
            Rental.Text = "Rental";
            Rental.Click += tabPage2_Click;
            // 
            // ReturnBox
            // 
            ReturnBox.FormattingEnabled = true;
            ReturnBox.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            ReturnBox.Location = new Point(237, 197);
            ReturnBox.Name = "ReturnBox";
            ReturnBox.Size = new Size(151, 28);
            ReturnBox.TabIndex = 13;
            ReturnBox.Visible = false;
            ReturnBox.SelectedIndexChanged += ReturnBox_SelectedIndexChanged;
            ReturnBox.VisibleChanged += radioButton1_CheckedChanged_1;
            ReturnBox.Click += radioButton1_CheckedChanged_1;
            // 
            // locationReturn
            // 
            locationReturn.AutoSize = true;
            locationReturn.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locationReturn.Location = new Point(67, 191);
            locationReturn.Name = "locationReturn";
            locationReturn.Size = new Size(92, 31);
            locationReturn.TabIndex = 12;
            locationReturn.Text = "Return:";
            locationReturn.Visible = false;
            locationReturn.VisibleChanged += radioButton1_CheckedChanged_1;
            locationReturn.Click += radioButton3_CheckedChanged;
            // 
            // diff
            // 
            diff.AutoSize = true;
            diff.Location = new Point(67, 128);
            diff.Name = "diff";
            diff.Size = new Size(210, 24);
            diff.TabIndex = 11;
            diff.TabStop = true;
            diff.Text = "Return to different location";
            diff.UseVisualStyleBackColor = true;
            diff.CheckedChanged += radioButton1_CheckedChanged_1;
            // 
            // addBranch
            // 
            addBranch.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            addBranch.Location = new Point(274, 501);
            addBranch.Name = "addBranch";
            addBranch.Size = new Size(176, 53);
            addBranch.TabIndex = 10;
            addBranch.Text = "Add Branch";
            addBranch.UseVisualStyleBackColor = true;
            addBranch.Click += addBranch_Click;
            // 
            // Reserve
            // 
            Reserve.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Reserve.Location = new Point(52, 498);
            Reserve.Name = "Reserve";
            Reserve.Size = new Size(151, 58);
            Reserve.TabIndex = 9;
            Reserve.Text = "Reserve";
            Reserve.UseVisualStyleBackColor = true;
            Reserve.Click += button2_Click;
            // 
            // dateR
            // 
            dateR.Location = new Point(298, 368);
            dateR.Name = "dateR";
            dateR.Size = new Size(250, 27);
            dateR.TabIndex = 8;
            // 
            // enterD
            // 
            enterD.AutoSize = true;
            enterD.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterD.Location = new Point(52, 368);
            enterD.Name = "enterD";
            enterD.Size = new Size(227, 31);
            enterD.TabIndex = 7;
            enterD.Text = "Enter drop-off date:";
            enterD.Click += label5_Click_1;
            // 
            // branch
            // 
            branch.FormattingEnabled = true;
            branch.Items.AddRange(new object[] { "Whyte Avenue", "Jasper Avenue", "North side", "South side", "YEG Edmonton Int'l Airport" });
            branch.Location = new Point(232, 65);
            branch.Name = "branch";
            branch.Size = new Size(151, 28);
            branch.TabIndex = 5;
            branch.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // locationtext
            // 
            locationtext.AutoSize = true;
            locationtext.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            locationtext.Location = new Point(62, 59);
            locationtext.Name = "locationtext";
            locationtext.Size = new Size(101, 31);
            locationtext.TabIndex = 4;
            locationtext.Text = "Pick-up:";
            locationtext.Click += locationtext_Click;
            // 
            // DateP
            // 
            DateP.Location = new Point(298, 294);
            DateP.Name = "DateP";
            DateP.Size = new Size(250, 27);
            DateP.TabIndex = 2;
            DateP.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // enterp
            // 
            enterp.AutoSize = true;
            enterp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            enterp.Location = new Point(52, 294);
            enterp.Name = "enterp";
            enterp.Size = new Size(216, 31);
            enterp.TabIndex = 0;
            enterp.Text = "Enter pick-up date:";
            enterp.Click += label4_Click_2;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(Car);
            tabControl1.Controls.Add(Rental);
            tabControl1.Controls.Add(Reports);
            tabControl1.Location = new Point(12, 12);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(766, 629);
            tabControl1.TabIndex = 11;
            // 
            // Reports
            // 
            Reports.BackColor = SystemColors.GradientInactiveCaption;
            Reports.Location = new Point(4, 29);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(758, 596);
            Reports.TabIndex = 3;
            Reports.Text = "Reports";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.MenuBar;
            ClientSize = new Size(996, 819);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Reservation";
            Load += Form1_Load;
            Car.ResumeLayout(false);
            Car.PerformLayout();
            Rental.ResumeLayout(false);
            Rental.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private RadioButton mult;
        private RadioButton add;
        private RadioButton sub;
        private TabPage Car;
        private RadioButton Delete;
        private TabPage Rental;
        private ComboBox ReturnBox;
        private Label locationReturn;
        private RadioButton diff;
        private Button addBranch;
        private Button Reserve;
        private DateTimePicker dateR;
        private Label enterD;
        private ComboBox branch;
        private Label locationtext;
        private DateTimePicker DateP;
        private Label enterp;
        private TabControl tabControl1;
        private TabPage Reports;
        private Label label6;
        private Label label5;
        private Label VIN;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private Label label4;
        private TextBox textBox5;
        private Label label8;
        private TextBox textBox4;
        private Label label7;
        private Button button1;
        private RadioButton Search;
        private RadioButton Modify;
        private RadioButton radioButton1;
        private Label label1;
        private TextBox textBox6;
        private Label label2;
        private TabPage tabPage3;
    }
}
