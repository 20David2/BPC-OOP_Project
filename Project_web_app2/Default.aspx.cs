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

        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected async void btn_Click(object sender, EventArgs e)
        {
            Label2.Text = sessionId.ToString();
            UserCreate user = new UserCreate
            {
                name = TextBox2.Text,
                email = TextBox1.Text,
            };
            HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:44381/");
            client.BaseAddress = new Uri("https://oopzapalky.trialhosting.cz/matchapi/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/values", user).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                UserCreateReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<UserCreateReturn>(result);
                Label1.Text = back.playerId.ToString();
                Label2.Text = back.message;
                 
            }
            else
            {
                Label2.Text = "Error";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GameCreate.aspx?id=" + Label1.Text);
        }
    }
}