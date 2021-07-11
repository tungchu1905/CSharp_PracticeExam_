using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Summer_2020_B5_DO_Web
{
    public partial class MainScreen : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            gvBooks.DataSource = Database.getAllBook();
            gvBooks.DataBind();
        }
    }
}