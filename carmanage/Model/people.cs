using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("people")]
    public partial class people
    {
           public people(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idpeople {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:身份证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string code {get;set;}

           /// <summary>
           /// Desc:手机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string mobile {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? orgs_idorgs {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string addr {get;set;}

    }
}
