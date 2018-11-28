namespace EzpzChris.Extensions
{
    using System.Linq;

    static class IntExtensions
    {
        static int KeepOnlyDigit(this string text) => int.Parse(text
            .Where(c => !char.IsDigit(c))
            .Aggregate(string.Empty, (current, c) => current + c));
    }
}