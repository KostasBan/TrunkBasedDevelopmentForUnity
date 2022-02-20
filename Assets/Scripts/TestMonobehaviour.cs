using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using ScoreLogic;

public class TestMonobehaviour : MonoBehaviour
{
    public Score score = new Score();
    public Button buttonIncrease;

    public void IncreaseScore(int value) => score.IncreaseScoreBy(value); 
}