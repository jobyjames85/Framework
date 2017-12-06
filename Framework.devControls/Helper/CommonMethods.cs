using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Framework.devControls
{
   public class CommonMethods
    {
       public static void AddLocalizeItem(LocalizeItemSelector selector, string ietfLanguageTag, string value)
       {
           LocalizeItem localizeItem = new LocalizeItem();
           localizeItem.IetfLanguageTag = ietfLanguageTag;
           localizeItem.Text = value;
           selector.Collection.Add(localizeItem);
       }
    }
}
