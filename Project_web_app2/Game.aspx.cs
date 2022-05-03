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
            int nummatches = 20;
            
            if (IsPostBack) {
                return;
            }
            else
            {
                lblRemainingInfo.Text = nummatches.ToString();
            }
        }

        protected async void btnPlay_Click(object sender, EventArgs e)
        {
            
            if (tbMove.Text != "")
            {

                lblError.Visible = false;
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
                    GameMoveReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<GameMoveReturn>(result);
                    


                    if (back.state)
                    {
                        lblState.Text = "Your move!";
                    }
                    else
                    {
                        lblState.Text = "Error";
                    }

                }
                else
                {
                    lblState.Text = "Error";
                }
            }
            else
            {
                lblError.Text = "You have to write how many matches you want to take!!";
                lblError.Visible = true;
            }
            
        }

        protected async void GetConst()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.GetAsync("api/Game?gameid=" + Request["gameid"]).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                lblState.Text = result;
                GameConst back = Newtonsoft.Json.JsonConvert.DeserializeObject<GameConst>(result);
                lblMaxPerRound.Text = back.NumMatchesPerRound.ToString();
                lblRemainingInfo.Text = back.TotalNumMatches.ToString();
                //dopiš si co chceš
            }
            else
            {
                lblState.Text = "Error";
            }
        }
    }

}