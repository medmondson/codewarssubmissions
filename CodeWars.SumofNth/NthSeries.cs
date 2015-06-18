using System;

public class NthSeries
{
    public static string seriesSum(int n)
    {
        // Happy Coding ^_^

        if (n == 0)
            return "0.00";

        decimal total = 0;

        for(int i=1; i<=n; i++)
        {
            decimal division = 1 / FindDivider(i);
            total = total + division;
        }

        return total.ToString("F");

    }

    private static decimal FindDivider(int n)
    {
        int initialDivder = 4;

        if (n == 1)
            return 1;

        if (n == 2)
            return initialDivder;

        return initialDivder + (3 * (n - 2));

    }
}