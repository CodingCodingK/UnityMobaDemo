//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Bright.Serialization;

namespace proto.HOKProtocol
{

    public  sealed class RspBattleEnd :  Bright.Serialization.BeanBase 
    {
        public RspBattleEnd()
        {
        }

        public RspBattleEnd(Bright.Common.NotNullInitialization _) 
        {
        }

        public static void SerializeRspBattleEnd(ByteBuf _buf, RspBattleEnd x)
        {
            x.Serialize(_buf);
        }

        public static RspBattleEnd DeserializeRspBattleEnd(ByteBuf _buf)
        {
            var x = new HOKProtocol.RspBattleEnd();
            x.Deserialize(_buf);
            return x;
        }


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
        }

        public override void Deserialize(ByteBuf _buf)
        {
        }

        public override string ToString()
        {
            return "HOKProtocol.RspBattleEnd{ "
            + "}";
        }
    }

}
