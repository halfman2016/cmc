using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("testrec")]
    public partial class testrec
    {
           public testrec(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idtestrec {get;set;}

           /// <summary>
           /// Desc:检验日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? testdate {get;set;}

           /// <summary>
           /// Desc:检验有效期
           /// Default:
           /// Nullable:False
           /// </summary>           
           public DateTime exdate {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int cars_idcars {get;set;}

    }
}
