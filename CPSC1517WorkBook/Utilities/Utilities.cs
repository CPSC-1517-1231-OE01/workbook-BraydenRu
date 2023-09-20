namespace Utils
{

    public static class Utilities
    {

        public static bool IsZeroOrNegative(int value) => value <= 0;

        // bool result;

        // if (value <= 0)
        // {
        // result = true;
        // }
        // else
        // {
        //     result = false;
        // }
        // return result;



        public static bool IsNullEmptyOrWhiteSpace(string value) => string.IsNullOrWhiteSpace(value);


        public static bool IsPositive(int value) => value > 0;
        public static bool IsPositive(double value) => value > 0.0;
        public static bool IsPositive(decimal value) => value > 0M;


        public static bool IsInFuture(DateOnly value) => value > DateOnly.FromDateTime(DateTime.Now);
    }
}
