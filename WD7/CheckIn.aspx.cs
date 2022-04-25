using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;


namespace WD7
{
    public partial class CheckIn : System.Web.UI.Page
    {
        SqlConnection X;
        SqlCommand Q;
        string S,LoginUser;
        static int errortimes = 0;
        protected string findmember(Label L)
        {
            L.Text = "身分認證中";
            Q = X.CreateCommand();
            S = "Select * from [table] where 代號 = "+"'"+ LoginUser + "'";
            L.Text = "SQL語言=" + S;
            Q.CommandText = S;
            Q.ExecuteNonQuery();
            SqlDataReader R = Q.ExecuteReader();
            if (R.Read() == true)
            {
                L.Text = "有此會員";
                String Pwd = Convert.ToString(R["密碼"]);
                return Pwd;
            }
            else
            {
                L.Text = "查無此人";
                return null;
            }
        }
        protected void opendata(Label L)
        {
            X = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\lin\Desktop\作業專區\大二課程\高等視窗程式設計\WD7\WD7\App_Data\Girl.mdf;Integrated Security=True");
            if (X.State == System.Data.ConnectionState.Closed)
            {
                try
                {
                    X.Open();
                    L.Text = "連通成功!!";
                }
                catch (Exception)
                {
                    L.Text = "連通失敗";
                }
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            LoginUser = TextBox1.Text;
            opendata(Label3);
            string CorrectPwd = TextBox2.Text;
            string InputPwd = findmember(Label4);
            if (InputPwd == CorrectPwd)
            {
                Label4.Text = "密碼正確";
                Session["RealUser"] = LoginUser;
                Response.Redirect("Default.aspx");
            }
            else
            {
                Label4.Text = "密碼錯誤";
                errortimes++;
                if(errortimes == 3)
                {
                    Button1.Enabled = false;
                    TextBox2.ReadOnly = true;
                    Label4.Text = "密碼錯誤超過3次，無法再次輸入";
                    Response.Redirect("Handle.aspx");
                }
            }
            X.Close();
        }
    }
}