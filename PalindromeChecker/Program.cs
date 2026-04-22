public class Solution
{
    public bool IsPalindrome(int x)
    {
        // Any negative number cannot be a palindrome, so we return false immediately.
        if (x < 0)
        {
            return false;
        }
        // Convert int x to string
        string num = x.ToString();
        // Convert string num to char array
        char[] xChar = num.ToCharArray();
        // Reverse the char array
        Array.Reverse(xChar);
        // Convert the reversed char array back to string
        string reverse = new string(xChar);
        // Check if the original number is equal to the reversed number
        return num == reverse;
    }
}

// This program sets the entry point to build and run the project, 
// it also sets the boundary for the test cases to be between 121 and 525, 
// which includes both palindromic and non-palindromic numbers. 
// The output will show each number along with whether it is a palindrome or not.
public class Program
{
    public static void Main(string[] args)
    {
        Solution solution = new Solution();
        for (int i = 121; i <= 525; i++)
        {
            bool result = solution.IsPalindrome(i);
            Console.WriteLine($"{i}: {result}");
        }
    }
}