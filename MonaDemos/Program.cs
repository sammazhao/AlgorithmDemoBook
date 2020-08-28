using System;
using System.Globalization;
using static MonaDemos.enumDemo;
using MonaDemos.algorithmDemo;
using System.Collections.Generic;

public class Example
{
    ////public static void Main()
    ////{
    ////    string date = "01/13/1983";
    ////    DateTime dateTime = DateTime.ParseExact(date, "MM/dd/yyyy", CultureInfo.InvariantCulture);
    ////    Console.WriteLine(dateTime.ToString("ddMMyyyy", CultureInfo.GetCultureInfo("el-GR")));

    ////    void InputDate(LocaleCountryCodeEnum countryCode)
    ////    {
    ////        string currentCulture = string.Empty;
    ////        string format = string.Empty;
    ////        switch (countryCode)
    ////        {
    ////            case LocaleCountryCodeEnum.Arabic:
    ////                currentCulture = "ar-AE";
    ////                format = "yyyyMd";
    ////                break;

    ////            case LocaleCountryCodeEnum.English:
    ////                currentCulture = "en-US";
    ////                format = "Mdyyyy";
    ////                break;

    ////            case LocaleCountryCodeEnum.Greek:
    ////                currentCulture = "el-GR";
    ////                format = "dMyyyy";
    ////                break;
    ////            case LocaleCountryCodeEnum.Norweign:
    ////                currentCulture = "nb-NO";
    ////                ////format = "ddMMyyyy";
    ////                format = (LocaleDateFormatEnum.ddMMyyyy).ToString();
    ////                var f2 = LocaleDateFormatEnum.ddMMyyyy;
    ////                var f3 = (int)LocaleDateFormatEnum.ddMMyyyy;
    ////                break;
    ////        }

    ////        Console.WriteLine(format);

    ////    }

    ////    InputDate(LocaleCountryCodeEnum.Norweign);
    ////}

    public static void Main()
    {
        //List<int> list = new List<int> { 10, 2, 3, 100, 6 };

        //SortingDemo sort = new SortingDemo();
        //var result = sort.BubbleSorting(list);
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);
        //}

        //string str = "i     am   a student";
        //Algorithm algorithm = new Algorithm();
        //var result = algorithm.testDemo1(str);
        //string result2 = algorithm.ReverseDemo2();
        ////long result3 = algorithm.Fib(4);
        //long result4 = algorithm.FibWithRecurse(4);
        //Console.WriteLine(result4);
        //foreach (var i in result)
        //{
        //    Console.WriteLine(i);

        //}

        //////两数之和执行
        ////int [] numArray = { 2, 3, 1, 5, 0, 7 };
        ////SumOfTwoNumber sum = new SumOfTwoNumber();
        ////List<int> res = new List<int> { };
        ////res = sum.SumTest(numArray, 9);
        ////if (res.Count > 0)
        ////{
        ////    foreach (int i in res)
        ////    {
        ////        Console.WriteLine(i);
        ////        Console.ReadKey();
        ////    }
        ////}

        LeetCodeSolution solution = new LeetCodeSolution();
        //////旋转指定数量字符串执行
        ////string s = "abcdefg";
        ////string res = solution.LeftTurnStringTest(s, 2);

        //////移动0
        ////List<int> nums = new List<int> { 2, 0, 0, 4, 56, 0, 9 };
        ////solution.MoveZero(nums);
        //////Console.WriteLine(res);
        ////Console.ReadKey();

        //有效的括号
        //bool resStatus = solution.isKuoHaoValid("(({[]}}))");
        //Console.WriteLine(resStatus);

        //遍历string打出每个字符和出现的次数
        solution.CountCharInString("wwpaquuuu");
        Console.ReadKey();
    }
}
// The example displays the following output:
//       06/15/2008 converts to 6/15/2008 12:00:00 AM.
//       6/15/2008 is not in the correct format.
//       Sun 15 Jun 2008 8:30 AM -06:00 converts to 6/15/2008 7:30:00 AM.
//       Sun 15 Jun 2008 8:30 AM -06 is not in the correct format.
//       15/06/2008 08:30 converts to 6/15/2008 8:30:00 AM.
//       18/08/2015 06:30:15.006542 converts to 8/18/2015 6:30:15 AM.


