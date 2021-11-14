using Grpc.Core;
using GrpcOrder.Service.Infrastructure;
using GrpcOrder.Service.Protos;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;
using static GrpcOrder.Service.Protos.orderPackage;

namespace GrpcOrder.Service.Services
{
    public class OrderService : orderPackageBase
    {

        private readonly ILogger<OrderService> _logger;
        private MessageService _messageService;

        public OrderService(ILogger<OrderService> logger, MessageService messageService)
        {
            _logger = logger;
            _messageService = messageService;
        }

        public override  Task<StatusMessage> CreateOrder(Order request, ServerCallContext context)
        {

            var orderCreatedEventMessage = $"Order Creted: {request.OrderId} Payment Account ID: {request.PaymentId}";
            _messageService.SendOrderCreatedEvent(orderCreatedEventMessage);
            return Task.FromResult(new StatusMessage
            {
                Message = "Order Created: " + request.OrderId + request.PaymentId


                 
        });


           
              

            
           
        }

       




    }
}
