﻿using System;
using System.Collections.Generic;
using PENet;

/// <summary>
/// 网络通信数据协议
/// </summary>
namespace HOKProtocol
{
    [Serializable]
    public class GameMsg : KCPMsg
	{
        public CMD cmd;
        public ErrorCode err;
		public ReqLogin reqLogin;
		public RspLogin rspLogin;
		public ReqMatch reqMatch;
		public RspMatch rspMatch;
	}

    #region 登陆相关

    /// <summary>
    /// 登录请求
    /// </summary>
    [Serializable]
    public class ReqLogin
    {
        public string acct { get; set; }
        public string pass { get; set; }
    }

    /// <summary>
    /// 登录回应
    /// </summary>
    [Serializable]
    public class RspLogin
    {
        public PlayerData playerData;
    }

    /// <summary>
    /// 重命名请求
    /// </summary>
    [Serializable]
    public class ReqRename
    {
        public string name { get; set; }
    }

    /// <summary>
    /// 重命名回应
    /// </summary>
    [Serializable]
    public class RspRename
    {
        public string name { get; set; }
    }
    #endregion


    #region 匹配确认相关

    /// <summary>
    /// 匹配请求
    /// </summary>
    [Serializable]
    public class ReqMatch
    {
        /// <summary>
        /// 匹配类型
        /// </summary>
        public PvpEnum pvpEnum;
    }

    /// <summary>
    /// 匹配回应
    /// </summary>
    [Serializable]
    public class RspMatch
    {
        /// <summary>
        /// 预计等待时间
        /// </summary>
        public int preTime;
    }

    #endregion

    /// <summary>
	/// 用户信息
	/// </summary>
	[Serializable]
    public class PlayerData
    {
        public int id { get; set; }
        public string name { get; set; }
        public int level { get; set; }
        public int exp { get; set; }
        public int coin { get; set; }
        public int diamond { get; set; }
        public int ticket { get; set; }
        public List<HeroSelectData> heroSelectData;
    }

    [Serializable]
    public class HeroSelectData
    {
        public int heroID { get; set; }
       
        //已拥有
        //本周限免
    }


    /// <summary>
    /// 匹配类型
    /// </summary>
    public enum PvpEnum
    {
        None = 0,
        _1V1 = 1,
        _2V2 = 2,
        _5V5 = 3,

    }

    /// <summary>
    /// Command协议常数
    /// </summary>
    public enum ErrorCode
    {
        None = 0,

        /// <summary>
        /// 服务端数据异常
        /// </summary>
        ServerDataError,
        ClientDataError,

        /// <summary>
        /// 更新数据库出错
        /// </summary>
        UpdateDBError,

        // 登录相关

        /// <summary>
        /// 账号已登陆
        /// </summary>
        AccountIsOnline,

        /// <summary>
        /// 密码错误
        /// </summary>
        WrongPass,

        /// <summary>
        /// 名字已存在
        /// </summary>
        NameExisted,

        LackLevel,
        LackCoin,
        LackCrystal,
        LackDiamond,
        LackPower,

        TaskError,

    }

    /// <summary>
    /// Command协议常数
    /// </summary>
    public enum CMD
    {
        None = 0,
        // 登录相关
        ReqLogin = 101,
        RspLogin = 102,

        //匹配
        ReqMatch = 103,
        RspMatch = 104,




    }

   

}