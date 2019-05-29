using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data;
using System.Web.Configuration;

namespace ExamProject
{
    public partial class SchedulingForm1 : System.Web.UI.Page
    {


        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ExamProject"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand del = new SqlCommand("DELETE FROM TimeTable;", con);
            try
            {
                del.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

            con.Close();


            //DropDownList1.SelectedIndex = 1;
            //DropDownList2.SelectedIndex = 1;

            //DropDownList3.SelectedIndex = 1;
            //DropDownList4.SelectedIndex = 1;

            //DropDownList5.SelectedIndex = 1;
            //DropDownList6.SelectedIndex = 1;

            //DropDownList7.SelectedIndex = 1;
            //DropDownList8.SelectedIndex = 1;
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Replace.aspx");
        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("View.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            try
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("INSERT INTO TimeTable VALUES (1, " + DropDownList1.SelectedValue + ", " + DropDownList2.SelectedValue + ", 1);", con);
                int i = cmd.ExecuteNonQuery();

                SqlCommand cme = new SqlCommand("INSERT INTO TimeTable VALUES (2, " + DropDownList3.SelectedValue + ", " + DropDownList4.SelectedValue + ", 2);", con);
                i = cme.ExecuteNonQuery();

                SqlCommand cmf = new SqlCommand("INSERT INTO TimeTable VALUES (3, " + DropDownList5.SelectedValue + ", " + DropDownList6.SelectedValue + ", 1);", con);
                i = cmf.ExecuteNonQuery();

                con.Close();

                //Label1.Text = "INSERT INTO TimeTable VALUES (1, " + DropDownList1.SelectedValue + ", " + DropDownList2.SelectedValue + ", 1);";




                if (i != 0)
                {
                    //MessageBox.Show(i + "Data Saved");
                    Response.Redirect("SchedulingForm2.aspx");
                }
            }
            catch (Exception ex)
            { }
        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            //do nothing
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            //Do nothing
        }
    }
}