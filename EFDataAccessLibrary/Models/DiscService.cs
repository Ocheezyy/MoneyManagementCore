using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFDataAccessLibrary.DataAccess;

namespace EFDataAccessLibrary.Models
{
    public class DiscService
    {
        private readonly AppDbContext _db;

        public DiscService(AppDbContext db)
        {
            db = _db;
        }

        // Get all transactions
        public List<DiscInfo> GetAllDisc()
        {
            var DiscTransactions = _db.Discs.ToList();
            return DiscTransactions;
        }

        // Insert Transactions
        public string CreateDisc(DiscInfo objDisc)
        {
            _db.Discs.Add(objDisc);
            _db.SaveChanges();
            return "Saved Successfully";
        }

        //Search for transaction
        // Currently not working for Discover Database because of no primary key
        //public Disc GetTransactionDisc(int id)
        //{
        //    Disc disc;
        //    return disc;
        //}

        public string UpdateTransactionDisc(DiscInfo objDisc)
        {
            _db.Discs.Update(objDisc);
            _db.SaveChanges();
            return "Updated successfully";
        }

        public string DeleteTransactionDisc(DccuInfo objDisc)
        {
            _db.Remove(objDisc);
            _db.SaveChanges();
            return "Removed successfully";
        }
    }
}
