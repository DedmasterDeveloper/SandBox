using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp01
{
    public partial class DefaultForm : Form
    {
        public DefaultForm()
        {
            InitializeComponent();


            textBox1.Text = "ABC";
            counterUserControl1.SomeEvent += counterUserControl1_SomeEvent;
            counterUserControl1.CounterEvent += CounterUserControl1_CounterEvent;
        }

        private void CounterUserControl1_CounterEvent(object sender, CounterEventArgs e)
        {
            MessageBox.Show($"Вы несколько раз нажали кнопку, счётчик равен {e.Counter}");
        }

        private void counterUserControl1_SomeEvent (object sender, EventArgs e)
        {
            
        }

        private void DefaultForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = "Hello";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = int.TryParse(textBox1.Text, out int i);
            if(res)
            {
                MessageBox.Show($"Вы ввели число: {i}", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show($"Некорректное число", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
