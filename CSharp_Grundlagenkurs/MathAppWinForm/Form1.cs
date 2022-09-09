using MathLibrary;

namespace MathAppWinForm
{
    public partial class Form1 : Form
    {
        private Calculator calculator;
        public Form1()
        {
            calculator = new Calculator();
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double zahl1 = double.Parse(textBox1.Text);
                double zahl2 = double.Parse(textBox2.Text);

                double result = calculator.Division(zahl1, zahl2);

                MessageBox.Show(result.ToString());
            }
            catch (TeileDurchNullException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (MathLibraryException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex) //Für Alle unbekannten Fehler, kann mit allen Arbeiten 
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            MessageBox.Show($"Neuer Text: {this.textBox3.Text}");
        }
    }
}