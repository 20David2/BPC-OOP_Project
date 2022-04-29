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
        protected void Page_Load(object sender, EventArgs e)
        {
            Session["userId"] = Guid.Empty;
            Label1.Text = "Test";
            if (IsPostBack)
                return;
        }

        protected async void btn_Click(object sender, EventArgs e)
        {
            UserCreate user = new UserCreate
            {
                name = "Prvni Uzivatel",
                email = TextBox1.Text,
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/values", user).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                UserCreateReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<UserCreateReturn>(result);
                Label1.Text = back.playerId.ToString();
                Session["userId"] = back.playerId;
                Label2.Text = Session["userId"].ToString();
            }
            else
            {
                Label1.Text = "Error";
            }

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("GameCreate.aspx");
        }
    }
}