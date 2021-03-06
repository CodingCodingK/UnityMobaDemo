
using System.Collections;
using proto.HOKProtocol;
using UnityEngine;
using UnityEngine.UI;
using cfg;

/// 技能Button
public class SkillItem : WindowBase
{
    public Image imgCycle;
    public Image skillIcon;
    public Image imgCd;
    public Text txtCD;
    public Image imgPoint;
    public Image imgForbid;
    public Transform EffectRoot;

    private HeroView viewHero;

    private int skillIndex;
    private SkillCfg skillCfg;
    private float curtSelectRange = 0;
    /// 根据宽高比算出的最远技能点拖拽距离
    private float pointDis;
    private Vector2 startPos = Vector2.zero;
    
    public void InitSkillItem(SkillCfg skillCfg,int skillIndex)
    {
        SetActive(EffectRoot,false);
        InitWindow();

        viewHero = BattleSys.Instance.GetSelfHero().mainViewUnit as HeroView;

        this.skillIndex = skillIndex;
        this.skillCfg = skillCfg;
        if (skillCfg.targetCfg != null)
        {
            this.curtSelectRange = skillCfg.targetCfg.selectRange;
        }
        
        pointDis = Screen.height * 1.0f / ClientConfig.ScreenStandardHeight * ClientConfig.SkillOPDis;
        
        if (skillCfg.isNormalAttack == false)
        {
            SetSprite(skillIcon,"ResImages/PlayWnd/" + skillCfg.iconName);
            SetActive(imgCd,false);
            SetActive(txtCD,false);
            
            OnClickDown(skillIcon.gameObject, (evt, args) =>
            {
                startPos = evt.position;
                // 显示技能托盘与拖点
                SetActive(imgCycle,true);
                SetActive(imgPoint,true);
                ShowSkillAtkRange(true);
                if (skillCfg.releaseMode == ReleaseModeEnum.Position)
                {
                    // 通知场景中显示skill guide
                    viewHero.SetSkillGuide(skillIndex,true,ReleaseModeEnum.Position,Vector3.zero);
                }
                else if (skillCfg.releaseMode == ReleaseModeEnum.Direction)
                {
                    viewHero.SetSkillGuide(skillIndex,true,ReleaseModeEnum.Direction,Vector3.zero);
                }
            });
            
            OnDrag(skillIcon.gameObject, (evt, args) =>
            {
                #region UI映射
                
                Vector2 dir = evt.position - startPos;
                float len = dir.magnitude;
                if (len > pointDis)
                {
                    // 拖拽距离
                    Vector2 clampDir = Vector2.ClampMagnitude(dir, pointDis);
                    imgPoint.transform.position = startPos + clampDir;
                }
                else
                {
                    imgPoint.transform.position = evt.position;
                }
                
                #endregion

                #region 模型映射

                if (skillCfg.releaseMode == ReleaseModeEnum.Position)
                {
                    if (dir == Vector2.zero)
                    {
                        return;
                    }
                    // 从UI映射到地图
                    dir = BattleSys.Instance.SkillDisMultiplier * dir;
                    Vector2 clampDir = Vector2.ClampMagnitude(dir, skillCfg.targetCfg.selectRange);
                    Vector3 clampDirVector3 = new Vector3(clampDir.x, 0, clampDir.y);
                    clampDirVector3 = Quaternion.Euler(0, 45, 0) * clampDirVector3;// 这里的45度是相机偏移的45度
                    viewHero.SetSkillGuide(skillIndex,true,ReleaseModeEnum.Position,clampDirVector3);
                }
                else if (skillCfg.releaseMode == ReleaseModeEnum.Direction)
                {
                    Vector3 dirVector3 = new Vector3(dir.x, 0, dir.y);
                    dirVector3 = Quaternion.Euler(0, 45, 0) * dirVector3;// 这里的45度是相机偏移的45度
                    viewHero.SetSkillGuide(skillIndex,true,ReleaseModeEnum.Direction,dirVector3.normalized);
                }
                else
                {
                    this.Warn(skillCfg.releaseMode.ToString() + " 没有实现！");
                }

                // 显示技能取消
                if (len >= ClientConfig.SkillCancelDis)
                {
                    SetActive(GameRootResources.Instance().playWindow.imgCancelSkill);
                }
                else
                {
                    SetActive(GameRootResources.Instance().playWindow.imgCancelSkill,false);
                }
                #endregion
            });
            
            OnClickUp(skillIcon.gameObject, (evt, args) =>
            {
                this.Log("OnClickUp");
                Vector2 dir = evt.position - startPos;
                imgPoint.transform.position = startPos;
                SetActive(imgCycle,false);
                SetActive(imgPoint,false);
                
                SetActive(GameRootResources.Instance().playWindow.imgCancelSkill,false);
                ShowSkillAtkRange(false);

                if (dir.magnitude >= ClientConfig.SkillCancelDis)
                {
                    this.Log("取消技能施放 " + dir.magnitude + " " + ClientConfig.SkillCancelDis);
                    viewHero.DisableSkillGuide(skillIndex);
                    return;
                }

                if (skillCfg.releaseMode == ReleaseModeEnum.Click)
                {
                    this.Log("直接施放技能");
                    // 直接释放技能
                    viewHero.DisableSkillGuide(skillIndex);
                    ClickSkillItem();
                }
                else if (skillCfg.releaseMode == ReleaseModeEnum.Position)
                {
                    dir = BattleSys.Instance.SkillDisMultiplier * dir;
                    Vector2 clampDir = Vector2.ClampMagnitude(dir, skillCfg.targetCfg.selectRange);
                    viewHero.DisableSkillGuide(skillIndex);
                    Vector3 clampDirVector3 = new Vector3(clampDir.x, 0, clampDir.y);
                    clampDirVector3 = Quaternion.Euler(0, 45, 0) * clampDirVector3;// 这里的45度是相机偏移的45度
                    ClickSkillItem(clampDirVector3);
                }
                else if (skillCfg.releaseMode == ReleaseModeEnum.Direction)
                {
                    viewHero.DisableSkillGuide(skillIndex);
                    if (dir == Vector2.zero)
                    {
                        return;
                    }
                    
                    Vector3 dirVector3 = new Vector3(dir.x, 0, dir.y);
                    dirVector3 = Quaternion.Euler(0, 45, 0) * dirVector3;// 这里的45度是相机偏移的45度
                    ClickSkillItem(dirVector3.normalized);
                }
                else
                {
                    this.Warn("Skill release mode not exist.");
                }
                
                ShowEffect();
            });
            
        }
        else
        {
            // 普攻
            OnClickDown(skillIcon.gameObject, (evt, args) =>
            {
                ShowSkillAtkRange(true);
                ClickSkillItem();
            });
            
            OnClickUp(skillIcon.gameObject, (evt, args) =>
            {
                ShowSkillAtkRange(false);
                ShowEffect();
            });
        }
    }

