using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;
using AsteroidsAPI.Controllers;
using AsteroidsAPI.Services;
using Microsoft.AspNetCore.SignalR;


namespace AsteroidsAPI.Hubs
{
    public class GameHub : Hub
    {
        public async Task JoinLobby()
        {
            //Add player with connectionID
            await Clients.All.SendAsync("LobbyUpdate");
        }

        public async Task GetOnlineIds()
        {
            GameBoardServices.AddPlayer(Context.ConnectionId);
            await Clients.All.SendAsync("ReceiveOnlineId", GameBoardServices.players);
        }

        public async Task CannonShoot(Vector2 dir, Vector2 pos)
        {

        }
        public async Task SpaceshipMove(Vector2 newPos)
        {

        }
    }
}
