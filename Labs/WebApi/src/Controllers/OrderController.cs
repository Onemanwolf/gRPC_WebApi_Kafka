using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Grpc.Net.Client;
using Newtonsoft.Json;
using ApiGateway.Models;

namespace ApiGateway.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class OrderController : ControllerBase
    {


        private readonly ILogger<OrderController> _logger;

        public OrderController(ILogger<OrderController> logger)
        {
            _logger = logger;
        }

        [HttpPost]
        public async Task<ActionResult> Create( object order)
        {
            /// calls Grpc Service to create order
            ///
            ///
        var orderRequest = JsonConvert.DeserializeObject<OrderRequest>(order.ToString());




         using var channel = GrpcChannel.ForAddress("https://localhost:5001");
         var client = new orderPackage.orderPackageClient(channel);


        var orders = new Order();
        orders.OrderId = orderRequest.OrderId;
        orders.CustomerId = orderRequest.CustomerId;
        orders.PaymentId = orderRequest.PaymentId;
        foreach(var item in orderRequest.orderItems)
        {
          orders.OrderItems.Add(item.ToString());
        }
        //orders.OrderItems.Add(new [] {"{productId = 1, price = 3.44}","{productId = 2, price = 5.44}"});
        orders.Total = orderRequest.Total;


        var reply = await client.CreateOrderAsync(
                              orders);
          //  Console.WriteLine("Order response: " + reply.Message);
          await Task.Run(() => {Console.WriteLine($"Order Created: {order}");});
           return Ok(reply.Message);
        }
    }
}
