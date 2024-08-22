// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: redpoint.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
/// <summary>Holder for reflection information generated from redpoint.proto</summary>
public static partial class RedpointReflection {

  #region Descriptor
  /// <summary>File descriptor for redpoint.proto</summary>
  public static pbr::FileDescriptor Descriptor {
    get { return descriptor; }
  }
  private static pbr::FileDescriptor descriptor;

  static RedpointReflection() {
    byte[] descriptorData = global::System.Convert.FromBase64String(
        string.Concat(
          "Cg5yZWRwb2ludC5wcm90bxoKYmVhbi5wcm90byKFAwoKUmVkUG9pbnRQYhIN",
          "CgVwb2ludBgBIAEoBRIdCghtYWluVGFzaxgCIAEoCzILLk1haW5UYXNrUGIS",
          "DgoGYWxseUlkGAMgASgFEhUKBGF0dHIYBCABKAsyBy5BdHRyUGISEQoJc2Vy",
          "dmVyTXNnGAUgASgJEhMKC2FkdmFuY2VUaW1lGAYgASgDEiEKA3R0ZxgHIAMo",
          "CzIULlJlZFBvaW50UGIuVHRnRW50cnkSDgoGY29tYmF0GAggASgDEiUKDGRh",
          "aWx5UmVmcmVzaBgJIAEoCzIPLkRhaWx5UmVmcmVzaFBiEisKDXN0YWdlVGFz",
          "a0luZm8YCiABKAsyFC5QbGF5ZXJTdGFnZVRhc2tJbmZvEhUKDW9wZW5Gcmll",
          "bmRJZHMYCyADKAUSFQoEbWFpbBgMIAEoCzIHLk1haWxQYhIZCgZnbUluZm8Y",
          "DSABKAsyCS5HbUluZm9QYhoqCghUdGdFbnRyeRILCgNrZXkYASABKAUSDQoF",
          "dmFsdWUYAiABKAU6AjgBQhgKCmNvbS5jYi5tc2dCClBCUmVkUG9pbnRiBnBy",
          "b3RvMw=="));
    descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
        new pbr::FileDescriptor[] { global::BeanReflection.Descriptor, },
        new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
          new pbr::GeneratedClrTypeInfo(typeof(global::RedPointPb), global::RedPointPb.Parser, new[]{ "Point", "MainTask", "AllyId", "Attr", "ServerMsg", "AdvanceTime", "Ttg", "Combat", "DailyRefresh", "StageTaskInfo", "OpenFriendIds", "Mail", "GmInfo" }, null, null, new pbr::GeneratedClrTypeInfo[] { null, })
        }));
  }
  #endregion

}
#region Messages
/// <summary>
///不单单是红点系统，所有的推送也放这里
/// </summary>
public sealed partial class RedPointPb : pb::IMessage<RedPointPb> {
  private static readonly pb::MessageParser<RedPointPb> _parser = new pb::MessageParser<RedPointPb>(() => new RedPointPb());
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pb::MessageParser<RedPointPb> Parser { get { return _parser; } }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public static pbr::MessageDescriptor Descriptor {
    get { return global::RedpointReflection.Descriptor.MessageTypes[0]; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  pbr::MessageDescriptor pb::IMessage.Descriptor {
    get { return Descriptor; }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RedPointPb() {
    OnConstruction();
  }

  partial void OnConstruction();

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RedPointPb(RedPointPb other) : this() {
    point_ = other.point_;
    MainTask = other.mainTask_ != null ? other.MainTask.Clone() : null;
    allyId_ = other.allyId_;
    Attr = other.attr_ != null ? other.Attr.Clone() : null;
    serverMsg_ = other.serverMsg_;
    advanceTime_ = other.advanceTime_;
    ttg_ = other.ttg_.Clone();
    combat_ = other.combat_;
    DailyRefresh = other.dailyRefresh_ != null ? other.DailyRefresh.Clone() : null;
    StageTaskInfo = other.stageTaskInfo_ != null ? other.StageTaskInfo.Clone() : null;
    openFriendIds_ = other.openFriendIds_.Clone();
    Mail = other.mail_ != null ? other.Mail.Clone() : null;
    GmInfo = other.gmInfo_ != null ? other.GmInfo.Clone() : null;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public RedPointPb Clone() {
    return new RedPointPb(this);
  }

  /// <summary>Field number for the "point" field.</summary>
  public const int PointFieldNumber = 1;
  private int point_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int Point {
    get { return point_; }
    set {
      point_ = value;
    }
  }

  /// <summary>Field number for the "mainTask" field.</summary>
  public const int MainTaskFieldNumber = 2;
  private global::MainTaskPb mainTask_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MainTaskPb MainTask {
    get { return mainTask_; }
    set {
      mainTask_ = value;
    }
  }

  /// <summary>Field number for the "allyId" field.</summary>
  public const int AllyIdFieldNumber = 3;
  private int allyId_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int AllyId {
    get { return allyId_; }
    set {
      allyId_ = value;
    }
  }

  /// <summary>Field number for the "attr" field.</summary>
  public const int AttrFieldNumber = 4;
  private global::AttrPb attr_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::AttrPb Attr {
    get { return attr_; }
    set {
      attr_ = value;
    }
  }

  /// <summary>Field number for the "serverMsg" field.</summary>
  public const int ServerMsgFieldNumber = 5;
  private string serverMsg_ = "";
  /// <summary>
  ///对应point=4
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public string ServerMsg {
    get { return serverMsg_; }
    set {
      serverMsg_ = pb::ProtoPreconditions.CheckNotNull(value, "value");
    }
  }

  /// <summary>Field number for the "advanceTime" field.</summary>
  public const int AdvanceTimeFieldNumber = 6;
  private long advanceTime_;
  /// <summary>
  ///孵化池晋级结束时间 s
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long AdvanceTime {
    get { return advanceTime_; }
    set {
      advanceTime_ = value;
    }
  }

  /// <summary>Field number for the "ttg" field.</summary>
  public const int TtgFieldNumber = 7;
  private static readonly pbc::MapField<int, int>.Codec _map_ttg_codec
      = new pbc::MapField<int, int>.Codec(pb::FieldCodec.ForInt32(8), pb::FieldCodec.ForInt32(16), 58);
  private readonly pbc::MapField<int, int> ttg_ = new pbc::MapField<int, int>();
  /// <summary>
  ///对应point=6 talent to grade
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::MapField<int, int> Ttg {
    get { return ttg_; }
  }

  /// <summary>Field number for the "combat" field.</summary>
  public const int CombatFieldNumber = 8;
  private long combat_;
  /// <summary>
  /// 战力
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public long Combat {
    get { return combat_; }
    set {
      combat_ = value;
    }
  }

  /// <summary>Field number for the "dailyRefresh" field.</summary>
  public const int DailyRefreshFieldNumber = 9;
  private global::DailyRefreshPb dailyRefresh_;
  /// <summary>
  /// 每日刷新数据
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::DailyRefreshPb DailyRefresh {
    get { return dailyRefresh_; }
    set {
      dailyRefresh_ = value;
    }
  }

  /// <summary>Field number for the "stageTaskInfo" field.</summary>
  public const int StageTaskInfoFieldNumber = 10;
  private global::PlayerStageTaskInfo stageTaskInfo_;
  /// <summary>
  /// 玩家进阶任务
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::PlayerStageTaskInfo StageTaskInfo {
    get { return stageTaskInfo_; }
    set {
      stageTaskInfo_ = value;
    }
  }

  /// <summary>Field number for the "openFriendIds" field.</summary>
  public const int OpenFriendIdsFieldNumber = 11;
  private static readonly pb::FieldCodec<int> _repeated_openFriendIds_codec
      = pb::FieldCodec.ForInt32(90);
  private readonly pbc::RepeatedField<int> openFriendIds_ = new pbc::RepeatedField<int>();
  /// <summary>
  /// 解锁密友ID
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public pbc::RepeatedField<int> OpenFriendIds {
    get { return openFriendIds_; }
  }

  /// <summary>Field number for the "mail" field.</summary>
  public const int MailFieldNumber = 12;
  private global::MailPb mail_;
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::MailPb Mail {
    get { return mail_; }
    set {
      mail_ = value;
    }
  }

  /// <summary>Field number for the "gmInfo" field.</summary>
  public const int GmInfoFieldNumber = 13;
  private global::GmInfoPb gmInfo_;
  /// <summary>
  ///GmResponse
  /// </summary>
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public global::GmInfoPb GmInfo {
    get { return gmInfo_; }
    set {
      gmInfo_ = value;
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override bool Equals(object other) {
    return Equals(other as RedPointPb);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public bool Equals(RedPointPb other) {
    if (ReferenceEquals(other, null)) {
      return false;
    }
    if (ReferenceEquals(other, this)) {
      return true;
    }
    if (Point != other.Point) return false;
    if (!object.Equals(MainTask, other.MainTask)) return false;
    if (AllyId != other.AllyId) return false;
    if (!object.Equals(Attr, other.Attr)) return false;
    if (ServerMsg != other.ServerMsg) return false;
    if (AdvanceTime != other.AdvanceTime) return false;
    if (!Ttg.Equals(other.Ttg)) return false;
    if (Combat != other.Combat) return false;
    if (!object.Equals(DailyRefresh, other.DailyRefresh)) return false;
    if (!object.Equals(StageTaskInfo, other.StageTaskInfo)) return false;
    if(!openFriendIds_.Equals(other.openFriendIds_)) return false;
    if (!object.Equals(Mail, other.Mail)) return false;
    if (!object.Equals(GmInfo, other.GmInfo)) return false;
    return true;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override int GetHashCode() {
    int hash = 1;
    if (Point != 0) hash ^= Point.GetHashCode();
    if (mainTask_ != null) hash ^= MainTask.GetHashCode();
    if (AllyId != 0) hash ^= AllyId.GetHashCode();
    if (attr_ != null) hash ^= Attr.GetHashCode();
    if (ServerMsg.Length != 0) hash ^= ServerMsg.GetHashCode();
    if (AdvanceTime != 0L) hash ^= AdvanceTime.GetHashCode();
    hash ^= Ttg.GetHashCode();
    if (Combat != 0L) hash ^= Combat.GetHashCode();
    if (dailyRefresh_ != null) hash ^= DailyRefresh.GetHashCode();
    if (stageTaskInfo_ != null) hash ^= StageTaskInfo.GetHashCode();
    hash ^= openFriendIds_.GetHashCode();
    if (mail_ != null) hash ^= Mail.GetHashCode();
    if (gmInfo_ != null) hash ^= GmInfo.GetHashCode();
    return hash;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public override string ToString() {
    return pb::JsonFormatter.ToDiagnosticString(this);
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void WriteTo(pb::CodedOutputStream output) {
    if (Point != 0) {
      output.WriteRawTag(8);
      output.WriteInt32(Point);
    }
    if (mainTask_ != null) {
      output.WriteRawTag(18);
      output.WriteMessage(MainTask);
    }
    if (AllyId != 0) {
      output.WriteRawTag(24);
      output.WriteInt32(AllyId);
    }
    if (attr_ != null) {
      output.WriteRawTag(34);
      output.WriteMessage(Attr);
    }
    if (ServerMsg.Length != 0) {
      output.WriteRawTag(42);
      output.WriteString(ServerMsg);
    }
    if (AdvanceTime != 0L) {
      output.WriteRawTag(48);
      output.WriteInt64(AdvanceTime);
    }
    ttg_.WriteTo(output, _map_ttg_codec);
    if (Combat != 0L) {
      output.WriteRawTag(64);
      output.WriteInt64(Combat);
    }
    if (dailyRefresh_ != null) {
      output.WriteRawTag(74);
      output.WriteMessage(DailyRefresh);
    }
    if (stageTaskInfo_ != null) {
      output.WriteRawTag(82);
      output.WriteMessage(StageTaskInfo);
    }
    openFriendIds_.WriteTo(output, _repeated_openFriendIds_codec);
    if (mail_ != null) {
      output.WriteRawTag(98);
      output.WriteMessage(Mail);
    }
    if (gmInfo_ != null) {
      output.WriteRawTag(106);
      output.WriteMessage(GmInfo);
    }
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public int CalculateSize() {
    int size = 0;
    if (Point != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(Point);
    }
    if (mainTask_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(MainTask);
    }
    if (AllyId != 0) {
      size += 1 + pb::CodedOutputStream.ComputeInt32Size(AllyId);
    }
    if (attr_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Attr);
    }
    if (ServerMsg.Length != 0) {
      size += 1 + pb::CodedOutputStream.ComputeStringSize(ServerMsg);
    }
    if (AdvanceTime != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(AdvanceTime);
    }
    size += ttg_.CalculateSize(_map_ttg_codec);
    if (Combat != 0L) {
      size += 1 + pb::CodedOutputStream.ComputeInt64Size(Combat);
    }
    if (dailyRefresh_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(DailyRefresh);
    }
    if (stageTaskInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(StageTaskInfo);
    }
    size += openFriendIds_.CalculateSize(_repeated_openFriendIds_codec);
    if (mail_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(Mail);
    }
    if (gmInfo_ != null) {
      size += 1 + pb::CodedOutputStream.ComputeMessageSize(GmInfo);
    }
    return size;
  }

  [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
  public void MergeFrom(RedPointPb other) {
    if (other == null) {
      return;
    }
    if (other.Point != 0) {
      Point = other.Point;
    }
    if (other.mainTask_ != null) {
      if (mainTask_ == null) {
        mainTask_ = new global::MainTaskPb();
      }
      MainTask.MergeFrom(other.MainTask);
    }
    if (other.AllyId != 0) {
      AllyId = other.AllyId;
    }
    if (other.attr_ != null) {
      if (attr_ == null) {
        attr_ = new global::AttrPb();
      }
      Attr.MergeFrom(other.Attr);
    }
    if (other.ServerMsg.Length != 0) {
      ServerMsg = other.ServerMsg;
    }
    if (other.AdvanceTime != 0L) {
      AdvanceTime = other.AdvanceTime;
    }
    ttg_.Add(other.ttg_);
    if (other.Combat != 0L) {
      Combat = other.Combat;
    }
    if (other.dailyRefresh_ != null) {
      if (dailyRefresh_ == null) {
        dailyRefresh_ = new global::DailyRefreshPb();
      }
      DailyRefresh.MergeFrom(other.DailyRefresh);
    }
    if (other.stageTaskInfo_ != null) {
      if (stageTaskInfo_ == null) {
        stageTaskInfo_ = new global::PlayerStageTaskInfo();
      }
      StageTaskInfo.MergeFrom(other.StageTaskInfo);
    }
    openFriendIds_.Add(other.openFriendIds_);
    if (other.mail_ != null) {
      if (mail_ == null) {
        mail_ = new global::MailPb();
      }
      Mail.MergeFrom(other.Mail);
    }
    if (other.gmInfo_ != null) {
      if (gmInfo_ == null) {
        gmInfo_ = new global::GmInfoPb();
      }
      GmInfo.MergeFrom(other.GmInfo);
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
          Point = input.ReadInt32();
          break;
        }
        case 18: {
          if (mainTask_ == null) {
            mainTask_ = new global::MainTaskPb();
          }
          input.ReadMessage(mainTask_);
          break;
        }
        case 24: {
          AllyId = input.ReadInt32();
          break;
        }
        case 34: {
          if (attr_ == null) {
            attr_ = new global::AttrPb();
          }
          input.ReadMessage(attr_);
          break;
        }
        case 42: {
          ServerMsg = input.ReadString();
          break;
        }
        case 48: {
          AdvanceTime = input.ReadInt64();
          break;
        }
        case 58: {
          ttg_.AddEntriesFrom(input, _map_ttg_codec);
          break;
        }
        case 64: {
          Combat = input.ReadInt64();
          break;
        }
        case 74: {
          if (dailyRefresh_ == null) {
            dailyRefresh_ = new global::DailyRefreshPb();
          }
          input.ReadMessage(dailyRefresh_);
          break;
        }
        case 82: {
          if (stageTaskInfo_ == null) {
            stageTaskInfo_ = new global::PlayerStageTaskInfo();
          }
          input.ReadMessage(stageTaskInfo_);
          break;
        }
        case 90:
        case 88: {
          openFriendIds_.AddEntriesFrom(input, _repeated_openFriendIds_codec);
          break;
        }
        case 98: {
          if (mail_ == null) {
            mail_ = new global::MailPb();
          }
          input.ReadMessage(mail_);
          break;
        }
        case 106: {
          if (gmInfo_ == null) {
            gmInfo_ = new global::GmInfoPb();
          }
          input.ReadMessage(gmInfo_);
          break;
        }
      }
    }
  }

}

#endregion


#endregion Designer generated code
