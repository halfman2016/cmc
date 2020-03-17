using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("forceins")]
    public partial class forceins
    {
           public forceins(){

            this.deathinde =Convert.ToInt32("11000");
            this.medinde =Convert.ToInt32("10000");
            this.proinde =Convert.ToInt32("2000");
            this.nrdeathinde =Convert.ToInt32("11000");
            this.nrmedinde =Convert.ToInt32("1000");
            this.nrproinde =Convert.ToInt32("100");
            this.dispute =Convert.ToString("诉讼");
            this.paypy =0;
            this.lpf =0;

           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idInsurances {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int cars_idcars {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int insclass_idinsclass {get;set;}

           /// <summary>
           /// Desc:死亡伤残赔偿限额
           /// Default:11000
           /// Nullable:True
           /// </summary>           
           public int? deathinde {get;set;}

           /// <summary>
           /// Desc:医疗费用赔偿限额
           /// Default:10000
           /// Nullable:True
           /// </summary>           
           public int? medinde {get;set;}

           /// <summary>
           /// Desc:财产损失赔偿限额
           /// Default:2000
           /// Nullable:True
           /// </summary>           
           public int? proinde {get;set;}

           /// <summary>
           /// Desc:无责任死亡伤残赔偿限额
           /// Default:11000
           /// Nullable:True
           /// </summary>           
           public int? nrdeathinde {get;set;}

           /// <summary>
           /// Desc:无责任医疗费用赔偿限额
           /// Default:1000
           /// Nullable:True
           /// </summary>           
           public int? nrmedinde {get;set;}

           /// <summary>
           /// Desc:无责任财产损失赔偿限额
           /// Default:100
           /// Nullable:True
           /// </summary>           
           public int? nrproinde {get;set;}

           /// <summary>
           /// Desc:保费
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? premium {get;set;}

           /// <summary>
           /// Desc:保险期间自
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? startdate {get;set;}

           /// <summary>
           /// Desc:浮动比率
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? floatratio {get;set;}

           /// <summary>
           /// Desc:至
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? enddate {get;set;}

           /// <summary>
           /// Desc:争议解决方式
           /// Default:诉讼
           /// Nullable:True
           /// </summary>           
           public string dispute {get;set;}

           /// <summary>
           /// Desc:当年应缴
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? payty {get;set;}

           /// <summary>
           /// Desc:往年补缴
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public float? paypy {get;set;}

           /// <summary>
           /// Desc:滞纳金
           /// Default:0
           /// Nullable:True
           /// </summary>           
           public float? lpf {get;set;}

           /// <summary>
           /// Desc:合计
           /// Default:
           /// Nullable:True
           /// </summary>           
           public float? ttax {get;set;}

           /// <summary>
           /// Desc:签单日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? signdate {get;set;}

           /// <summary>
           /// Desc:核保人
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string underwriting {get;set;}

           /// <summary>
           /// Desc:制单
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string Manufacturing {get;set;}

           /// <summary>
           /// Desc:经办
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string handle {get;set;}

           /// <summary>
           /// Desc:保单号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string ponum {get;set;}

    }
}
