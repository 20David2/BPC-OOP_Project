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
            
            if (TextBox1.Text != "" && TextBox2.Text !="")
            {
                if (isEmail(TextBox1.Text))
                {
                    Label2.Text = sessionId.ToString();



                    UserCreate user = new UserCreate
                    {

                        name = TextBox2.Text,
                        email = TextBox1.Text,
                    };

                    
                    Button2.Visible = false;
                    HttpClient client = new HttpClient();
                    client.BaseAddress = new Uri("https://localhost:44381/");
                    //client.BaseAddress = new Uri("https://oopzapalky.trialhosting.cz/matchapi/");
                    HttpResponseMessage response = client.PostAsJsonAsync("api/values", user).Result;
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();
                        UserCreateReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<UserCreateReturn>(result);
                        
                        Label1.Text =back.playerId.ToString();

                        
                        Label2.Text = back.message;
                        if (Label2.Text == "This email address is already being used")
                        {
                            Label5.Text = "Do you want to sign in new player with new email?";
                            Button3.Enabled = true;
                            Button3.Visible = true;
                            Label7.Text = "Nah just =>";
                        }
                        Button2.Enabled = true;
                        Button2.Visible = true;
                        Button2.Text = "Continue";

                    }
                    else
                    {
                        Label2.Text = "Error";
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
            Response.Redirect("GameCreate.aspx?id=" + Label1.Text);
        }

        protected void WrongInput()
        {
            
            Label2.Text = "Wrong input \n" +
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
            Button2.Enabled = false;
            Button2.Visible = false;
            Button3.Enabled = false;
            Button3.Visible = false;
            Label5.Text = "";
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