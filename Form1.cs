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
      Person person = new Person(firstNameInput.Text, lastNameInput.Text, ssnInput.Text);
      resultBox.Text = person.ToString();
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      this.Close();
    }
  }
}