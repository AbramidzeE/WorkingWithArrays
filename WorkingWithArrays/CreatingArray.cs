﻿using System;

namespace WorkingWithArrays
{
    public static class CreatingArray
    {
        public static int[] CreateEmptyArrayOfIntegers()
        {
            // TODO #1-1. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            int[] array;

            return array = new int[0];
        }

        public static bool[] CreateEmptyArrayOfBooleans()
        {
            // TODO #1-2. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            bool[] array;
            return array = new bool[0];
        }

        public static string[] CreateEmptyArrayOfStrings()
        {
            // TODO #1-3. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            string[] array;
            return array = new string[0];
        }

        public static char[] CreateEmptyArrayOfCharacters()
        {
            // TODO #1-4. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            char[] array;
            return array = new char[0];
        }

        public static double[] CreateEmptyArrayOfDoubles()
        {
            // TODO #1-5. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            double[] array;
            return array = new double[0];
        }

        public static float[] CreateEmptyArrayOfFloats()
        {
            // TODO #1-6. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            float[] array;
            return array = new float[0];
        }

        public static decimal[] CreateEmptyArrayOfDecimals()
        {
            // TODO #1-7. Add the method implementation. The method should return an empty array.
            // See Array.Empty<T> method documentation page: https://docs.microsoft.com/en-us/dotnet/api/system.array.empty
            decimal[] array;
            return array = new decimal[0];
        }

        public static int[] CreateArrayOfTenIntegersWithDefaultValues()
        {
            // TODO #1-8. Add the method implementation. The method should return an array that contains ten integers with default values.
            int[] array;
            return array = new int[10];
        }

        public static bool[] CreateArrayOfTwentyBooleansWithDefaultValues()
        {
            // TODO #1-9. Add the method implementation. The method should return an array that contains twenty booleans with default values.
            bool[] array;
            return array = new bool[20];
        }

        public static string[] CreateArrayOfFiveEmptyStrings()
        {
            // TODO #1-10. Add the method implementation. The method should return an array that contains five empty strings with default values.
            string[] array;
            return array = new string[5];
        }

        public static char[] CreateArrayOfFifteenCharactersWithDefaultValues()
        {
            // TODO #1-11. Add the method implementation. The method should return an array that contains fifteen characters with default values.
            char[] array;
            return array = new char[15];
        }

        public static double[] CreateArrayOfEighteenDoublesWithDefaultValues()
        {
            // TODO #1-12. Add the method implementation. The method should return an array that contains eighteen doubles with default values.
            double[] array;
            return array = new double[18];
        }

        public static float[] CreateArrayOfOneHundredFloatsWithDefaultValues()
        {
            // TODO #1-13. Add the method implementation. The method should return an array that contains one hundred doubles with default values.
            float[] array;
            return array = new float[100];
        }

        public static decimal[] CreateArrayOfOneThousandDecimalsWithDefaultValues()
        {
            // TODO #1-14. Add the method implementation. The method should return an array that contains one thousand decimals with default values.
            decimal[] array;
            return array = new decimal[1000];
        }

        public static int[] CreateIntArrayWithOneElement()
        {
            // TODO #1-15. Add the method implementation. The method should return an array that contains one integer: 123,456.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            int[] arrays = { 123456 };
            return arrays;
        }

        public static int[] CreateIntArrayWithTwoElements()
        {
            // TODO #1-16. Add the method implementation. The method should return an array that contains two integers:
            // 1,111,111; 9,999,999
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            int[] arrays = { 1111111, 9999999 };
            return arrays;
        }

        public static int[] CreateIntArrayWithTenElements()
        {
            // TODO #1-17. Add the method implementation. The method should return an array that contains ten integers:
            //  0; 4,234; 3,845; 2,942; 1,104; 9,794; 923,943; 7,537; 4,162; 10,134
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            int[] arrays = { 0, 4234, 3845, 2942, 1104, 9794, 923943, 7537, 4162, 10134 };
            return arrays;
        }

        public static bool[] CreateBoolArrayWithOneElement()
        {
            // TODO #1-18. Add the method implementation. The method should return an array that contains one boolean: true.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            bool[] arrays = { true };
            return arrays;
        }

        public static bool[] CreateBoolArrayWithFiveElements()
        {
            // TODO #1-19. Add the method implementation. The method should return an array that contains five booleans:
            //  true; false; true; false; true
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            bool[] arrays = { true, true, false, false, true };
            return arrays;
        }

        public static bool[] CreateBoolArrayWithSevenElements()
        {
            // TODO #1-20. Add the method implementation. The method should return an array that contains seven booleans:
            //  false; true; true; false; true; true; false
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            bool[] arrays = { true, true, false, false, true, false, true };
            return arrays;
        }

