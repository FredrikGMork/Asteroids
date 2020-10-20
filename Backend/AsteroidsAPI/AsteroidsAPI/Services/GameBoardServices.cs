using AsteroidsAPI.Models;
using Microsoft.AspNetCore.SignalR;

namespace AsteroidsAPI.Services
{
    public class GameBoardServices //:IGameBoardServices
    {
        public GameBoard GameBoard;
        public Spaceship Spaceship;
        public static IPlayer[] players;

        public void Setup()
        {
            players = new IPlayer[2];
            
        }

        public void Start()
        {
            
        }

        public static bool IsReady()
        {

            return false;
        }
        
        
        public static void AddPlayer(string connectionId)
        {
            if(players[0] != null && players[1] == null)
            {
                players[1] = new Cannon(connectionId);

            } else if (players[0] != null && players[1] != null)
            {
                //TODO
            } else
            {
                players[0] = new Captain(connectionId);
            }

        }
        public void AssignRoles()
        {

        }
        public void CreateSpaceship()
        {

            //hente begge spillere.

            //gi roller

            //opprett romskip
            Spaceship = new Spaceship();
        }

        //Starte spillbrett  med romskip(captain, cannon) og asteroide.
        public void CreateGameBoard()
        {

        }
    }
}