using HiltonDeluxe.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HiltonDeluxe.Repository
{
    public class CustomerRepo
    {

        HiltonDeluxeEntities8 _dbConnection;

        public CustomerRepo()
        {
            _dbConnection = new HiltonDeluxeEntities8();
        }

        public Kund GetOneCustomer(int kundID)
        {
            Kund kund = _dbConnection.Kund.Where(x => x.KundID == kundID).FirstOrDefault();
            return kund;
        }

        public List<Kund> GetAllCustomer()
        {
            return _dbConnection
                    .Kund
                    .AsNoTracking()
                    .ToList();          
        }

        public void AddCustomer(Kund kund)
        {
            _dbConnection.Kund.Add(kund);
            _dbConnection.SaveChanges();
        }

        public void UpdateCustomer(Kund kund)
        {
            Kund oldKund = _dbConnection.Kund.Where(x => x.KundID == kund.KundID).SingleOrDefault();
            _dbConnection.Entry(oldKund).CurrentValues.SetValues(kund);
            _dbConnection.SaveChanges();
        }

        public void DeleteCustomer(int kundID)
        {
            Kund kund = _dbConnection.Kund.Where(x => x.KundID == kundID).SingleOrDefault();
            _dbConnection.Kund.Remove(kund);
            _dbConnection.SaveChanges();
        }

    }
}
