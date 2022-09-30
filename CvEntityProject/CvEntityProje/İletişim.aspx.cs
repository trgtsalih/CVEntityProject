using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class İletişim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTİTYEntities db = new DBCVENTİTYEntities();
            var mesajlar = db.TBLILETISIM.ToList();
            Repeater1.DataSource = mesajlar;
            Repeater1.DataBind();
        }
    }
}