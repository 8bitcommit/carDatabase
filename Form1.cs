namespace LAB6291
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click_2(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string mes = "Reservation from " + branch.Text + " branch \nFrom Date: " + DateP.Text + " To Date: " + dateR.Text + "\nFor:" + (dateR.Value - DateP.Value).Days.ToString() + " days is Confirmed";
            MessageBox.Show(mes);
        }

        private void addBranch_Click(object sender, EventArgs e)
        {
            branch.Items.Add("London");
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {

            if (diff.Checked == true)
                locationReturn.Visible = true;
            ReturnBox.Visible = true;


        }

        private void locationtext_Click(object sender, EventArgs e)
        {

        }

        private void ReturnBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click_3(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}

