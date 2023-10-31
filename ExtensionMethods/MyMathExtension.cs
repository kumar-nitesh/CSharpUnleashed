namespace ExtensionMethods
{
    public static class MyMathExtension
    {
        public static int factorial(this int x)
        {
            if (x <= 1) return 1;
            if (x == 2) return 2;
            else
                return x * factorial(x - 1);
        }

        public static int addOne(this int x)
        {
            return 5 + x;
        }
    }
}
