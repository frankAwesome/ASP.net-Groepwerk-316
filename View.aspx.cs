using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ExamProject
{
    public partial class View : System.Web.UI.Page
    {
        StreamReader sr;

        StreamWriter wr;

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Replace.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            sr = new StreamReader(HttpContext.Current.Server.MapPath("~") + "TextFile.txt");
            String line = sr.ReadToEnd();
            TextBox1.Text = line;
            sr.Close();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SchedulingForm1.aspx");
        }
    }
}