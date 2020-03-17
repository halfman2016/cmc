using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("drivers")]
    public partial class drivers
    {
           public drivers(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int iddriver {get;set;}

           /// <summary>
           /// Desc:姓名
           /// Default:
           /// Nullable:False
           /// </summary>           
           public string name {get;set;}

           /// <summary>
           /// Desc:驾驶证号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string licenseno {get;set;}

           /// <summary>
           /// Desc:发证日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? applydate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? people_idpeople {get;set;}

    }
}
