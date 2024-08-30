namespace PRAMS.Infraestructure.Utils
{
    public static class ConvertTo
    {

        public static T ChangeType<T>(this object obj)
        {
            return (T)Convert.ChangeType(obj, typeof(T));
        }
    }
}
