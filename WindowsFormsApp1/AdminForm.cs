using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AdminForm : Form
    {
        public AdminForm()
        {
            InitializeComponent();
            RefreshUserList();
        }

        private void RefreshUserList()
        {
            userListBox1.Items.Clear();
            userListBox1.Items.AddRange(
                GuschinEntities.GetContext().Users.ToArray());
        }

        private void changeStatusbutton_Click(object sender, EventArgs e)
        {
            if (userListBox1.SelectedItem == null)
            {
                MessageBox.Show("Сначала выберите пользователя!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedUser = userListBox1.SelectedItem as Users;

            try
            {
                using (var context = new GuschinEntities())
                {
                    var userToUpdate = context.Users.Find(selectedUser.id);

                    if (userToUpdate != null)
                    {
                        userToUpdate.isBlocked = !userToUpdate.isBlocked;
                        context.SaveChanges();
                    }
                }
                RefreshUserList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при смене статуса: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DeleteUserButton_Click(object sender, EventArgs e)
        {
            if (userListBox1.SelectedItem == null)
            {
                MessageBox.Show("Выберите пользователя для удаления!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = userListBox1.SelectedItem as Users;

            var result = MessageBox.Show($"Удалить пользователя {user.Login}?", "Подтверждение", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                try
                {
                    using (var context = new GuschinEntities())
                    {
                        var userToDelete = context.Users.Find(user.id);
                        if (userToDelete != null)
                        {
                            context.Users.Remove(userToDelete);
                            context.SaveChanges();
                        }
                    }
                    RefreshUserList();
                    MessageBox.Show("Пользователь удален!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ошибка при удалении: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void addNewUserbutton_Click(object sender, EventArgs e)
        {
            UserForm userForm = new UserForm();
            userForm.ShowDialog();
            RefreshUserList();
        }

        private void elutUserbutton_Click(object sender, EventArgs e)
        {

        }
    }
}