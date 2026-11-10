namespace WindowsFormsApp1
{
    partial class AdminForm
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
            this.userListBox1 = new System.Windows.Forms.ListBox();
            this.addNewUserbutton = new System.Windows.Forms.Button();
            this.elutUserbutton = new System.Windows.Forms.Button();
            this.DeleteUserbutton = new System.Windows.Forms.Button();
            this.changeStatusbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // userListBox1
            // 
            this.userListBox1.FormattingEnabled = true;
            this.userListBox1.ItemHeight = 16;
            this.userListBox1.Location = new System.Drawing.Point(12, 12);
            this.userListBox1.Name = "userListBox1";
            this.userListBox1.Size = new System.Drawing.Size(486, 340);
            this.userListBox1.TabIndex = 0;
            // 
            // addNewUserbutton
            // 
            this.addNewUserbutton.Location = new System.Drawing.Point(12, 358);
            this.addNewUserbutton.Name = "addNewUserbutton";
            this.addNewUserbutton.Size = new System.Drawing.Size(486, 23);
            this.addNewUserbutton.TabIndex = 1;
            this.addNewUserbutton.Text = "Добавить нового пользователя";
            this.addNewUserbutton.UseVisualStyleBackColor = true;
            this.addNewUserbutton.Click += new System.EventHandler(this.addNewUserbutton_Click);
            // 
            // elutUserbutton
            // 
            this.elutUserbutton.Location = new System.Drawing.Point(12, 387);
            this.elutUserbutton.Name = "elutUserbutton";
            this.elutUserbutton.Size = new System.Drawing.Size(486, 23);
            this.elutUserbutton.TabIndex = 2;
            this.elutUserbutton.Text = "Редактировать пользователя";
            this.elutUserbutton.UseVisualStyleBackColor = true;
            this.elutUserbutton.Click += new System.EventHandler(this.elutUserbutton_Click);
            // 
            // DeleteUserbutton
            // 
            this.DeleteUserbutton.Location = new System.Drawing.Point(12, 416);
            this.DeleteUserbutton.Name = "DeleteUserbutton";
            this.DeleteUserbutton.Size = new System.Drawing.Size(486, 23);
            this.DeleteUserbutton.TabIndex = 3;
            this.DeleteUserbutton.Text = "Удалить пользователя";
            this.DeleteUserbutton.UseVisualStyleBackColor = true;
            this.DeleteUserbutton.Click += new System.EventHandler(this.DeleteUserButton_Click);
            // 
            // changeStatusbutton
            // 
            this.changeStatusbutton.Location = new System.Drawing.Point(12, 445);
            this.changeStatusbutton.Name = "changeStatusbutton";
            this.changeStatusbutton.Size = new System.Drawing.Size(486, 23);
            this.changeStatusbutton.TabIndex = 4;
            this.changeStatusbutton.Text = "Сменить статус блокировки";
            this.changeStatusbutton.UseVisualStyleBackColor = true;
            this.changeStatusbutton.Click += new System.EventHandler(this.changeStatusbutton_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 535);
            this.Controls.Add(this.changeStatusbutton);
            this.Controls.Add(this.DeleteUserbutton);
            this.Controls.Add(this.elutUserbutton);
            this.Controls.Add(this.addNewUserbutton);
            this.Controls.Add(this.userListBox1);
            this.Name = "AdminForm";
            this.Text = "Окно администратора";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox userListBox1;
        private System.Windows.Forms.Button addNewUserbutton;
        private System.Windows.Forms.Button elutUserbutton;
        private System.Windows.Forms.Button DeleteUserbutton;
        private System.Windows.Forms.Button changeStatusbutton;
    }
}