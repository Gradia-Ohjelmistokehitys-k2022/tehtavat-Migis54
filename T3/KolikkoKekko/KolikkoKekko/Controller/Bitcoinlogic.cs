using KolikkoKekko.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace KolikkoKekko.Controller
{
    public class Bitcoinlogic:INotifyPropertyChanged
    {
        readonly Bitcoinprice Bitcoinprice;

        public double? minVolume;
        public double? MinVolume
        {
            get => minVolume;
            set
            {
                minVolume = value;
                OnPropertyChanged(nameof(MinVolume));
            }
        }

        public double? maxVolume;
        public double? MaxVolume
        {
            get => maxVolume;
            set
            {
                maxVolume = value;
                OnPropertyChanged(nameof(MaxVolume));
            }
        }

        public double? minPrice;
        public double? MinPrice
        {
            get => minPrice;
            set
            {
                minPrice = value;
                OnPropertyChanged(nameof(MinPrice));
                
            }
        }
        public double? maxPrice;
        public double? MaxPrice
        {
            get => maxPrice;
            set
            {
                maxPrice = value;
                OnPropertyChanged(nameof(MaxPrice));

            }
        }
        public string? bullishStart;
        public string? BullishStart
        {
            get => bullishStart;
            set
            {
                bullishStart = value;
                OnPropertyChanged(nameof(BullishStart));
            }
        }

        private string? bullishEnd;
        public string? BullishEnd
        {
            get => bullishEnd;
            set
            {
                bullishEnd = value;
                OnPropertyChanged(nameof(BullishEnd));
            }
        }
        private string? bearishStart;
        public string? BearishStart
        {
            get => bearishStart;
            set
            {
                bearishStart = value;
                OnPropertyChanged(nameof(BearishStart));
            }
        }

        private string? bearishEnd;
        public string? BearishEnd
        {
            get => bearishEnd;
            set
            {
                bearishEnd = value;
                OnPropertyChanged(nameof(BearishEnd));
            }
        }
        private string? bestBuyDate;
        public string? BestBuyDate
        {
            get => bestBuyDate;
            set
            {
                bestBuyDate = value;
                OnPropertyChanged(nameof(BestBuyDate));
            }
        }

        private string? bestSellDate;
        public string? BestSellDate
        {
            get => bestSellDate;
            set
            {
                bestSellDate = value;
                OnPropertyChanged(nameof(BestSellDate));
            }
        }
        public event PropertyChangedEventHandler? PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public Bitcoinlogic()
        {
            Bitcoinprice = new Bitcoinprice();
            Bitcoinprice.OnDataFetched += OnBitcoinDataFetch;
        }
        public async Task FetchBitcoinDataAsync(DateTime StartDate, DateTime EndDate)
        {
            if (StartDate != null && EndDate != null)
            {
                await Bitcoinprice.FetchBitcoinDataAsync(StartDate, EndDate);
            }
        }
        private (int length, DateTime? start, DateTime? end) CalculateTrendLenght(List<Tuple<DateTime, double>> bitcoinPrices, bool isBullish)
        {
            if (bitcoinPrices == null || bitcoinPrices.Count < 2) return (0, null, null);
            int longestTrend = 0;
            int currentTrend = 0;
            DateTime? currentStart = null;
            DateTime? longestStart = null;
            DateTime? longestEnd = null;
            for (int i = 1; i < bitcoinPrices.Count; i++)
            {
                if ((isBullish && bitcoinPrices[i].Item2 > bitcoinPrices[i - 1].Item2) || (!isBullish && bitcoinPrices[i].Item2 < bitcoinPrices[i - 1].Item2))
                {
                    currentTrend++;
                    if (currentStart == null)
                    {
                        currentStart = bitcoinPrices[i - 1].Item1;
                    }
                }
                else
                {
                    if (currentTrend > longestTrend)
                    {
                        longestTrend = currentTrend;
                        longestStart = currentStart;
                        longestEnd = bitcoinPrices[i - 1].Item1;
                    }
                    currentTrend = 0;
                    currentStart = null;
                }
            }
            if (currentTrend > longestTrend)
            {
                longestTrend = currentTrend;
                longestStart = currentStart;
                longestEnd = bitcoinPrices[^1].Item1;
            }
            return (longestTrend, longestStart, longestEnd);
        }


        private Tuple<DateTime?, DateTime?> FindBestBuySellDays(List<Tuple<DateTime, double>> bitcoinPrices)
        {
            if (bitcoinPrices == null || bitcoinPrices.Count < 2) return Tuple.Create<DateTime?, DateTime?>(null, null);
            double minPrice = double.MaxValue;
            double maxProfit = 0;
            DateTime? buyDate = null;
            DateTime? sellDate = null;
            foreach (var bitcoinData in bitcoinPrices)
            {
                if (bitcoinData.Item2 < minPrice)
                {
                    minPrice = bitcoinData.Item2;
                    buyDate = bitcoinData.Item1;
                }
                double profit = bitcoinData.Item2 - minPrice;
                if (profit > maxProfit)
                {
                    maxProfit = profit;
                    sellDate = bitcoinData.Item1;
                }
            }
            return Tuple.Create(buyDate, sellDate);
        }
        public event Action<List<Tuple<DateTime, double>>> OnPriceDataUpdated;
        public void OnBitcoinDataFetch(List<Tuple<DateTime, double>> bitcoinPrices, List<Tuple<DateTime, double>> bitcoinVolumes)
        {
            OnPriceDataUpdated?.Invoke(bitcoinPrices);

            var minPrice = bitcoinPrices.MinBy(x => x.Item2);
            var maxPrice = bitcoinPrices.MaxBy(x => x.Item2);
            MaxPrice = maxPrice?.Item2;
            MinPrice = minPrice?.Item2;

            var minVolume = bitcoinVolumes.MinBy(x => x.Item2);
            var maxVolume = bitcoinVolumes.MaxBy(x => x.Item2);
            MaxVolume = maxVolume?.Item2;
            MinVolume = minVolume?.Item2;

            var bullishTrend = CalculateTrendLenght(bitcoinPrices, true);
            var bearishTrend = CalculateTrendLenght(bitcoinPrices, false);

            BullishStart = bullishTrend.start?.ToString("dd/MM/yyyy hh:mm");
            BullishEnd = bullishTrend.end?.ToString("dd/MM/yyyy hh:mm");
            BearishStart = bearishTrend.start?.ToString("dd/MM/yyyy hh:mm");
            BearishEnd = bearishTrend.end?.ToString("dd/MM/yyyy hh:mm");

            var bestBuySell = FindBestBuySellDays(bitcoinPrices);
            BestBuyDate = bestBuySell.Item1?.ToString("dd/MM/yyyy hh:mm");
            BestSellDate = bestBuySell.Item2?.ToString("dd/MM/yyyy hh:mm");
        }
    }
}
