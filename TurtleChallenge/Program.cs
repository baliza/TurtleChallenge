using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using TurtleChallenge.Core.Minefield;
using TurtleChallenge.Core.Turtle;

namespace TurtleChallenge
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var gs = args[0];
            var ms = args[1];
            var gameSettings = ReadFromJson<GameSettings>($"{gs}.json");
            var moves = ReadFromJson<IList<TurtleAction[]>>($"{ms}.json");
            var tg = GetTileGenerator(gameSettings);
            var mf = GetMindField(gameSettings, tg);
            foreach (var listOfMoves in moves)
            {
                var actions = 0;
                var t = new Turtle(mf, gameSettings.StartingDirection);
                mf.SetStartPosition(gameSettings.Start);
                foreach (var move in listOfMoves)
                {
                    actions++;
                    if (move == TurtleAction.Move)
                        t.Move();
                    else
                        t.Rotate();
                    if (t.CurentStatus == TurtleStatus.MineHit)
                        break;
                }
                Console.WriteLine($"Final result: {t.CurentStatus} - Actions: {actions}");
            }
        }

        private static IMindField GetMindField(GameSettings gs, ITileGenerator tileGenerator)
        {
            return new MindField(tileGenerator);
        }

        private static ITileGenerator GetTileGenerator(GameSettings gs)
        {
            return new TileGenerator(gs.Size, gs.Mines, gs.Exit);
        }

        private static T ReadFromJson<T>(string name)
        {
            using (var r = new StreamReader(name))
            {
                var json = r.ReadToEnd();
                var gs = JsonConvert.DeserializeObject<T>(json);
                return gs;
            }
        }
    }
}