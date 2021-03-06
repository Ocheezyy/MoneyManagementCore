﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using EFDataAccessLibrary.DataAccess;

namespace EFDataAccessLibrary.Models
{
    public class DccuService
    {
        private readonly AppDbContext _db;

        public DccuService(AppDbContext db)
        {
            _db = db;
        }

        // Get all transactions
        public List<DccuInfo> GetAllDccu()
        {
            var DccuTransactions = _db.Dccus.ToList();
            return DccuTransactions;
        }

        // Insert Transactions
        public string CreateDccu(DccuInfo objDccu)
        {
            _db.Dccus.Add(objDccu);
            _db.SaveChanges();
            return "Saved Successfully";
        }

        //Search for transaction
        public DccuInfo GetTransactionDccu(string TxNumber)
        {
            var dccu = _db.Dccus.FirstOrDefault(s => s.Transaction_Number == TxNumber);
            return dccu;
        }

        public string UpdateTransactionDccu(DccuInfo objDccu)
        {
            _db.Dccus.Update(objDccu);
            _db.SaveChanges();
            return "Updated successfully";
        }

        public string DeleteTransactionDccu(DccuInfo objDccu)
        {
            _db.Remove(objDccu);
            _db.SaveChanges();
            return "Removed successfully";
        }
    }
}
