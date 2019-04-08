using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace API_Usage.Models
{
    public class Company
    {
        [Key]
        public string symbol { get; set; }
        public string name { get; set; }
        public string date { get; set; }
        public bool isEnabled { get; set; }
        public string type { get; set; }
        public string iexId { get; set; }
        public List<Equity> Equities { get; set; }
    }

    public class Equity
    {
        public int EquityId { get; set; }
        public string date { get; set; }
        public float open { get; set; }
        public float high { get; set; }
        public float low { get; set; }
        public float close { get; set; }
        public int volume { get; set; }
        public int unadjustedVolume { get; set; }
        public float change { get; set; }
        public float changePercent { get; set; }
        public float vwap { get; set; }
        public string label { get; set; }
        public float changeOverTime { get; set; }
        public string symbol { get; set; }
    }

    public class ChartRoot
    {
        public Equity[] chart { get; set; }
    }
    public class News
    {
        public string datetime { get; set; }
        public string headline { get; set; }
        public string source { get; set; }
        public string url { get; set; }
        public string summary { get; set; }
        public string related { get; set; }
        public string image { get; set; }
    }
    public class Newses
    {
        public News[] newss { get; set; }
    }
    public class StockstoInvest
    {

        public string symbol { get; set; }
        public float latestPrice { get; set; }
        public float week52High { get; set; }
        public float week52Low { get; set; }
        public string decision { get; set; }

    }
}