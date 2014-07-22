using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace Sagua.Jinson.Global.Domain
{


    public enum ShopType
    {
        [Display(Name="淘宝")]
        Taobao,

        [Display(Name = "拍拍")]
        Paipai,

        [Display(Name = "京东")]
        Jindon
    }
}
