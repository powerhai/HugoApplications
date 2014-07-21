using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Markup;

namespace Sagua.Jinson.Shopper.Common
{
    [MarkupExtensionReturnType(typeof(IEnumerable))]
    public class EnumValuesExtension : MarkupExtension
    {
        public EnumValuesExtension()
        {
        }
         
        public EnumValuesExtension(Type enumType)
        {
            this.EnumType = enumType; 
        }

        [ConstructorArgument("enumType")]
        public Type EnumType { get; set; }

        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            if (this.EnumType == null)
                throw new ArgumentException("The enum type is not set");

            var Items = new List<ViualEnum>();

            foreach (var item in Enum.GetValues(EnumType))
            {
                FieldInfo fieldInfo = item.GetType().GetField(item.ToString());
                var browsableAttributies = fieldInfo.GetCustomAttributes(typeof(BrowsableAttribute), false);
                if (browsableAttributies.Any())
                {
                    var browsableAttribute = browsableAttributies.First() as BrowsableAttribute;
                    if (browsableAttribute.Browsable == false)
                        continue;
                }

                Items.Add(new ViualEnum { Description =  ((Enum)item).GetDescription(), Value = (Enum)item });

            }
            return Items;

        }

        public class ViualEnum
        {
            public string Description { get; set; }
            public Enum Value { get; set; }
        }
    }
}
