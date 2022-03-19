using PrzykladowaAplikacja.Models;

namespace PrzykladowaAplikacja
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            studenciListBox.ValueMember = "ImieINazwisko";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("To jest jakies info");
        }

        private void ImieTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           //OR ||
           //AND &&
            if(string.IsNullOrWhiteSpace(ImieTextBox.Text))
            {
                MessageBox.Show("Imiê nie mo¿e byæ puste");
                return;
            }
            if (string.IsNullOrWhiteSpace(NazwiskoTextBox.Text))
            {
                MessageBox.Show("Nazwisko nie mo¿e byæ puste");
                return;
            }

            Student nowyStudent = new Student();
            nowyStudent.Imie = ImieTextBox.Text;
            nowyStudent.Nazwisko = NazwiskoTextBox.Text;


            studenciListBox.Items.Add(nowyStudent);

            ImieTextBox.Text = "";
            NazwiskoTextBox.Text = "";
        }
    }
}