using System;
using System.Collections.Generic;
using System.IO;

namespace PricePublisher
{
    public class PriceEventReader
    {
        private string _csvFileName;

        public PriceEventReader(string csvFileName)
        {
            _csvFileName = csvFileName;
        }

        public List<PriceEvent> GetAllPriceEvents()
        {
            var priceEvents = new List<PriceEvent>();
            bool headerLine = true;
            using (var reader = new StreamReader(_csvFileName))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    if (headerLine) 
                    {
                        headerLine = false;
                        continue;
                    }

                    var priceEvent = BuildPriceEvent(line);
                    priceEvents.Add(priceEvent);
                }
            }

            return priceEvents;
        }

        private PriceEvent BuildPriceEvent(string line)
        {
            var values = line.Split(',');

            var date = DateTime.Parse(values[0]);
            var open = decimal.Parse(values[1]);
            var high = decimal.Parse(values[2]);
            var low = decimal.Parse(values[3]);
            var adjClose = decimal.Parse(values[4]);
            var volume = decimal.Parse(values[5]);

            return new PriceEvent(date, open, high, low, adjClose, volume);
        }
    }
}
