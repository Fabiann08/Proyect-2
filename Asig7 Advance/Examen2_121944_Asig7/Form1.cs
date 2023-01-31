namespace Examen2_121944_Asig7
{
    public partial class Form1 : Form
    {
        double farenheit, kelvin, celcius;
        double constantForKelvin = 273.15;
        public Form1()
        {
            InitializeComponent();
        }

        private void IntputTemperatureTextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ToKelvinRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            farenheit = double.Parse(IntputTemperatureTextBox.Text);
            celcius = (farenheit - 32.0) * (5.0 / 9.0);
            kelvin = celcius + constantForKelvin;
        }

        private void AnimalComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked != true)
            {
                if (AnimalComboBox.SelectedIndex == 1)
                {
                    AnimalPictureBox.Image = Properties.Resources.Pig;
                }
                if (AnimalComboBox.SelectedIndex == 2) 
                {
                    AnimalPictureBox.Image = Properties.Resources.Bird;
                }

                if (AnimalComboBox.SelectedIndex == 3)
                {
                    AnimalPictureBox.Image = Properties.Resources.HedgeHog;
                }

                if (AnimalComboBox.SelectedIndex == 4)
                {
                    AnimalPictureBox.Image = Properties.Resources.Crocodile;
                }

                if (AnimalComboBox.SelectedIndex == 5)
                {
                    AnimalPictureBox.Image = Properties.Resources.Dog;
                }
                
                if (AnimalComboBox.SelectedIndex == 6)
                {
                    AnimalPictureBox.Image = Properties.Resources.Cat;
                }
                
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Exception(object sender, EventArgs e)
        {
            try
            {

                double n = Double.Parse(IntputTemperatureTextBox.Text);

            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ToCelciusRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            farenheit = double.Parse(IntputTemperatureTextBox.Text);
            celcius = (farenheit - 32.0) * (5.0 / 9.0);
        }

        private void ShowResultButton_Click(object sender, EventArgs e)
        {
            if (ToKelvinRadioButton.Checked)
                ResultLabel.Text = "Result in Kelvin: " + kelvin.ToString("0.0000");
            if(ToCelciusRadioButton.Checked)
                ResultLabel.Text = "Result in Celcius: " + celcius.ToString("0.0000");
        }

    }
}
