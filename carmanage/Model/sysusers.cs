using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("sysusers")]
    public partial class sysusers
    {
           public sysusers(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idsysuser {get;set;}

           /// <summary>
           /// Desc:用户名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string username {get;set;}

           /// <summary>
           /// Desc:密码
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string password {get;set;}

           /// <summary>
           /// Desc:建立日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? createdate {get;set;}

           /// <summary>
           /// Desc:角色
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string role {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? people_idpeople {get;set;}

    }
}
