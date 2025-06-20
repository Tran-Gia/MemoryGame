namespace WindowsFormsApplication1.Functions.GlobalFunctions
{
    public static class StringHelper
    {
        public static string PrependZero(string input, int totalNumOfDigits)
        {
            while(input.Length < totalNumOfDigits)
            {
                input = "0" + input;
            }

            return input;
        }

        public static string PrependZero(int input, int totalNumOfDigits)
        {
            return PrependZero(input.ToString(), totalNumOfDigits);
        }
    }
}
