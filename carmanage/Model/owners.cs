using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("owners")]
    public partial class owners
    {
           public owners(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idowners {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? orgs_idorgs {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:True
           /// </summary>           
           public int? people_idpeople {get;set;}

    }
}
