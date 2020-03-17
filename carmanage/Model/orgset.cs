using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("orgset")]
    public partial class orgset
    {
           public orgset(){

            this.days =Convert.ToInt32("20");

           }
           /// <summary>
           /// Desc:临期提醒
           /// Default:20
           /// Nullable:True
           /// </summary>           
           public int? days {get;set;}

           /// <summary>
           /// Desc:是否开通短信
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string sms {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int orgs_idorgs {get;set;}

    }
}
