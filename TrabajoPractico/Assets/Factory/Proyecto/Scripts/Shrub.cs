using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shrub : LandThing
{
    public override string Name => "Shrub";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal");
    }
}
