using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using System.Threading;

namespace ExamProject
{
    public partial class Replace : System.Web.UI.Page
    {
        StreamReader sr;

        StreamWriter wr;

        String line;


        protected void Page_Load(object sender, EventArgs e)
        {
            Label1.Visible = false;
            Label2.Visible = false;

            //Replace
            sr = new StreamReader(HttpContext.Current.Server.MapPath("~") + "TextFile.txt");
            line = sr.ReadToEnd();
            sr.Close();



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
            //string sNew = "two";
            //string sOld = "hello";
            wr = new StreamWriter(HttpContext.Current.Server.MapPath("~") + "TextFile.txt");

            string sNew = TextBox1.Text;
                string sOld = TextBox2.Text;

                if (sNew == string.Empty)
                {
                    Label1.Visible = true;
                }
                else
                {
                    if (sOld == string.Empty)
                    {
                        Label2.Visible = true;
                    }
                    else if (sNew.Length >= 2 && sOld.Length >= 2)
                    {
                        string firstNames = line.Replace(sNew, sOld);

                        wr.Write(firstNames);
                    }
                    
                }

            wr.Close();
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SchedulingForm1.aspx");
        }
    }
}