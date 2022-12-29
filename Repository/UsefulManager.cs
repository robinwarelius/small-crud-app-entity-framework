using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HiltonDeluxe.Repository;
using HiltonDeluxe.Models;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace HiltonDeluxe.Repository
{
    public class UsefulManager
    {
        CustomerRepo _customerRepo;
        BookingRepo _bookingRepo;

        public UsefulManager()
        {
            _customerRepo = new CustomerRepo();
            _bookingRepo = new BookingRepo();
        }

        public Kund GetOneCustomer(int kundID)
        {
            Kund kund = _customerRepo.GetOneCustomer(kundID);
            return kund;
        }

        public List<Kund> GetAllCustomer()
        {
            return _customerRepo.GetAllCustomer();
        }

        public void UpdateCustomer(Kund kund)
        {
            _customerRepo.UpdateCustomer(kund);
        }

        public void AddCustomer(Kund kund)
        {
            _customerRepo.AddCustomer(kund);
        }

        public void DeleteCustomer(int kundID)
        {
            int antalBokningar = _bookingRepo.GetAllBooking().Count(x => x.KundID == kundID);
            if (antalBokningar <= 0)
            {
                _customerRepo.DeleteCustomer(kundID);
                MessageBox.Show("Kunden är nu borttagen ur systemet.");
            }
            else
            {
                MessageBox.Show("Kunden går ej ta bort då hen innehar aktuella bokningar.");
            }
        }

        public int CountAmountBooking(int kundID)
        {
            int antalBokningar = _bookingRepo.GetAllBooking().Count(x => x.KundID == kundID);
            return antalBokningar;
        }

        public List<Bokning> GetAllBooking()
        {
            return _bookingRepo.GetAllBooking();
        }

        public List<Rum> GetSortedRoom(DateTime start, DateTime end, int amoutPerson)
        {
            List<Bokning> sorteradBokning = _bookingRepo.GetAllBooking().Where(x => start >= x.AnkomstDatum && start <= x.AvreseDatum ||
            end >= x.AnkomstDatum && end <= x.AvreseDatum || start <= x.AnkomstDatum && end >= x.AvreseDatum).ToList();
            List<Rum> ledigaRum = _bookingRepo.GetAllRoom().Where(i => !sorteradBokning.Select(x => x.RumID).Contains(i.RumID)).ToList();

            if (amoutPerson > 1)
            {
                ledigaRum = ledigaRum.Where(x => x.RumNamn.Contains("Dubbel")).ToList();

            }
            return ledigaRum;
        }

        public void AddBoking(Bokning bokning)
        {
            _bookingRepo.AddBooking(bokning);
        }

        public void UpdateBooking(Bokning boking)
        {
            _bookingRepo.UpdateBooking(boking);
        }    

        public void DeleteBooking(int bookingID)
        {
            _bookingRepo.DeleteBoking(bookingID);
        }

        public void DeleteInvoiceBooking()
        {
            List<Bokning> allBooking = _bookingRepo.GetAllBooking();
            Faktura deleteInvocie = new Faktura();
            Bokning deleteBooking = new Bokning();
            DateTime today = DateTime.Now;
            DateTime bookingDay;

            foreach (var i in allBooking)
            {
                bookingDay = (DateTime)i.BokningDatum;
                TimeSpan difference = today - bookingDay;
                int amountDay = difference.Days;

                if (amountDay >= 10)
                {
                    deleteBooking.BokningID = i.BokningID;
                    deleteInvocie = _bookingRepo.GetOneInvoice(deleteBooking.BokningID);
                    _bookingRepo.DeleteInvoice(deleteInvocie);
                    _bookingRepo.DeleteInvoiceBooking(deleteBooking.BokningID);
                }
            }
        }

        public void AddInvoice(Bokning bokning, int price)
        {
            TimeSpan difference = bokning.AvreseDatum - bokning.AnkomstDatum;
            int amountDay = difference.Days;
            price = amountDay * price;
            Faktura faktura = new Faktura();
            faktura.BokningID = bokning.BokningID;
            faktura.Hanterad = "Nej";
            faktura.Belopp = price;
            _bookingRepo.AddInvoice(faktura);                   
        }
    
        public void UpdateInvoice(Faktura invoice)
        {
            _bookingRepo.UpdateInvoice(invoice);
        }

        public List <Faktura> GetAllInvoice()
        {
            return _bookingRepo.GetAllInvoice();
        } 

        public void DeleteInvoice(int invoiceID)
        {            
            _bookingRepo.DeleteInvoice(invoiceID);
        }

    }
   
}
