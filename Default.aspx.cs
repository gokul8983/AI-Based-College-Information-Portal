using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Drawing;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (!Page.IsPostBack)
        {
            txtUsername.Focus();
            
        }
    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {

        try
        {
            Login login = new Login();
            DataTable dt = login.CheckAdminUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                Session["LoginId"] = dt.Rows[0]["Id"].ToString();
                Session["Role"] = "Admin";
                Session["UserName"] = dt.Rows[0]["UserName"].ToString();
                Response.Redirect("~/Common/DashBoard.aspx");
            }
            else
            {
                lblmsg.Text = "Incorrect Credential. Please try again!";
                lblmsg.ForeColor = Color.Red;
            }
        }
        catch (Exception ex)
        {
            lblmsg.Text = ex.Message;
            lblmsg.ForeColor = Color.Red;
        }
    }

    protected void btnStudentLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/StudentLogin.aspx");
        Response.Redirect("~/Default.aspx");
    }
}