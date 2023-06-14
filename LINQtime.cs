namespace Linky;

class LINQexec
{
    public IEnumerable<int> firstOne(int[] nums)
    {
        IEnumerable<int> evensQuery = 
            from num in nums
            where num % 2 == 0
            select num;

        return evensQuery;
    }

    public void print(IEnumerable<int> query)
    {
        foreach (var i in query)
        {
            System.Console.WriteLine(i + " ");
        }
    }
}