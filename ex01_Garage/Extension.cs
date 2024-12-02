using ex01_Garage.Models.Options;

namespace ex01_Garage
{
    public static class Extension
    {
        public static string CustomToString(this IList<IOption> options)
        {
            return string.Join(", ", options.Select(x => x.CustomToString()));
        }

        public static string CustomToString(this IOption option)
        {
            return string.Format("{0} ({1}€)", option.GetType().Name, option.GetPrix());
        }

    }
}
