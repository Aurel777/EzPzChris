namespace EzpzChris.Extensions
{
    #region Using Statements

    using System;
    using System.ComponentModel;
    using System.Globalization;
    using System.Linq;

    #endregion

    static class Extensions
    {
        static string GetString(Enum value)
        {
            var fieldInfo = value.GetType().GetField(value.ToString());
            var attributes = (DescriptionAttribute[]) fieldInfo.GetCustomAttributes(typeof(DescriptionAttribute), false);
            return attributes.Length > 0 ? attributes[0].Description : value.ToString();
        }
        
        static string GetEnumDescription(string value, Type enumType)
        {
            var names = Enum.GetNames(enumType);
            foreach (var name in names.Where(name => GetString((Enum) Enum.Parse(enumType, name)).Equals(value)))
                return Enum.Parse(enumType, name).ToString();

            throw new ArgumentException("The string is not a description or value of the specified enum.");
        }

        public static string GetDescription<T>(this T enumWithDescription) where T : IConvertible
        {
            if (!(enumWithDescription is Enum))
                return string.Empty;

            var type = enumWithDescription.GetType();
            foreach (int value in Enum.GetValues(type))
            {
                if (value != enumWithDescription.ToInt32(CultureInfo.InvariantCulture))
                    continue;

                var memberInfo = type.GetMember(type.GetEnumName(value));
                if (memberInfo[0].GetCustomAttributes(typeof(DescriptionAttribute), false).FirstOrDefault() is DescriptionAttribute descriptionAttribute)
                    return descriptionAttribute.Description;
            }

            return string.Empty;
        }
    }
}

