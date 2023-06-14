using Linky;


int[] numArr = {1,23,45,65,12,45,123,45,67,234,8423812,82,9823,3,2};
LINQexec caller = new LINQexec();

IEnumerable<int> evens = caller.evensFilter(numArr);
IEnumerable<int> fourDigits =  caller.fourDigitFinder(numArr);
caller.print(fourDigits);

