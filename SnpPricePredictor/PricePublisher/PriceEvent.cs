using System;
namespace PricePublisher
{
    public class PriceEvent
    {
        public PriceEvent(
            DateTime date, 
            decimal open, 
            decimal high, 
            decimal low, 
            decimal adjClose, 
            decimal volume)
        {
            Date = date;
            Open = open;
            High = high;
            Low = low;
            AdjClose = adjClose;
            Volume = volume;
        }

        public DateTime Date { get; }
        public decimal Open { get; }
        public decimal High { get; }
        public decimal Low { get; }
        public decimal AdjClose { get; }
        public decimal Volume { get; }

        public override string ToString()
        {
            return string.Format(
                "[SnpPriceEvent: Date={0}, Open={1}, High={2}, Low={3}, AdjClose={4}, Volume={5}]", 
                Date, 
                Open, 
                High, 
                Low, 
                AdjClose, 
                Volume);
        }
    }
}
