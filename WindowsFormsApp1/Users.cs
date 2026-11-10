namespace WindowsFormsApp1
{
    using System;
    using System.Collections.Generic;

    public partial class Users
    {
        public int id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public Nullable<int> Role_id { get; set; }
        public Nullable<bool> isBlocked { get; set; }

        public virtual Roles Roles { get; set; }

        public override string ToString()
        {
            // Если Role_id = 1, пишем "Admin". Иначе (если 2) - "User"
            string roleName = Role_id == 1 ? "Admin" : "User";

            // Выводим: ID Логин Роль Статус
            return $"{id} {Login} {roleName} {isBlocked}";
        }
    }
}