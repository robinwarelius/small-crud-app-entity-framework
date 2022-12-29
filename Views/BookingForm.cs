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

namespace HiltonDeluxe.Views
{
    public partial class BookingForm : Form
    {
        UsefulManager manager;
        public BookingForm()
        {
            InitializeComponent();
            manager = new UsefulManager();
            FillAmountPersonBox();
            FillAmountBedBox();
            FillCustomerBox();
        }
        private void searchButton_Click(object sender, EventArgs e)
        {
            DateTime start;
            DateTime end;
            bool valueStart = DateTime.TryParse(startDateText.Text, out start);
            bool valueEnd = DateTime.TryParse(endDateText.Text, out end);
            int value = 0;

            if (!valueStart && !valueEnd || start < DateTime.Now || end < DateTime.Now || start >= end || end <= start || amountPersonBox.SelectedItem == null)
            {
                MessageBox.Show("Mata in korrekta datum & välj antal personer.");
            }
            else
            {
                start = DateTime.Parse(startDateText.Text);
                end = DateTime.Parse(endDateText.Text);
                value = int.Parse(amountPersonBox.SelectedItem.ToString());
                FillRoomGrid(start, end, value);
            }                                      
        }

        private void FillRoomGrid(DateTime start, DateTime end, int value)
        {
            var result = manager.GetSortedRoom(start, end, value);

            if (value > 1)
            {
                amountBedBox.Visible = true;
                amountBedLabel.Visible = true;
            }
            roomGrid.Rows.Clear();
            foreach (var i in result)
            {
                roomGrid.Rows.Add(
                i.RumID,
                i.RumTyp.RumTyp1,
                i.RumNamn,
                i.Pris);
            }
        }

        private void FillAmountBedBox()
        {
            amountBedBox.Items.Add(1);
            amountBedBox.Items.Add(2);
        }
        private void FillAmountPersonBox()
        {
            for (int i = 1; i <= 6; i++)
            {
                amountPersonBox.Items.Add(i);
            }
        }

        private void bookButton_Click(object sender, EventArgs e)
        {
            if (customerBox.SelectedItem == null)
            {
                MessageBox.Show("Mata in ett kundID.");
            }
            else
            {
                string[] kundID = customerBox.SelectedItem.ToString().Split(',');
                Bokning bokning = new Bokning();
                bokning.AnkomstDatum = DateTime.Parse(startDateText.Text);
                bokning.AvreseDatum = DateTime.Parse(endDateText.Text);
                bokning.KundID = int.Parse(kundID[0]);
                bokning.RumID = int.Parse(roomGrid.SelectedRows[0].Cells[0].Value.ToString());
                bokning.BokningDatum = DateTime.Now;
                if (amountBedBox.SelectedItem != null)
                {
                    bokning.ExtraSang = int.Parse(amountBedBox.SelectedItem.ToString());
                }       
                manager.AddBoking(bokning);
                manager.AddInvoice(bokning, int.Parse(roomGrid.SelectedRows[0].Cells[3].Value.ToString()));
                MessageBox.Show("Bokningen finns nu i systemet.");
                roomGrid.Rows.Clear();            

            }                  
        }

        private void FillCustomerBox()
        {
            var customers = manager.GetAllCustomer();
            foreach (var i in customers)
            {
                customerBox.Items.Add($"{i.KundID}, {i.ForNamn} {i.EfterNamn}");
            }
        }
                      
        private void SearchForm_Load(object sender, EventArgs e)
        {

        }

        private void roomGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        
    }
}
