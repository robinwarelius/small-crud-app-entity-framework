using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiltonDeluxe.Models;
using HiltonDeluxe.Repository;
using HiltonDeluxe.Views;

namespace HiltonDeluxe.Views
{
    public partial class CustomerForm : Form
    {
        UsefulManager manager;

        public CustomerForm()
        {
            InitializeComponent();
            manager = new UsefulManager();
            ShowAllCustomers();           
        }
        private void updateButton_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text != "" && lastNameText.Text != "" && emailText.Text != "")
            {
                int kundID = int.Parse(customerGrid.SelectedRows[0].Cells[0].Value.ToString());
                Kund kund = new Kund();
                kund.KundID = kundID;
                kund.ForNamn = firstNameText.Text;
                kund.EfterNamn = lastNameText.Text;
                kund.Email = emailText.Text;
                manager.UpdateCustomer(kund);
                MessageBox.Show("Kunden är nu uppdaterad.");
            }
            else
            {
                MessageBox.Show("Mata in alla värden.");
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (firstNameText.Text != "" && lastNameText.Text != "" && emailText.Text != "")
            {
                Kund kund = new Kund();
                kund.ForNamn = firstNameText.Text;
                kund.EfterNamn = lastNameText.Text;
                kund.Email = emailText.Text;
                manager.AddCustomer(kund);
                MessageBox.Show("Kunden finns nu i systemet.");
            }
            else
            {
                MessageBox.Show("Mata in alla värden.");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int kundID = int.Parse(customerGrid.SelectedRows[0].Cells[0].Value.ToString());
            manager.DeleteCustomer(kundID);
        }

        private void updateListButton_Click(object sender, EventArgs e)
        {
            ShowAllCustomers();
        }
        private void ShowAllCustomers()
        {           
            var result = manager.GetAllCustomer(); 

            foreach (var i in result)
            {              
                customerGrid.Rows.Add(
                    i.KundID,
                    i.ForNamn,
                    i.EfterNamn,
                    i.Email
                    );
                
            }                            
        }

        private void showAmountButton_Click(object sender, EventArgs e)
        {
            int kundID = int.Parse(customerGrid.SelectedRows[0].Cells[0].Value.ToString());
            amountLabel2.Text = manager.CountAmountBooking(kundID).ToString();
        }

        private void customerGrid_SelectedIndexChanged(object sender, EventArgs e)
        {        
                int kundID = int.Parse(customerGrid.SelectedRows[0].Cells[0].Value.ToString());
                Kund kund = manager.GetOneCustomer(kundID);
                firstNameText.Text = kund.ForNamn;
                lastNameText.Text = kund.EfterNamn;
                emailText.Text = kund.Email;                 
        }
        private void customerGrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void firstnameLabel_Click(object sender, EventArgs e)
        {

        }

    }
}
