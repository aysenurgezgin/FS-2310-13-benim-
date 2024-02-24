using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MiniShop.Shared.Extensions

{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value) 
        {
            string result =value
                .GetType()
                .GetMember(value.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()//Null değilse oluypr bu sonraki soru işareti
                ?.GetName();
            return result;
        }
    }
}
