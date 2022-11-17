using System;
using System.Data;
using System.Drawing;
using System.Web.UI;

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
            DataTable dt = login.CheckStudentUser(txtUsername.Text.Trim(), txtPassword.Text.Trim());
            if (dt.Rows.Count > 0)
            {
                Session["LoginId"] = dt.Rows[0]["Id"].ToString();
                Session["UserName"] = dt.Rows[0]["StudentName"].ToString();
                Session["Role"] = "Student";
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



    protected void btnAdminLogin_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Default.aspx");
    }

    protected void btnStudentRegistration_Click(object sender, EventArgs e)
    {
        Response.Redirect("~/Student/StudentRegistration.aspx");
    }
}