using System.Collections.Generic;
using MathGameLibrary.Game;

namespace MathGameLibrary
{
    public class PlayerModel
    {
        public string PlayerName { get; set; }
        public List<GameModel> GameHistory { get; set; } = new List<GameModel>();
    }
}
