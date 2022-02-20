using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

public class ButtonBehaviourTester
{
    int test = 0;

    // A Test behaves as an ordinary method
    [Test, Order(10)]
    public void ButtonBehaviourTesterSimplePasses()
    {
        // Use the Assert class to test conditions
        Assert.AreEqual(test, 10);
    }

    [Test, Order(1)]
    public void ButtonBehaviourTesterSimplePasses2()
    {
        test = 10;
    }
    // A UnityTest behaves like a coroutine in Play Mode. In Edit Mode you can use
    // `yield return null;` to skip a frame.
    [UnityTest]
    public IEnumerator ButtonBehaviourTesterWithEnumeratorPasses()
    {
        // Use the Assert class to test conditions.
        // Use yield to skip a frame.
        yield return null;
    }
}
