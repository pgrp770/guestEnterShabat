using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using guestEnterShabat.FormHendlrer;
using guestEnterShabat.Models;
using guestEnterShabat.Repositories;

namespace guestEnterShabat.View
{
    public partial class LoginForm : Form
    {
       
        private GuestReposetory gr;
        private CategoryRepository cr;
        public LoginForm()
        {
            InitializeComponent();
            gr = new GuestReposetory();
            cr = new CategoryRepository();
            RefreshList(listBox1);
        }

        private List<string> ConvertGuestListToString(List<Guests> oldList)
        {
            List<string> newList = new List<string>();
            foreach (Guests guest in oldList)
            {
                newList.Add(guest.Name.ToString());
            }
            return newList;
        }
        private void RefreshList(ListBox lb)
        {
            lb.SelectedIndexChanged -= listBox1_SelectedIndexChanged;
            lb.DataSource = ConvertGuestListToString(gr.GetAll());
            lb.SelectedIndex = -1; // This optional line keeps the first item from being selected.
            lb.SelectedIndexChanged += listBox1_SelectedIndexChanged;
       
        }
        
        /* -- buttons -- */
        private void button1_Click(object sender, EventArgs e)
        {
            if (gr.isThereThisGuest(textBox1.Text))
            {
                MessageBox.Show("there is such guest");
                return;
            }
            else
            {
                gr.Create(new Guests(textBox1.Text));
                RefreshList(listBox1);
            
                FoodForm fr = new FoodForm(cr.GetAllString()[0], textBox1.Text, 1);
                fr.Show();
                this.Hide();

            }

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var i = listBox1.Items[listBox1.SelectedIndex].ToString();
            FormNavigator formNavigator = new FormNavigator(i.ToString(), 0, true);
            this.Hide();
        }
    }
}
