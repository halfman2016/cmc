using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("orgs")]
    public partial class orgs
    {
           public orgs(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idorgs {get;set;}

           /// <summary>
           /// Desc:名称
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:机构代码	
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string code {get;set;}

           /// <summary>
           /// Desc:地址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string addr {get;set;}

    }
}
