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
            if (IsPostBack) {
                return;
            }
            else
            {
                try
                {
                    Guid guid1 = new Guid(Request["gameid"]);
                    Guid guid2 = new Guid(Request["playerid"]);
                }
                catch (Exception)
                {
                    Response.Redirect("Default.aspx");
                }
                GetConst();
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
                //client.BaseAddress = new Uri("https://localhost:44381/");
                client.BaseAddress = new Uri("https://oopzapalkyapp.trialhosting.cz/matchapi/");
                HttpResponseMessage response = client.PostAsJsonAsync("api/game", game).Result;
                if (response.IsSuccessStatusCode)
                {
                    var result = await response.Content.ReadAsStringAsync();
                    GameMoveReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<GameMoveReturn>(result);
                    
                    if (back.state)
                    {
                        lblLastCount.Text = back.NumOfMatchesRemaining.ToString();
                        lblRemainingInfo.Text = back.NumOfMatchesRemaining.ToString();
                        lblWhoTurn.Text = back.NamePlayerTurn;
                        lblError.Text = "";
                        lblState.Text = "";

                        btnPlay.Visible = false;
                        btnReload.Visible = true;

                        if (back.NumOfMatchesRemaining <= 0)
                        {
                            btnPlay.Visible = false;
                            btnReload.Visible = false;
                            lblState.Text = "Winner is: " + back.Winner;
                        }
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
            //client.BaseAddress = new Uri("https://localhost:44381/");
            client.BaseAddress = new Uri("https://oopzapalkyapp.trialhosting.cz/matchapi/");
            HttpResponseMessage response = client.GetAsync("api/Game?gameid=" + Request["gameid"]).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                GameConst back = Newtonsoft.Json.JsonConvert.DeserializeObject<GameConst>(result);
                lblMaxPerRound.Text = back.NumMatchesPerRound.ToString();
                lblRemainingInfo.Text = back.TotalNumMatches.ToString();
                lblGameName.Text = back.GameName;

                
            }
            else
            {
                lblState.Text = "Error";
            }
        }

        protected void btnReload_Click(object sender, EventArgs e)
        {
            GetConst();
            if (lblRemainingInfo.Text != lblLastCount.Text)
            {
                btnReload.Visible = false;
                btnPlay.Visible = true;
                tbMove.Text = "";
                lblWhoTurn.Text = "You";

                if ((int.Parse(lblRemainingInfo.Text) <= 0))
                {
                    btnPlay.Visible = false;
                    btnReload.Visible = false;
                    lblState.Text = "You lose";
                }
            }

        }
    }

}