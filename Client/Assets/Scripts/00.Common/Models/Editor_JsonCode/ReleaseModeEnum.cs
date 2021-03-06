//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace editor.cfg
{
    /// <summary>
    /// 技能释放模式
    /// </summary>
    public static partial class ReleaseModeEnum
    {
        public static readonly Bright.Config.EditorEnumItemInfo None = new Bright.Config.EditorEnumItemInfo("None", "", 0, "无");
        public static readonly Bright.Config.EditorEnumItemInfo Click = new Bright.Config.EditorEnumItemInfo("Click", "", 1, "点击直接释放");
        public static readonly Bright.Config.EditorEnumItemInfo Position = new Bright.Config.EditorEnumItemInfo("Position", "", 2, "根据位置释放");
        public static readonly Bright.Config.EditorEnumItemInfo Direction = new Bright.Config.EditorEnumItemInfo("Direction", "", 3, "根据方向释放");

        private static readonly System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> __items = new System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo>
        {
            None,
            Click,
            Position,
            Direction,
        };

        public static System.Collections.Generic.List<Bright.Config.EditorEnumItemInfo> GetItems() => __items;

        public static Bright.Config.EditorEnumItemInfo GetByName(string name)
        {
            return __items.Find(c => c.Name == name);
        }

        public static Bright.Config.EditorEnumItemInfo GetByNameOrAlias(string name)
        {
            return __items.Find(c => c.Name == name || c.Alias == name);
        }

        public static Bright.Config.EditorEnumItemInfo GetByValue(int value)
        {
            return __items.Find(c => c.Value == value);
        }
    }
}
