using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileObjectPool : MonoBehaviour
{
    public List<GameObject> catapultPooledObjects;
    public List<GameObject> gunPooledObjects;
    public List<GameObject> misilPooledObjects;

    public GameObject catapultBullet;
    public GameObject gunBullet;
    public GameObject misilBullet;

    public int catapultAmount;
    public int gunAmount;
    public int misilAmount;

    public static ProjectileObjectPool Instance { get; private set; }
    private void Awake()
    {
        if (Instance != null && Instance != this)
        {
            Destroy(this);
        }
        else
        {
            Instance = this;
            DontDestroyOnLoad(this);
        }
    }

    void Start()
    {
        catapultPooledObjects = new List<GameObject>();
        gunPooledObjects = new List<GameObject>();
        misilPooledObjects = new List<GameObject>();

        GameObject tmp;

        for (int i = 0; i < catapultAmount; i++)
        {
            tmp = Instantiate(catapultBullet);
            tmp.SetActive(false);
            catapultPooledObjects.Add(tmp);
        }

        for (int i = 0; i < gunAmount; i++)
        {
            tmp = Instantiate(gunBullet);
            tmp.SetActive(false);
            gunPooledObjects.Add(tmp);
        }

        for (int i = 0; i < misilAmount; i++)
        {
            tmp = Instantiate(misilBullet);
            tmp.SetActive(false);
            misilPooledObjects.Add(tmp);
        }
    }

    public GameObject GetCatapultBullet()
    {
        for (int i = 0; i < catapultAmount; i++)
        {
            if (!catapultPooledObjects[i].activeInHierarchy)
            {
                return catapultPooledObjects[i];
            }
        }
        GameObject tmp;
        tmp = Instantiate(catapultBullet);
        tmp.SetActive(false);
        catapultPooledObjects.Add(tmp);
        catapultAmount += 1;
        return tmp;
    }

    public GameObject GetGunBullet()
    {
        for (int i = 0; i < gunAmount; i++)
        {
            if (!gunPooledObjects[i].activeInHierarchy)
            {
                return gunPooledObjects[i];
            }
        }
        GameObject tmp;
        tmp = Instantiate(gunBullet);
        tmp.SetActive(false);
        gunPooledObjects.Add(tmp);
        gunAmount += 1;
        return tmp;
    }

    public GameObject GetMisilBullet()
    {
        for (int i = 0; i < misilAmount; i++)
        {
            if (!misilPooledObjects[i].activeInHierarchy)
            {
                return misilPooledObjects[i];
            }
        }
        GameObject tmp;
        tmp = Instantiate(misilBullet);
        tmp.SetActive(false);
        misilPooledObjects.Add(tmp);
        misilAmount += 1;
        return tmp;
    }
}
