namespace ssn_validator
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void btnValidate_Click(object sender, EventArgs e)
    {
      // Create a person instance.
      Person person = new Person(firstNameInput.Text, lastNameInput.Text, ssnInput.Text);
      // Display the person's information in the result textbox.
      resultBox.Text = person.ToString();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}