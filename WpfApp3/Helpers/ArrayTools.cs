namespace WpfApp3.Helpers
{
    public static class ArrayTools
    {
        public static void Fill<T>(this T[] a, T fillVal)
        {
            for (int i = 0; i < a.Length; i++)
                a[i] = fillVal;
        }
    }
}