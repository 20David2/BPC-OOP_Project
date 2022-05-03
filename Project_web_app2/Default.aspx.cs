using Project_web_app2.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Project_web_app2
{

    public partial class Default : System.Web.UI.Page
    {
        public Guid sessionId = new Guid();
        string plId = "";
        protected void Page_Load(object sender, EventArgs e)
        {
            setnullall();
            if (IsPostBack)
                return;
        }

        protected async void btn_Click(object sender, EventArgs e)
        {

            if (TextBox1.Text != "" && TextBox2.Text != "")
            {
                if (isEmail(TextBox1.Text))
                {
                    lbl_errorMessage.Text = sessionId.ToString();



                    UserCreate user = new UserCreate
                    {
                        name = TextBox2.Text,
                        email = TextBox1.Text,
                    };


                    btnLogin.Visible = false;
                    HttpClient client = new HttpClient();
                    //client.BaseAddress = new Uri("https://localhost:44381/");
                    client.BaseAddress = new Uri("https://oopzapalkyapp.trialhosting.cz/matchapi/");
                    HttpResponseMessage response = client.PostAsJsonAsync("api/values", user).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        UserCreateReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<UserCreateReturn>(result);
                        lbl_id.Text = back.playerId.ToString();
                        lbl_errorMessage.Text = back.message;
                        if (lbl_errorMessage.Text == "This email address is already being used")
                        {
                            lblSign.Text = "Do you want to sign in new player with new email?";
                            btnSign.Enabled = true;
                            btnSign.Visible = true;
                            Label7.Text = "Continue nad login =>";
                        }
                        btnLogin.Enabled = true;
                        btnLogin.Visible = true;
                        btnLogin.Text = "Login";

                    }
                    else
                    {
                        lbl_errorMessage.Text = "Error";
                    }
                }
                else
                {
                    WrongInput();
                }

            }
            else
            {
                WrongInput();
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GameCreate.aspx?id=" + lbl_id.Text);
        }

        protected void WrongInput()
        {

            lbl_errorMessage.Text = "Wrong input \n" +
                    "try it again";
        }

        protected bool isEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                return false;
            }
        }

        protected void setnullall()
        {
            btnLogin.Enabled = false;
            btnLogin.Visible = false;
            btnSign.Enabled = false;
            btnSign.Visible = false;
            lbl_errorMessage.Text = "";
            lblSign.Text = "";
            Label7.Text = "";

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            setnullall();
            TextBox1.Text = "";
            TextBox2.Text = "";
        }
    }
}