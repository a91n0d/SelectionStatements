using System;

namespace SelectionStatments
{
    public static class Statements
    {
        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithNestedIfElse(int first, int second, int third)
        {
            if (first < second)
            {
                first = second;
            }

            if (first < third)
            {
                first = third;
            }

            Console.WriteLine("Number {0} is the largest", first);
        }

        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithIfElseAndTernaryOperator(int first, int second, int third)
        {
            first = first < second ? second : first;
            first = first < third ? third : first;
            Console.WriteLine("Number {0} is the largest", first);
        }

        /// <summary>
        /// Writes the largest of three numbers in a separate line in format "Number {0} is the largest".
        /// </summary>
        /// <param name="first">First number.</param>
        /// <param name="second">Second number.</param>
        /// <param name="third">Third number.</param>
        public static void WriteLargestWithIfElseAndConditionLogicalOperators(int first, int second, int third)
        {
            if (third > first && third > second)
            {
                first = third;
            }

            if (second > first && second > third)
            {
                first = second;
            }

            Console.WriteLine("Number {0} is the largest", first);
        }

        /// <summary>
        /// Writes the reaction to the user's age:
        /// - writes "Enjoy your retirement!" if user's age is more or equal 65;
        /// - writes "Fancy an alcoholic beverage?" if user's is age more or equal 21;
        /// - writes "You're old enough to drive." if user's is age more or equal 18;
        /// - writes "You are too young to drive, drink, or retire." otherwise.
        /// </summary>
        /// <param name="userAge">User's age is more or equals zero.</param>
        public static void HowOldAreYouReactionWithCascadedIfElse(int userAge)
        {
            if (userAge >= 65)
            {
                Console.WriteLine("Enjoy your retirement!");
            }
            else if (userAge >= 21)
            {
                Console.WriteLine("Fancy an alcoholic beverage?");
            }
            else if (userAge >= 18)
            {
                Console.WriteLine("You're old enough to drive.");
            }
            else
            {
                Console.WriteLine("You are too young to drive, drink, or retire.");
            }
        }

        /// <summary>
        /// Writes the message with information about count of daily downloads:
        /// - writes "No downloads." if countOfDailyDownloads is less or equals 0;
        /// - writes "Daily downloads: 1-100." if countOfDailyDownloads is less than 100;
        /// - writes "Daily downloads: 100-1,000." if countOfDailyDownloads is less than 1000;
        /// - writes "Daily downloads: 1,000-10,000." if countOfDailyDownloads is less than 10000;
        /// - writes "Daily downloads: 10,000-100,000." if countOfDailyDownloads is less than 100000;
        /// - writes "Daily downloads: 100,000+." otherwise.
        /// </summary>
        /// <param name="countOfDailyDownloads">Count of daily downloads more or equals zero.</param>
        public static void WriteInformationAboutDailyDownloadsWithCascadedIfElse(int countOfDailyDownloads)
        {
            if (countOfDailyDownloads > 100_000)
            {
                Console.WriteLine("Daily downloads: 100,000+.");
            }
            else if (countOfDailyDownloads >= 10_000)
            {
                Console.WriteLine("Daily downloads: 10,000-100,000.");
            }
            else if (countOfDailyDownloads >= 1_000)
            {
                Console.WriteLine("Daily downloads: 1,000-10,000.");
            }
            else if (countOfDailyDownloads >= 100)
            {
                Console.WriteLine("Daily downloads: 100-1,000.");
            }
            else if (countOfDailyDownloads >= 1)
            {
                Console.WriteLine("Daily downloads: 1-100.");
            }
            else
            {
                Console.WriteLine("No downloads.");
            }
        }

