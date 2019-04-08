using System.Collections.Generic;

namespace API_Usage.Models
{
  public class CompaniesEquities
  {
    public List<Company> Companies { get; set; }
    public Equity Current { get; set; }
    public string Dates { get; set; }
    public string Prices { get; set; }
    public string Volumes { get; set; }
    public float AvgPrice { get; set; }
    public double AvgVolume { get; set; }

    public CompaniesEquities(List<Company> companies, Equity current,
                                      string dates, string prices, string volumes,
                                      float avgprice, double avgvolume)
    {
      Companies = companies;
      Current = current;
      Dates = dates;
      Prices = prices;
      Volumes = volumes;
      AvgPrice = avgprice;
      AvgVolume = avgvolume;
    }
  }

  public class AzureMLModel
  {
    public string Message { get; set; }
    public string JsonObject { get; set; }
  }
    public class CompaniesNews
    {
        public List<Company> Companies { get; set; }

        public News news { get; set; }

        public CompaniesNews(List<Company> companies, News newss
                                          )
        {
            Companies = companies;
            news = newss;
        }
       
    }
    public class CompaniestoInvest
    {
        public List<Company> Companies { get; set; }

        public StockstoInvest stockstoinvest{ get; set; }
        public CompaniestoInvest(List<Company> companies, StockstoInvest stocks)
        {
            Companies = companies;
            stockstoinvest = stocks;
            if (stockstoinvest.latestPrice < ((stockstoinvest.week52Low * 150) / 100))
            {
                stockstoinvest.decision = "safe to invest";
            }
            else
            {
               stockstoinvest.decision  = "not safe to invest";
            }


        }

    }
    
}