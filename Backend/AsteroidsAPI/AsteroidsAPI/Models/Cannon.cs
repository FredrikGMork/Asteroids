using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteroidsAPI.Models
{
    public class Cannon: IPlayer
    {
        public string connectionId { get; set; }

        public Cannon(string connectionId) {
            this.connectionId = connectionId;
        }
    }
}
