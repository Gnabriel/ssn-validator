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
    }
  }
}