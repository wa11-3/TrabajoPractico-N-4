using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tree : LandThing
{
    public override string Name => "Tree";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal");
    }
}
