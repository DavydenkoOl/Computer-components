using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Компьютерные_состовляющие
{
    public partial class Form2 : Form
    {
        Tovar tovar;
        bool isEdit;
       
        public Form2(Tovar tovar, bool isEdit)
        {
            InitializeComponent();
            this.tovar = tovar;
            this.isEdit = isEdit;
            if (isEdit == true)
            {
                this.Text = "Редактировать";
                textBox1.Text = tovar.Name;
                textBox2.Text = tovar.Izgotovitel;
                textBox3.Text = tovar.Opisanie;
                textBox4.Text = tovar.Price.ToString();
            }
            else
            {
                this.Text = "Добавить";
            }
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "" || textBox2.Text == "" || textBox3.Text == ""||textBox4.Text=="")
            {
                MessageBox.Show("Не все поля были заполнены!");
                return;
            }

            if (tovar == null)
            {
                tovar = new Tovar();
            }
            tovar.Name = textBox1.Text;
            tovar.Izgotovitel = textBox2.Text;
            tovar.Opisanie = textBox3.Text;
            if (Double.TryParse(textBox4.Text, out double tmp) && tmp > 0)
            {
                tovar.Price = tmp;
                
            }
            else
            {
                MessageBox.Show("Введите значение больше 0!");
                textBox4.Clear();
                textBox4.Select();
            }
            listBox1.Items.Add(textBox1.Text);
            listBox1.Items.Add(textBox2.Text);
            listBox1.Items.Add(textBox3.Text);
           
            //this.DialogResult = DialogResult.OK;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            
        }
    }
}
