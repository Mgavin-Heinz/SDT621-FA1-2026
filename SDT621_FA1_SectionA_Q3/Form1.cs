using System.Runtime.InteropServices;

namespace SDT621_FA1_SectionA_Q3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLanguage.Text == "")
            {
                MessageBox.Show("Please enter a language.");
                return;
            }

            if (lstLanguages.Items.Contains(txtLanguage.Text))
            {
                MessageBox.Show("This language already exists in the list.");
                return;
            }

            lstLanguages.Items.Add(txtLanguage.Text);
            lblStatus.Text = $"Added: {txtLanguage.Text} at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
            txtLanguage.Clear();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (lstLanguages.SelectedItem == null)
            {
                MessageBox.Show("Please Select an item to remove first");
                return;
            }

            string language = lstLanguages.SelectedItem.ToString();
            lstLanguages.Items.Remove(lstLanguages.SelectedItem);
            lblStatus.Text = $"Removed: {language} at {DateTime.Now:dd MMM yyyy HH:mm:ss}";
        }

    }
}
