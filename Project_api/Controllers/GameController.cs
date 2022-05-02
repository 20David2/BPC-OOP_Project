using Project_api.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Project_api.Controllers
{
    public class GameController : ApiController
    {

        public GameConst Get(string gameid)
        {
            try
            {
                using (var db = new DBLinqToSqlDataContext())
                {
                    var localgame = db.Games.FirstOrDefault(m => m.gameId == new Guid(gameid));
                    GameConst gameConst = new GameConst()
                    {
                        NumMatchesPerRound = (int)localgame.matchRoundCount,
                        TotalNumMatches = (int)localgame.matchStartCount,
                        GameName = localgame.gameName,
                    };
                    return gameConst;
                }
            }
            catch (Exception e)
            {
                return new GameConst() { GameName = null, NumMatchesPerRound = 0, TotalNumMatches = 0};
            }

            
        }

        // POST api/game
        public GameMoveReturn Post([FromBody] GameMove move)
        {
            GameMove game = move;

            using (var db = new DBLinqToSqlDataContext())
            {
                var localgame = db.Games.FirstOrDefault(m => m.gameId == move.gameId);
                if (move.move >= 0 && move.move <= localgame.matchRoundCount )
                {
                    
                    if (move.playerId == localgame.player1Id || move.playerId == localgame.Player2Id)
                    {
                        if (db.Moves.Any(m => m.movesGameId == game.gameId))
                        {
                            var lastmove = (from m in db.Moves
                                            where m.movesGameId == game.gameId
                                            orderby m.moveNumber descending
                                            select m).FirstOrDefault();

                            if (lastmove.movePlayer != move.playerId) //hrac je na tahu
                            {
                                if (lastmove.actualMatchCount - game.move == 1)
                                {
                                    if (localgame.player1Id == move.playerId) //player 2 is a winner
                                    {
                                        var winnerPlayer = db.Users.FirstOrDefault(p => p.userId == localgame.Player2Id);
                                        return new GameMoveReturn { state = true, NumOfMatchesRemaining = 0, NamePlayerTurn = winnerPlayer.userName, Winner = winnerPlayer.userName };
                                    }
                                    else if (localgame.Player2Id == move.playerId) //player 1 is a winner
                                    {
                                        var winnerPlayer = db.Users.FirstOrDefault(p => p.userId == localgame.player1Id);
                                        return new GameMoveReturn { state = true, NumOfMatchesRemaining = 0, NamePlayerTurn = winnerPlayer.userName, Winner = winnerPlayer.userName };
                                    }
                                    else //error, unknown player
                                    {
                                        return new GameMoveReturn { state = false, NumOfMatchesRemaining = 0, NamePlayerTurn = null, Winner = null };
                                    }
                                }
                                else if (lastmove.actualMatchCount - game.move <= 1) //player on move is a winner
                                {
                                    var winnerPlayer = db.Users.FirstOrDefault(p => p.userId == move.playerId);
                                    return new GameMoveReturn { state = true, NumOfMatchesRemaining = 0, NamePlayerTurn = winnerPlayer.userName, Winner = winnerPlayer.userName };
                                }

                                Move newMove = new Move
                                {
                                    movesGameId = game.gameId,
                                    movePlayer = game.playerId,
                                    moveNumber = lastmove.moveNumber + 1,
                                    moveMatchCount = game.move,
                                    actualMatchCount = lastmove.actualMatchCount - game.move
                                };

                                db.Moves.InsertOnSubmit(newMove);
                                db.SubmitChanges();

                                if (localgame.player1Id == move.playerId) //player 2 is on move
                                {
                                    var PlayerOnMove = db.Users.FirstOrDefault(p => p.userId == localgame.Player2Id);
                                    return new GameMoveReturn { state = true, NumOfMatchesRemaining = newMove.actualMatchCount, NamePlayerTurn = PlayerOnMove.userName, Winner = null };
                                }
                                else if (localgame.Player2Id == move.playerId) //player 1 is on move
                                {
                                    var PlayerOnMove = db.Users.FirstOrDefault(p => p.userId == localgame.player1Id);
                                    return new GameMoveReturn { state = true, NumOfMatchesRemaining = newMove.actualMatchCount, NamePlayerTurn = PlayerOnMove.userName, Winner = null };
                                }
                                else //error, unknown player
                                {
                                    return new GameMoveReturn { state = false, NumOfMatchesRemaining = 0, NamePlayerTurn = null, Winner = null };
                                }
                            }
                            else //hrac neni na tahu
                            {
                                if (localgame.player1Id == move.playerId) //player 2 is on move
                                {
                                    var PlayerOnMove = db.Users.FirstOrDefault(p => p.userId == localgame.Player2Id);
                                    return new GameMoveReturn { state = true, NumOfMatchesRemaining = lastmove.actualMatchCount, NamePlayerTurn = PlayerOnMove.userName, Winner = null };
                                }
                                else if (localgame.Player2Id == move.playerId) //player 1 is on move
                                {
                                    var PlayerOnMove = db.Users.FirstOrDefault(p => p.userId == localgame.player1Id);
                                    return new GameMoveReturn { state = true, NumOfMatchesRemaining = lastmove.actualMatchCount, NamePlayerTurn = PlayerOnMove.userName, Winner = null };
                                }
                                else //error, unknown player
                                {
                                    return new GameMoveReturn { state = false, NumOfMatchesRemaining = 0, NamePlayerTurn = null, Winner = null };
                                }
                            }

                        }
                        else if (db.Games.Any(m => m.gameId == game.gameId)) //první tah
                        {
                            Game currentgame = db.Games.Where(m => m.gameId == game.gameId).FirstOrDefault();

                            Move newMove = new Move
                            {
                                movesGameId = game.gameId,
                                movePlayer = game.playerId,
                                moveNumber = 1,
                                moveMatchCount = game.move,
                                actualMatchCount = (int)currentgame.matchStartCount - game.move
                            };
                            db.Moves.InsertOnSubmit(newMove);
                            db.SubmitChanges();
                            return new GameMoveReturn { state = true, NumOfMatchesRemaining = newMove.actualMatchCount, NamePlayerTurn = null, Winner = null };
                        }
                        else
                        {
                            return new GameMoveReturn { state = false, NumOfMatchesRemaining = 0, NamePlayerTurn = null, Winner = null };
                        }
                    }
                    else //neplatný hráč
                    {
                        return new GameMoveReturn { state = false, NumOfMatchesRemaining = 0, NamePlayerTurn = null, Winner = null };
                    }
                }
                else
                {
                    return new GameMoveReturn { state = false, NumOfMatchesRemaining = 0, NamePlayerTurn = null, Winner = null };
                }

                
            }
        }
    }
}
