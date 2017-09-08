using System;
using Klarna.Entities;
using Klarna.Settlements.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Klarna.Settlements.Test
{
    [TestClass]
    public class TransactionTest
    {
        [TestMethod]
        public void MustBeAbleToGetTransactionsOnRef()
        {
            var config = new MerchantConfig("K500746", "fia'w2ahSheahahc", Server.Playground);

            TransactionRequest req = new TransactionRequest()
            {
                PaymentReference = "FYCK",
                Offset = 0,
                Size = 10
            };
            var payoutsGetter = new Transactions();
            var listOfPayouts = payoutsGetter.GetTransactions(req, config);
            Assert.IsNotNull(listOfPayouts);
        }
        [TestMethod]
        public void MustBeAbleToGetAllTransactions()
        {
            var config = new MerchantConfig("K500746", "fia'w2ahSheahahc", Server.Playground);

            TransactionRequest req = new TransactionRequest()
            {
                
                Offset = 0,
                Size = 10
            };
            var payoutsGetter = new Transactions();
            var listOfPayouts = payoutsGetter.GetTransactions(req, config);
            Assert.IsNotNull(listOfPayouts);
        }
    }
}
