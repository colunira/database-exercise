using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace database_exercise.DAL
{
    class UsersRepository
    {
        #region queries
        private const string SELECT_ALL_USERS = "select * from users";
        #endregion
        MySqlConnection connection = DBConnection.Instance.Connection;
        List<User> users = new List<User>();
        public void getAllUsers()
        {
            using (MySqlCommand command = new MySqlCommand(SELECT_ALL_USERS, connection)) //wyrzuca obiekt po zakończeniu, read only
            {
                connection.Open();
                MySqlDataReader dr=command.ExecuteReader();
                while (dr.Read())
                {
                    users.Add(new DAL.User(dr));
                }
                connection.Close();
            }
            foreach (var u in users)
            {
                Console.WriteLine(u);
            }
        }
    }
}
