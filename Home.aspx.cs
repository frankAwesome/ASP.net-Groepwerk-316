﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ExamProject
{
    
    public partial class Home : System.Web.UI.Page
    {
        bool bRun;

        //static Mutex mutex = new Mutex(true, "Replace");
        //[STAThread]

        protected void Page_Load(object sender, EventArgs e)
        {
            //if (mutex.WaitOne(TimeSpan.Zero, true))
            //{
                //moved to on unload
                //mutex.ReleaseMutex();

           // }
            //else
            //{
            //    Response.Redirect("Error.aspx");
           // }

            //bRun = true;
        }

        protected void Page_UnLoad(object sender, EventArgs e)
        {
            //if (bRun)
                //mutex.ReleaseMutex();
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {

        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {

        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Replace.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("View.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SchedulingForm1.aspx");
        }
    }
}