using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using guestEnterShabat.FormHendlrer;
using guestEnterShabat.Repositories;

namespace guestEnterShabat
{
    public partial class FoodForm : Form
    {
        FoodRepository fr;
        string Name;
        public FoodForm(string header, string name, int i)
        {

            InitializeComponent();
            Name = name;
            fr = new FoodRepository();
            label1.Text = header;
            label2.Text = i.ToString();
            dataGridView1.DataSource = fr.SelectAllGuestsFoodByCategoryAndName(label1.Text, Name);
            dataGridView2.DataSource = fr.SelectAllGuestFoodByCategoryAndName(label1.Text, Name);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!fr.SelectFoodByNameCategoryGuestName(textBox1.Text, label1.Text, Name))
            {
                fr.Createa(Name, label1.Text, textBox1.Text);
                textBox1.Text = "";
                dataGridView1.DataSource = fr.SelectAllGuestsFoodByCategoryAndName(label1.Text, Name);
                dataGridView2.DataSource = fr.SelectAllGuestFoodByCategoryAndName(label1.Text, Name);
            }
            else
            {
                MessageBox.Show("You have ordered this dish!");
                return;
            }
        }

        private void buttonNext_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNavigator fn = new FormNavigator(Name, int.Parse(label2.Text), true);
        }

        private void buttonPrev_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormNavigator fn = new FormNavigator(Name, int.Parse(label2.Text) - 1);
        }

        private void FoodForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
