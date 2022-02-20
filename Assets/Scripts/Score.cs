using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace ScoreLogic
{
    public class Score
    {
        public int score = 0;

        public void IncreaseScoreBy(int value)
        {
            score += value;
            Debug.Log($"New score = {score}");
        }
    }
}
