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
public sealed partial class SkillCfg :  Bright.Config.EditorBeanBase 
{
    public SkillCfg()
    {
            iconName = "";
            aniName = "";
            audio_start = "";
            audio_work = "";
            audio_hit = "";
            buffIdArr = System.Array.Empty<int>();
            releaseMode = "None";
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        { 
            var _fieldJson = _json["skillId"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  skillId = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["iconName"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  iconName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["aniName"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  aniName = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["audio_start"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  audio_start = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["audio_work"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  audio_work = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["audio_hit"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  audio_hit = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["cdTime"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  cdTime = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["spellTime"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  spellTime = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["skillTime"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  skillTime = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["damage"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsNumber) { throw new SerializationException(); }  damage = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["buffIdArr"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsArray) { throw new SerializationException(); } int _n = _fieldJson.Count; buffIdArr = new int[_n]; int _index=0; foreach(SimpleJSON.JSONNode __e in _fieldJson.Children) { int __v;  if(!__e.IsNumber) { throw new SerializationException(); }  __v = __e;  buffIdArr[_index++] = __v; }  
            }
        }
        
        { 
            var _fieldJson = _json["isNormalAttack"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsBoolean) { throw new SerializationException(); }  isNormalAttack = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["releaseMode"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsString) { throw new SerializationException(); }  releaseMode = _fieldJson;
            }
        }
        
        { 
            var _fieldJson = _json["targetCfg"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  targetCfg = TargetCfg.LoadJsonTargetCfg(_fieldJson);
            }
        }
        
        { 
            var _fieldJson = _json["bulletCfg"];
            if (_fieldJson != null)
            {
                if(!_fieldJson.IsObject) { throw new SerializationException(); }  bulletCfg = BulletCfg.LoadJsonBulletCfg(_fieldJson);
            }
        }
        
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        {
            _json["skillId"] = new JSONNumber(skillId);
        }
        {

            if (iconName == null) { throw new System.ArgumentNullException(); }
            _json["iconName"] = new JSONString(iconName);
        }
        {

            if (aniName == null) { throw new System.ArgumentNullException(); }
            _json["aniName"] = new JSONString(aniName);
        }
        {

            if (audio_start == null) { throw new System.ArgumentNullException(); }
            _json["audio_start"] = new JSONString(audio_start);
        }
        {

            if (audio_work == null) { throw new System.ArgumentNullException(); }
            _json["audio_work"] = new JSONString(audio_work);
        }
        {

            if (audio_hit == null) { throw new System.ArgumentNullException(); }
            _json["audio_hit"] = new JSONString(audio_hit);
        }
        {
            _json["cdTime"] = new JSONNumber(cdTime);
        }
        {
            _json["spellTime"] = new JSONNumber(spellTime);
        }
        {
            _json["skillTime"] = new JSONNumber(skillTime);
        }
        {
            _json["damage"] = new JSONNumber(damage);
        }
        {

            if (buffIdArr == null) { throw new System.ArgumentNullException(); }
            { var __cjson = new JSONArray(); foreach(var _e in buffIdArr) { __cjson["null"] = new JSONNumber(_e); } _json["buffIdArr"] = __cjson; }
        }
        {
            _json["isNormalAttack"] = new JSONBool(isNormalAttack);
        }
        {
            _json["releaseMode"] = new JSONString(releaseMode);
        }

        if (targetCfg != null)
        {
            { var __bjson = new JSONObject();  TargetCfg.SaveJsonTargetCfg(targetCfg, __bjson); _json["targetCfg"] = __bjson; }
        }

        if (bulletCfg != null)
        {
            { var __bjson = new JSONObject();  BulletCfg.SaveJsonBulletCfg(bulletCfg, __bjson); _json["bulletCfg"] = __bjson; }
        }
    }

    public static SkillCfg LoadJsonSkillCfg(SimpleJSON.JSONNode _json)
    {
        SkillCfg obj = new SkillCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonSkillCfg(SkillCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

    [ShowInInspector, VerticalGroup("????????????")]public int skillId { get; set; }

    /// <summary>
    /// ????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public string iconName { get; set; }

    /// <summary>
    /// ????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public string aniName { get; set; }

    /// <summary>
    /// ??????????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public string audio_start { get; set; }

    /// <summary>
    /// ??????????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public string audio_work { get; set; }

    /// <summary>
    /// ??????????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public string audio_hit { get; set; }

    /// <summary>
    /// CD?????? ms
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public int cdTime { get; set; }

    /// <summary>
    /// ????????????(??????) ms
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public int spellTime { get; set; }

    /// <summary>
    /// ??????????????????(??????+??????) ms,??????????????????????????????????????????????????????????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public int skillTime { get; set; }

    /// <summary>
    /// ??????????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public int damage { get; set; }

    /// <summary>
    /// ??????Buff
    /// </summary>
    [ShowInInspector, VerticalGroup("buff")]public int[] buffIdArr { get; set; }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")]public bool isNormalAttack { get; set; }

    /// <summary>
    /// ????????????
    /// </summary>
    [ShowInInspector, VerticalGroup("??????")][ValueDropdown("ReleaseModeEnum_List", DropdownWidth = 250)]public string releaseMode { get; set; }
    private static System.Collections.IEnumerable ReleaseModeEnum_List = JsonEnumHelper.ReleaseModeEnum_List;

    /// <summary>
    /// ??????????????????,null????????????????????????
    /// </summary>
    [ShowInInspector, TableColumnWidth(200), VerticalGroup("buff????????????")]public TargetCfg targetCfg { get; set; }

    /// <summary>
    /// ??????????????????????????????null
    /// </summary>
    [ShowInInspector, TableColumnWidth(200), VerticalGroup("??????")]public BulletCfg bulletCfg { get; set; }

}
}
