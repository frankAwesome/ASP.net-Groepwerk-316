using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace ExamProject
{
    public partial class Replace : System.Web.UI.Page
    {
        StreamReader sr;

        StreamWriter wr;


        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("View.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            //Replace
            sr = new StreamReader(HttpContext.Current.Server.MapPath("~") + "TextFile.txt");
            String line = sr.ReadToEnd();
            sr.Close();

            wr = new StreamWriter(HttpContext.Current.Server.MapPath("~") + "TextFile.txt");


            //string sNew = "two";
            //string sOld = "hello";

            try
            {
                string sNew = TextBox1.Text;
                string sOld = TextBox2.Text;

                string firstNames = line.Replace(sNew, sOld);

                wr.Write(firstNames);
            }
            catch (Exception)
            { }

            wr.Close();
        }
    }
}