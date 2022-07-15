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
      this.firstNameInput = new System.Windows.Forms.TextBox();
      this.lastNameInput = new System.Windows.Forms.TextBox();
      this.ssnInput = new System.Windows.Forms.TextBox();
      this.resultBox = new System.Windows.Forms.RichTextBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.btnExit = new System.Windows.Forms.Button();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.menuValidate = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.menuExit = new System.Windows.Forms.ToolStripMenuItem();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnValidate
      // 
      this.btnValidate.Location = new System.Drawing.Point(107, 175);
      this.btnValidate.Margin = new System.Windows.Forms.Padding(2);
      this.btnValidate.Name = "btnValidate";
      this.btnValidate.Size = new System.Drawing.Size(94, 37);
      this.btnValidate.TabIndex = 0;
      this.btnValidate.Text = "Validate";
      this.btnValidate.UseVisualStyleBackColor = true;
      this.btnValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // firstNameInput
      // 
      this.firstNameInput.Location = new System.Drawing.Point(68, 46);
      this.firstNameInput.Margin = new System.Windows.Forms.Padding(2);
      this.firstNameInput.Name = "firstNameInput";
      this.firstNameInput.Size = new System.Drawing.Size(172, 23);
      this.firstNameInput.TabIndex = 1;
      // 
      // lastNameInput
      // 
      this.lastNameInput.Location = new System.Drawing.Point(68, 91);
      this.lastNameInput.Margin = new System.Windows.Forms.Padding(2);
      this.lastNameInput.Name = "lastNameInput";
      this.lastNameInput.Size = new System.Drawing.Size(172, 23);
      this.lastNameInput.TabIndex = 2;
      // 
      // ssnInput
      // 
      this.ssnInput.Location = new System.Drawing.Point(68, 139);
      this.ssnInput.Margin = new System.Windows.Forms.Padding(2);
      this.ssnInput.Name = "ssnInput";
      this.ssnInput.Size = new System.Drawing.Size(172, 23);
      this.ssnInput.TabIndex = 3;
      // 
      // resultBox
      // 
      this.resultBox.Location = new System.Drawing.Point(276, 29);
      this.resultBox.Margin = new System.Windows.Forms.Padding(2);
      this.resultBox.Name = "resultBox";
      this.resultBox.ReadOnly = true;
      this.resultBox.Size = new System.Drawing.Size(230, 211);
      this.resultBox.TabIndex = 5;
      this.resultBox.Text = "";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(70, 29);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(62, 15);
      this.label1.TabIndex = 6;
      this.label1.Text = "First name";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(68, 74);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(61, 15);
      this.label2.TabIndex = 7;
      this.label2.Text = "Last name";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Location = new System.Drawing.Point(68, 122);
      this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(162, 15);
      this.label3.TabIndex = 8;
      this.label3.Text = "Social Security Number (SSN)";
      // 
      // btnExit
      // 
      this.btnExit.Location = new System.Drawing.Point(107, 216);
      this.btnExit.Margin = new System.Windows.Forms.Padding(2);
      this.btnExit.Name = "btnExit";
      this.btnExit.Size = new System.Drawing.Size(94, 24);
      this.btnExit.TabIndex = 9;
      this.btnExit.Text = "Exit";
      this.btnExit.UseVisualStyleBackColor = true;
      this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(560, 24);
      this.menuStrip1.TabIndex = 10;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // menuToolStripMenuItem
      // 
      this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuValidate,
            this.toolStripSeparator1,
            this.menuExit});
      this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
      this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
      this.menuToolStripMenuItem.Text = "Menu";
      // 
      // menuValidate
      // 
      this.menuValidate.Name = "menuValidate";
      this.menuValidate.Size = new System.Drawing.Size(115, 22);
      this.menuValidate.Text = "Validate";
      this.menuValidate.Click += new System.EventHandler(this.btnValidate_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(112, 6);
      // 
      // menuExit
      // 
      this.menuExit.Name = "menuExit";
      this.menuExit.Size = new System.Drawing.Size(115, 22);
      this.menuExit.Text = "Exit";
      this.menuExit.Click += new System.EventHandler(this.btnExit_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(560, 270);
      this.Controls.Add(this.btnExit);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.resultBox);
      this.Controls.Add(this.ssnInput);
      this.Controls.Add(this.lastNameInput);
      this.Controls.Add(this.firstNameInput);
      this.Controls.Add(this.btnValidate);
      this.Controls.Add(this.menuStrip1);
      this.MainMenuStrip = this.menuStrip1;
      this.Margin = new System.Windows.Forms.Padding(2);
      this.Name = "Form1";
      this.Text = "Form1";
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private Button btnValidate;
    private TextBox firstNameInput;
    private TextBox lastNameInput;
    private TextBox ssnInput;
    private RichTextBox resultBox;
    private Label label1;
    private Label label2;
    private Label label3;
    private Button btnExit;
    private MenuStrip menuStrip1;
    private ToolStripMenuItem menuToolStripMenuItem;
    private ToolStripMenuItem menuValidate;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripMenuItem menuExit;
  }
}