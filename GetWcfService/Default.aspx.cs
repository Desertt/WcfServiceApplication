using System;

public partial class _Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        NewService.MathClient service = new NewService.MathClient();

        Label1.Text = service.Topla(50, 50).ToString();

    }
}