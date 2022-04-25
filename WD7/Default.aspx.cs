using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WD7
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RealUser"] != null)
            {
                Label1.Text = "歡迎" + Convert.ToString(Session["RealUser"]) + "登入";
                MyPanel.Visible = true;
            }
        }
    }
}