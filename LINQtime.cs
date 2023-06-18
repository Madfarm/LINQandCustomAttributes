namespace Linky;



// Linq time
class LINQexec
{
    public IEnumerable<int> evensFilter(int[] nums)
    {
        IEnumerable<int> evensQuery = 
            from num in nums
            where num % 2 == 0
            select num;

        return evensQuery;
    }

    public IEnumerable<int> fourDigitFinder(int[] nums)
    {
        IEnumerable<int> fourDigitNums =
            from num in nums
            where num > 1000
            select num;

        return fourDigitNums;
    }

    public void print(IEnumerable<int> query)
    {
        foreach (var i in query)
        {
            System.Console.WriteLine(i + " ");
        }
    }

    public IEnumerable<int> getOdds(int[] nums)
    {
        IEnumerable<int> odds =
            from num in nums
            where num % 2 != 0
            select num;

        return odds;
    }

    public Boolean doesInclude(int target, int[]nums)
    {
       return nums.Contains(target);
    }
}