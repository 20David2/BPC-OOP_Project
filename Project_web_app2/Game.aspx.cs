using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Project_web_app2.App.Models;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Project_web_app2
{
    public partial class Game : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (IsPostBack)
                return;
        }

        protected async void btnPlay_Click(object sender, EventArgs e)
        {
            GameMove game = new GameMove
            {
                gameId = new Guid(Request["gameid"]),
                playerId = new Guid(Request["playerid"]),
                move = int.Parse(tbMove.Text)
            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/game", game).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                lblState.Text = result;
            }
            else
            {
                lblState.Text = "Error";
            }
        }
    }

}