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

    public  sealed class RspBagItem :  Bright.Serialization.BeanBase 
    {
        public RspBagItem()
        {
        }

        public RspBagItem(Bright.Common.NotNullInitialization _) 
        {
            updatedPlayerData = new HOKProtocol.PlayerData();
        }

        public static void SerializeRspBagItem(ByteBuf _buf, RspBagItem x)
        {
            x.Serialize(_buf);
        }

        public static RspBagItem DeserializeRspBagItem(ByteBuf _buf)
        {
            var x = new HOKProtocol.RspBagItem();
            x.Deserialize(_buf);
            return x;
        }

         public HOKProtocol.PlayerData updatedPlayerData;

         public int usedItem;


        public const int __ID__ = 0;
        public override int GetTypeId() => __ID__;

        public override void Serialize(ByteBuf _buf)
        {
            HOKProtocol.PlayerData.SerializePlayerData(_buf, updatedPlayerData);
            _buf.WriteInt(usedItem);
        }

        public override void Deserialize(ByteBuf _buf)
        {
            updatedPlayerData = HOKProtocol.PlayerData.DeserializePlayerData(_buf);
            usedItem = _buf.ReadInt();
        }

        public override string ToString()
        {
            return "HOKProtocol.RspBagItem{ "
            + "updatedPlayerData:" + updatedPlayerData + ","
            + "usedItem:" + usedItem + ","
            + "}";
        }
    }

}
