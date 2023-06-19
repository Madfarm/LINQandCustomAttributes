## LINQ - Language Integrate Query
Designed to provide a consistent query experience with xml, relational databases, ADO.NET databases, streams, and .NET collections
- LINQ can be used with anything that supports IEnumerable


- amazing, actually

In Visual Studio, LINQ provides intellisense against the SQL server you're fetching from

a query is not executed until the query variable is iterated over


two syntaxes(so far):

IEnumerable<int> odds =
            from num in nums
            where num % 2 != 0
            select num;

 IEnumerable<int> odds = nums.Where(num => num % 2 != 0);


 both should grab all odd numbers and then store them in a collection called odds
