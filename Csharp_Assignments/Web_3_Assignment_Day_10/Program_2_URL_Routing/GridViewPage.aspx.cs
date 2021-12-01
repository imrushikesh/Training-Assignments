using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

public partial class GridViewPage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        GridView1.DataSource = GetData();
        GridView1.DataBind();
    }

    private DataTable GetData()
    {
        string strConn = "Server=.;Database=AspFormDB;Trusted_Connection=true";
        SqlConnection conn = new SqlConnection(strConn);
        SqlDataAdapter da = new SqlDataAdapter("select Id,Title,Description,author from Articletable", conn);
        DataSet ds = new DataSet();
        da.Fill(ds, "MyTestTable");
        return ds.Tables["MyTestTable"];
    }

    protected string getTitle(Object str)
    {
        return str.ToString().Replace(' ', '-');
    }
}