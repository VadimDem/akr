using System.Reflection.Metadata;
using System.Windows.Forms;
using WeatherProject.Models;

namespace WeatherProject
{
    public partial class Form1 : Form
    {
        WeatherController weatherController = new WeatherController();
        public Form1()
        {
            InitializeComponent();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            var weather = await weatherController.GetWeather(textBox.Text);
            TempLabel.Text = weather?.Main?.Temperature.ToString() + "�C";
            PressureLabel.Text = (weather?.Main?.Pressure * 0.750062)?.ToString("F2") + " ��. ��.��.";
            HumidityLabel.Text = weather?.Main?.Humidity.ToString() + "%";
            WeatherLabel.Text = weather?.Weather?.First().Description?.ToString();

            var iconCode = weather?.Weather?.First().Icon?.ToString();
            var iconUrl = $"http://openweathermap.org/img/w/{iconCode}.png";
            Icon.ImageLocation = iconUrl;

            switch (weather?.Weather?.First()?.Main)
            {
                case "Rain":
                    RecLabel.Text = "������������� ����� ����";
                    break;
                case "Snow":
                    RecLabel.Text = "������������� ������ ������ ������";
                    break;
                case "Wind":
                    RecLabel.Text = "������������� ������� ��������\n� ��������� �������� �� �������� �����������.";
                    break;
                case "Clouds":
                    RecLabel.Text = "������������� ������������� � ������������ ������.";
                    break;
                case "Clear":
                    RecLabel.Text = "������������� �������";
                    break;
            }

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult res = MessageBox.Show("�������, ��� ������ ������� ���������?", "", MessageBoxButtons.YesNo);
            if (res == DialogResult.Yes)
            {
                res = MessageBox.Show("������ ��������� ����?", "", MessageBoxButtons.YesNo);
                if (res == DialogResult.Yes)
                {
                    string txt = String.Join("\n", TempLabel.Text, PressureLabel.Text, HumidityLabel.Text, WeatherLabel.Text);
                    File.WriteAllText(Environment.CurrentDirectory + "/data.txt", txt);
                }
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
