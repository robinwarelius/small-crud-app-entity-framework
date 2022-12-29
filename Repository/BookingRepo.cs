using HiltonDeluxe.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations.Model;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiltonDeluxe.Repository
{
    public class BookingRepo
    {
        HiltonDeluxeEntities8 _dbConnection;
        public BookingRepo()
        {
            _dbConnection = new HiltonDeluxeEntities8();
        }

        public List<Bokning> GetAllBooking()
        {
            return _dbConnection
                .Bokning
                .Include("Kund")
                .Include("Rum")               
                .AsNoTracking()
                .ToList();
        }

        public void AddBooking(Bokning bokning)
        {
            _dbConnection.Bokning.Add(bokning);
            _dbConnection.SaveChanges();
        }

        public void DeleteInvoiceBooking(int bookingID)
        {
            Bokning delete = _dbConnection.Bokning.Where(x => x.BokningID == bookingID).SingleOrDefault();
            _dbConnection.Bokning.Remove(delete);
            _dbConnection.SaveChanges();
        }

        public void DeleteBoking(int bookingID)
        {
            Bokning delete = _dbConnection.Bokning.Where(x => x.BokningID == bookingID).SingleOrDefault();
            _dbConnection.Bokning.Remove(delete);
            _dbConnection.SaveChanges();

        }
        public void UpdateBooking(Bokning boking)
        {
            Bokning oldBoking = _dbConnection.Bokning.Where(x => x.BokningID == boking.BokningID).SingleOrDefault();
            _dbConnection.Entry(oldBoking).CurrentValues.SetValues(boking);
            _dbConnection.SaveChanges();
                   
        }
        public List<Rum> GetAllRoom()
        {
            return _dbConnection
                .Rum
                .Include("RumTyp")
                .AsNoTracking()
                .ToList();
        }

        public List<Faktura> GetAllInvoice()
        {
            return _dbConnection
                .Faktura
                .Include("Bokning")
                .AsNoTracking()
                .ToList();
        }

        public Faktura GetOneInvoice(int bookingID)
        {
            Faktura invoice = _dbConnection.Faktura.Where(x => x.BokningID == bookingID).SingleOrDefault();
            return invoice;
        }

        public void AddInvoice(Faktura faktura)
        {
            _dbConnection.Faktura.Add(faktura);
            _dbConnection.SaveChanges();
        }

        public void DeleteInvoice(Faktura invoice)
        {
            _dbConnection.Faktura.Remove(invoice);
            _dbConnection.SaveChanges();
        }

        public void DeleteInvoice (int invoiceID)
        {
            Faktura invoice = _dbConnection.Faktura.Where(x => x.BokningID == invoiceID).SingleOrDefault();
            _dbConnection.Faktura.Remove(invoice);
            _dbConnection.SaveChanges();
        }

        public void UpdateInvoice (Faktura invoice)
        {
            Faktura oldInvoice = _dbConnection.Faktura.Where(x => x.FakturaID == invoice.FakturaID).SingleOrDefault();
            _dbConnection.Entry(oldInvoice).CurrentValues.SetValues(invoice);
            _dbConnection.SaveChanges();
        }

    }
}
