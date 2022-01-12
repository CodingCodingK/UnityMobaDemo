using PEMath;

public class ArthurMarkBuffCfg : BuffCfg
{
    public int damagePct;
}

public class ArthurMarkBuff : Buff
{
    PEInt damagePct;
    MainLogicUnit target;
    
    public ArthurMarkBuff(MainLogicUnit source, MainLogicUnit owner, Skill skill, int buffId, object[] args = null) : base(source, owner, skill, buffId, args)
    {
    }
    
    public override void LogicInit() {
        base.LogicInit();

        ArthurMarkBuffCfg ambc = cfg as ArthurMarkBuffCfg;
        damagePct = ambc.damagePct;
        target = skill.lockTarget;
    }
    
    protected override void Start() {
        base.Start();
        target.OnHurt += GetHurt;
    }

    void GetHurt() {
        target.GetDamageByBuff(damagePct / 100 * target.ud.unitCfg.hp, this, false);
    }

    protected override void End() {
        base.End();
        target.OnHurt -= GetHurt;
    }
}