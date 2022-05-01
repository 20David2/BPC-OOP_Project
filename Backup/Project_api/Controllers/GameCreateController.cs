﻿using Project_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_api.Controllers
{
    public class GameCreateController : ApiController
    {
        //GET api/values
        public List<GameList> Get(string test)
        {
            List<GameList> list = new List<GameList>();
            using (var db = new DBLinqToSqlDataContext())
            {
                var games = db.Games;
                foreach (var game in games)
                {
                    list.Add(new GameList { gameId = game.gameId, gameName = game.gameName, matchStartCount = (int)game.matchStartCount, matchRoundCount = (int)game.matchRoundCount });
                }
                return list;

            }
        }


        // POST api/values
        public GameCreateReturn Post([FromBody] GameCreate newGame)
        {
            Game game = new Game() { gameId = Guid.NewGuid(), gameName = newGame.gameName, player1Id = newGame.player1Id, matchStartCount = newGame.matchStartCount, matchRoundCount = newGame.matchRoundCount };

            using (var db = new DBLinqToSqlDataContext())
            {
                db.Games.InsertOnSubmit(game);
                db.SubmitChanges();
                return new GameCreateReturn { state = true, gameId = game.gameId, message = "Game successfully created" };
            }
        }


        ////PUT api/values
        public string Put(int id, [FromBody] JoinGame joingame)
        {
            JoinGame join = joingame;

            using (var db = new DBLinqToSqlDataContext())
            {
                Game game = db.Games.Single(x => x.gameId == join.gameId);
                game.Player2Id = join.player2Id;
                db.SubmitChanges();
                return ("Submit succesfull");
            }
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}