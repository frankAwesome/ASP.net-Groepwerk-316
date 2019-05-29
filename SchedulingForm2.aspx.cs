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
    public partial class SchedulingForm2 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ExamProject"].ConnectionString);

        protected void Page_Load(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand del = new SqlCommand("DELETE FROM QuantumTable;", con);
            try
            {
               del.ExecuteNonQuery();
            }
            catch (Exception ex)
            { }

            //con.Close();

            Label4.Visible = false;
            Label5.Visible = false;

            con.Close();

        }

        protected void ImageButton3_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("View.aspx");
        }

        protected void ImageButton1_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Home.aspx");
        }

        protected void ImageButton2_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("Replace.aspx");
        }

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SchedulingForm1.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            
            con.Open();

            SqlCommand cmd = new SqlCommand("INSERT INTO QuantumTable VALUES (1, " + TextBox1.Text + ");", con);
            int i = cmd.ExecuteNonQuery();

            SqlCommand cme = new SqlCommand("INSERT INTO QuantumTable VALUES (2, " + TextBox2.Text + ");", con);
            i = cme.ExecuteNonQuery();

            SqlCommand cmf = new SqlCommand("INSERT INTO QuantumTable VALUES (3, " + TextBox3.Text + ");", con);
            i = cmf.ExecuteNonQuery();

            //SqlCommand cmg = new SqlCommand("INSERT INTO QuantumTable VALUES (4, " + TextBox4.Text + ");", con);
            //i = cmg.ExecuteNonQuery();

            con.Close();

            int one = 0;
            int two = 0;
            int three = 0;

            one = Convert.ToInt16(TextBox1.Text);
            two = Convert.ToInt16(TextBox2.Text);
            three = Convert.ToInt16(TextBox3.Text);

            //Slider minimum settings
            if (one <= two & two <= three)
            {

                if (i != 0)
                {
                    Response.Redirect("SchedulingForm3.aspx");
                }
            }
            else
            {
                Label4.Visible = true;
                Label5.Visible = true;
            }
            //Label5.Text = "INSERT INTO QuantumTable VALUES (1, " + TextBox1.Text + ");";


            

            

        }

        protected void ImageButton6_Click(object sender, ImageClickEventArgs e)
        {
            //do nothing
        }

        protected void ImageButton7_Click(object sender, ImageClickEventArgs e)
        {
            //Donothing
        }
    }
}