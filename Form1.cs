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
    public partial class Form1 : Form
    {
        double summ ;
        Tovar tovar;
        List<Tovar> tovarList = new List<Tovar>();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            tovar = new Tovar();
           
            Form2 f2 = new Form2(tovar, false);
            if (f2.ShowDialog() == DialogResult.OK)

            {
                if (comboBox1.Items.Contains(tovar.Name))
                {
                    MessageBox.Show("Товар с таким названием существует!");
                    return;
                }
                comboBox1.Items.Add(tovar.Name);
                tovarList.Add(tovar);
                MessageBox.Show("Товар добавлен!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {

                MessageBox.Show("Товар не выбран!");
                return;
            }
            for (int i = 0; i < tovarList.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString()==(tovarList[i].Name) )
                {
                    textBox1.Text = tovarList[i].Price.ToString();
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            for (int i = 0; i < tovarList.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == (tovarList[i].Name))
                {
                    listBox1.Items.Add(tovarList[i].Name);
                    summ += tovarList[i].Price;
                    textBox2.Text = summ.ToString();

                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Товар не выбран!");

                return;
            }

            for (int i = 0; i < tovarList.Count; i++)
            {
                if (comboBox1.SelectedItem.ToString() == (tovarList[i].Name))
                {
                    int pos = i; 
                    tovar = tovarList[i];
                    Form2 f2 = new Form2(tovar, true);
                    if (f2.ShowDialog() == DialogResult.OK)
                    {
                        tovarList.RemoveAt(pos);
                        tovarList.Insert(pos, tovar);
                        comboBox1.Items.RemoveAt(pos);
                        comboBox1.Items.Insert(pos,tovar.Name);
                    }

                }
            }
            


           

            

            
        }
    }
}
