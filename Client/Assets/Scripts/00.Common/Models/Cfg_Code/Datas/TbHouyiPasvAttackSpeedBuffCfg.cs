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
   
public partial class TbHouyiPasvAttackSpeedBuffCfg
{
    private readonly Dictionary<int, HouyiPasvAttackSpeedBuffCfg> _dataMap;
    private readonly List<HouyiPasvAttackSpeedBuffCfg> _dataList;
    
    public TbHouyiPasvAttackSpeedBuffCfg(ByteBuf _buf)
    {
        _dataMap = new Dictionary<int, HouyiPasvAttackSpeedBuffCfg>();
        _dataList = new List<HouyiPasvAttackSpeedBuffCfg>();
        
        for(int n = _buf.ReadSize() ; n > 0 ; --n)
        {
            HouyiPasvAttackSpeedBuffCfg _v;
            _v = HouyiPasvAttackSpeedBuffCfg.DeserializeHouyiPasvAttackSpeedBuffCfg(_buf);
            _dataList.Add(_v);
            _dataMap.Add(_v.buffId, _v);
        }
        PostInit();
    }

    public Dictionary<int, HouyiPasvAttackSpeedBuffCfg> DataMap => _dataMap;
    public List<HouyiPasvAttackSpeedBuffCfg> DataList => _dataList;

    public HouyiPasvAttackSpeedBuffCfg GetOrDefault(int key) => _dataMap.TryGetValue(key, out var v) ? v : null;
    public HouyiPasvAttackSpeedBuffCfg Get(int key) => _dataMap[key];
    public HouyiPasvAttackSpeedBuffCfg this[int key] => _dataMap[key];

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