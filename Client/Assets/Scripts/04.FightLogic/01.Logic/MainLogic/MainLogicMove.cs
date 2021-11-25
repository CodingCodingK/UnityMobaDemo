﻿/****************************************************
    文件：MainLogicMove.cs
    作者：CodingCodingK
    博客：CodingCodingK.github.io
    邮箱：2470939431@qq.com
    日期：#DATE#
    功能：Unknown
*****************************************************/

using System.Collections;
using System.Collections.Generic;
using HOKProtocol;
using PEMath;
using PEPhysx;

/// <summary>
/// MainLogicMove
/// </summary>
public partial class MainLogicUnit
{
    private PEVector3 _inputDir;
    /// UI输入方向
    public PEVector3 InputDir
    {
        private set
        {
            _inputDir = value;
        }
        get
        {
            return _inputDir;
        }
    }
    
    /// 战斗单位物理碰撞器
    public PECylinderCollider collider;
    /// 环境碰撞体
    private List<PEColliderBase> envColliList;
    
    void InitMove()
    {
        LogicPos = ud.bornPos;
        moveSpeedBase = ud.unitCfg.moveSpeed;
        LogicMoveSpeed = ud.unitCfg.moveSpeed;
        envColliList = BattleSys.Instance.GetEnvColliders();

        collider = new PECylinderCollider(ud.unitCfg.colliCfg)
        {
            mPos = LogicPos,
        };


    }
    
    void TickMove()
    {
        // InputDir:UI输入的数据
        PEVector3 moveDir = InputDir;
        // 预测更新Collider = 方向 * 速度 * 时间
        collider.mPos += moveDir * LogicMoveSpeed * (PEInt) Configs.ClientLogicFromDeltaSec;
        // adj:位置矫正数据
        PEVector3 adj = PEVector3.zero;
        // 用定点数运算出碰撞结果,这块也是跑在服务器上的?
        collider.CalcCollidersInteraction(envColliList,ref moveDir,ref adj);
        if (LogicDir != moveDir)
        {
            LogicDir = moveDir;
        }

        if (LogicDir != PEVector3.zero)
        {
            LogicPos = collider.mPos + adj;
        }

        collider.mPos = LogicPos;
        
        
    }
    
    void UnInitMove()
    {
        
    }

    public void InputMoveKey(PEVector3 dir)
    {
        InputDir = dir;
    }
}
