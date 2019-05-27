using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        //String text = "";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
      
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm1.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm2.aspx");


        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void ImageButton3_Click1(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton3_Click2(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void ImageButton3_Click3(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("WebForm3.aspx");
        }

        protected void ImageButton4_Click1(object sender, ImageClickEventArgs e)
        {
                using (StreamReader sr = new StreamReader(HttpContext.Current.Server.MapPath("~") + "TextFile.txt"))
                {
                    // Read the stream to a string, and write the string to the console.
                    String line = sr.ReadToEnd();
                    //Console.WriteLine(line);
                    TextBoxShow.Text = line;
                }

        }
    }
}