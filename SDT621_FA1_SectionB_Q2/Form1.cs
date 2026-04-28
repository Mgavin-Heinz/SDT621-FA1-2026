namespace SDT621_FA1_SectionB_Q2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string idNumber = txtID.Text;
            string citizenshipStatus = comboBoxCTZ.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(idNumber) || string.IsNullOrWhiteSpace(citizenshipStatus))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenshipStatus);
            lblValidID.Text = profile.ValidateID();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string idNumber = txtID.Text;
            string citizenshipStatus = comboBoxCTZ.SelectedItem?.ToString() ?? "";
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(idNumber) || string.IsNullOrWhiteSpace(citizenshipStatus))
            {
                MessageBox.Show("Please fill in all fields.");
                return;
            }
            CitizenProfile profile = new CitizenProfile(name, idNumber, citizenshipStatus);
            txtProfile.Text = "==== DIGITAL CITIZEN SUMMARY ====\r\n" +
                                $"Name: {profile.FullName}\r\n" +
                                $"ID Number: {profile.IDNumber}\r\n" +
                                $"Age: {profile.Age}\r\n" +
                                $"Citizenship: {profile.CitizenshipStatus}\r\n" +
                                $"Validation: {profile.ValidateID()}\r\n" +
                                "Processed at: Home Affairs Digital Desk\r\n" +
                                $"Timestamp: {DateTime.Now:yyyy/MM/dd HH:mm:ss}";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}