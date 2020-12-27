using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp03
{
    public partial class MainForm : Form
    {
        private TrueFalse database;


        public MainForm()
        {
            InitializeComponent();
        }

        //Открываем базу
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(openFileDialog.FileName);
                database.Load();
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = database.Count;
                numericUpDown1.Value = 1;

                if(database.Count != 0)
                {
                    textBox1.Text = database[0].Text;
                    checkBox1.Checked = database[0].TrueFalse;
                }
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void выйтиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }


        //Создание нового файла
        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                database = new TrueFalse(saveFileDialog.FileName);
                database.Add("123", true);
                database.Save();
                numericUpDown1.Minimum = 1;
                numericUpDown1.Maximum = 1;
                numericUpDown1.Value = 1;
            }
        }

        //Сохраняем  изменения
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            database[(int)numericUpDown1.Value - 1].Text = textBox1.Text;
            database[(int)numericUpDown1.Value - 1].TrueFalse = checkBox1.Checked;
        }

        //Пролистывание базы
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = database[(int)numericUpDown1.Value - 1].Text;
            checkBox1.Checked = database[(int)numericUpDown1.Value - 1].TrueFalse;
        }

        //Добавляем запись
        private void AddButton_Click(object sender, EventArgs e)
        {
            if(database == null)
            {
                MessageBox.Show("Создайте новую базу данных", "Ошибка");
                return;
            }

            database.Add((database.Count) + 1.ToString(), true);
            numericUpDown1.Maximum = database.Count;
            numericUpDown1.Value = database.Count;
        }

        //Удаляем запись
        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (database == null || numericUpDown1.Maximum == 1)
                return;

            database.Remove((int)numericUpDown1.Value);
            numericUpDown1.Maximum--;

            if(numericUpDown1.Value > 1)
            {
                //numericUpDown1.Value = numericUpDown1.Value - 1;
            }

        }

        //Сохраняем в файл
        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(database != null)
            {
                database.Save();
            }
            else
            {
                MessageBox.Show("База данных не создана.", "Ошибка");
            }
        }
    }
}
