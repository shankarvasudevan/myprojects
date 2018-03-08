using System;
using System.Collections.Generic;
using System.Text;
using Confluent.Kafka;
using Confluent.Kafka.Serialization;

namespace PricePublisher
{
    public class PricePublisher
    {
        public void Publish()
        {
            var config = new Dictionary<string, object>
            {
                { "bootstrap.servers", "localhost:9092" }
            };

            using (var producer = new Producer<Null, string>(config, null, new StringSerializer(Encoding.UTF8)))
            {
                var priceEventReader = new PriceEventReader(@"snp-price-data.csv");
                var priceEvents = priceEventReader.GetAllPriceEvents();

                foreach (var priceEvent in priceEvents)
                {
                    producer.ProduceAsync("snp-price-events", null, priceEvent.ToString());
                }
            }
        }
    }
}
