using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WD7
{
    public partial class About : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["RealUser"] != null)
            {
                Label1.Text = "歡迎" + Convert.ToString(Session["RealUser"]) + "登入";
                Panel1.Visible = true;
                Label2.Text = "2007年8月5日以《Into The New World》一曲正式出道。"+
                    "初時由九名成員組成，成員包括有太妍、潔西卡、珊妮、蒂芬妮、孝淵、俞利、秀英、潤娥及徐玄。";
                Label3.Text = "官方粉絲名叫「S♡NE」（소원，讀音似英文的So One，韓文意思為「願望」）";
                Label4.Text = "2014年9月30日，時為成員的潔西卡表示因與公司未能達成共識而退出少女時代，後期組合以八人形式進行活動";
            }
        }
    }
}