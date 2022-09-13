using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary
{
    public class MatchupModel
    {
        public List<MatchupEntyModel> Enteries { get; set; } = new List<MatchupEntyModel>();
        public TeamModel Winner { get; set; }
        public int MatchupRound { get; set; }
    }
}
