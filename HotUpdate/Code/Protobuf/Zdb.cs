// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: zdb.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from zdb.proto</summary>
public static partial class ZdbReflection {

  #region Descriptor
  /// <summary>File descriptor for zdb.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static ZdbReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cgl6ZGIucHJvdG8iWAoKWkFjY291bnRQYhIfCgJpZBgBIAMoCzITLlpBY2Nv",
          "dW50UGIuSWRFbnRyeRopCgdJZEVudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1",
          "ZRgCIAEoBToCOAEiYgoMWlRvd2VyU2hvcFBiEiUKBHNob3AYASADKAsyFy5a",
          "VG93ZXJTaG9wUGIuU2hvcEVudHJ5GisKCVNob3BFbnRyeRILCgNrZXkYASAB",
          "KAUSDQoFdmFsdWUYAiABKAU6AjgBIigKBlpQdnBQYhILCgNwaWQYASADKAUS",
          "EQoJcmVmcmVzaENkGAIgASgFImIKCVpPbmxpbmVQYhImCgZvbmxpbmUYASAD",
          "KAsyFi5aT25saW5lUGIuT25saW5lRW50cnkaLQoLT25saW5lRW50cnkSCwoD",
          "a2V5GAEgASgJEg0KBXZhbHVlGAIgASgFOgI4ASJHCgtaQ29ubkRhdGFQYhIK",
          "CgJzMBgBIAEoAxIMCgR0aW1lGAIgASgDEg0KBXMwRXJyGAMgASgFEg8KB3Rp",
          "bWVFcnIYBCABKAVCEwoKY29tLmNiLm1zZ0IFUEJaZGJiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::ZAccountPb), global::ZAccountPb.Parser, new[]{ "Id" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::ZTowerShopPb), global::ZTowerShopPb.Parser, new[]{ "Shop" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::ZPvpPb), global::ZPvpPb.Parser, new[]{ "Pid", "RefreshCd" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ZOnlinePb), global::ZOnlinePb.Parser, new[]{ "Online" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::ZConnDataPb), global::ZConnDataPb.Parser, new[]{ "S0", "Time", "S0Err", "TimeErr" }, null, null, null)
        }));
  }
  #endregion

}
#region Messages
public sealed partial class ZAccountPb : pb::IMessage<ZAccountPb> {
  private static readonly pb::MessageParser<ZAccountPb> _parser = new pb::MessageParser<ZAccountPb>(() => new ZAccountPb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ZAccountPb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ZdbReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZAccountPb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZAccountPb(ZAccountPb other) : this() {
    id_ = other.id_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZAccountPb Clone() {
    return new ZAccountPb(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private static readonly pbc::MapField<int, int>.Codec _map_id_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 10);
  private readonly pbc::MapField<int, int> id_ = new pbc::MapField<int, int>();
  /// <summary>
  ///sid->pid
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> Id {
    get { return id_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ZAccountPb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ZAccountPb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!Id.Equals(other.Id)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= Id.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    id_.WriteTo(output, _map_id_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += id_.CalculateSize(_map_id_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ZAccountPb other) {
    if (other == null) {
      return;
    }
    id_.Add(other.id_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          id_.AddEntriesFrom(input, _map_id_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class ZTowerShopPb : pb::IMessage<ZTowerShopPb> {
  private static readonly pb::MessageParser<ZTowerShopPb> _parser = new pb::MessageParser<ZTowerShopPb>(() => new ZTowerShopPb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ZTowerShopPb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ZdbReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZTowerShopPb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZTowerShopPb(ZTowerShopPb other) : this() {
    shop_ = other.shop_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZTowerShopPb Clone() {
    return new ZTowerShopPb(this);
  }

  /// <summary>Field number for the "shop" field.</summary>
  public const int ShopFieldNumber = 1;
  private static readonly pbc::MapField<int, int>.Codec _map_shop_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 10);
  private readonly pbc::MapField<int, int> shop_ = new pbc::MapField<int, int>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> Shop {
    get { return shop_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ZTowerShopPb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ZTowerShopPb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!Shop.Equals(other.Shop)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= Shop.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    shop_.WriteTo(output, _map_shop_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += shop_.CalculateSize(_map_shop_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ZTowerShopPb other) {
    if (other == null) {
      return;
    }
    shop_.Add(other.shop_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          shop_.AddEntriesFrom(input, _map_shop_codec);
          break;
        }
      }
    }
  }

}

/// <summary>
///废弃
/// </summary>
public sealed partial class ZPvpPb : pb::IMessage<ZPvpPb> {
  private static readonly pb::MessageParser<ZPvpPb> _parser = new pb::MessageParser<ZPvpPb>(() => new ZPvpPb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ZPvpPb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ZdbReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZPvpPb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZPvpPb(ZPvpPb other) : this() {
    pid_ = other.pid_.Clone();
    refreshCd_ = other.refreshCd_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZPvpPb Clone() {
    return new ZPvpPb(this);
  }

  /// <summary>Field number for the "pid" field.</summary>
  public const int PidFieldNumber = 1;
  private static readonly pb::FieldCodec<int> _repeated_pid_codec
      = pb::FieldCodec.ForInt32(10);
  private readonly pbc::RepeatedField<int> pid_ = new pbc::RepeatedField<int>();
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<int> Pid {
    get { return pid_; }
  }

  /// <summary>Field number for the "refreshCd" field.</summary>
  public const int RefreshCdFieldNumber = 2;
  private int refreshCd_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int RefreshCd {
    get { return refreshCd_; }
    set {
      refreshCd_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ZPvpPb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ZPvpPb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if(!pid_.Equals(other.pid_)) return false;
    if (RefreshCd != other.RefreshCd) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= pid_.GetHashCode();
    if (RefreshCd != 0) hash ^= RefreshCd.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    pid_.WriteTo(output, _repeated_pid_codec);
    if (RefreshCd != 0) {
      output.WriteRawTag(16);
      output.WriteInt32(RefreshCd);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += pid_.CalculateSize(_repeated_pid_codec);
    if (RefreshCd != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(RefreshCd);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ZPvpPb other) {
    if (other == null) {
      return;
    }
    pid_.Add(other.pid_);
    if (other.RefreshCd != 0) {
      RefreshCd = other.RefreshCd;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10:
        case 8: {
          pid_.AddEntriesFrom(input, _repeated_pid_codec);
          break;
        }
        case 16: {
          RefreshCd = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class ZOnlinePb : pb::IMessage<ZOnlinePb> {
  private static readonly pb::MessageParser<ZOnlinePb> _parser = new pb::MessageParser<ZOnlinePb>(() => new ZOnlinePb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ZOnlinePb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ZdbReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZOnlinePb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZOnlinePb(ZOnlinePb other) : this() {
    online_ = other.online_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZOnlinePb Clone() {
    return new ZOnlinePb(this);
  }

  /// <summary>Field number for the "online" field.</summary>
  public const int OnlineFieldNumber = 1;
  private static readonly pbc::MapField<string, int>.Codec _map_online_codec
      = new pbc::MapField<string, int>.Codec(pb::FieldCodec.ForString(10), pb::FieldCodec.ForInt32(16), 10);
  private readonly pbc::MapField<string, int> online_ = new pbc::MapField<string, int>();
  /// <summary>
  ///HHmmss->num
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<string, int> Online {
    get { return online_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ZOnlinePb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ZOnlinePb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!Online.Equals(other.Online)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    hash ^= Online.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    online_.WriteTo(output, _map_online_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    size += online_.CalculateSize(_map_online_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ZOnlinePb other) {
    if (other == null) {
      return;
    }
    online_.Add(other.online_);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(pb::CodedInputStream input) {
    uint tag;
    while ((tag = input.ReadTag()) != 0) {
      switch(tag) {
        default:
          input.SkipLastField();
          break;
        case 10: {
          online_.AddEntriesFrom(input, _map_online_codec);
          break;
        }
      }
    }
  }

}

public sealed partial class ZConnDataPb : pb::IMessage<ZConnDataPb> {
  private static readonly pb::MessageParser<ZConnDataPb> _parser = new pb::MessageParser<ZConnDataPb>(() => new ZConnDataPb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ZConnDataPb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::ZdbReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZConnDataPb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZConnDataPb(ZConnDataPb other) : this() {
    s0_ = other.s0_;
    time_ = other.time_;
    s0Err_ = other.s0Err_;
    timeErr_ = other.timeErr_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ZConnDataPb Clone() {
    return new ZConnDataPb(this);
  }

  /// <summary>Field number for the "s0" field.</summary>
  public const int S0FieldNumber = 1;
  private long s0_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long S0 {
    get { return s0_; }
    set {
      s0_ = value;
    }
  }

  /// <summary>Field number for the "time" field.</summary>
  public const int TimeFieldNumber = 2;
  private long time_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Time {
    get { return time_; }
    set {
      time_ = value;
    }
  }

  /// <summary>Field number for the "s0Err" field.</summary>
  public const int S0ErrFieldNumber = 3;
  private int s0Err_;
  /// <summary>
  ///s0错误次数，每天给5次
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int S0Err {
    get { return s0Err_; }
    set {
      s0Err_ = value;
    }
  }

  /// <summary>Field number for the "timeErr" field.</summary>
  public const int TimeErrFieldNumber = 4;
  private int timeErr_;
  /// <summary>
  ///每天给5次
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int TimeErr {
    get { return timeErr_; }
    set {
      timeErr_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ZConnDataPb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ZConnDataPb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (S0 != other.S0) return false;
    if (Time != other.Time) return false;
    if (S0Err != other.S0Err) return false;
    if (TimeErr != other.TimeErr) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (S0 != 0L) hash ^= S0.GetHashCode();
    if (Time != 0L) hash ^= Time.GetHashCode();
    if (S0Err != 0) hash ^= S0Err.GetHashCode();
    if (TimeErr != 0) hash ^= TimeErr.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (S0 != 0L) {
      output.WriteRawTag(8);
      output.WriteInt64(S0);
    }
    if (Time != 0L) {
      output.WriteRawTag(16);
      output.WriteInt64(Time);
    }
    if (S0Err != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(S0Err);
    }
    if (TimeErr != 0) {
      output.WriteRawTag(32);
      output.WriteInt32(TimeErr);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (S0 != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(S0);
    }
    if (Time != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Time);
    }
    if (S0Err != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(S0Err);
    }
    if (TimeErr != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimeErr);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ZConnDataPb other) {
    if (other == null) {
      return;
    }
    if (other.S0 != 0L) {
      S0 = other.S0;
    }
    if (other.Time != 0L) {
      Time = other.Time;
    }
    if (other.S0Err != 0) {
      S0Err = other.S0Err;
    }
    if (other.TimeErr != 0) {
      TimeErr = other.TimeErr;
    }
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
          S0 = input.ReadInt64();
          break;
        }
        case 16: {
          Time = input.ReadInt64();
          break;
        }
        case 24: {
          S0Err = input.ReadInt32();
          break;
        }
        case 32: {
          TimeErr = input.ReadInt32();
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code