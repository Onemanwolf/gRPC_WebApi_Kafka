using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ApiGateway.Models;
using Grpc.Net.Client;


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
         using var channel = GrpcChannel.ForAddress("https://localhost:5001");
         var client = new orderPackage.orderPackageClient(channel);


        var orders = new Order();
        orders.OrderId = 1;
        orders.CustomerId = 1;
        orders.PaymentId = 1;
        orders.OrderItems.Add(new [] {"{productId = 1, price = 3.44}","{productId = 2, price = 5.44}"});
        orders.Total = 0;


        var reply = await client.CreateOrderAsync(
                              orders);
          //  Console.WriteLine("Order response: " + reply.Message);
          await Task.Run(() => {Console.WriteLine($"Order Created: {order}");});
           return Ok(reply.Message);
        }
    }
}
