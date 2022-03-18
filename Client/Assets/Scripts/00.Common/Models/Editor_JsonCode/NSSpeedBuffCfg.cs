//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using Bright.Serialization;
using System.Collections.Generic;
using SimpleJSON;
using Sirenix.OdinInspector;


namespace editor.cfg
{

    [Serializable]
public sealed partial class NSSpeedBuffCfg :  BuffCfg 
{
    public NSSpeedBuffCfg()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
        { 
            var _fieldJson = _json["moveSpeedPer"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  moveSpeedPer = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["atkSpeedPer"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  atkSpeedPer = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["resetTime"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  resetTime = _fieldJson;
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
        {
            _json["moveSpeedPer"] = new JSONNumber(moveSpeedPer);
        }
        {
            _json["atkSpeedPer"] = new JSONNumber(atkSpeedPer);
        }
        {
            _json["resetTime"] = new JSONNumber(resetTime);
        }
    }

    public static NSSpeedBuffCfg LoadJsonNSSpeedBuffCfg(SimpleJSON.JSONNode _json)
    {
        NSSpeedBuffCfg obj = new NSSpeedBuffCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonNSSpeedBuffCfg(NSSpeedBuffCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    /// <summary>
    /// 移动速度改变百分比
    /// </summary>
    [ShowInInspector, VerticalGroup("特殊")]public int moveSpeedPer { get; set; }

    /// <summary>
    /// 攻击速度改变百分比
    /// </summary>
    [ShowInInspector, VerticalGroup("特殊")]public int atkSpeedPer { get; set; }

    /// <summary>
    /// 速度改变持续时间
    /// </summary>
    [ShowInInspector, VerticalGroup("特殊")]public int resetTime { get; set; }

}
}