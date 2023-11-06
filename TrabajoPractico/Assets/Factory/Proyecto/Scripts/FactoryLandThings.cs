using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FactoryLandThings : MonoBehaviour
{
    [SerializeField] private LandThing[] things;
    private Dictionary<string, LandThing> thingsByName;

    private void Awake()
    {
        thingsByName = new Dictionary<string, LandThing>();
        foreach (var thing in things)
        {
            thingsByName.Add(thing.Name, thing);
        }
    }

    public void CreateLandThing(string nameThing)
    {
        Transform playerTransform = this.transform;
        if (thingsByName.TryGetValue(nameThing, out LandThing thingPrefab))
        {
            LandThing thingInstance = Instantiate(thingPrefab, playerTransform.position, Quaternion.identity);
            //return thingInstance;
        }
        else
        {
            Debug.LogWarning($"La habilidad '{nameThing}' no existe en la base de datos de habilidades.");
            //return null;
        }
    }
}
