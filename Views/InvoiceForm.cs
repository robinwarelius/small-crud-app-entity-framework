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
    public partial class InvoiceForm : Form
    {
        UsefulManager manager;
        
        public InvoiceForm()
        {
            InitializeComponent();
            manager = new UsefulManager();
            ShowAllInvoice();
            dateLabel2.Text = DateTime.Now.ToShortDateString();

        }

        private void ShowAllInvoice()
        {
            var result = manager.GetAllInvoice().Where(x => x.Hanterad.ToLower() == "nej");
            invoiceGrid.Rows.Clear();
            foreach (var i in result)
            {
                invoiceGrid.Rows.Add(
                    i.FakturaID,
                    i.Belopp,
                    i.Hanterad,
                    i.BokningID,
                    i.Bokning1.BokningDatum
                    );
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            ShowAllInvoice();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {                       
                manager.DeleteInvoiceBooking();                     
        }

        private void payButton_Click(object sender, EventArgs e)
        {
            int invoiceID = int.Parse(invoiceGrid.SelectedRows[0].Cells[0].Value.ToString());

            Faktura invoice = new Faktura();
            invoice.FakturaID = invoiceID;
            invoice.Belopp = int.Parse(invoiceGrid.SelectedRows[0].Cells[1].Value.ToString());
            invoice.Hanterad = "Ja";
            invoice.BokningID = int.Parse(invoiceGrid.SelectedRows[0].Cells[3].Value.ToString());
            manager.UpdateInvoice(invoice);

        }
    }
}