        public static string[] CreateStringArrayWithOneElement()
        {
            // TODO #1-21. Add the method implementation. The method should return an array that contains one string: one.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            string[] arrays = { "one" };
            return arrays;
        }

        public static string[] CreateStringArrayWithThreeElements()
        {
            // TODO #1-22. Add the method implementation. The method should return an array that contains three strings:
            //  one; two; three
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            string[] arrays = { "one", "two", "three" };
            return arrays;
        }

        public static string[] CreateStringArrayWithSixElements()
        {
            // TODO #1-23. Add the method implementation. The method should return an array that contains three strings:
            //  one; two; three; four; five; six
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            string[] arrays = { "one", "two", "three", "four", "five", "six" };
            return arrays;
        }

        public static char[] CreateCharArrayWithOneElement()
        {
            // TODO #1-24. Add the method implementation. The method should return an array that contains one character: a.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            char[] arrays = { 'a' };
            return arrays;
        }

        public static char[] CreateCharArrayWithThreeElements()
        {
            // TODO #1-25. Add the method implementation. The method should return an array that contains three characters:
            //  a; b; c
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            char[] arrays = { 'a', 'b', 'c' };
            return arrays;
        }

        public static char[] CreateCharArrayWithNineElements()
        {
            // TODO #1-26. Add the method implementation. The method should return an array that contains nine characters:
            //  a; b; c; d; e; f; g; h; a
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            char[] arrays = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'a'  };
            return arrays;
        }

        public static double[] CreateDoubleArrayWithOneElement()
        {
            // TODO #1-27. Add the method implementation. The method should return an array that contains one double: 1.12.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            double[] arrays = { 1.12 };
            return arrays;
        }

        public static double[] CreateDoubleWithFiveElements()
        {
            // TODO #1-28. Add the method implementation. The method should return an array that contains five doubles:
            //  1.12; 2.23; 3.34; 4.45; 5.56
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            double[] arrays = { 1.12, 2.23, 3.34, 4.45, 5.56 };
            return arrays;
        }

        public static double[] CreateDoubleWithNineElements()
        {
            // TODO #1-29. Add the method implementation. The method should return an array that contains nine doubles:
            //  1.12; 2.23; 3.34; 4.45; 5.56; 6.67; 7.78; 8.89; 9.91
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            double[] arrays = { 1.12, 2.23, 3.34, 4.45, 5.56, 6.67, 7.78, 8.89, 9.91 };
            return arrays;
        }

        public static float[] CreateFloatArrayWithOneElement()
        {
            // TODO #1-30. Add the method implementation. The method should return an array that contains one float: 123,456,789.123456.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            float[] arrays = { 123456789.123456f };
            return arrays;
        }

        public static float[] CreateFloatWithThreeElements()
        {
            // TODO #1-31. Add the method implementation. The method should return an array that contains three floats:
            //  1,000,000.123456; 2,223,334,444.123456; 9,999.999999
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            float[] arrays = { 1000000.123456f, 2223334444.123456f, 9999.999999f };
            return arrays;
        }

        public static float[] CreateFloatWithFiveElements()
        {
            // TODO #1-32. Add the method implementation. The method should return an array that contains five floats:
            //  1.0123; 20.012345; 300.01234567; 4,000.01234567; 500,000.01234567
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            float[] arrays = { 1.0123f, 20.012345f, 300.01234567f, 4000.01234567f, 500000.01234567f };
            return arrays;
        }

        public static decimal[] CreateDecimalArrayWithOneElement()
        {
            // TODO #1-33. Add the method implementation. The method should return an array that contains one double: 10,000.123456.
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            decimal[] arrays = { 10000.123456m };
            return arrays;
        }

        public static decimal[] CreateDecimalWithFiveElements()
        {
            // TODO #1-34. Add the method implementation. The method should return an array that contains four doubles:
            //  1,000.1234; 100,000.2345; 100,000.3456; 1,000,000.456789; 10,000,000.5678901
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            decimal[] arrays = { 1000.1234m, 100000.2345m, 100000.3456m, 1000000.456789m, 10000000.5678901m };
            return arrays;
        }

        public static decimal[] CreateDecimalWithNineElements()
        {
            // TODO #1-35. Add the method implementation. The method should return an array that contains ten doubles:
            //  10.122112; 200.233223; 3,000.344334; 40,000.455445; 500,000.566556; 6,000,000.677667; 70,000,000.788778; 800,000,000.899889; 9,000,000,000.911991
            // Use implicitly typed array syntax: https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/arrays/implicitly-typed-arrays
            decimal[] arrays = { 10.122112m, 200.233223m, 3000.344334m, 40000.455445m, 500000.566556m, 6000000.677667m, 70000000.788778m, 800000000.899889m, 9000000000.911991m };
            return arrays;
        }
    }
}
