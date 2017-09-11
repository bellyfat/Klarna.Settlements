using System;
using System.Collections.Generic;
using System.Net;
using System.Reflection;
using Klarna.Entities;
using Klarna.Helpers;
using System.ComponentModel;
using Klarna.Exception;
using Newtonsoft.Json;
using PayoutRequest = Klarna.Settlements.Entities.PayoutRequest;
using TransactionRequest = Klarna.Settlements.Entities.TransactionRequest;

namespace Klarna.Settlements
{
    class RequestHelper
    {
        private readonly JsonRequest _requestHelper;
        private readonly DigestCreator _digestCreator;

        public RequestHelper()
        {
            _requestHelper = new JsonRequest();
            _digestCreator = new DigestCreator();
        }

        public HttpWebResponse CreateRequest(string method, PayoutRequest request, MerchantConfig config)
        {
            var path = CreatePath(request);
            path = "payouts?" + path;
            return DoRequest(config, path, method);
        }

        public HttpWebResponse CreateRequest(string method, TransactionRequest request, MerchantConfig config)
        {
            var path = CreatePath(request);
            path = "transactions?" + path;
            return DoRequest(config, path, method);
        }

        public HttpWebResponse CreateSinglePayoutRequest(string method, string payref, MerchantConfig config)
        {
            var path = "payouts/"+ payref;
            return DoRequest(config, path, method);
        }
        private HttpWebResponse DoRequest(MerchantConfig config, string path, string method)
        {
            var digest = _digestCreator.CreateDigest(config.merchantId, config.sharedSecret);
            var apiLocation = GetApiLocation(config);
            try
            {
                return _requestHelper.CreateRequest(digest, new Uri(apiLocation + "" + path), method, useragent: "Mnording Settlement API " + Assembly.GetExecutingAssembly().GetName().Version);
            }
            catch (System.Exception e)
            {

                throw new ConnectionException("failed to connect", config, e);
            }
        }

        private Uri GetApiLocation(MerchantConfig config)
        {
            return config.Server == Server.Live ? SettlementConfig.Live : SettlementConfig.Playground;
        }
        private string ConvertObjectToString(object obj)
        {
            var result = new List<string>();
            foreach (PropertyDescriptor property in TypeDescriptor.GetProperties(obj))
            {
                if (JsonConvert.SerializeObject(property.GetValue(obj)) != "null")
                {
                    result.Add(JsonConvert.SerializeObject(property.Name) + "=" + JsonConvert.SerializeObject(property.GetValue(obj)));

                }
            }
            return string.Join("&", result);
        }


        private string CreatePath(PayoutRequest request)
        {
            var data = JsonConvert.SerializeObject(request);
            var path = CleanStringForPath(data);
            return path;
        }
        private string CreatePath(TransactionRequest request)
        {
            var data = JsonConvert.SerializeObject(request);
            var path = CleanStringForPath(data);
            return path;
        }

        private string CleanStringForPath(string s)
        {
            var path = ConvertObjectToString(JsonConvert.DeserializeObject(s));
            path = path.Replace("\"", "");
            path = path.Replace("\"", "");
            path = path.Replace("/", "");
            return path;
        }


    }
}
