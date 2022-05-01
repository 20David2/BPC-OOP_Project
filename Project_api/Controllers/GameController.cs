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
        // POST api/game
        public int Post([FromBody] GameMove move)
        {
            GameMove game = move;
            
            using (var db = new DBLinqToSqlDataContext())
            {
                
                if (db.Moves.Any(m => m.movesGameId == game.gameId))
                {
                    
                    var lastmove = (from m in db.Moves
                                    where m.movesGameId == game.gameId
                                    orderby m.moveNumber descending
                                    select m).FirstOrDefault();
                    
                    if (lastmove.movePlayer != move.playerId)
                    {
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
                        return 1;//tah zahran
                    }
                    else
                    {
                        return 2; //hrac neni na tahu
                    }
                }
                else if (db.Games.Any(m => m.gameId == game.gameId))
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
                    return 3; //prvni tah
                }
                else
                {
                    return 0; //chyba
                }
            }
        }
    }
}
