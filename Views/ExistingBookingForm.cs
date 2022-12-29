using HiltonDeluxe.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HiltonDeluxe.Repository;
using HiltonDeluxe.Models;

namespace HiltonDeluxe.Views
{
    public partial class ExistingBookingForm : Form
    {
        UsefulManager manager;
        public ExistingBookingForm()
        {
            InitializeComponent();
            manager = new UsefulManager();
            ShowAllInformation();        
            FillPersonBox();       
        }

        private void invoiceButton_Click(object sender, EventArgs e)
        {
            InvoiceForm frm = new InvoiceForm();
            frm.ShowDialog();
            manager.DeleteInvoiceBooking();
        }

        private void ShowAllInformation()
        {
            var result = manager.GetAllBooking();
            infoGrid.Rows.Clear();

            foreach (var i in result)
            {
                infoGrid.Rows.Add(
                    i.BokningID,
                    i.AnkomstDatum.ToShortDateString(),
                    i.AvreseDatum.ToShortDateString(),
                    i.BokningDatum,
                    i.Kund.KundID,
                    i.Kund.ForNamn,
                    i.Kund.EfterNamn,
                    i.Rum.RumNamn
                    );
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            string[] room = roomBox.SelectedItem.ToString().Split(',');
            Bokning booking = new Bokning();
            booking.BokningID = int.Parse(infoGrid.SelectedRows[0].Cells[0].Value.ToString());
            booking.AnkomstDatum = DateTime.Parse(startText.Text.ToString());
            booking.AvreseDatum = DateTime.Parse(endText.Text.ToString());
            booking.KundID = int.Parse(infoGrid.SelectedRows[0].Cells[4].Value.ToString());
            booking.RumID = int.Parse(room[0]);
            if (bedBox.SelectedItem != null)
            {
                booking.ExtraSang = int.Parse(bedBox.SelectedItem.ToString());
            }
            booking.BokningDatum = DateTime.Now;
            manager.DeleteInvoice(booking.BokningID);
            manager.AddInvoice(booking, int.Parse(room[1]));
            manager.UpdateBooking(booking);
            
            MessageBox.Show("Bokningen finns nu i systemet.");
            ShowAllInformation();
            ClearText();

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            int bookingID = int.Parse(infoGrid.SelectedRows[0].Cells[0].Value.ToString());
            manager.DeleteInvoice(bookingID);
            manager.DeleteBooking(bookingID);
            ShowAllInformation();
        }

        private void updateListButton_Click(object sender, EventArgs e)
        {
            ShowAllInformation();
        }

        private void FillBedBox(int value)
        {
            if (value > 1)
            {
                bedBox.Visible = true;
                bedLabel.Visible = true;
                bedBox.Items.Add(1);
                bedBox.Items.Add(2);
            }           
        }

        private void FillPersonBox()
        {
            for (int i = 1; i < 6; i++)
            {
                personBox.Items.Add(i.ToString());
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {         
            int value = int.Parse(personBox.SelectedItem.ToString());
            FillBedBox(value);
            var result = manager.GetSortedRoom(DateTime.Parse(startText.Text), DateTime.Parse(endText.Text), value);
            foreach (var i in result)
            {
                roomBox.Items.Add($"{i.RumID}, {i.Pris}, {i.RumNamn}");
            }
        }

        private void ClearText()
        {
            startText.Clear();
            endText.Clear();           
      
        }
    }
}
