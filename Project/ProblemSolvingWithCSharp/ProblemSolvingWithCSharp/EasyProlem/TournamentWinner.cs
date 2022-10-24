using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolvingWithCSharp.EasyProlem
{
    class TournamentWinner
    {
        public int Home_Team_Won = 1;
        public string TournamentWinnerS1(List<List<string>> competitions, List<int> results)
        {
            // Write your code here.
            Dictionary<string, int> scores = new Dictionary<string, int>();
            string currentBaseteam = "";
            scores[currentBaseteam] = 0;
            for (int idx = 0; idx < competitions.Count; idx++)
            {
                List<string> competition = competitions[idx];
                int result = results[idx];
                string homeTeam = competition[0];
                string awayTeam = competition[1];
                string winTem = (result == Home_Team_Won) ? homeTeam : awayTeam;

                UpdateScore(winTem, 3, scores);
                if (scores[winTem] > scores[currentBaseteam])
                    currentBaseteam = winTem;
            }
            return currentBaseteam;
        }
        public void UpdateScore(string team,int point,Dictionary<string,int> scores)
        {
            if (!scores.ContainsKey(team))
            {
                scores[team] = 0;
            }
            scores[team] = scores[team] + point;
        }
    }
}
