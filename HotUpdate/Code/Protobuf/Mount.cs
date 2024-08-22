// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: mount.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from mount.proto</summary>
public static partial class MountReflection {

  #region Descriptor
  /// <summary>File descriptor for mount.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static MountReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cgttb3VudC5wcm90bxoKYmVhbi5wcm90byIOCgxNb3VudEluZm9SZXEiKgoN",
          "TW91bnRJbmZvUmVzcBIZCgZtb3VudHMYASABKAsyCS5Nb3VudHNQYiIYCgpS",
          "ZU1vdW50UmVxEgoKAmlkGAEgASgFIigKC1JlTW91bnRSZXNwEhkKBm1vdW50",
          "cxgBIAEoCzIJLk1vdW50c1BiIhgKClVwTW91bnRSZXESCgoCaWQYASABKAUi",
          "jQEKC1VwTW91bnRSZXNwEhkKBm1vdW50cxgBIAEoCzIJLk1vdW50c1BiEjAK",
          "CmNoYW5nZUl0ZW0YAiADKAsyHC5VcE1vdW50UmVzcC5DaGFuZ2VJdGVtRW50",
          "cnkaMQoPQ2hhbmdlSXRlbUVudHJ5EgsKA2tleRgBIAEoBRINCgV2YWx1ZRgC",
          "IAEoBToCOAEiGQoLQnV5TW91bnRSZXESCgoCaWQYASABKAUijwEKDEJ1eU1v",
          "dW50UmVzcBIZCgZtb3VudHMYASABKAsyCS5Nb3VudHNQYhIxCgpjaGFuZ2VJ",
          "dGVtGAIgAygLMh0uQnV5TW91bnRSZXNwLkNoYW5nZUl0ZW1FbnRyeRoxCg9D",
          "aGFuZ2VJdGVtRW50cnkSCwoDa2V5GAEgASgFEg0KBXZhbHVlGAIgASgFOgI4",
          "ASIOCgxTdGVwTW91bnRSZXEikQEKDVN0ZXBNb3VudFJlc3ASGQoGbW91bnRz",
          "GAEgASgLMgkuTW91bnRzUGISMgoKY2hhbmdlSXRlbRgCIAMoCzIeLlN0ZXBN",
          "b3VudFJlc3AuQ2hhbmdlSXRlbUVudHJ5GjEKD0NoYW5nZUl0ZW1FbnRyeRIL",
          "CgNrZXkYASABKAUSDQoFdmFsdWUYAiABKAU6AjgBQhUKCmNvbS5jYi5tc2dC",
          "B1BCTW91bnRiBnByb3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BeanReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::MountInfoReq), global::MountInfoReq.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::MountInfoResp), global::MountInfoResp.Parser, new[]{ "Mounts" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ReMountReq), global::ReMountReq.Parser, new[]{ "Id" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::ReMountResp), global::ReMountResp.Parser, new[]{ "Mounts" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::UpMountReq), global::UpMountReq.Parser, new[]{ "Id" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::UpMountResp), global::UpMountResp.Parser, new[]{ "Mounts", "ChangeItem" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyMountReq), global::BuyMountReq.Parser, new[]{ "Id" }, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::BuyMountResp), global::BuyMountResp.Parser, new[]{ "Mounts", "ChangeItem" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, }),
          new pbr::GeneratedClrTypeInfo(typeof(global::StepMountReq), global::StepMountReq.Parser, null, null, null, null),
          new pbr::GeneratedClrTypeInfo(typeof(global::StepMountResp), global::StepMountResp.Parser, new[]{ "Mounts", "ChangeItem" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
///坐骑信息（当前）
/// </summary>
public sealed partial class MountInfoReq : pb::IMessage<MountInfoReq> {
  private static readonly pb::MessageParser<MountInfoReq> _parser = new pb::MessageParser<MountInfoReq>(() => new MountInfoReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MountInfoReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MountInfoReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MountInfoReq(MountInfoReq other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MountInfoReq Clone() {
    return new MountInfoReq(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MountInfoReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MountInfoReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MountInfoReq other) {
    if (other == null) {
      return;
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
      }
    }
  }

}

public sealed partial class MountInfoResp : pb::IMessage<MountInfoResp> {
  private static readonly pb::MessageParser<MountInfoResp> _parser = new pb::MessageParser<MountInfoResp>(() => new MountInfoResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<MountInfoResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[1]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MountInfoResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MountInfoResp(MountInfoResp other) : this() {
    Mounts = other.mounts_ != null ? other.Mounts.Clone() : null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public MountInfoResp Clone() {
    return new MountInfoResp(this);
  }

  /// <summary>Field number for the "mounts" field.</summary>
  public const int MountsFieldNumber = 1;
  private global::MountsPb mounts_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MountsPb Mounts {
    get { return mounts_; }
    set {
      mounts_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as MountInfoResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(MountInfoResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Mounts, other.Mounts)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (mounts_ != null) hash ^= Mounts.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (mounts_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Mounts);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (mounts_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Mounts);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(MountInfoResp other) {
    if (other == null) {
      return;
    }
    if (other.mounts_ != null) {
      if (mounts_ == null) {
        mounts_ = new global::MountsPb();
      }
      Mounts.MergeFrom(other.Mounts);
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
        case 10: {
          if (mounts_ == null) {
            mounts_ = new global::MountsPb();
          }
          input.ReadMessage(mounts_);
          break;
        }
      }
    }
  }

}

/// <summary>
///更换
/// </summary>
public sealed partial class ReMountReq : pb::IMessage<ReMountReq> {
  private static readonly pb::MessageParser<ReMountReq> _parser = new pb::MessageParser<ReMountReq>(() => new ReMountReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ReMountReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[2]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReMountReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReMountReq(ReMountReq other) : this() {
    id_ = other.id_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReMountReq Clone() {
    return new ReMountReq(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  /// <summary>
  ///id
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ReMountReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ReMountReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ReMountReq other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
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
          Id = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class ReMountResp : pb::IMessage<ReMountResp> {
  private static readonly pb::MessageParser<ReMountResp> _parser = new pb::MessageParser<ReMountResp>(() => new ReMountResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<ReMountResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[3]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReMountResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReMountResp(ReMountResp other) : this() {
    Mounts = other.mounts_ != null ? other.Mounts.Clone() : null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public ReMountResp Clone() {
    return new ReMountResp(this);
  }

  /// <summary>Field number for the "mounts" field.</summary>
  public const int MountsFieldNumber = 1;
  private global::MountsPb mounts_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MountsPb Mounts {
    get { return mounts_; }
    set {
      mounts_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as ReMountResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(ReMountResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Mounts, other.Mounts)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (mounts_ != null) hash ^= Mounts.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (mounts_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Mounts);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (mounts_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Mounts);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(ReMountResp other) {
    if (other == null) {
      return;
    }
    if (other.mounts_ != null) {
      if (mounts_ == null) {
        mounts_ = new global::MountsPb();
      }
      Mounts.MergeFrom(other.Mounts);
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
        case 10: {
          if (mounts_ == null) {
            mounts_ = new global::MountsPb();
          }
          input.ReadMessage(mounts_);
          break;
        }
      }
    }
  }

}

/// <summary>
///升级 
/// </summary>
public sealed partial class UpMountReq : pb::IMessage<UpMountReq> {
  private static readonly pb::MessageParser<UpMountReq> _parser = new pb::MessageParser<UpMountReq>(() => new UpMountReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<UpMountReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[4]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public UpMountReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public UpMountReq(UpMountReq other) : this() {
    id_ = other.id_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public UpMountReq Clone() {
    return new UpMountReq(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  /// <summary>
  ///id
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as UpMountReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(UpMountReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(UpMountReq other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
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
          Id = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class UpMountResp : pb::IMessage<UpMountResp> {
  private static readonly pb::MessageParser<UpMountResp> _parser = new pb::MessageParser<UpMountResp>(() => new UpMountResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<UpMountResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[5]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public UpMountResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public UpMountResp(UpMountResp other) : this() {
    Mounts = other.mounts_ != null ? other.Mounts.Clone() : null;
    changeItem_ = other.changeItem_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public UpMountResp Clone() {
    return new UpMountResp(this);
  }

  /// <summary>Field number for the "mounts" field.</summary>
  public const int MountsFieldNumber = 1;
  private global::MountsPb mounts_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MountsPb Mounts {
    get { return mounts_; }
    set {
      mounts_ = value;
    }
  }

  /// <summary>Field number for the "changeItem" field.</summary>
  public const int ChangeItemFieldNumber = 2;
  private static readonly pbc::MapField<int, int>.Codec _map_changeItem_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 18);
  private readonly pbc::MapField<int, int> changeItem_ = new pbc::MapField<int, int>();
  /// <summary>
  ///固定改变道具，客户端直接用k,v进行道具覆盖
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> ChangeItem {
    get { return changeItem_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as UpMountResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(UpMountResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Mounts, other.Mounts)) return false;
    if (!ChangeItem.Equals(other.ChangeItem)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (mounts_ != null) hash ^= Mounts.GetHashCode();
    hash ^= ChangeItem.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (mounts_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Mounts);
    }
    changeItem_.WriteTo(output, _map_changeItem_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (mounts_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Mounts);
    }
    size += changeItem_.CalculateSize(_map_changeItem_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(UpMountResp other) {
    if (other == null) {
      return;
    }
    if (other.mounts_ != null) {
      if (mounts_ == null) {
        mounts_ = new global::MountsPb();
      }
      Mounts.MergeFrom(other.Mounts);
    }
    changeItem_.Add(other.changeItem_);
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
          if (mounts_ == null) {
            mounts_ = new global::MountsPb();
          }
          input.ReadMessage(mounts_);
          break;
        }
        case 18: {
          changeItem_.AddEntriesFrom(input, _map_changeItem_codec);
          break;
        }
      }
    }
  }

}

/// <summary>
///购买
/// </summary>
public sealed partial class BuyMountReq : pb::IMessage<BuyMountReq> {
  private static readonly pb::MessageParser<BuyMountReq> _parser = new pb::MessageParser<BuyMountReq>(() => new BuyMountReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BuyMountReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[6]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyMountReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyMountReq(BuyMountReq other) : this() {
    id_ = other.id_;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyMountReq Clone() {
    return new BuyMountReq(this);
  }

  /// <summary>Field number for the "id" field.</summary>
  public const int IdFieldNumber = 1;
  private int id_;
  /// <summary>
  ///坐骑id
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Id {
    get { return id_; }
    set {
      id_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BuyMountReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BuyMountReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Id != other.Id) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Id != 0) hash ^= Id.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Id != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Id);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Id != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Id);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BuyMountReq other) {
    if (other == null) {
      return;
    }
    if (other.Id != 0) {
      Id = other.Id;
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
          Id = input.ReadInt32();
          break;
        }
      }
    }
  }

}

public sealed partial class BuyMountResp : pb::IMessage<BuyMountResp> {
  private static readonly pb::MessageParser<BuyMountResp> _parser = new pb::MessageParser<BuyMountResp>(() => new BuyMountResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<BuyMountResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[7]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyMountResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyMountResp(BuyMountResp other) : this() {
    Mounts = other.mounts_ != null ? other.Mounts.Clone() : null;
    changeItem_ = other.changeItem_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public BuyMountResp Clone() {
    return new BuyMountResp(this);
  }

  /// <summary>Field number for the "mounts" field.</summary>
  public const int MountsFieldNumber = 1;
  private global::MountsPb mounts_;
  /// <summary>
  ///购买成功后的坐骑
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MountsPb Mounts {
    get { return mounts_; }
    set {
      mounts_ = value;
    }
  }

  /// <summary>Field number for the "changeItem" field.</summary>
  public const int ChangeItemFieldNumber = 2;
  private static readonly pbc::MapField<int, int>.Codec _map_changeItem_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 18);
  private readonly pbc::MapField<int, int> changeItem_ = new pbc::MapField<int, int>();
  /// <summary>
  ///固定改变道具，客户端直接用k,v进行道具覆盖
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> ChangeItem {
    get { return changeItem_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as BuyMountResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(BuyMountResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Mounts, other.Mounts)) return false;
    if (!ChangeItem.Equals(other.ChangeItem)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (mounts_ != null) hash ^= Mounts.GetHashCode();
    hash ^= ChangeItem.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (mounts_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Mounts);
    }
    changeItem_.WriteTo(output, _map_changeItem_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (mounts_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Mounts);
    }
    size += changeItem_.CalculateSize(_map_changeItem_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(BuyMountResp other) {
    if (other == null) {
      return;
    }
    if (other.mounts_ != null) {
      if (mounts_ == null) {
        mounts_ = new global::MountsPb();
      }
      Mounts.MergeFrom(other.Mounts);
    }
    changeItem_.Add(other.changeItem_);
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
          if (mounts_ == null) {
            mounts_ = new global::MountsPb();
          }
          input.ReadMessage(mounts_);
          break;
        }
        case 18: {
          changeItem_.AddEntriesFrom(input, _map_changeItem_codec);
          break;
        }
      }
    }
  }

}

/// <summary>
///升阶
/// </summary>
public sealed partial class StepMountReq : pb::IMessage<StepMountReq> {
  private static readonly pb::MessageParser<StepMountReq> _parser = new pb::MessageParser<StepMountReq>(() => new StepMountReq());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<StepMountReq> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[8]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StepMountReq() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StepMountReq(StepMountReq other) : this() {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StepMountReq Clone() {
    return new StepMountReq(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as StepMountReq);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(StepMountReq other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(StepMountReq other) {
    if (other == null) {
      return;
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
      }
    }
  }

}

public sealed partial class StepMountResp : pb::IMessage<StepMountResp> {
  private static readonly pb::MessageParser<StepMountResp> _parser = new pb::MessageParser<StepMountResp>(() => new StepMountResp());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<StepMountResp> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::MountReflection.Descriptor.MessageTypes[9]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StepMountResp() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StepMountResp(StepMountResp other) : this() {
    Mounts = other.mounts_ != null ? other.Mounts.Clone() : null;
    changeItem_ = other.changeItem_.Clone();
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public StepMountResp Clone() {
    return new StepMountResp(this);
  }

  /// <summary>Field number for the "mounts" field.</summary>
  public const int MountsFieldNumber = 1;
  private global::MountsPb mounts_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MountsPb Mounts {
    get { return mounts_; }
    set {
      mounts_ = value;
    }
  }

  /// <summary>Field number for the "changeItem" field.</summary>
  public const int ChangeItemFieldNumber = 2;
  private static readonly pbc::MapField<int, int>.Codec _map_changeItem_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 18);
  private readonly pbc::MapField<int, int> changeItem_ = new pbc::MapField<int, int>();
  /// <summary>
  ///固定改变道具，客户端直接用k,v进行道具覆盖
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> ChangeItem {
    get { return changeItem_; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as StepMountResp);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(StepMountResp other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (!object.Equals(Mounts, other.Mounts)) return false;
    if (!ChangeItem.Equals(other.ChangeItem)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (mounts_ != null) hash ^= Mounts.GetHashCode();
    hash ^= ChangeItem.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (mounts_ != null) {
      output.WriteRawTag(10);
      output.WriteMessage(Mounts);
    }
    changeItem_.WriteTo(output, _map_changeItem_codec);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (mounts_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Mounts);
    }
    size += changeItem_.CalculateSize(_map_changeItem_codec);
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(StepMountResp other) {
    if (other == null) {
      return;
    }
    if (other.mounts_ != null) {
      if (mounts_ == null) {
        mounts_ = new global::MountsPb();
      }
      Mounts.MergeFrom(other.Mounts);
    }
    changeItem_.Add(other.changeItem_);
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
          if (mounts_ == null) {
            mounts_ = new global::MountsPb();
          }
          input.ReadMessage(mounts_);
          break;
        }
        case 18: {
          changeItem_.AddEntriesFrom(input, _map_changeItem_codec);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code