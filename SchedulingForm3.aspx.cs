using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading;
using System.Web.Configuration;
using System.Data.SqlClient;

namespace ExamProject
{
    public partial class SchedulingForm3 : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(WebConfigurationManager.ConnectionStrings["ExamProject"].ConnectionString);

        int iP1Start = 0;
        int iP1Burst = 0;
        int iP1Priority = 0;
        int iP1Quantum = 0;

        int iP2Start = 0;
        int iP2Burst = 0;
        int iP2Priority = 0;
        int iP2Quantum = 0;

        int iP3Start = 0;
        int iP3Burst = 0;
        int iP3Priority = 0;
        int iP3Quantum = 0;



        protected void Page_Load(object sender, EventArgs e)
        {
            string connString = WebConfigurationManager.ConnectionStrings["ExamProject"].ConnectionString;


            //1
            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select StartTime from TimeTable where Id =1";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP1Start = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select BurstTime from TimeTable where Id =1";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP1Burst = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select Priority from TimeTable where Id =1";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP1Priority = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select TimeQuantum from QuantumTable where Id =1";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP1Quantum = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }


            //2
            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select StartTime from TimeTable where Id =2";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP2Start = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select BurstTime from TimeTable where Id =2";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP2Burst = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select Priority from TimeTable where Id =2";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP2Priority = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select TimeQuantum from QuantumTable where Id =2";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP2Quantum = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }


            //3
            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select StartTime from TimeTable where Id =3";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP3Start = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select BurstTime from TimeTable where Id =3";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP3Burst = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select Priority from TimeTable where Id =3";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP3Priority = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }

            using (var conn = new SqlConnection(connString))
            {
                string sqlString = @"select TimeQuantum from QuantumTable where Id =3";
                using (var command = new SqlCommand(sqlString, conn))
                {
                    conn.Open();
                    var result = command.ExecuteScalar();
                    iP3Quantum = Convert.ToInt16(result.ToString());
                    conn.Close();
                }
            }


            //process details

            Label1.Text = "Start time: "+iP1Start.ToString();
            Label5.Text = "Start time: " + iP2Start.ToString();
            Label9.Text = "Start time: " + iP3Start.ToString();

            Label2.Text = "Burst time: " + iP1Burst.ToString();
            Label6.Text = "Burst time: " + iP2Burst.ToString();
            Label10.Text = "Burst time: " + iP3Burst.ToString();

            Label3.Text = "Priority: " + iP1Priority.ToString();
            Label7.Text = "Priority: " + iP2Priority.ToString();
            Label11.Text = "Priority: " + iP3Priority.ToString();

            Label4.Text = "Quantum time: " + iP1Quantum.ToString();
            Label8.Text = "Quantum time: " + iP2Quantum.ToString();
            Label12.Text = "Quantum time: " + iP3Quantum.ToString();






            //Label1.Text = iP1Start.ToString();

            //Algorithm beginning
            //start with init settings aka user just go next next

            //1
            if (iP1Start == 0 && iP3Start == 0 && iP1Quantum == 1 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }
            }


            //2
            if (iP1Start == 0 && iP3Start == 0 && iP1Quantum == 1 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    //
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }

            //3
            if (iP1Start == 0 && iP3Start == 0 && iP1Quantum == 2 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //4
            if (iP1Start == 0 && iP3Start == 0 && iP1Quantum == 2 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //5
            if (iP1Start == 0 && iP3Start == 6 && iP1Quantum == 1 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }

            //6
            if (iP1Start == 0 && iP3Start == 6 && iP1Quantum == 1 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //7
            if (iP1Start == 0 && iP3Start == 6 && iP1Quantum == 2 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //8
            if (iP1Start == 0 && iP3Start == 6 && iP1Quantum == 2 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //9
            if (iP1Start == 3 && iP3Start == 0 && iP1Quantum == 1 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //10
            if (iP1Start == 3 && iP3Start == 0 && iP1Quantum == 1 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //11
            if (iP1Start == 3 && iP3Start == 0 && iP1Quantum == 2 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //12
            if (iP1Start == 3 && iP3Start == 0 && iP1Quantum == 2 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //13
            if (iP1Start == 3 && iP3Start == 6 && iP1Quantum == 1 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //14
            if (iP1Start == 3 && iP3Start == 6 && iP1Quantum == 1 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //15
            if (iP1Start == 3 && iP3Start == 6 && iP1Quantum == 2 && iP3Quantum == 1)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }


            //16
            if (iP1Start == 3 && iP3Start == 6 && iP1Quantum == 2 && iP3Quantum == 2)
            {
                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 3)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 3 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 3 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }

                if (iP1Burst == 4 && iP2Burst == 4 && iP3Burst == 4)
                {
                    Image9.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image10.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image11.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image12.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image13.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image14.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image15.ImageUrl = "~/Images/icons8-circle-filled-50RED.png";
                    Image16.ImageUrl = "~/Images/icons8-circle-filled-50BLUE.png";
                    Image17.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image18.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image19.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                    Image20.ImageUrl = "~/Images/icons8-circle-filled-50YELLOW.png";
                }
            }

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

        protected void ImageButton4_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SchedulingForm1.aspx");
        }

        protected void ImageButton5_Click(object sender, ImageClickEventArgs e)
        {
            Response.Redirect("SchedulingForm2.aspx");
        }
    }
}