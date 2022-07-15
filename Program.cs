using System.Text.RegularExpressions;

namespace ssn_validator
{
  // Enum that represents genders.
  enum Gender
  {
    MALE,
    FEMALE
  }

  // Class that represents one person containing its full name and SSN.
  class Person
  {
    string firstName;
    string lastName;
    string ssn;

    public Person (string firstName, string lastName, string ssn)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.ssn = ssn;
    }

    // Checks if the persons SSN is valid.
    public bool validateSSN ()
    {
      // Regex pattern for a Swedish SSN.
      // Source: https://gist.github.com/nekman/1058171?permalink_comment_id=3451462#gistcomment-3451462
      string pattern = @"^(19|20)?\d{2}(01|02|03|04|05|06|07|08|09|10|11|12)((0[1-9])|(1|2)[0-9]|(30|31))-\d{4}$";
      // Create a Regex.
      Regex regex = new Regex(pattern);
      // Check SSN for Regex match.
      Match match = regex.Match(this.ssn);

      // SSN pattern is found and the SSN is valid.
      if (match.Success && this.twentyOneAlgorithm())
      {
        return true;
      }
      // Invalid SSN.
      return false;
    }

    // Checks the gender of a person based on their SSN.
    public Gender checkGender ()
    {
      // Check if second to last number in SSN is even or odd.
      if (this.ssn[this.ssn.Length - 2]%2 == 0)
      {
        // Second to last number is even.
        return Gender.FEMALE;
      }
      // Second to last number is odd.
      return Gender.MALE;
    }

    // Nicely displays a persons information or an error message if the SSN is invalid.
    public override string ToString()
    {
      string result = "";

      if (this.validateSSN())
      {
        // Valid SSN.
        result += $"First name: {this.firstName}\n";
        result += $"Last name: {this.lastName}\n";
        result += $"SSN: {this.ssn}\n";
        result += $"Gender: {this.checkGender()}\n";
      }
      else
      {
        // Invalid SSN.
        result += "Invalid Social Security Number.\n";
      }
      
      return result;
    }

    // Algorithm to validate a Swedish SSN called the "21-algorithm".
    private bool twentyOneAlgorithm()
    {
      // Remove the dash or plus signs from the SSN.
      char[] charsToTrim = { '-', '+' };
      string cleanSSN = this.ssn.Replace("-", string.Empty);

      // Remove first two digits if the SSN is written as 12 characters.
      if (cleanSSN.Length == 12)
      {
        cleanSSN = cleanSSN.Substring(2);
      }

      int sum = 0;

      // Iterate over each number in the SSN.
      for (int i = 0; i < cleanSSN.Length; i++)
      {
        // Get current number as an int.
        int number = int.Parse(cleanSSN[i].ToString());

        // Set the number to multiply with below (switch between 2 and 1).
        // First number multiplies with 2, second with 1, third with 2, fourth with 1, ...
        int toMultiply;
        if (i % 2 == 0) toMultiply = 2;
        else toMultiply = 1;

        int product = number * toMultiply;
        // Calculate the sum of digits in the product.
        int digitSum = getDigitSum(product);
        // Add the digit sum to a total sum.
        sum += digitSum;
      }

      // Check if the total sum is divisible by 10.
      if (sum%10 == 0)
      {
        // If divisible by 10, the SSN is valid.
        return true;
      }
      // If not divisible by 10, the SSN is invalid.
      return false;
    }

    // Helper function to calculate the sum of digits in a number.
    private static int getDigitSum(int number)
    {
      int sum = 0;
      while (number != 0)
      {
        sum += number % 10;
        number /= 10;
      }
      return sum;
    }
  }

  internal static class Program
  {
    /// <summary>
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
      // To customize application configuration such as set high DPI settings or default font,
      // see https://aka.ms/applicationconfiguration.
      ApplicationConfiguration.Initialize();
      Application.Run(new Form1());
    }
  }
}