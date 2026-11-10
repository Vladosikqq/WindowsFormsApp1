using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class UserForm : Form
    {
        public UserForm()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void canselbutton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void savebutton_Click(object sender, EventArgs e)
        {
            if (loginTextBox.Text == "" || passwordTextBox.Text == "" ||
                (!adminradioButton.Checked && !userradioButton.Checked))
            {
                MessageBox.Show("Заполнены не все поля или не выбрана роль",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var user = new Users()
            {
                Login = loginTextBox.Text,
                Password = passwordTextBox.Text,
                isBlocked = false,
                Role_id = adminradioButton.Checked ? 1 : 2
            };

            try
            {
                using (var context = new GuschinEntities())
                {
                    context.Users.Add(user);
                    context.SaveChanges();
                }
                MessageBox.Show("Пользователь успешно добавлен!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при сохранении: " + ex.Message,
                    "Ошибка БД", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}