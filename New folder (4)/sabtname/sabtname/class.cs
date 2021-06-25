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
    public partial class @class : Form
    {

        public static SqlConnection con4;
        public static SqlCommand cmd4;
        public static SqlDataAdapter da4;
        public static DataTable dt4;


        void lmi4()
        {


            string sqlstr4 = "select* from class ";
            cmd4 = new SqlCommand(sqlstr4, con4);
            da4 = new SqlDataAdapter(cmd4);
            dt4 = new DataTable();
            da4.Fill(dt4);
        }



        public @class()
        {
            InitializeComponent();
            string cs4 = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename='|DataDirectory|\\school.mdf';Integrated Security=True";
            con4 = new SqlConnection(cs4);
            con4.Open();

            lmi4();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")

            {
                cmd4 = new SqlCommand("addclass", con4);

                cmd4.CommandType = CommandType.StoredProcedure;
                cmd4.Parameters.AddWithValue("@classid", textBox2.Text);

                cmd4.Parameters.AddWithValue("@name", textBox1.Text);

                cmd4.ExecuteNonQuery();

                MessageBox.Show("اطلاعات با موفقیت ذخیره شد");
                textBox1.Text = "";
                textBox2.Text = "";
                lmi4();
            }

            else
                MessageBox.Show("فیلدها نمیتوانند خالی باشند");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            cmd4 = new SqlCommand("dec", con4);
            cmd4.CommandType = CommandType.StoredProcedure;
            cmd4.Parameters.AddWithValue("@classid", textBox2.Text);
            cmd4.Parameters.AddWithValue("@name", textBox1.Text);
            cmd4.ExecuteNonQuery();
            MessageBox.Show(" کلاس باموفقیت حذف شد");
            textBox1.Text = "";
            textBox2.Text = "";

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form main = new student();
            main.Show();
            this.Close();
        }

        private void dataclass_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void class_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            lmi4();
            dataclass.DataSource = @class.dt4;
        }



        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            SqlCommand str = new SqlCommand("SELECT * FROM class WHERE classid=@classid ", con4);
            da4 = new SqlDataAdapter(str);
            str.Parameters.AddWithValue("classid",textBox2.Text);


            DataTable tb = new DataTable();
            da4.Fill(tb);
            if (tb.Rows.Count <= 0)
            {
                MessageBox.Show("آی دی مورد نظر یافت نشد");
            }
            else
            {
                textBox2.Text = tb.Rows[0][0].ToString();
                textBox1.Text = tb.Rows[0][1].ToString();
              


            }
        }
    }
}