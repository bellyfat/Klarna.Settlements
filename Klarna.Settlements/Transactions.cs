using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Klarna.Entities;
using Klarna.Settlements.Entities;
using Newtonsoft.Json;

namespace Klarna.Settlements
{
    public class Transactions
    {
        public TransactionResult GetTransactions(TransactionRequest reg, MerchantConfig config)
        {
            TransactionResult transactions;

            var reqhelper = new RequestHelper();
            var response = reqhelper.CreateRequest("GET", reg, config);
            using (var reader = new StreamReader(response.GetResponseStream()))
            {
                string result = reader.ReadToEnd(); // do something fun...
                var jsreader = new JsonTextReader(new StringReader(result));
                transactions = new JsonSerializer().Deserialize<TransactionResult>(jsreader);
            }
            return transactions;
        }
    }
}
