using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data; //datareader

namespace database_exercise.DAL
{
    class User
    {
        public int id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Bithrday { get; set; }
        public User(IDataReader dataReader)
        {
            id = (int)dataReader["id_u"];
            FirstName = dataReader["fname"].ToString();
            LastName = dataReader["lname"].ToString();
            Bithrday = (DateTime)dataReader["bdate"];
        }
        public override string ToString()
        {
            return $"{id}. {FirstName} {LastName}, {Bithrday}";
        }
    }
}
