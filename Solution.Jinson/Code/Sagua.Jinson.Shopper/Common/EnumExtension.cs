using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Sagua.Jinson.Shopper.Common
{
    public static class EnumExtension
    {
        public static string GetDescription(this Enum enumObj)
        {
            if (enumObj == null)
                return null;
            string rv = enumObj.ToString();
             
                FieldInfo fieldInfo = enumObj.GetType().GetField(enumObj.ToString());
                var attribArray = Attribute.GetCustomAttributes(fieldInfo, typeof(DisplayAttribute), false);
                rv = enumObj.ToString();
                if (attribArray.Any())
                {
                    var att = attribArray[0] as DisplayAttribute;
                    rv = att != null ? att.Name  : enumObj.ToString();
                }
            
            return rv;
        }
    }
}
