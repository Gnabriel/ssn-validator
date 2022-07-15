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
    int ssn;

    public Person (string firstName, string lastName, int ssn)
    {
      this.firstName = firstName;
      this.lastName = lastName;
      this.ssn = ssn;
    }

    public bool validateSSN ()
    {
      return true;
    }

    public Gender checkGender ()
    {
      return Gender.MALE;
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