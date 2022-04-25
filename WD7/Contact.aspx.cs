using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WD7
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RealUser"] != null)
            {
                Label1.Text = "歡迎" + Convert.ToString(Session["RealUser"]) + "登入";
                Panel1.Visible = true;
            }
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            string songname;
            for (int j = 0; j < 7; j++)
            {
                songname = GridView1.Rows[j].Cells[3].Text.ToString();
                if (songname.Trim() == TextBox1.Text.Trim())
                {
                    GridView1.Rows[j].BackColor = System.Drawing.Color.LightSkyBlue;
                }
                else
                {
                    GridView1.Rows[j].BackColor = System.Drawing.Color.White;
                }
            }
        }
    }
}