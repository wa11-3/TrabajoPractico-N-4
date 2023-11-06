using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : LandThing
{
    public override string Name => "Rock";
    public override void Activate()
    {
        Debug.Log("Logica de la habilidad Heal");
    }
}
