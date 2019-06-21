using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using database_exercise.DAL; //żeby nie wpisywać DAL. przed każdym odniesieniem do folderu DAL
namespace database_exercise
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DBConnection con = DBConnection.Instance;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            UsersRepository us = new UsersRepository();
            us.getAllUsers();
        }
    }
}
