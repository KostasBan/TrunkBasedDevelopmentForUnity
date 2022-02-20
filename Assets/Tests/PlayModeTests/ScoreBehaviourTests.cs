using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using UnityEngine.SceneManagement;

public class ScoreBehaviourTests
{
    TestMonobehaviour test;
    public static string scene = "SampleScene";
    bool sceneLoaded;

    [OneTimeSetUp]
    public void SetUp()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
        SceneManager.LoadScene(scene, LoadSceneMode.Additive);
    }
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        sceneLoaded = true;
        test = GameObject.FindObjectOfType<TestMonobehaviour>();
    }
    [UnityTest, Order(0)]
    public IEnumerator TestMonoIsntNull()
    {
        yield return new WaitWhile(() => sceneLoaded == false);
        Assert.That(test, Is.Not.Null);
    }

    [UnityTest, Order(1)]
    public IEnumerator TestButtonIsntNull()
    {
        yield return new WaitWhile(() => sceneLoaded == false);
        Assert.That(test.buttonIncrease, Is.Not.Null, $"{test.gameObject.name} component {typeof(TestMonobehaviour).ToString()} in scene {scene} has no reference for buttonIncrease");
    }

    [UnityTest, Order(2)]
    public IEnumerator TestScoreStartingValueIs0()
    {
        yield return new WaitWhile(() => sceneLoaded == false);
        Assert.That(test.score.score, Is.EqualTo(0));
    }

    [UnityTest, Order(3)]
    public IEnumerator ScoreButtonIncreasesBy1()
    {
        yield return new WaitWhile(() => sceneLoaded == false);
        test.buttonIncrease.onClick.Invoke();
        Assert.That(test.score.score, Is.EqualTo(1));
    }


}
