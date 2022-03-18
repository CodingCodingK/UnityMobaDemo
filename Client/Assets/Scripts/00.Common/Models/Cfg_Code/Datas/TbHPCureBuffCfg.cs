//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;

namespace cfg.Datas
{
   
public partial class TbHPCureBuffCfg
{
    private readonly Dictionary<int, HPCureBuffCfg> _dataMap;
    private readonly List<HPCureBuffCfg> _dataList;
    
    public TbHPCureBuffCfg(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, HPCureBuffCfg>();
        _dataList = new List<HPCureBuffCfg>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            HPCureBuffCfg _v;
            _v = HPCureBuffCfg.DeserializeHPCureBuffCfg(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.buffId, _v);
        }
        PostInit();
    }

    public Dictionary<int, HPCureBuffCfg> DataMap => _dataMap;
    public List<HPCureBuffCfg> DataList => _dataList;

    public HPCureBuffCfg GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public HPCureBuffCfg Get(int key) => _dataMap[key];
    public HPCureBuffCfg this[int key] => _dataMap[key];

    public void Resolve(Dictionary<string, object> _tables)
    {
        foreach(var v in _dataList)
        {
            v.Resolve(_tables);
        }
        PostResolve();
    }

    public void TranslateText(System.Func<string, string, string> translator)
    {
        foreach(var v in _dataList)
        {
            v.TranslateText(translator);
        }
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}