using System;
using System.Linq;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class AutorisationForm : Form
    {
        public AutorisationForm()
        {
            InitializeComponent();
        }

        bool capchaFlag = false;
        string loginUser = "";
        int valueError = 0;

        
        private void refrashKaphaButton_Click(object sender, EventArgs e)
        {
            capchaFlag = !capchaFlag;
            var picter = LeftTopPictureBox.Image;
            LeftTopPictureBox.Image = RightTopPictureBox.Image;
            RightTopPictureBox.Image = picter;

            picter = leftButtomPictureBox.Image;
            leftButtomPictureBox.Image = RightButtomPictureBox.Image;
            RightButtomPictureBox.Image = picter;
        }

        
        private void loginButton_Click(object sender, EventArgs e)
        {
            if (logintextBox.Text == "" || passwordtextBox.Text == "")
            {
                MessageBox.Show("Заполнены не все поля",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
                var user = GuschinEntities.GetContext().Users
                .FirstOrDefault(us => us.Login == logintextBox.Text);

            if (user == null)
            {
                MessageBox.Show("Логин или пароль неправильный!",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            
            if (user.isBlocked == true)
            {
                MessageBox.Show("Ваша учетная запись, заблокирована, обратитесь к администратору",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            
            if (user.Login != loginUser)
            {
                loginUser = user.Login;
                valueError = 0;
            }

            
            if (capchaFlag == false)
            {
                valueError++;
                MessageBox.Show("Неправильно собрана капча!",
                    "Ошибка",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                
                if (valueError >= 3)
                {
                    user.isBlocked = true;
                    GuschinEntities.GetContext().SaveChanges();
                    MessageBox.Show("Вы заблокированы за 3 неверные попытки!", "Блокировка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            
            if (user.Password != passwordtextBox.Text)
            {
                valueError++;
                MessageBox.Show("Вы ввели неправильный пароль!",
                    "Ошибка авторизации",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                
                if (valueError >= 3)
                {
                    user.isBlocked = true;
                    GuschinEntities.GetContext().SaveChanges();
                    MessageBox.Show("Вы заблокированы за 3 неверные попытки!", "Блокировка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                return;
            }

            
            if (user.Role_id == 1)
            {
                
                AdminForm adminForm = new AdminForm();
                adminForm.ShowDialog();
                return;
            }

            if (user.Role_id == 2)
            {
                MessageBox.Show(user.Login + ", вы вошли!",
                    "Успешная авторизация",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                return;
            }
        }
    }
}