//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using Bright.Serialization;
using System.Collections.Generic;



namespace cfg
{

public sealed partial class StunBuffCfg_DynamicTime :  BuffCfg 
{
    public StunBuffCfg_DynamicTime(ByteBuf _buf)  : base(_buf) 
    {
        minStunTime = _buf.ReadInt();
        maxStunTime = _buf.ReadInt();
        PostInit();
    }

    public static StunBuffCfg_DynamicTime DeserializeStunBuffCfg_DynamicTime(ByteBuf _buf)
    {
        return new StunBuffCfg_DynamicTime(_buf);
    }

    public int minStunTime { get; private set; }
    public int maxStunTime { get; private set; }

    public const int __ID__ = -722227164;
    public override int GetTypeId() => __ID__;

    public override void Resolve(Dictionary<string, object> _tables)
    {
        base.Resolve(_tables);
        PostResolve();
    }

    public override void TranslateText(System.Func<string, string, string> translator)
    {
        base.TranslateText(translator);
    }

    public override string ToString()
    {
        return "{ "
        + "buffId:" + buffId + ","
        + "buffName:" + buffName + ","
        + "buffType:" + buffType + ","
        + "attacher:" + attacher + ","
        + "staticPosType:" + staticPosType + ","
        + "impacter:" + impacter + ","
        + "buffDelay:" + buffDelay + ","
        + "buffInterval:" + buffInterval + ","
        + "buffDuration:" + buffDuration + ","
        + "buffAudio:" + buffAudio + ","
        + "buffEffect:" + buffEffect + ","
        + "hitTickAudio:" + hitTickAudio + ","
        + "effectDestoryExtend:" + effectDestoryExtend + ","
        + "minStunTime:" + minStunTime + ","
        + "maxStunTime:" + maxStunTime + ","
        + "}";
    }
    
    partial void PostInit();
    partial void PostResolve();
}

}
