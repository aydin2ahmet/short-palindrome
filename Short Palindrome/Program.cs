var result = shortPalindrome("kkkkkkz");

Console.WriteLine(result);

long shortPalindrome(string s)
{
    int[] firstArray = new int[26];
    long[,] secondArray = new long[26, 26];
    long[,,] thirdArray = new long[26, 26, 26];
    long totalCount = 0;

    long modValue = (long)Math.Pow(10, 9) + 7;

    foreach (var i in s)
    {
        var k = (int)i - 97;

        for (int j = 0; j < 26; j++)
        {
            totalCount += thirdArray[k, j, j];
            thirdArray[j, k, k] = (thirdArray[j, k, k] + secondArray[j, k]) % modValue;
            secondArray[j, k] = (secondArray[j, k] + firstArray[j]) % modValue;
        }

        totalCount %= modValue;
        firstArray[k] += 1;
    }

    return totalCount;
}