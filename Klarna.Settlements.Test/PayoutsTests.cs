using System;
using Klarna.Entities;
using Klarna.Settlements.Entities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Klarna.Settlements.Test
{
    [TestClass]
    public class PayoutsTests
    {
        [TestMethod]
        public void MustBePossibleToGetPayouts()
        {
            var config = new MerchantConfig("K500746", "fia'w2ahSheahahc",Server.Playground);

            PayoutRequest req = new PayoutRequest
            {
                CurrencyCode = "EUR",
                EndDate =  DateTime.Now.Date.ToShortDateString(),
                StartDate = DateTime.Now.Subtract(new TimeSpan(1000,0,0,0)).ToShortDateString(),
                Offset = 0,
                Size = 10
            };
            var payoutsGetter = new Payouts();
            var listOfPayouts = payoutsGetter.GetPayouts(req,config);
            Assert.IsNotNull(listOfPayouts);
        }

        [TestMethod]
        public void MustBeAbleToFetchSinglePayout()
        {
            var config = new MerchantConfig("K500746", "fia'w2ahSheahahc", Server.Playground);
            var payoutsGetter = new Payouts();
            var payout = payoutsGetter.GetSinglePayout("FYCK", config);
            Assert.IsNotNull(payout);
        }
    }
}
