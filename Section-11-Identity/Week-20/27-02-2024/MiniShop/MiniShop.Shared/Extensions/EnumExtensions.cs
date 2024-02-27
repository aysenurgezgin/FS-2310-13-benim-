using System.ComponentModel.DataAnnotations;
using System.Reflection;

namespace MiniShop.Shared.Extensions
{
    public static class EnumExtensions
    {
        public static string GetDisplayName(this Enum value)
        {
            string result = value
                .GetType()
                .GetMember(value.ToString())
                .First()
                .GetCustomAttribute<DisplayAttribute>()
                ?.GetName();
            return result;
        }
        //Benim yaptığım enum yapısı;
        //public static string changeIsState(this Enum value)
        //{
        //    string result = value
        //        .StateName();
        //    return ViewModels();
        //}

        //private static string ViewModels()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
