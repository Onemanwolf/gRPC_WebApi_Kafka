using Confluent.Kafka;
using System;
using System.Net;

namespace GrpcOrder.Service.Infrastructure
{
    public class MessageService
    {


        public static int _numProduced = 0;

        public void SendOrderCreatedEvent(string order)
        {
            var topic = "orders";

            var config = new ProducerConfig
            {
                BootstrapServers = "localhost:9092",
                ClientId = Dns.GetHostName(),

            };
            Produce(topic, config, order);
           
            Console.WriteLine(order);

        }

        public static void Produce(string topic, ClientConfig config, string order)
        {
            using (var producer = new ProducerBuilder<string, string>(config).Build())
            {
                
                
                    var key = $"order-messagenum-{_numProduced}";
                   

                    Console.WriteLine($"Producing record: {key} {order}");

                    producer.Produce(topic, new Message<string, string> { Key = key, Value = order },
                        (deliveryReport) =>
                        {
                            if (deliveryReport.Error.Code != ErrorCode.NoError)
                            {
                                Console.WriteLine($"Failed to deliver message: {deliveryReport.Error.Reason}");
                            }
                            else
                            {
                                Console.WriteLine($"Produced message to: {deliveryReport.TopicPartitionOffset}");
                                _numProduced += 1;
                            }
                        });
               

                producer.Flush(TimeSpan.FromSeconds(10));

                Console.WriteLine($"{_numProduced} messages were produced to topic {topic}");
            }
        }



    }
}
