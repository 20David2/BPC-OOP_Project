using Project_web_app2.App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
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
            else
            {
                GetGames();
                return;
            }
        }

        //protected async void GetGames()
        //{
        //    IEnumerable<GameList> games = null;
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:44381/");
        //    HttpResponseMessage response = client.PostAsJsonAsync("api/gameCreate",1).Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var result = await response.Content.ReadAsStringAsync();
        //        List<GameList> back = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameList>>(result);

        //        lbGames.DataSource = back;
        //    }
        //    else
        //    {
        //        lblState.Text = "Error";
        //    }
        //}

        //protected async void GetGames()
        //{
        //    IEnumerable<GameList> games = null;
        //    HttpClient client = new HttpClient();
        //    client.BaseAddress = new Uri("https://localhost:44381/");
        //    HttpResponseMessage response = client.GetAsync("api/gameCreate").Result;
        //    if (response.IsSuccessStatusCode)
        //    {
        //        var result = await response.Content.ReadAsStringAsync();
        //        List<GameList> back = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameList>>(result);

        //        lbGames.DataSource = back;
        //    }
        //    else
        //    {
        //        lblState.Text = "Error";
        //    }
        //}

        protected async void GetGames()
        {
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.GetAsync("api/GameCreate?test=test").Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                lblState.Text = result;
                List<GameList> back = Newtonsoft.Json.JsonConvert.DeserializeObject<List<GameList>>(result);

                List<string> values = new List<string>();
                for(int i = 1; i <= back.Count; i++)
                {
                    values.Add(i.ToString() + ". " + back[i-1]);
                }

                lbGames.DataSource = values;
                lbGames.DataBind();
                lbGames.AutoPostBack = false;

                List<string> ids = new List<string>();
                foreach (var game in back)
                {
                    ids.Add(game.ToString(1));
                }

                lbIds.DataSource = ids;
                lbIds.DataBind();
            }
            else
            {
                lblState.Text = "Error";
            }
        }

        protected async void AddPlayer(Guid gameid, Guid playerid)
        {
            JoinGame join = new JoinGame
            {
                gameId = gameid,
                player2Id = playerid
            };


            //HttpClient client = new HttpClient();
            //client.BaseAddress = new Uri("https://localhost:44381/");
            //await client.PutAsJsonAsync("api/gameCreate", join);

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.PutAsJsonAsync("api/gameCreate/1", join).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                lbljoin.Text = result;
            }
            else
            {
                lbljoin.Text = "Error";
            }

        }
        protected async void btSubmit_Click(object sender, EventArgs e)
        {
            GameCreated game = new GameCreated
            {
                gameName = tbGameName.Text,
                player1Id = new Guid ( Request["id"] ),
                matchStartCount = int.Parse(tbMatchStart.Text),
                matchRoundCount = int.Parse(tbMatchRound.Text),

            };
            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://localhost:44381/");
            HttpResponseMessage response = client.PostAsJsonAsync("api/gameCreate", game).Result;
            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadAsStringAsync();
                GameCreateReturn back = Newtonsoft.Json.JsonConvert.DeserializeObject<GameCreateReturn>(result);
                lblState.Text = back.message;
                lblGameid.Text = back.gameId.ToString();
            }
            else
            {
                lblState.Text = "Error";
            }
        }

        protected void btContinue_Click(object sender, EventArgs e)
        {
            Response.Redirect("Game.aspx?gameid=" + lblGameid.Text + "&playerid=" + Request["id"]);
        }

        protected void btnSet_Click(object sender, EventArgs e)
        {
            var result = lbIds.Items.Cast<ListItem>().ToArray();
            lblGameid.Text = result[lbGames.SelectedIndex].ToString();
            lblState.Text = result[lbGames.SelectedIndex].ToString();
            AddPlayer(new Guid(result[lbGames.SelectedIndex].ToString()), new Guid(Request["id"]));
            //lbljoin.Text = "Successfull joined to game";
        }

        protected void lbGames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Response.Redirect("Game.aspx?gameid=" + lblGameid.Text + "&playerid=" + Request["id"]);
            //var result = lbIds.Items.Cast<ListItem>().ToArray();
            //lblState.Text = lbGames.SelectedIndex.ToString();
        }

        protected void btnredirect_Click(object sender, EventArgs e)
        {
            var result = lbIds.Items.Cast<ListItem>().ToArray();
            Response.Redirect("Game.aspx?gameid=" + result[lbGames.SelectedIndex].ToString() + "&playerid=" + Request["id"]);
        }
    }
}