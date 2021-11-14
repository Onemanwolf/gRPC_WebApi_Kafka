// <auto-generated>
//     Generated by the protocol buffer compiler.  DO NOT EDIT!
//     source: Protos/order.proto
// </auto-generated>
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace GrpcOrder.Service.Protos {

  /// <summary>Holder for reflection information generated from Protos/order.proto</summary>
  public static partial class OrderReflection {

    #region Descriptor
    /// <summary>File descriptor for Protos/order.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static OrderReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "ChJQcm90b3Mvb3JkZXIucHJvdG8SDG9yZGVyUGFja2FnZSJiCgVPcmRlchIS",
            "CgpjdXN0b21lcklkGAEgASgDEg8KB29yZGVySWQYAiABKAMSEQoJcGF5bWVu",
            "dElkGAMgASgDEg0KBXRvdGFsGAQgASgBEhIKCm9yZGVySXRlbXMYBSADKAki",
            "NwoNU3RhdHVzTWVzc2FnZRIPCgdtZXNzYWdlGAEgASgJEhUKDW9yZGVyUmVj",
            "ZWl2ZWQYAiABKAgyTwoMb3JkZXJQYWNrYWdlEj8KC0NyZWF0ZU9yZGVyEhMu",
            "b3JkZXJQYWNrYWdlLk9yZGVyGhsub3JkZXJQYWNrYWdlLlN0YXR1c01lc3Nh",
            "Z2VCG6oCGEdycGNPcmRlci5TZXJ2aWNlLlByb3Rvc2IGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcOrder.Service.Protos.Order), global::GrpcOrder.Service.Protos.Order.Parser, new[]{ "CustomerId", "OrderId", "PaymentId", "Total", "OrderItems" }, null, null, null, null),
            new pbr::GeneratedClrTypeInfo(typeof(global::GrpcOrder.Service.Protos.StatusMessage), global::GrpcOrder.Service.Protos.StatusMessage.Parser, new[]{ "Message", "OrderReceived" }, null, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class Order : pb::IMessage<Order>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<Order> _parser = new pb::MessageParser<Order>(() => new Order());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<Order> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcOrder.Service.Protos.OrderReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Order() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Order(Order other) : this() {
      customerId_ = other.customerId_;
      orderId_ = other.orderId_;
      paymentId_ = other.paymentId_;
      total_ = other.total_;
      orderItems_ = other.orderItems_.Clone();
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public Order Clone() {
      return new Order(this);
    }

    /// <summary>Field number for the "customerId" field.</summary>
    public const int CustomerIdFieldNumber = 1;
    private long customerId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long CustomerId {
      get { return customerId_; }
      set {
        customerId_ = value;
      }
    }

    /// <summary>Field number for the "orderId" field.</summary>
    public const int OrderIdFieldNumber = 2;
    private long orderId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long OrderId {
      get { return orderId_; }
      set {
        orderId_ = value;
      }
    }

    /// <summary>Field number for the "paymentId" field.</summary>
    public const int PaymentIdFieldNumber = 3;
    private long paymentId_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public long PaymentId {
      get { return paymentId_; }
      set {
        paymentId_ = value;
      }
    }

    /// <summary>Field number for the "total" field.</summary>
    public const int TotalFieldNumber = 4;
    private double total_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public double Total {
      get { return total_; }
      set {
        total_ = value;
      }
    }

    /// <summary>Field number for the "orderItems" field.</summary>
    public const int OrderItemsFieldNumber = 5;
    private static readonly pb::FieldCodec<string> _repeated_orderItems_codec
        = pb::FieldCodec.ForString(42);
    private readonly pbc::RepeatedField<string> orderItems_ = new pbc::RepeatedField<string>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<string> OrderItems {
      get { return orderItems_; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as Order);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(Order other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (CustomerId != other.CustomerId) return false;
      if (OrderId != other.OrderId) return false;
      if (PaymentId != other.PaymentId) return false;
      if (!pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.Equals(Total, other.Total)) return false;
      if(!orderItems_.Equals(other.orderItems_)) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (CustomerId != 0L) hash ^= CustomerId.GetHashCode();
      if (OrderId != 0L) hash ^= OrderId.GetHashCode();
      if (PaymentId != 0L) hash ^= PaymentId.GetHashCode();
      if (Total != 0D) hash ^= pbc::ProtobufEqualityComparers.BitwiseDoubleEqualityComparer.GetHashCode(Total);
      hash ^= orderItems_.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (CustomerId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CustomerId);
      }
      if (OrderId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(OrderId);
      }
      if (PaymentId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(PaymentId);
      }
      if (Total != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Total);
      }
      orderItems_.WriteTo(output, _repeated_orderItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (CustomerId != 0L) {
        output.WriteRawTag(8);
        output.WriteInt64(CustomerId);
      }
      if (OrderId != 0L) {
        output.WriteRawTag(16);
        output.WriteInt64(OrderId);
      }
      if (PaymentId != 0L) {
        output.WriteRawTag(24);
        output.WriteInt64(PaymentId);
      }
      if (Total != 0D) {
        output.WriteRawTag(33);
        output.WriteDouble(Total);
      }
      orderItems_.WriteTo(ref output, _repeated_orderItems_codec);
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (CustomerId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(CustomerId);
      }
      if (OrderId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(OrderId);
      }
      if (PaymentId != 0L) {
        size += 1 + pb::CodedOutputStream.ComputeInt64Size(PaymentId);
      }
      if (Total != 0D) {
        size += 1 + 8;
      }
      size += orderItems_.CalculateSize(_repeated_orderItems_codec);
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(Order other) {
      if (other == null) {
        return;
      }
      if (other.CustomerId != 0L) {
        CustomerId = other.CustomerId;
      }
      if (other.OrderId != 0L) {
        OrderId = other.OrderId;
      }
      if (other.PaymentId != 0L) {
        PaymentId = other.PaymentId;
      }
      if (other.Total != 0D) {
        Total = other.Total;
      }
      orderItems_.Add(other.orderItems_);
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 8: {
            CustomerId = input.ReadInt64();
            break;
          }
          case 16: {
            OrderId = input.ReadInt64();
            break;
          }
          case 24: {
            PaymentId = input.ReadInt64();
            break;
          }
          case 33: {
            Total = input.ReadDouble();
            break;
          }
          case 42: {
            orderItems_.AddEntriesFrom(input, _repeated_orderItems_codec);
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 8: {
            CustomerId = input.ReadInt64();
            break;
          }
          case 16: {
            OrderId = input.ReadInt64();
            break;
          }
          case 24: {
            PaymentId = input.ReadInt64();
            break;
          }
          case 33: {
            Total = input.ReadDouble();
            break;
          }
          case 42: {
            orderItems_.AddEntriesFrom(ref input, _repeated_orderItems_codec);
            break;
          }
        }
      }
    }
    #endif

  }

  public sealed partial class StatusMessage : pb::IMessage<StatusMessage>
  #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      , pb::IBufferMessage
  #endif
  {
    private static readonly pb::MessageParser<StatusMessage> _parser = new pb::MessageParser<StatusMessage>(() => new StatusMessage());
    private pb::UnknownFieldSet _unknownFields;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<StatusMessage> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::GrpcOrder.Service.Protos.OrderReflection.Descriptor.MessageTypes[1]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusMessage() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusMessage(StatusMessage other) : this() {
      message_ = other.message_;
      orderReceived_ = other.orderReceived_;
      _unknownFields = pb::UnknownFieldSet.Clone(other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public StatusMessage Clone() {
      return new StatusMessage(this);
    }

    /// <summary>Field number for the "message" field.</summary>
    public const int MessageFieldNumber = 1;
    private string message_ = "";
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public string Message {
      get { return message_; }
      set {
        message_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
      }
    }

    /// <summary>Field number for the "orderReceived" field.</summary>
    public const int OrderReceivedFieldNumber = 2;
    private bool orderReceived_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool OrderReceived {
      get { return orderReceived_; }
      set {
        orderReceived_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as StatusMessage);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(StatusMessage other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (Message != other.Message) return false;
      if (OrderReceived != other.OrderReceived) return false;
      return Equals(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (Message.Length != 0) hash ^= Message.GetHashCode();
      if (OrderReceived != false) hash ^= OrderReceived.GetHashCode();
      if (_unknownFields != null) {
        hash ^= _unknownFields.GetHashCode();
      }
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      output.WriteRawMessage(this);
    #else
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (OrderReceived != false) {
        output.WriteRawTag(16);
        output.WriteBool(OrderReceived);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(output);
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalWriteTo(ref pb::WriteContext output) {
      if (Message.Length != 0) {
        output.WriteRawTag(10);
        output.WriteString(Message);
      }
      if (OrderReceived != false) {
        output.WriteRawTag(16);
        output.WriteBool(OrderReceived);
      }
      if (_unknownFields != null) {
        _unknownFields.WriteTo(ref output);
      }
    }
    #endif

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (Message.Length != 0) {
        size += 1 + pb::CodedOutputStream.ComputeStringSize(Message);
      }
      if (OrderReceived != false) {
        size += 1 + 1;
      }
      if (_unknownFields != null) {
        size += _unknownFields.CalculateSize();
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(StatusMessage other) {
      if (other == null) {
        return;
      }
      if (other.Message.Length != 0) {
        Message = other.Message;
      }
      if (other.OrderReceived != false) {
        OrderReceived = other.OrderReceived;
      }
      _unknownFields = pb::UnknownFieldSet.MergeFrom(_unknownFields, other._unknownFields);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
      input.ReadRawMessage(this);
    #else
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            OrderReceived = input.ReadBool();
            break;
          }
        }
      }
    #endif
    }

    #if !GOOGLE_PROTOBUF_REFSTRUCT_COMPATIBILITY_MODE
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    void pb::IBufferMessage.InternalMergeFrom(ref pb::ParseContext input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            _unknownFields = pb::UnknownFieldSet.MergeFieldFrom(_unknownFields, ref input);
            break;
          case 10: {
            Message = input.ReadString();
            break;
          }
          case 16: {
            OrderReceived = input.ReadBool();
            break;
          }
        }
      }
    }
    #endif

  }

  #endregion

}

#endregion Designer generated code