        /// <summary>
        /// Writes on base on the DayOfWeek enumeration whether a particular date is
        /// - a weekend, writes "The weekend.";
        /// - the first day of the work week, writes "The first day of the work week.";
        /// - the last day of the work week, writes "The last day of the work week.";
        /// - the middle of the work week, "The middle of the work week.".
        /// </summary>
        /// <param name="dayOfWeek">Day of week.</param>
        public static void WriteTheInformationAboutDayWithIfElse(DayOfWeek dayOfWeek)
        {
            if ((byte)dayOfWeek == 0 || (byte)dayOfWeek == 6)
            {
                Console.WriteLine("The weekend.");
            }
            else if ((byte)dayOfWeek > 1 && (byte)dayOfWeek < 5)
            {
                Console.WriteLine("The middle of the work week.");
            }
            else if ((byte)dayOfWeek == 1)
            {
                Console.WriteLine("The first day of the work week.");
            }
            else if ((byte)dayOfWeek == 5)
            {
                Console.WriteLine("The last day of the work week.");
            }
        }

        /// <summary>
        /// Determines on base on the DayOfWeek enumeration whether a particular date is
        /// - a weekend, writes "The weekend.";
        /// - the first day of the work week, writes "The first day of the work week.";
        /// - the last day of the work week, writes "The last day of the work week.";
        /// - the middle of the work week, "The middle of the work week.".
        /// </summary>
        /// <param name="dayOfWeek">Day of week.</param>
        public static void WriteTheInformationAboutDayWithSwitchStatement(DayOfWeek dayOfWeek)
        {
            switch ((byte)dayOfWeek)
            {
                case 0:
                case 6:
                    Console.WriteLine("The weekend.");
                    break;
                case 1:
                    Console.WriteLine("The first day of the work week.");
                    break;
                case 5:
                    Console.WriteLine("The last day of the work week.");
                    break;
                default:
                    Console.WriteLine("The middle of the work week.");
                    break;
            }
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithCascadedIfElse(object arg)
        {
            if (arg is sbyte)
            {
                return $"{arg} is sbyte.";
            }

            if (arg is byte)
            {
                return $"{arg} is byte.";
            }

            if (arg is short)
            {
                return $"{arg} is short.";
            }

            if (arg is int)
            {
                return $"{arg} is int.";
            }

            if (arg is long)
            {
                return $"{arg} is long.";
            }

            if (arg is ushort)
            {
                return $"{arg} is ushort.";
            }

            if (arg is uint)
            {
                return $"{arg} is uint.";
            }

            if (arg is ulong)
            {
                return $"{arg} is ulong.";
            }

            return $"{arg} is not integer.";
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithSwitchStatement(object arg)
        {
            switch (arg)
            {
                case sbyte _: return $"{arg} is sbyte.";
                case byte _: return $"{arg} is byte.";
                case short _: return $"{arg} is short.";
                case int _: return $"{arg} is int.";
                case long _: return $"{arg} is long.";
                case ushort _: return $"{arg} is ushort.";
                case uint _: return $"{arg} is uint.";
                case ulong _: return $"{arg} is ulong.";
                default: return $"{arg} is not integer.";
            }
        }

        /// <summary>
        /// Gets the message with information about the type of integer in format:
        /// - "{arg} is sbyte.", if arg is sbyte;
        /// - "{arg} is byte.", if arg is byte;
        /// - "{arg} is short.", if arg is short;
        /// - "{arg} is int.", if arg is int;
        /// - "{arg} is long.", if arg is long;
        /// - "{arg} is ushort.", if arg is ushort;
        /// - "{arg} is uint.", if arg is uint;
        /// - "{arg} is ulong.", if arg is ulong.
        /// - "{arg} is not integer.", otherwise.
        /// </summary>
        /// <param name="arg">Presents some integer.</param>
        /// <returns>The message with information about the type of integer.</returns>
        public static string GetTypeOfIntegerWithSwitchExpression(object arg) => arg switch
        {
            sbyte _ => $"{arg} is sbyte.",
            byte _ => $"{arg} is byte.",
            short _ => $"{arg} is short.",
            int _ => $"{arg} is int.",
            long _ => $"{arg} is long.",
            ushort _ => $"{arg} is ushort.",
            uint _ => $"{arg} is uint.",
            ulong _ => $"{arg} is ulong.",
            _ => $"{arg} is not integer."
        };

        /// <summary>
        /// Writes the season that corresponds to the given month:
        /// - writes "It's winter now." if month is December, January or February;
        /// - writes "It's spring now." if month is March, April or May;
        /// - writes "It's summer now." if month is June, July or August;
        /// - writes "It's autumn now." if month is September, October or November;
        /// - writes "Sorry, the month was entered incorrectly." otherwise.
        /// </summary>
        /// <param name="month">Source month.</param>
        public static void WriteTheInformationAboutSeasonsWithSwitchStatement(Month month)
        {
            switch ((byte)month)
            {
                case 1:
                case 2:
                case 12:
                    Console.WriteLine("It's winter now.");
                    break;
                case 3:
                case 4:
                case 5:
                    Console.WriteLine("It's spring now.");
                    break;
                case 6:
                case 7:
                case 8:
                    Console.WriteLine("It's summer now.");
                    break;
                case 9:
                case 10:
                case 11:
                    Console.WriteLine("It's autumn now.");
                    break;
                default:
                    Console.WriteLine("Sorry, the month was entered incorrectly.");
                    break;
            }
        }

        /// <summary>
        /// Returns the length of the integer's string presentation.
        /// </summary>
        /// <param name="number">Source integer.</param>
        /// <returns>The length of the integer's string presentation.</returns>
        public static byte GetLengthWithCascadedIfElse(int number)
        {
            if (number > 0)
            {
                number *= -1;
            }

            if (number < -1000000000)
            {
                return 10;
            }

            if (number < -100000000)
            {
                return 9;
            }

            if (number < -10000000)
            {
                return 8;
            }

            if (number < -1000000)
            {
                return 7;
            }

            if (number < -100000)
            {
                return 6;
            }

            if (number < -10000)
            {
                return 5;
            }

            if (number < -1000)
            {
                return 4;
            }

            if (number < -100)
            {
                return 3;
            }

            if (number < -10)
            {
                return 2;
            }

            return 1;
        }

        /// <summary>
        /// Returns the length of the integer's string presentation.
        /// </summary>
        /// <param name="number">Source integer.</param>
        /// <returns>The length of the integer's string presentation.</returns>
        public static byte GetLengthWithSwitchExpression(int number) => number switch
        {
            int n when n > 0 => GetLengthWithSwitchExpression(number * -1),
            int n when n < -1000000000 => 10,
            int n when n < -100000000 => 9,
            int n when n < -10000000 => 8,
            int n when n < -1000000 => 7,
            int n when n < -100000 => 6,
            int n when n < -10000 => 5,
            int n when n < -1000 => 4,
            int n when n < -100 => 3,
            int n when n < -10 => 2,
            _ => 1
        };

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithCascadedIfElse(int month)
        {
            if (month > 12)
            {
                return null;
            }

            if (month < 1)
            {
                return null;
            }

            return (Month)month;
        }

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithSwitchStatement(int month)
        {
            switch (month)
            {
                case int m when m > 12:
                    return null;
                case int m when m < 1:
                    return null;
                default:
                    return (Month)month;
            }
        }

        /// <summary>
        /// Returns the value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or
        /// null, if integer less than 1 or more than 12.
        /// </summary>
        /// <param name="month">Source integer.</param>
        /// <returns>The value of enum <see cref="SelectionStatments.Month"/> that corresponds to the given integer
        /// - or null, if integer less than 1 or more than 12.
        /// </returns>
        public static Month? GetMonthWithSwitchExpression(int month) => month switch
        {
            int m when m > 12 => null,
            int m when m < 1 => null,
            _ => (Month)month
        };
    }
}
