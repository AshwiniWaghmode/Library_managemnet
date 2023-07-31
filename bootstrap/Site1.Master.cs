using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ElibraryManagement
{
    public partial class Site1 : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            try
            {
                if (Session["role"].Equals(""))
                {
                    LinkButton1.Visible = true; //user login linkbutton
                    LinkButton2.Visible = true; //user signup link button

                    LinkButton3.Visible = false; // logout link button
                    LinkButton7.Visible = false; //hello user link button

                    LinkButton6.Visible = true; //admin login button
                    LinkButton11.Visible = false; //author management
                    LinkButton12.Visible = false; //publisher management
                    LinkButton8.Visible = false; //book inventory
                    LinkButton9.Visible = false; //book issuing
                    LinkButton10.Visible = false; //member management
                }
                else if(Session["role"].Equals("user"))
                {

                    LinkButton1.Visible = false; //user login linkbutton
                    LinkButton2.Visible = false; //user signup link button

                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; //hello user link button
                    LinkButton7.Text = "Hello " +Session["username"].ToString();


                    LinkButton6.Visible = true; //admin login button
                    LinkButton11.Visible = false; //author management
                    LinkButton12.Visible = false; //publisher management
                    LinkButton8.Visible = false; //book inventory
                    LinkButton9.Visible = false; //book issuing
                    LinkButton10.Visible = false; //member management
                }

                else if (Session["role"].Equals("admin"))
                {

                    LinkButton1.Visible = false; //user login linkbutton
                    LinkButton2.Visible = false; //user signup link button

                    LinkButton3.Visible = true; // logout link button
                    LinkButton7.Visible = true; //hello user link button
                    LinkButton7.Text = "Hello admin ";


                    LinkButton6.Visible = false; //admin login button
                    LinkButton11.Visible = true; //author management
                    LinkButton12.Visible = true; //publisher management
                    LinkButton8.Visible = true; //book inventory
                    LinkButton9.Visible = true; //book issuing
                    LinkButton10.Visible = true; //member management
                }

            }
            catch(Exception ex)
            {

            }
            
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("AdminLogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminauthermanagement.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminpublishermanagement.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookinventory.aspx");
        }

        protected void LinkButton9_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminbookissuing.aspx");
        }

        protected void LinkButton10_Click(object sender, EventArgs e)
        {
            Response.Redirect("adminmembermanagement.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewbook.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("Userlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("usersignup.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

            //Response.Write("<script>alert('Thak you for visiting....!');</script>");
            Session["username"] = "";
            Session["full_name"] = "";
            Session["role"] = "";
            Session["status"] = "";

            LinkButton1.Visible = true; //user login linkbutton
            LinkButton2.Visible = true; //user signup link button

            LinkButton3.Visible = false; // logout link button
            LinkButton7.Visible = false; //hello user link button

            LinkButton6.Visible = true; //admin login button
            LinkButton11.Visible = false; //author management
            LinkButton12.Visible = false; //publisher management
            LinkButton8.Visible = false; //book inventory
            LinkButton9.Visible = false; //book issuing
            LinkButton10.Visible = false; //member management

            Response.Redirect("Homepage.aspx");
        }


        //view profile
        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("userviewprofile.aspx");
        }
    }
}