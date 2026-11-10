namespace WindowsFormsApp1
{
    partial class UserForm
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
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.adminradioButton = new System.Windows.Forms.RadioButton();
            this.userradioButton = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.savebutton = new System.Windows.Forms.Button();
            this.canselbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(199, 37);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(195, 22);
            this.loginTextBox.TabIndex = 0;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(199, 92);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(195, 22);
            this.passwordTextBox.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.userradioButton);
            this.groupBox1.Controls.Add(this.adminradioButton);
            this.groupBox1.Location = new System.Drawing.Point(42, 162);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 100);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // adminradioButton
            // 
            this.adminradioButton.AutoSize = true;
            this.adminradioButton.Location = new System.Drawing.Point(215, 21);
            this.adminradioButton.Name = "adminradioButton";
            this.adminradioButton.Size = new System.Drawing.Size(131, 20);
            this.adminradioButton.TabIndex = 0;
            this.adminradioButton.TabStop = true;
            this.adminradioButton.Text = "Администратор";
            this.adminradioButton.UseVisualStyleBackColor = true;
            // 
            // userradioButton
            // 
            this.userradioButton.AutoSize = true;
            this.userradioButton.Location = new System.Drawing.Point(215, 57);
            this.userradioButton.Name = "userradioButton";
            this.userradioButton.Size = new System.Drawing.Size(123, 20);
            this.userradioButton.TabIndex = 1;
            this.userradioButton.TabStop = true;
            this.userradioButton.Text = "Пользователь";
            this.userradioButton.UseVisualStyleBackColor = true;
            this.userradioButton.CheckedChanged += new System.EventHandler(this.radioButton2_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.TabIndex = 4;
            this.label1.Text = "Логин";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "Пароль";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(63, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Роль";
            // 
            // savebutton
            // 
            this.savebutton.Location = new System.Drawing.Point(75, 287);
            this.savebutton.Name = "savebutton";
            this.savebutton.Size = new System.Drawing.Size(273, 23);
            this.savebutton.TabIndex = 6;
            this.savebutton.Text = "Сохранить";
            this.savebutton.UseVisualStyleBackColor = true;
            this.savebutton.Click += new System.EventHandler(this.savebutton_Click);
            // 
            // canselbutton
            // 
            this.canselbutton.Location = new System.Drawing.Point(75, 337);
            this.canselbutton.Name = "canselbutton";
            this.canselbutton.Size = new System.Drawing.Size(273, 23);
            this.canselbutton.TabIndex = 7;
            this.canselbutton.Text = "Отмена";
            this.canselbutton.UseVisualStyleBackColor = true;
            this.canselbutton.Click += new System.EventHandler(this.canselbutton_Click);
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(421, 450);
            this.Controls.Add(this.canselbutton);
            this.Controls.Add(this.savebutton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Name = "UserForm";
            this.Text = "Оконо пользователя";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton userradioButton;
        private System.Windows.Forms.RadioButton adminradioButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button savebutton;
        private System.Windows.Forms.Button canselbutton;
    }
}