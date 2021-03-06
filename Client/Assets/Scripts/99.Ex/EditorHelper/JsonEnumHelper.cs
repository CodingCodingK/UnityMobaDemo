using System.Linq;
using Sirenix.OdinInspector;

namespace editor.cfg
{
    public class JsonEnumHelper
    {
        public static System.Collections.IEnumerable BuffTypeEnum_List;
        public static System.Collections.IEnumerable AttachTypeEnum_List;
        public static System.Collections.IEnumerable StaticPosTypeEnum_List;
        public static System.Collections.IEnumerable TargetTeamEnum_List;
        public static System.Collections.IEnumerable SelectRuleEnum_List;
        public static System.Collections.IEnumerable UnitTypeEnum_List;
        public static System.Collections.IEnumerable ReleaseModeEnum_List;
        public static System.Collections.IEnumerable BulletTypeEnum_List;

        static JsonEnumHelper()
        {
            var buffTypeEnums = new ValueDropdownList<string>();
            buffTypeEnums.AddRange(editor.cfg.BuffTypeEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            BuffTypeEnum_List = buffTypeEnums;
            
            var attachTypeEnums = new ValueDropdownList<string>();
            attachTypeEnums.AddRange(editor.cfg.AttachTypeEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            AttachTypeEnum_List = attachTypeEnums;
            
            var staticPosTypeEnums = new ValueDropdownList<string>();
            staticPosTypeEnums.AddRange(editor.cfg.StaticPosTypeEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            StaticPosTypeEnum_List = staticPosTypeEnums;
            
            var targetTeamEnum_List = new ValueDropdownList<string>();
            targetTeamEnum_List.AddRange(editor.cfg.TargetTeamEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            TargetTeamEnum_List = targetTeamEnum_List;
            
            var selectRuleEnum_List = new ValueDropdownList<string>();
            selectRuleEnum_List.AddRange(editor.cfg.SelectRuleEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            SelectRuleEnum_List = selectRuleEnum_List;
            
            var unitTypeEnum_List = new ValueDropdownList<string>();
            unitTypeEnum_List.AddRange(editor.cfg.UnitTypeEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            UnitTypeEnum_List = unitTypeEnum_List;
            
            var releaseModeEnum_List = new ValueDropdownList<string>();
            releaseModeEnum_List.AddRange(editor.cfg.ReleaseModeEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            ReleaseModeEnum_List = releaseModeEnum_List;
            
            var bulletTypeEnum_List = new ValueDropdownList<string>();
            bulletTypeEnum_List.AddRange(editor.cfg.BulletTypeEnum.GetItems().Select(o =>
            {
                return new ValueDropdownItem<string>(o.Name, o.Name);
            }).ToList());
            BulletTypeEnum_List = bulletTypeEnum_List;
        }

        // public static System.Collections.IEnumerable GetVal()
        // {
        //     return BuffTypeEnum_List.GetEnumerator()
        // }
    }
}