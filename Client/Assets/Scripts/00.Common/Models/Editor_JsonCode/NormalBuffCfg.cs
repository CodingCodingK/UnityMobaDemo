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



namespace editor.cfg
{

    [Serializable]
public sealed partial class NormalBuffCfg :  BuffCfg 
{
    public NormalBuffCfg()
    {
    }

    public override void LoadJson(SimpleJSON.JSONObject _json)
    {
        base.LoadJson(_json);
    }

    public override void SaveJson(SimpleJSON.JSONObject _json)
    {        
        base.SaveJson(_json);
    }

    public static NormalBuffCfg LoadJsonNormalBuffCfg(SimpleJSON.JSONNode _json)
    {
        NormalBuffCfg obj = new NormalBuffCfg();
        obj.LoadJson((SimpleJSON.JSONObject)_json);
        return obj;
    }
        
    public static void SaveJsonNormalBuffCfg(NormalBuffCfg _obj, SimpleJSON.JSONNode _json)
    {
        _obj.SaveJson((SimpleJSON.JSONObject)_json);
    }

}
}