using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AsteroidsAPI.Models
{
    public class Captain: IPlayer
    {
        public string connectionId { get; }

        public Captain(string connectionId)
        {
            this.connectionId = connectionId;
        }
    }
}
