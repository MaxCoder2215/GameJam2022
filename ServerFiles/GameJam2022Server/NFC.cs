using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Nancy;

namespace GameJam2022Server
{
    public class NFC : NancyModule
    {
        public NFC()
        {
            Get("/asignplayer/1/{name}", (dynamic test) =>
            {
                return $"hi {test.name} you are now Player 1";
            }, (NancyContext context) =>
            {
                string ip = context.Request.UserHostAddress;
                Program.AsignPlayer(ip, 1);
                return true;
            });

            Get("/asignplayer/2/{name}", (dynamic test) =>
            {
                return $"hi {test.name} you are now Player 2";
            }, (NancyContext context) =>
            {
                string ip = context.Request.UserHostAddress;
                Program.AsignPlayer(ip, 2);
                return true;
            });

            Get("/asignplayer/3/{name}", (dynamic test) =>
            {
                return $"hi {test.name} you are now Player 3";
            }, (NancyContext context) =>
            {
                string ip = context.Request.UserHostAddress;
                Program.AsignPlayer(ip, 3);
                return true;
            });

            Get("/asignplayer/4/{name}", (dynamic test) =>
            {
                return $"hi {test.name} you are now Player 4";
            }, (NancyContext context) =>
            {
                string ip = context.Request.UserHostAddress;
                Program.AsignPlayer(ip, 4);
                return true;
            });

            Get("/item", (dynamic d) => {
                return "<h1>Item<\\h1>";
            }, (NancyContext context) =>
            {
                int player = -1;
                try
                {
                    player = Program.PlayerIP[context.Request.UserHostAddress];
                }
                catch (KeyNotFoundException k)
                {
                    Console.WriteLine("Player not found");
                    return false;
                }

                Console.WriteLine($"Finding {context.Request.Query.item} for player {player}");
                
                return true;
            });
        }
    }
}
