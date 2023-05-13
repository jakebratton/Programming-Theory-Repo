using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChickenBehavior : Animal
{
    // Polymorphism
    protected override void Speak()
    {
        Debug.Log("Bawk");
    }
}
