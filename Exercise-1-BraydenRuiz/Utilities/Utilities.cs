using System.Net.NetworkInformation;

namespace Utils
{
    public static class Utilities
    {
        public static bool IsPostiveNonZero(int value) => value > 0;
       
        public static bool InHundreds(int value) => value % 100 == 0;

        public static bool IsNullEmptyOrWhiteSpace(string value) => string.IsNullOrWhiteSpace(value);

    }