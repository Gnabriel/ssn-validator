namespace ssn_validator
{
  partial class Form1
  {
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
      this.btnValidate = new System.Windows.Forms.Button();
      this.firstName = new System.Windows.Forms.TextBox();
      this.lastName = new System.Windows.Forms.TextBox();
      this.ssn = new System.Windows.Forms.TextBox();
      this.boxOutput = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // btnValidate
      // 
      this.btnValidate.Location = new System.Drawing.Point(155, 308);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(112, 34);
      this.btnValidate.TabIndex = 0;
      this.btnValidate.Text = "Validate";
      this.btnValidate.UseVisualStyleBackColor = true;
      // 
      // firstName
      // 
      this.firstName.Location = new System.Drawing.Point(107, 96);
      this.firstName.Name = "firstName";
      this.firstName.Size = new System.Drawing.Size(216, 31);
      this.firstName.TabIndex = 1;
      // 
      // lastName
      // 
      this.lastName.Location = new System.Drawing.Point(107, 171);
      this.lastName.Name = "lastName";
      this.lastName.Size = new System.Drawing.Size(216, 31);
      this.lastName.TabIndex = 2;
      // 
      // ssn
      // 
      this.ssn.Location = new System.Drawing.Point(107, 251);
      this.ssn.Name = "ssn";
      this.ssn.Size = new System.Drawing.Size(216, 31);
      this.ssn.TabIndex = 3;
      // 
      // boxOutput
      // 
      this.boxOutput.Location = new System.Drawing.Point(434, 77);
      this.boxOutput.Name = "boxOutput";
      this.boxOutput.Size = new System.Drawing.Size(268, 305);
      this.boxOutput.TabIndex = 5;
      this.boxOutput.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(110, 68);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(94, 25);
      this.label1.TabIndex = 6;
      this.label1.Text = "First name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(107, 143);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(92, 25);
      this.label2.TabIndex = 7;
      this.label2.Text = "Last name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(107, 223);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(190, 25);
      this.label3.TabIndex = 8;
      this.label3.Text = "Social security number";
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(155, 348);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(112, 34);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.boxOutput);
      this.Controls.Add(this.ssn);
      this.Controls.Add(this.lastName);
      this.Controls.Add(this.firstName);
      this.Controls.Add(this.btnValidate);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnValidate;
    private TextBox firstName;
    private TextBox lastName;
    private TextBox ssn;
    private RichTextBox boxOutput;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button btnExit;
  }
}