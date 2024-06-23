using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Xml.Linq;

namespace WindowsProject1
{
    public partial class Form1 : Form
    {
        Database db = new Database();
        public Form1()
        {
            InitializeComponent();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (ValidateInput())
            {
                string firstName = textBox1.Text;
                string lastName = textBox2.Text;
                DateTime birthDate = BirthDate.Value;
                String gender = radioButton1.Checked ? radioButton1.Text : radioButton2.Text;
                string phoneNum = PhoneNum.Text;
                int age = int.Parse(textBox3.Text);
                String Email = eMail.Text;
                String major = ListOption1.Text;
                db.SaveApplicant(firstName, lastName, age, birthDate, gender, phoneNum, Email,major);
                ValidateInput();
                MessageBox.Show("Applicant saved successfully!");
            }
        }

        private bool ValidateInput()
        {
            if (!Regex.IsMatch(textBox1.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("First name should contain only letters.");
                return false;
            }

            if (!Regex.IsMatch(textBox2.Text, @"^[a-zA-Z]+$"))
            {
                MessageBox.Show("Last name should contain only letters.");
                return false;
            }

            if (!Regex.IsMatch(PhoneNum.Text, @"^\+?1?[-.\s]?(\d{3})?[-.\s]?\d{3}[-.\s]?\d{4}$"))
            {
                MessageBox.Show("Invalid Phone Number Format.");
                return false;
            }

            if (!Regex.IsMatch(eMail.Text, @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
            {
                MessageBox.Show("Invalid email address format");
                return false;
            }

            if (!int.TryParse(textBox3.Text, out int age) || age <= 0)
            {
                MessageBox.Show("Age must be a positive integer.");
                return false;
            }
            return true;
        }


        private void ClearInputFields(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            BirthDate.Value = DateTimePicker.MinimumDateTime;
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            PhoneNum.Clear();
            eMail.Clear();


        }

        private void closeForm(object sender, EventArgs e)
        {
            this.Close();
        }

        private void majorList1_indexSelected(object sender, EventArgs e)
        {
            string selectedMajor = ListOption1.SelectedItem.ToString();
            MessageBox.Show("You Selected: " + selectedMajor);
        }

    }
}
