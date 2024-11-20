using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fullStackOops.Events
{
    public delegate void PriceChangedHandler(decimal oldPrice, decimal newPrice);
    
    public class Stock
    {
        string symbol;
        decimal price;

        public Stock(string symbol)
        { 
            this.symbol = symbol;
        }

        // Declare the event using EventHandler<T>
        public event EventHandler<PriceChangedEventArgs> PriceChanged;

        // Method to raise the event
        protected virtual void OnPriceChanged(PriceChangedEventArgs e)
        {
            PriceChanged?.Invoke(this, e);
        }

        public decimal Price
        {
            get => price;
            set
            {
                if (price == value) return; // Exit if nothing has changed
                decimal oldPrice = price;
                price = value;

                // Raise the event
                OnPriceChanged(new PriceChangedEventArgs(oldPrice, price));
            }
        }

      /*  static void Main(string[] args)
        {
            Stock stock = new Stock("MSFT");
            stock.Price = 27.10M;

            //Subscribe to the PriceChanged event
            stock.PriceChanged += Stock_PriceChanged;
            stock.Price = 31.59M;

            //Change the price to trigger the event
            //stock.Price = 120;
            //stock.Price = 135;
        }*/

        private static void Stock_PriceChanged(object sender, PriceChangedEventArgs e)
        {
            Console.WriteLine($"The price changed from {e.LastPrice} to {e.NewPrice}");
            if((e.NewPrice-e.LastPrice) / e.LastPrice > 0.1M)
                Console.WriteLine("Alert, 10% stock price increase!");
        }
    }
   
}
