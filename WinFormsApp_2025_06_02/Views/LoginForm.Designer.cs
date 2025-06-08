namespace WinFormsApp_2025_06_02
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            userNameLabel = new Label();
            passwordLabel = new Label();
            heading = new Label();
            userNameTxt = new TextBox();
            passwordTxt = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // userNameLabel
            // 
            userNameLabel.AutoSize = true;
            userNameLabel.Location = new Point(54, 73);
            userNameLabel.Name = "userNameLabel";
            userNameLabel.Size = new Size(86, 20);
            userNameLabel.TabIndex = 0;
            userNameLabel.Text = "Username : ";
            userNameLabel.Click += label1_Click;
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Location = new Point(54, 128);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new Size(81, 20);
            passwordLabel.TabIndex = 1;
            passwordLabel.Text = "Password  :";
            passwordLabel.TextAlign = ContentAlignment.TopCenter;
            // 
            // heading
            // 
            heading.AutoSize = true;
            heading.Location = new Point(223, 13);
            heading.Name = "label4";
            heading.Size = new Size(55, 20);
            heading.TabIndex = 2;
            heading.Text = "LOG IN";
            heading.TextAlign = ContentAlignment.MiddleCenter;
            heading.Click += label4_Click;
            // 
            // userName
            // 
            userNameTxt.Location = new Point(148, 70);
            userNameTxt.Name = "userName";
            userNameTxt.Size = new Size(125, 27);
            userNameTxt.TabIndex = 3;
            // 
            // password
            // 
            passwordTxt.Location = new Point(148, 125);
            passwordTxt.Name = "password";
            passwordTxt.Size = new Size(125, 27);
            passwordTxt.TabIndex = 4;
            // 
            // OnLogin
            // 
            button1.Location = new Point(261, 197);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 5;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += this.OnLogin;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(passwordTxt);
            Controls.Add(userNameTxt);
            Controls.Add(heading);
            Controls.Add(passwordLabel);
            Controls.Add(userNameLabel);
            Name = "LoginForm";
            Text = "LoginForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label userNameLabel;
        private Label passwordLabel;
        private Label heading;
        private TextBox userNameTxt;
        private TextBox passwordTxt;
        private Button button1;
    }
}