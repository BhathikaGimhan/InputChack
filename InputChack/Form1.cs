namespace InputChack
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if(int.TryParse(inputNumber.Text,out int value))
                {
                    var getVal = int.Parse(inputNumber.Text);
                    if (getVal > 0)
                    {
                        if (dataGridView1.Rows.Count <= 10)
                        {
                            dataGridView1.Rows.Add(getVal, "");
                            inputNumber.Text = "";
                            if(dataGridView1.Rows.Count == 10)
                            {
                                MessageBox.Show("You have entered 10 numbers");
                                inputNumber.Focus();
                                inputNumber.Text = "";
                            }
                        }
                        else
                        {
                            MessageBox.Show("You can not entered more than 10 numbers");
                            inputNumber.Focus();
                            inputNumber.Text = "";
                        }
                    }
                    else
                    {
                        MessageBox.Show("You can not entered less than 1");
                        inputNumber.Focus();
                        inputNumber.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Entered value is invalid");
                    inputNumber.Focus();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}