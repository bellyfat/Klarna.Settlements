using System;

namespace Klarna.Settlements
{
    public static class SettlementConfig
    {
        public static Uri Live = new Uri("https://api.klarna.com/settlements/v1/");
        public static Uri Playground = new Uri(" https://api.playground.klarna.com/settlements/v1/");
    }
}
