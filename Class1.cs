using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppAssignment
{
    public class Class1
    {
        static List<Players> players = new List<Players>()
        {
            new Players{PlayerId = 1,PlayerName="Dhoni",JerseyNo=07,PlayerTeam="CSK"},
            new Players{PlayerId = 2,PlayerName="Kohil",JerseyNo=18,PlayerTeam="RCB"},
            new Players{PlayerId = 3,PlayerName="Rohit",JerseyNo=37,PlayerTeam="MI"},
            new Players{PlayerId = 4,PlayerName="Sanju",JerseyNo=109,PlayerTeam="ME"},
        };
        public static void Main(String[] args)
        {
            var allplayers = GetPlayers();
            Console.WriteLine("allplayers");
            foreach(var players in allplayers)
            {
                Console.WriteLine($"ID:{players.PlayerId},Name:{players.PlayerName},Jersey_No:{players.JerseyNo},Player_Team:{players.PlayerTeam}");
            }
            Console.WriteLine("Enter player id to retrive:");
            if(int.TryParse(Console.ReadLine(),out var playersid))
            {
                var playersId = GetPlayersByid(playersid);
                if(playersId != null) 
                {
                    Console.WriteLine("Players found by id");
                    Console.WriteLine($"ID:{playersId.PlayerId},Name:{playersId.PlayerName},Jersey_No:{playersId.JerseyNo},Player_Team:{playersId.PlayerTeam}");
                }
                else
                {
                    Console.WriteLine("players not found");
                }
            }
            static List<Players> GetPlayers()
            {
                return players;
            }
            static Players GetPlayersByid(int id)
            {
                return players.Find(e => e.PlayerId == id);
            }
        }
    }
}
