using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing.Drawing2D;
using System.Text.RegularExpressions;
using System.IO;


namespace WindowsFormsApp4
{
    public partial class login : Form

    {
        int i, max1;
        
         private static SqlConnection con;
        private static SqlCommand cmd;
        private static SqlDataAdapter da;
        private static DataTable dt;
        void lmi()
        {


            string sqlstr = "select* from admin ";
            cmd = new SqlCommand(sqlstr, con);
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();

            da.Fill(dt);
        }

        
        public login()
        {
            InitializeComponent();


            string cs = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\school.mdf';Integrated Security=True";
            con = new SqlConnection(cs);
            con.Open();

            lmi();




        }

        void view()

        {
            while (i < max1 - 1)
            {
                i++;
                if (usename.Text == dt.Rows[i]["username"].ToString())
                {


                    idname.Text = dt.Rows[i]["idname"].ToString();
                    SqlCommand cm2 = new SqlCommand("login", con);
                    cm2.CommandType = CommandType.StoredProcedure;
                    cm2.Parameters.AddWithValue("@idname", idname.Text);
                    cm2.Parameters.AddWithValue("@username", usename.Text);

                    MessageBox.Show("به سیتم ثبت نام خوش آمدید");
                    cm2.ExecuteNonQuery();
                  
                    Form fr2 = new student();
                    fr2.Show();
                    this.Hide();

                    break;
                }

                else
                {
                    MessageBox.Show("رمز یا نام کاربری را اشتباه شده است");
                }

            }
           
        }
        private void log_Click(object sender, EventArgs e)
        {
            i = -1;
            if (usename.Text != "")
            {

                cmd.CommandText = "SELECT count(*) FROM admin ";

                max1= (int)cmd.ExecuteScalar();

                view();

            }

            




        }



        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                idname.PasswordChar = '\0';
            }
            else
            {
                idname.PasswordChar = '*';
            }
        }

        private void idname_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void usename_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
