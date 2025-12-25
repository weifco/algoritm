using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace лиман
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Разветвляющийся_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
        
            // получаем значения X и Y
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);

            // вычисляем результат
            double result;
            if (x * y < 5)
            {
                result = Math.Pow(f(x), 3) + Math.Sin(y);
            }
            else if (x * y > 7)
            {
                result = Math.Cosh(Math.Pow(f(x), 3)) + Math.Pow(y, 2);
            }
            else
            {
                result = Math.Cos(x + Math.Pow(f(x), 3));
            }

            // выводим результат и подсвечиваем его красным цветом
            txtResult.Text = $"Результат: {result}";
            txtResult.ForeColor = Color.Red;
        }

        // функция f(x)
        private double f(double x)
        {
            return x; // Здесь можно задать любую функцию f(x)
        }

        }

        private void buttonCalculateClick_Click(object sender, EventArgs e)
        {
        {

            // получаем значения X, Y, Z из текстовых полей
            double x = Convert.ToDouble(textBoxX.Text);
            double y = Convert.ToDouble(textBoxY.Text);
            double z = Convert.ToDouble(textBoxZ.Text);

            // вычисляем результат по формуле
            double result = Math.Pow(x, 2) * Math.Cos(x - y / z) / (0.5 + Math.Sin(y)) * (1 + Math.Pow(z, 2) / 5);

            // выводим результат в текстовое поле
            txtResult.Text = result.ToString();
        }
        }

        private void checkBoxRed_CheckedChanged(object sender, EventArgs e)
        {
            // 7. Если чекбокс отмечен — красный цвет
            if (cRedColor.Checked)
                txtResult.ForeColor = Color.Red;
            else
                txtResult.ForeColor = Color.Black;
        }
    }
}
    
    

