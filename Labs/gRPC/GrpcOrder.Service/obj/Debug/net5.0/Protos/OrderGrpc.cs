// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/order.proto
// </auto-generated>
#pragma warning disable 0414, 1591
#region Designer generated code

using grpc = global::Grpc.Core;

namespace GrpcOrder.Service.Protos {
  public static partial class orderPackage
  {
    static readonly string __ServiceName = "orderPackage.orderPackage";

    static void __Helper_SerializeMessage(global::Google.Protobuf.IMessage message, grpc::SerializationContext context)
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (message is global::Google.Protobuf.IBufferMessage)
      {
        context.SetPayloadLength(message.CalculateSize());
        global::Google.Protobuf.MessageExtensions.WriteTo(message, context.GetBufferWriter());
        context.Complete();
        return;
      }
      #endif
      context.Complete(global::Google.Protobuf.MessageExtensions.ToByteArray(message));
    }

    static class __Helper_MessageCache<T>
    {
      public static readonly bool IsBufferMessage = global::System.Reflection.IntrospectionExtensions.GetTypeInfo(typeof(global::Google.Protobuf.IBufferMessage)).IsAssignableFrom(typeof(T));
    }

    static T __Helper_DeserializeMessage<T>(grpc::DeserializationContext context, global::Google.Protobuf.MessageParser<T> parser) where T : global::Google.Protobuf.IMessage<T>
    {
      #if !GRPC_DISABLE_PROTOBUF_BUFFER_SERIALIZATION
      if (__Helper_MessageCache<T>.IsBufferMessage)
      {
        return parser.ParseFrom(context.PayloadAsReadOnlySequence());
      }
      #endif
      return parser.ParseFrom(context.PayloadAsNewBuffer());
    }

    static readonly grpc::Marshaller<global::GrpcOrder.Service.Protos.Order> __Marshaller_orderPackage_Order = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcOrder.Service.Protos.Order.Parser));
    static readonly grpc::Marshaller<global::GrpcOrder.Service.Protos.StatusMessage> __Marshaller_orderPackage_StatusMessage = grpc::Marshallers.Create(__Helper_SerializeMessage, context => __Helper_DeserializeMessage(context, global::GrpcOrder.Service.Protos.StatusMessage.Parser));

    static readonly grpc::Method<global::GrpcOrder.Service.Protos.Order, global::GrpcOrder.Service.Protos.StatusMessage> __Method_CreateOrder = new grpc::Method<global::GrpcOrder.Service.Protos.Order, global::GrpcOrder.Service.Protos.StatusMessage>(
        grpc::MethodType.Unary,
        __ServiceName,
        "CreateOrder",
        __Marshaller_orderPackage_Order,
        __Marshaller_orderPackage_StatusMessage);

    /// <summary>Service descriptor</summary>
    public static global::Google.Protobuf.Reflection.ServiceDescriptor Descriptor
    {
      get { return global::GrpcOrder.Service.Protos.OrderReflection.Descriptor.Services[0]; }
    }

    /// <summary>Base class for server-side implementations of orderPackage</summary>
    [grpc::BindServiceMethod(typeof(orderPackage), "BindService")]
    public abstract partial class orderPackageBase
    {
      public virtual global::System.Threading.Tasks.Task<global::GrpcOrder.Service.Protos.StatusMessage> CreateOrder(global::GrpcOrder.Service.Protos.Order request, grpc::ServerCallContext context)
      {
        throw new grpc::RpcException(new grpc::Status(grpc::StatusCode.Unimplemented, ""));
      }

    }

    /// <summary>Creates service definition that can be registered with a server</summary>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static grpc::ServerServiceDefinition BindService(orderPackageBase serviceImpl)
    {
      return grpc::ServerServiceDefinition.CreateBuilder()
          .AddMethod(__Method_CreateOrder, serviceImpl.CreateOrder).Build();
    }

    /// <summary>Register service method with a service binder with or without implementation. Useful when customizing the  service binding logic.
    /// Note: this method is part of an experimental API that can change or be removed without any prior notice.</summary>
    /// <param name="serviceBinder">Service methods will be bound by calling <c>AddMethod</c> on this object.</param>
    /// <param name="serviceImpl">An object implementing the server-side handling logic.</param>
    public static void BindService(grpc::ServiceBinderBase serviceBinder, orderPackageBase serviceImpl)
    {
      serviceBinder.AddMethod(__Method_CreateOrder, serviceImpl == null ? null : new grpc::UnaryServerMethod<global::GrpcOrder.Service.Protos.Order, global::GrpcOrder.Service.Protos.StatusMessage>(serviceImpl.CreateOrder));
    }

  }
}
#endregion