using Intercom.Core;
using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class MatchupModel
    {
        public List<MatchupEntyModel> Enteries { get; set; } = new List<MatchupEntyModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
