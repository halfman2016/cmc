using System;
using System.Linq;
using System.Text;
using SqlSugar;

namespace carmanage.Model
{
    ///<summary>
    ///
    ///</summary>
    [SugarTable("cars")]
    public partial class cars
    {
           public cars(){


           }
           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true,IsIdentity=true)]
           public int idcars {get;set;}

           /// <summary>
           /// Desc:号牌
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carplate {get;set;}

           /// <summary>
           /// Desc:车辆类型
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string cartype {get;set;}

           /// <summary>
           /// Desc:住址
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string caraddress {get;set;}

           /// <summary>
           /// Desc:使用性质 非营运
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string caruae {get;set;}

           /// <summary>
           /// Desc:品牌型号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carbrand {get;set;}

           /// <summary>
           /// Desc:车辆vin码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carvin {get;set;}

           /// <summary>
           /// Desc:发动机号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carengine {get;set;}

           /// <summary>
           /// Desc:注册日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? regdate {get;set;}

           /// <summary>
           /// Desc:发证日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? applydate {get;set;}

           /// <summary>
           /// Desc:档案编号
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string filenum {get;set;}

           /// <summary>
           /// Desc:核定载人数
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carcarry {get;set;}

           /// <summary>
           /// Desc:总质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carmass {get;set;}

           /// <summary>
           /// Desc:核定载重量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carcarrymass {get;set;}

           /// <summary>
           /// Desc:装备质量
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string caremass {get;set;}

           /// <summary>
           /// Desc:外观尺寸
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carappeara {get;set;}

           /// <summary>
           /// Desc:强制报废日期
           /// Default:
           /// Nullable:True
           /// </summary>           
           public DateTime? carscrapdate {get;set;}

           /// <summary>
           /// Desc:汽油/柴油
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string carfule {get;set;}

           /// <summary>
           /// Desc:证件号码
           /// Default:
           /// Nullable:True
           /// </summary>           
           public string papercode {get;set;}

           /// <summary>
           /// Desc:
           /// Default:
           /// Nullable:False
           /// </summary>           
           [SugarColumn(IsPrimaryKey=true)]
           public int owners_idowners {get;set;}

    }
}
