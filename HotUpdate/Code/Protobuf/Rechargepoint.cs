// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: rechargepoint.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from rechargepoint.proto</summary>
public static partial class RechargepointReflection {

  #region Descriptor
  /// <summary>File descriptor for rechargepoint.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RechargepointReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "ChNyZWNoYXJnZXBvaW50LnByb3RvGgpiZWFuLnByb3RvIt4BChNSZWNoYXJn",
          "ZVBvaW50SW5mb1BiEhEKCWdvb2RzVHlwZRgBIAEoBRISCgpyZWNoYXJnZUlk",
          "GAIgASgFEg8KB29yZGVyTm8YAyABKAkSEAoIZXJyb3JNc2cYBCABKAkSLgoF",
          "aXRlbXMYBSADKAsyHy5SZWNoYXJnZVBvaW50SW5mb1BiLkl0ZW1zRW50cnkS",
          "HwoFaW5mb3MYBiADKAsyEC5GaXJzdFJlY2hhcmdlUGIaLAoKSXRlbXNFbnRy",
          "eRILCgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6AjgBQh0KCmNvbS5jYi5t",
          "c2dCD1BCUmVjaGFyZ2VQb2ludGIGcHJvdG8z"));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BeanReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RechargePointInfoPb), global::RechargePointInfoPb.Parser, new[]{ "GoodsType", "RechargeId", "OrderNo", "ErrorMsg", "Items", "Infos" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
///*
///goodsType:
///1:金币充值（基础）
///2：首充
/// </summary>
public sealed partial class RechargePointInfoPb : pb::IMessage<RechargePointInfoPb> {
  private static readonly pb::MessageParser<RechargePointInfoPb> _parser = new pb::MessageParser<RechargePointInfoPb>(() => new RechargePointInfoPb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RechargePointInfoPb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RechargepointReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RechargePointInfoPb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RechargePointInfoPb(RechargePointInfoPb other) : this() {
    goodsType_ = other.goodsType_;
    rechargeId_ = other.rechargeId_;
    orderNo_ = other.orderNo_;
    errorMsg_ = other.errorMsg_;
    items_ = other.items_.Clone();
    infos_ = other.infos_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RechargePointInfoPb Clone() {
    return new RechargePointInfoPb(this);
  }

  /// <summary>Field number for the "goodsType" field.</summary>
  public const int GoodsTypeFieldNumber = 1;
  private int goodsType_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int GoodsType {
    get { return goodsType_; }
    set {
      goodsType_ = value;
    }
  }

  /// <summary>Field number for the "rechargeId" field.</summary>
  public const int RechargeIdFieldNumber = 2;
  private int rechargeId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int RechargeId {
    get { return rechargeId_; }
    set {
      rechargeId_ = value;
    }
  }

  /// <summary>Field number for the "orderNo" field.</summary>
  public const int OrderNoFieldNumber = 3;
  private string orderNo_ = "";
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string OrderNo {
    get { return orderNo_; }
    set {
      orderNo_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "errorMsg" field.</summary>
  public const int ErrorMsgFieldNumber = 4;
  private string errorMsg_ = "";
  /// <summary>
  ///错误消息
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string ErrorMsg {
    get { return errorMsg_; }
    set {
      errorMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "items" field.</summary>
  public const int ItemsFieldNumber = 5;
  private static readonly pbc::MapField<int, int>.Codec _map_items_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 42);
  private readonly pbc::MapField<int, int> items_ = new pbc::MapField<int, int>();
  /// <summary>
  ///道具列表
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> Items {
    get { return items_; }
  }

  /// <summary>Field number for the "infos" field.</summary>
  public const int InfosFieldNumber = 6;
  private static readonly pb::FieldCodec<global::FirstRechargePb> _repeated_infos_codec
      = pb::FieldCodec.ForMessage(50, global::FirstRechargePb.Parser);
  private readonly pbc::RepeatedField<global::FirstRechargePb> infos_ = new pbc::RepeatedField<global::FirstRechargePb>();
  /// <summary>
  ///*以下根据不同的goodsType*
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<global::FirstRechargePb> Infos {
    get { return infos_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RechargePointInfoPb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RechargePointInfoPb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (GoodsType != other.GoodsType) return false;
    if (RechargeId != other.RechargeId) return false;
    if (OrderNo != other.OrderNo) return false;
    if (ErrorMsg != other.ErrorMsg) return false;
    if (!Items.Equals(other.Items)) return false;
    if(!infos_.Equals(other.infos_)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (GoodsType != 0) hash ^= GoodsType.GetHashCode();
    if (RechargeId != 0) hash ^= RechargeId.GetHashCode();
    if (OrderNo.Length != 0) hash ^= OrderNo.GetHashCode();
    if (ErrorMsg.Length != 0) hash ^= ErrorMsg.GetHashCode();
    hash ^= Items.GetHashCode();
    hash ^= infos_.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (GoodsType != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(GoodsType);
    }
    if (RechargeId != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(RechargeId);
    }
    if (OrderNo.Length != 0) {
      output.WriteRawTag(26);
      output.WriteString(OrderNo);
    }
    if (ErrorMsg.Length != 0) {
      output.WriteRawTag(34);
      output.WriteString(ErrorMsg);
    }
    items_.WriteTo(output, _map_items_codec);
    infos_.WriteTo(output, _repeated_infos_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (GoodsType != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(GoodsType);
    }
    if (RechargeId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(RechargeId);
    }
    if (OrderNo.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(OrderNo);
    }
    if (ErrorMsg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ErrorMsg);
    }
    size += items_.CalculateSize(_map_items_codec);
    size += infos_.CalculateSize(_repeated_infos_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RechargePointInfoPb other) {
    if (other == null) {
      return;
    }
    if (other.GoodsType != 0) {
      GoodsType = other.GoodsType;
    }
    if (other.RechargeId != 0) {
      RechargeId = other.RechargeId;
    }
    if (other.OrderNo.Length != 0) {
      OrderNo = other.OrderNo;
    }
    if (other.ErrorMsg.Length != 0) {
      ErrorMsg = other.ErrorMsg;
    }
    items_.Add(other.items_);
    infos_.Add(other.infos_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 8: {
          GoodsType = input.ReadInt32();
          break;
        }
        case 16: {
          RechargeId = input.ReadInt32();
          break;
        }
        case 26: {
          OrderNo = input.ReadString();
          break;
        }
        case 34: {
          ErrorMsg = input.ReadString();
          break;
        }
        case 42: {
          items_.AddEntriesFrom(input, _map_items_codec);
          break;
        }
        case 50: {
          infos_.AddEntriesFrom(input, _repeated_infos_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code