    private Coroutine ct = null;
    /// <summary>
    /// 如果已经激活过了，就重新激活
    /// </summary>
    void ShowEffect()
    {
        if (ct != null)
        {
            StopCoroutine(ct);
            SetActive(EffectRoot,false);
        }
        SetActive(EffectRoot);
        if(gameObject.activeInHierarchy) {
            ct = StartCoroutine(DisableEffect());
        }
    }

    IEnumerator DisableEffect()
    {
        yield return new WaitForSeconds(0.5f);
        SetActive(EffectRoot,false);
    }

    private void ShowSkillAtkRange(bool state)
    {
        if (curtSelectRange > 0)
        {
            viewHero.SetAtkSkillRange(state,curtSelectRange);
        }
    }

    public bool CheckSkillId(int skillId)
    {
        return skillCfg.skillId == skillId;
    }

    public void EnterCDState(int cdTime)
    {
        int sec = cdTime / 1000;
        int ms = cdTime % 1000;
        CreateMonoTimer(
            (loopCount) => { SetText(txtCD, sec - loopCount); }, 
            1000,
            sec,
            (isDelay, loopPrg, allPrg) => { imgCd.fillAmount = 1 - allPrg;},
            () =>
            {
                SetActive(imgCd,false);
                SetActive(txtCD,false);
                audioSvc.PlayUIAudio("com_cd_ok");
                ShowEffect();
                skillIcon.raycastTarget = true;
            },
            ms
        );
        
        SetActive(imgCd);
        SetActive(txtCD);
        SetText(txtCD,sec);
        skillIcon.raycastTarget = false;
    }
    
    public void ClickSkillItem()
    {
        BattleSys.Instance.SendSkillKey(skillCfg.skillId,Vector3.zero);
    }
    
    /// 非指向技能
    public void ClickSkillItem(Vector3 vec)
    {
        BattleSys.Instance.SendSkillKey(skillCfg.skillId,vec);
    }
    
    public void SetForbidState(bool state)
    {
        SetActive(imgForbid,state);
    }

    public void RefreshImages(SkillCfg cfg)
    {
        if (!string.IsNullOrEmpty(cfg?.iconName))
        {
            SetSprite(skillIcon,"ResImages/PlayWnd/" + cfg.iconName);
        }
        
        if (cfg?.targetCfg != null)
        {
            curtSelectRange = cfg.targetCfg.selectRange;
        }
    }
}