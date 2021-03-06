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
public sealed partial class UnitInfoCfg :  Bright.Config.EditorBeanBase 
{
    
    public UnitInfoCfg()
    {
            unitName = "";
            resName = "";
            colliderType = "Hero";
            pasvBuff = System.Array.Empty<int>();
            skillArr = System.Array.Empty<int>();
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["unitId"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  unitId = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["unitName"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  unitName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["resName"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  resName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["hp"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  hp = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["def"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  def = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["moveSpeed"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  moveSpeed = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["colliderType"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  colliderType = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["pasvBuff"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n = _fieldJson.Count; pasvBuff = new int[_n]; int _index=0; foreach(SimpleJSON.JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  pasvBuff[_index++] = __v; }  
            }
        }
        
        { 
            var _fieldJson = _json["skillArr"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n = _fieldJson.Count; skillArr = new int[_n]; int _index=0; foreach(SimpleJSON.JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  skillArr[_index++] = __v; }  
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["unitId"] = new JSONNumber(unitId);
        }
        {

            if (unitName == null) { throw new System.ArgumentNullException(); }
            _json["unitName"] = new JSONString(unitName);
        }
        {

            if (resName == null) { throw new System.ArgumentNullException(); }
            _json["resName"] = new JSONString(resName);
        }
        {
            _json["hp"] = new JSONNumber(hp);
        }
        {
            _json["def"] = new JSONNumber(def);
        }
        {
            _json["moveSpeed"] = new JSONNumber(moveSpeed);
        }
        {
            _json["colliderType"] = new JSONString(colliderType);
        }
        {

            if (pasvBuff == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in pasvBuff) { __cjson["null"] = new JSONNumber(_e); } _json["pasvBuff"] = __cjson; }
        }
        {

            if (skillArr == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in skillArr) { __cjson["null"] = new JSONNumber(_e); } _json["skillArr"] = __cjson; }
        }
    }

    public static UnitInfoCfg LoadJsonUnitInfoCfg(SimpleJSON.JSONNode _json)
    {
        UnitInfoCfg obj = new UnitInfoCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonUnitInfoCfg(UnitInfoCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    [ShowInInspector, VerticalGroup("????????????")]public int unitId { get; set; }

    /// <summary>
    /// ???????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("????????????")]public string unitName { get; set; }

    /// <summary>
    /// ??????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public string resName { get; set; }

    [ShowInInspector, VerticalGroup("??????")]public int hp { get; set; }

    [ShowInInspector, VerticalGroup("??????")]public int def { get; set; }

    [ShowInInspector, VerticalGroup("??????")]public int moveSpeed { get; set; }

    /// <summary>
    /// ???????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")][ValueDropdown("UnitTypeEnum_List", DropdownWidth = 250)]public string colliderType { get; set; }
    private static System.Collections.IEnumerable UnitTypeEnum_List = JsonEnumHelper.UnitTypeEnum_List;

    /// <summary>
    /// ????????????buff
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]
    public int[] pasvBuff { get; set; }

    /// <summary>
    /// ????????????buff
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]
    public int[] skillArr { get; set; }

}
}
