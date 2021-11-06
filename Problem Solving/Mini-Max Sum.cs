using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using System.Text;
using System;

class Result
{

    /*
     * Complete the 'miniMaxSum' function below.
     *
     * The function accepts INTEGER_ARRAY arr as parameter.
     */

    public static void miniMaxSum(List<int> arr)
    {
         long minValue = long.MaxValue;
            long maxValue = long.MinValue;
            long sumOfAllNumbers = 0;
            for (int i = 0; i < arr.Count; i++)
            {
                sumOfAllNumbers += arr[i];
                if (arr[i] < minValue)
                {
                    minValue = arr[i];
                }
                if (arr[i] > maxValue)
                {
                    maxValue = arr[i];
                }



            }
            Console.WriteLine($"{sumOfAllNumbers - maxValue} {sumOfAllNumbers - minValue}");
    }

}

class Solution
{
    public static void Main(string[] args)
    {

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.miniMaxSum(arr);
    }
}
