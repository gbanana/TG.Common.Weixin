﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TG.Common.Weixin.Qy.Datas
{
    public class GetMemberResult : JsonResult
    {
        /// <summary>
        /// 员工UserID 
        /// </summary>
        public string userid { get; set; }
        /// <summary>
        /// 成员名称
        /// </summary>
        public string name { get; set; }
        /// <summary>
        /// 成员所属部门id列表
        /// </summary>
        public int[] department { get; set; }
        /// <summary>
        /// 职位信息
        /// </summary>
        public string position { get; set; }
        /// <summary>
        /// 手机号码
        /// </summary>
        public string mobile { get; set; }

        /// <summary>
        /// 性别。gender=0表示男，=1表示女 
        /// </summary>
        public int gender { get; set; }

        //最新接口去除了以下属性
        /// <summary>
        /// 办公电话 
        /// </summary>
        //public string tel { get; set; }

        /// <summary>
        /// 邮箱
        /// </summary>
        public string email { get; set; }
        /// <summary>
        /// 微信号
        /// </summary>
        public string weixinid { get; set; }
        /// <summary>
        /// 头像url。注：小图将url最后的"/0"改成"/64"
        /// </summary>
        public string avatar { get; set; }
        /// <summary>
        /// 关注状态: 1=已关注，2=已冻结，4=未关注 
        /// </summary>
        public int status { get; set; }
        /// <summary>
        /// 扩展属性
        /// </summary>
        public Extattr extattr { get; set; }
        //public Dictionary<string, string> extattr { get; set; }

    }

    public class GetDepartmentMemberResult : JsonResult
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        public List<UserList_Simple> userlist { get; set; }
    }

    public class UserList_Simple
    {
        /// <summary>
        /// 员工UserID
        /// </summary>
        public string userid { get; set; }
        /// <summary>
        /// 成员名称
        /// </summary>
        public string name { get; set; }
    }

    /// <summary>
    /// 扩展属性
    /// </summary>
    public class Extattr
    {
        public List<Attr> attrs { get; set; }
        public string this[string name]
        {
            get
            {
                var v = attrs.FirstOrDefault(q => q.name == name);
                if (v == null)
                {
                    return null;
                }
                return v.value;
            }
        }

    }

    public class Attr
    {
        public string name { get; set; }
        public string value { get; set; }
    }

    /// <summary>
    /// 获取部门成员(详情)返回结果
    /// </summary>
    public class GetDepartmentMemberInfoResult : JsonResult
    {
        /// <summary>
        /// 成员列表
        /// </summary>
        public List<GetMemberResult> userlist { get; set; }
    }

    public class InviteMemberResult : JsonResult
    {
        /// <summary>
        /// 1:微信邀请 2.邮件邀请
        /// </summary>
        public int type { get; set; }
    }
}
