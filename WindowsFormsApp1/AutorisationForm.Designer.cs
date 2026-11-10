using System;

namespace WindowsFormsApp1
{
    partial class AutorisationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AutorisationForm));
            this.logintextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.RightTopPictureBox = new System.Windows.Forms.PictureBox();
            this.LeftTopPictureBox = new System.Windows.Forms.PictureBox();
            this.leftButtomPictureBox = new System.Windows.Forms.PictureBox();
            this.RightButtomPictureBox = new System.Windows.Forms.PictureBox();
            this.refrashKaphaButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.RightTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTopPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtomPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightButtomPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // logintextBox
            // 
            this.logintextBox.Location = new System.Drawing.Point(41, 55);
            this.logintextBox.Name = "logintextBox";
            this.logintextBox.Size = new System.Drawing.Size(292, 22);
            this.logintextBox.TabIndex = 0;
            this.logintextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Location = new System.Drawing.Point(41, 115);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(292, 22);
            this.passwordtextBox.TabIndex = 1;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Логин:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Пароль:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // RightTopPictureBox
            // 
            this.RightTopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RightTopPictureBox.Image")));
            this.RightTopPictureBox.Location = new System.Drawing.Point(130, 179);
            this.RightTopPictureBox.Name = "RightTopPictureBox";
            this.RightTopPictureBox.Size = new System.Drawing.Size(83, 64);
            this.RightTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightTopPictureBox.TabIndex = 5;
            this.RightTopPictureBox.TabStop = false;
            // 
            // LeftTopPictureBox
            // 
            this.LeftTopPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LeftTopPictureBox.Image")));
            this.LeftTopPictureBox.Location = new System.Drawing.Point(41, 179);
            this.LeftTopPictureBox.Name = "LeftTopPictureBox";
            this.LeftTopPictureBox.Size = new System.Drawing.Size(83, 64);
            this.LeftTopPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.LeftTopPictureBox.TabIndex = 6;
            this.LeftTopPictureBox.TabStop = false;
            // 
            // leftButtomPictureBox
            // 
            this.leftButtomPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("leftButtomPictureBox.Image")));
            this.leftButtomPictureBox.Location = new System.Drawing.Point(41, 249);
            this.leftButtomPictureBox.Name = "leftButtomPictureBox";
            this.leftButtomPictureBox.Size = new System.Drawing.Size(83, 64);
            this.leftButtomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.leftButtomPictureBox.TabIndex = 7;
            this.leftButtomPictureBox.TabStop = false;
            // 
            // RightButtomPictureBox
            // 
            this.RightButtomPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("RightButtomPictureBox.Image")));
            this.RightButtomPictureBox.Location = new System.Drawing.Point(130, 249);
            this.RightButtomPictureBox.Name = "RightButtomPictureBox";
            this.RightButtomPictureBox.Size = new System.Drawing.Size(83, 64);
            this.RightButtomPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.RightButtomPictureBox.TabIndex = 8;
            this.RightButtomPictureBox.TabStop = false;
            // 
            // refrashKaphaButton
            // 
            this.refrashKaphaButton.Location = new System.Drawing.Point(219, 233);
            this.refrashKaphaButton.Name = "refrashKaphaButton";
            this.refrashKaphaButton.Size = new System.Drawing.Size(114, 23);
            this.refrashKaphaButton.TabIndex = 9;
            this.refrashKaphaButton.Text = "Перемешать";
            this.refrashKaphaButton.UseVisualStyleBackColor = true;
            this.refrashKaphaButton.Click += new System.EventHandler(this.refrashKaphaButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Location = new System.Drawing.Point(41, 341);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(292, 23);
            this.loginButton.TabIndex = 10;
            this.loginButton.Text = "Войти";
            this.loginButton.UseVisualStyleBackColor = true;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // AutorisationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 442);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.refrashKaphaButton);
            this.Controls.Add(this.RightButtomPictureBox);
            this.Controls.Add(this.leftButtomPictureBox);
            this.Controls.Add(this.LeftTopPictureBox);
            this.Controls.Add(this.RightTopPictureBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordtextBox);
            this.Controls.Add(this.logintextBox);
            this.MaximumSize = new System.Drawing.Size(389, 489);
            this.MinimumSize = new System.Drawing.Size(389, 489);
            this.Name = "AutorisationForm";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AutorisationForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.RightTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LeftTopPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leftButtomPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RightButtomPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox logintextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox RightTopPictureBox;
        private System.Windows.Forms.PictureBox LeftTopPictureBox;
        private System.Windows.Forms.PictureBox leftButtomPictureBox;
        private System.Windows.Forms.PictureBox RightButtomPictureBox;
        private System.Windows.Forms.Button refrashKaphaButton;
        private System.Windows.Forms.Button loginButton;

        // Просто добавь эти пустые методы обратно в код
        private void AutorisationForm_Load(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void passwordtextBox_TextChanged(object sender, EventArgs e) { }
    }
}