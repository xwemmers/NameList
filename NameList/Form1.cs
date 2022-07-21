namespace NameList
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Hallo " + txtFirstname.Text);

            lbxNames.Items.Add($"{txtFirstname.Text} uit {comboBox1.Text}");

            txtFirstname.Text = "";
            txtFirstname.Focus();

            UpdateLabel();
        }

        private void lblCounter_Click(object sender, EventArgs e)
        {
            lblCounter.Text = "Hee hoi!";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Deze functie wordt automatisch uitgevoerd als
            // de applicatie opstart

            UpdateLabel();
        }

        private void btnVerwijder_Click(object sender, EventArgs e)
        {
            int index = lbxNames.SelectedIndex;

            if (index == -1)
                MessageBox.Show("Selecteer eerst een student");
            else
                lbxNames.Items.RemoveAt(index);

            UpdateLabel();
        }

        void UpdateLabel()
        {
            if (lbxNames.Items.Count == 1)
                lblCounter.Text = $"Er is {lbxNames.Items.Count} student.";
            else
                lblCounter.Text = $"Er zijn {lbxNames.Items.Count} studenten.";

            // Maximaal 5 namen in de lijst
            if (lbxNames.Items.Count >= 5)
                btnToevoegen.Enabled = false;
            else
                btnToevoegen.Enabled = true;
        }



        // Todo

        // overbodige functies weg (designer)
        // naam van de buttons etc

        // max aantal studenten

        // tabindex
        // release/publish

    }
}
