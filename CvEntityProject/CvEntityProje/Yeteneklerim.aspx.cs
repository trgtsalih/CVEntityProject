using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace CvEntityProje
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBCVENTİTYEntities db = new DBCVENTİTYEntities();
            Repeater1.DataSource = db.TBLYETENEKLER.ToList();
            Repeater1.DataBind();
        }
    }
}