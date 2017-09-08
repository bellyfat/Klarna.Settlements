using System.Collections.Generic;
using System.IO;
using Klarna.Entities;
using Newtonsoft.Json;
using Payout = Klarna.Settlements.Entities.Payout;
using PayoutRequest = Klarna.Settlements.Entities.PayoutRequest;
using PayoutResult = Klarna.Settlements.Entities.PayoutResult;

namespace Klarna.Settlements
{
    public class Payouts
    {
        public PayoutResult GetPayouts(PayoutRequest request,MerchantConfig config)
        {
            PayoutResult payouts;
           
            var reqhelper = new RequestHelper();
          var response =   reqhelper.CreateRequest("GET",request, config);
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd(); // do something fun...
                var jsreader = new JsonTextReader(new StringReader(result));
                payouts = new JsonSerializer().Deserialize<PayoutResult>(jsreader);
            }
            return payouts;

        }

        public Payout GetSinglePayout(string paymentRef, MerchantConfig config)
        {
            Payout payouts;

            var reqhelper = new RequestHelper();
            var response = reqhelper.CreateSinglePayoutRequest("GET", paymentRef, config);
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd(); // do something fun...
                var jsreader = new JsonTextReader(new StringReader(result));
                payouts = new JsonSerializer().Deserialize<Payout>(jsreader);
            }
            return payouts;
        }
    }
}