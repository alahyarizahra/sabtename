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
    public partial class admin : Form
    {

        public static SqlConnection con3;
        public static SqlCommand cmd3;
        public static SqlDataAdapter da3;
        public static DataTable dt3;
        void lmi3()
        {


            string sqlstr3 = "select* from admin ";
            cmd3= new SqlCommand(sqlstr3,con3);
          da3 = new SqlDataAdapter(cmd3);
            dt3 = new DataTable();
           da3.Fill(dt3);
        }
        public admin()
        {
            InitializeComponent();

            string cs3 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\school.mdf';Integrated Security=True";
           con3= new SqlConnection(cs3);
            con3.Open();

            lmi3();
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (ida.Text != "" && usa.Text != "" && pass.Text != "" && email.Text != "")

            {
               cmd3 = new SqlCommand("addadmin", con3);

               cmd3.CommandType = CommandType.StoredProcedure;

                cmd3.Parameters.AddWithValue("@id", ida.Text);
                cmd3.Parameters.AddWithValue("@idname",pass.Text);
                cmd3.Parameters.AddWithValue("@username", usa.Text);
                cmd3.Parameters.AddWithValue("@email", email.Text);
                cmd3.ExecuteNonQuery();
                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                ida.Text = pass.Text = usa.Text = email.Text = "";
                lmi3();
            }

            else
                MessageBox.Show("فیلدها نمیتوانند خالی باشند");
        }

        private void usa_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void report_Click(object sender, EventArgs e)
        {
            lmi3();
            dt3.Columns[0].ColumnName = "کد";
            dt3.Columns[1].ColumnName = "رمز";
            dt3.Columns[2].ColumnName = "نام کاربری ";
            dt3.Columns[3].ColumnName = "ایمیل";
            
            dataadmin.DataSource = admin.dt3;
            
        }

        private void delet_Click(object sender, EventArgs e)
        {

          cmd3 = new SqlCommand("dea", con3);
            cmd3.CommandType = CommandType.StoredProcedure;
            cmd3.Parameters.AddWithValue("@id", ida.Text);
            cmd3.Parameters.AddWithValue("@idname", pass.Text);
            cmd3.Parameters.AddWithValue("@username", usa.Text);
            cmd3.Parameters.AddWithValue("@email", email.Text);
            cmd3.ExecuteNonQuery();
            MessageBox.Show("اطلاعات با موفقیت حذف شد");
            ida.Text = usa.Text = pass.Text = email.Text = "";
        }

        private void update_Click(object sender, EventArgs e)
        {
            if (ida.Text != "" && usa.Text != "" && pass.Text != "" && email.Text != "")

            {


                cmd3 = new SqlCommand("upa", con3);
                cmd3.CommandType = CommandType.StoredProcedure;
                cmd3.Parameters.AddWithValue("@id", ida.Text);
                cmd3.Parameters.AddWithValue("@idname", pass.Text);
                cmd3.Parameters.AddWithValue("@username", usa.Text);
                cmd3.Parameters.AddWithValue("@email", email.Text);
                cmd3.ExecuteNonQuery();
                 MessageBox.Show("اطلاعات مورد نظر بروزرسانی شدند");
                ida.Text = pass.Text = usa.Text = email.Text = "";

            }
            else
                MessageBox.Show("فیلدها نمیتوانند خالی باشند");
        }

        private void معلمToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form fr2 = new teacher();
            fr2.Show();
            this.Hide();
        }

        private void admin_Load(object sender, EventArgs e)
        {
        }

        private void دانشآموزToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr1 = new student();
            fr1.Show();
            this.Hide();
        }

        private void خروجToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ida_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand("SELECT * FROM admin WHERE id=@id ", con3);
            da3 = new SqlDataAdapter(str);
            str.Parameters.AddWithValue("id", ida.Text);


            DataTable tb = new DataTable();
            da3.Fill(tb);
            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("آی دی مورد نظر یافت نشد");
            }
            else
            {
                ida.Text = tb.Rows[0][0].ToString();
               usa.Text = tb.Rows[0][1].ToString();
               pass.Text = tb.Rows[0][2].ToString();
               email.Text = tb.Rows[0][3].ToString();

               
            }
        }

        private void کلاسToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fr4 = new @class();
            fr4.Show();
            this.Hide();
        }
    }
}
