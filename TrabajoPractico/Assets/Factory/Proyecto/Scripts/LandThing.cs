using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LandThing : MonoBehaviour
{
    public abstract string Name { get; }
    public abstract void Activate();
}
