/**
 * Autogenerated by Thrift Compiler (0.9.3)
 *
 * DO NOT EDIT UNLESS YOU ARE SURE THAT YOU KNOW WHAT YOU ARE DOING
 *  @generated
 */
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.IO;
using Thrift;
using Thrift.Collections;
using System.Runtime.Serialization;
using Thrift.Protocol;
using Thrift.Transport;


#if !SILVERLIGHT
[Serializable]
#endif
public partial class TimRemoteRoom : TBase
{
  private TimError _error;
  private TimRoom _room;
  private Dictionary<string, string> _extraMap;

  /// <summary>
  /// 错误码
  /// </summary>
  public TimError Error
  {
    get
    {
      return _error;
    }
    set
    {
      __isset.error = true;
      this._error = value;
    }
  }

  /// <summary>
  /// 远程房间信息
  /// </summary>
  public TimRoom Room
  {
    get
    {
      return _room;
    }
    set
    {
      __isset.room = true;
      this._room = value;
    }
  }

  public Dictionary<string, string> ExtraMap
  {
    get
    {
      return _extraMap;
    }
    set
    {
      __isset.extraMap = true;
      this._extraMap = value;
    }
  }


  public Isset __isset;
  #if !SILVERLIGHT
  [Serializable]
  #endif
  public struct Isset {
    public bool error;
    public bool room;
    public bool extraMap;
  }

  public TimRemoteRoom() {
  }

  public void Read (TProtocol iprot)
  {
    iprot.IncrementRecursionDepth();
    try
    {
      TField field;
      iprot.ReadStructBegin();
      while (true)
      {
        field = iprot.ReadFieldBegin();
        if (field.Type == TType.Stop) { 
          break;
        }
        switch (field.ID)
        {
          case 1:
            if (field.Type == TType.Struct) {
              Error = new TimError();
              Error.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 2:
            if (field.Type == TType.Struct) {
              Room = new TimRoom();
              Room.Read(iprot);
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          case 3:
            if (field.Type == TType.Map) {
              {
                ExtraMap = new Dictionary<string, string>();
                TMap _map103 = iprot.ReadMapBegin();
                for( int _i104 = 0; _i104 < _map103.Count; ++_i104)
                {
                  string _key105;
                  string _val106;
                  _key105 = iprot.ReadString();
                  _val106 = iprot.ReadString();
                  ExtraMap[_key105] = _val106;
                }
                iprot.ReadMapEnd();
              }
            } else { 
              TProtocolUtil.Skip(iprot, field.Type);
            }
            break;
          default: 
            TProtocolUtil.Skip(iprot, field.Type);
            break;
        }
        iprot.ReadFieldEnd();
      }
      iprot.ReadStructEnd();
    }
    finally
    {
      iprot.DecrementRecursionDepth();
    }
  }

  public void Write(TProtocol oprot) {
    oprot.IncrementRecursionDepth();
    try
    {
      TStruct struc = new TStruct("TimRemoteRoom");
      oprot.WriteStructBegin(struc);
      TField field = new TField();
      if (Error != null && __isset.error) {
        field.Name = "error";
        field.Type = TType.Struct;
        field.ID = 1;
        oprot.WriteFieldBegin(field);
        Error.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (Room != null && __isset.room) {
        field.Name = "room";
        field.Type = TType.Struct;
        field.ID = 2;
        oprot.WriteFieldBegin(field);
        Room.Write(oprot);
        oprot.WriteFieldEnd();
      }
      if (ExtraMap != null && __isset.extraMap) {
        field.Name = "extraMap";
        field.Type = TType.Map;
        field.ID = 3;
        oprot.WriteFieldBegin(field);
        {
          oprot.WriteMapBegin(new TMap(TType.String, TType.String, ExtraMap.Count));
          foreach (string _iter107 in ExtraMap.Keys)
          {
            oprot.WriteString(_iter107);
            oprot.WriteString(ExtraMap[_iter107]);
          }
          oprot.WriteMapEnd();
        }
        oprot.WriteFieldEnd();
      }
      oprot.WriteFieldStop();
      oprot.WriteStructEnd();
    }
    finally
    {
      oprot.DecrementRecursionDepth();
    }
  }

  public override string ToString() {
    StringBuilder __sb = new StringBuilder("TimRemoteRoom(");
    bool __first = true;
    if (Error != null && __isset.error) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Error: ");
      __sb.Append(Error== null ? "<null>" : Error.ToString());
    }
    if (Room != null && __isset.room) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("Room: ");
      __sb.Append(Room== null ? "<null>" : Room.ToString());
    }
    if (ExtraMap != null && __isset.extraMap) {
      if(!__first) { __sb.Append(", "); }
      __first = false;
      __sb.Append("ExtraMap: ");
      __sb.Append(ExtraMap);
    }
    __sb.Append(")");
    return __sb.ToString();
  }

}
