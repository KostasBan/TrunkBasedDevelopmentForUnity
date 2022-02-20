using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using ScoreLogic;
public class ScoreTester
{
    private Score testScore;

    [OneTimeSetUp]
    public void SetUP()
    {
        testScore = new Score();
    }
    [Test, Order(0)]
    public void ScoreInitializationTest()
    {
        Assert.IsNotNull(testScore);
        Assert.AreEqual(testScore.score, 0);
    }
    [Test, Order(1)]
    public void AddOneToScoreTest()
    {
        testScore.IncreaseScoreBy(1);
        Assert.AreEqual(testScore.score, 1);
    }
    [Test, Order(2)]
    public void AddFiveToScoreTest()
    {
        testScore.IncreaseScoreBy(5);
        Assert.AreEqual(testScore.score, 6);
    }
    [Test, Order(3)]
    public void Minus1ToScoreTest()
    {
        testScore.IncreaseScoreBy(-1);
        Assert.AreEqual(testScore.score, 5);
    }
}
