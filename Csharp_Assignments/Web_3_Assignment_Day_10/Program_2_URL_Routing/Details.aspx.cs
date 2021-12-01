using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;

public partial class Details : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Page.RouteData.Values["ID"].ToString() != null)
        {
            string strId = Page.RouteData.Values["id"].ToString();
            DisplayArticle(strId);
        }

        void DisplayArticle(string strId)
        {
            string strConn = "Server=.;Database=AspFormDB;Trusted_Connection=true";
            SqlConnection conn = new SqlConnection(strConn);
            SqlDataAdapter da = new SqlDataAdapter("select Id,Title,Description,author from Articletable where Id=" + strId, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, "Articletable");
            lblTitle.Text = ds.Tables["Articletable"].Rows[0][1].ToString();
            lblDescription.Text = ds.Tables["Articletable"].Rows[0][2].ToString();
            lblauthor.Text = ds.Tables["Articletable"].Rows[0][3].ToString();
        }
    }

}