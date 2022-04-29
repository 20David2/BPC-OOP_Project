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
    public partial class GameCreate : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected async void btSubmit_Click(object sender, EventArgs e)
        {
            GameCreated game = new GameCreated
            {
                gameName = tbGameName.Text,
                player1Id = (Guid)Session["userId"],
                matchStartCount = int.Parse(tbMatchStart.Text),
                matchRoundCount = int.Parse(tbMatchRound.Text),

            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/values", game).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                //UserCreateReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<UserCreateReturn>(result);
                lblState.Text = result;
            }
            else
            {
                lblState.Text = "Error";
            }
        }
    }
}